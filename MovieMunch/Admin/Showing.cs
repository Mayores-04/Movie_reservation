using MongoDB.Bson;
using MovieMunch.Admin.FilmsInCinema;
using MovieMunch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMunch.Admin
{
    public partial class Showing : Form
    {

        private readonly MovieService _movieService;
        public Showing(string userName, string profilePic)
        {
            _userName = userName;
            _profilePic = profilePic;
            InitializeComponent();
            _movieService = new MovieService();
            LoadMoviesInCinemaData();
            formOptionsPanel.BringToFront();

            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Update",
                Text = "Update",
                UseColumnTextForButtonValue = true,
                Name = "UpdateButton"
            };

            MoviesToShowTable.Columns.Add(updateButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Name = "DeleteButton"
            };
            MoviesToShowTable.Columns.Add(deleteButtonColumn);

            DataGridViewButtonColumn ViewMovies = new DataGridViewButtonColumn
            {
                HeaderText = "View",
                Text = "View Film",
                UseColumnTextForButtonValue = true,
                Name = "ViewButton"
            };
            MoviesToShowTable.Columns.Add(ViewMovies);

            MoviesToShowTable.CellContentClick += MoviesToShowTable_CellContentClick;

            MoviesToShowTable.CellPainting += MoviesToShowTable_CellPainting;
        }

        private void MoviesToShowTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == MoviesToShowTable.Columns["UpdateButton"].Index ||
                                    e.ColumnIndex == MoviesToShowTable.Columns["DeleteButton"].Index ||
                                    e.ColumnIndex == MoviesToShowTable.Columns["ViewButton"].Index))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);

                Color buttonColor = Color.Transparent;
                Color borderColor = Color.Black;  
                if (e.ColumnIndex == MoviesToShowTable.Columns["UpdateButton"].Index)
                {
                    buttonColor = Color.LightBlue;  
                    borderColor = Color.DarkBlue; 
                }
                else if (e.ColumnIndex == MoviesToShowTable.Columns["DeleteButton"].Index)
                {
                    buttonColor = Color.IndianRed;  
                    borderColor = Color.DarkRed;  
                }
                else if (e.ColumnIndex == MoviesToShowTable.Columns["ViewButton"].Index)
                {
                    buttonColor = Color.LightGreen; 
                    borderColor = Color.DarkGreen;  
                }

                Rectangle rect = new Rectangle(e.CellBounds.X + 2, e.CellBounds.Y + 2, e.CellBounds.Width - 4, e.CellBounds.Height - 4);
                GraphicsPath path = new GraphicsPath();
                path.AddArc(rect.X, rect.Y, 10, 10, 180, 90);  
                path.AddArc(rect.Right - 10, rect.Y, 10, 10, 270, 90);  
                path.AddArc(rect.Right - 10, rect.Bottom - 10, 10, 10, 0, 90); 
                path.AddArc(rect.X, rect.Bottom - 10, 10, 10, 90, 90); 
                path.CloseFigure();

                using (Brush brush = new SolidBrush(buttonColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                using (Pen pen = new Pen(borderColor, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    (string)e.FormattedValue,
                    e.CellStyle.Font,
                    rect,
                    e.CellStyle.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                e.Handled = true;  
            }
        }

        private void LoadMoviesInCinemaData()
        {
            List<Movie> movies = _movieService.GetAllMovies();
            MoviesToShowTable.Rows.Clear();

            foreach (var movie in movies)
            {
                MoviesToShowTable.Rows.Add(movie.Id, movie.MovieTitle, movie.MovieDescription, movie.MoviePrice, movie.MovieImagePath, movie.Day, movie.StartTime, movie.EndTime);
            }
        }

        private void ViewMovies(string movieID)
        {
            viewShowingImagePanel.Visible = true;
            var movie = _movieService.GetMovieById(new ObjectId(movieID));

            if (movie != null)
            {
                try
                {
                    viewShowingImageBox.BackgroundImage = Image.FromFile(movie.MovieImagePath);
                    viewShowingImageBox.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image ({ex.Message}) to user interface");
                }
            }
            else
            {
                MessageBox.Show("Movie not found.");
            }
        }

        private void MoviesToShowTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string moviesID = MoviesToShowTable.Rows[e.RowIndex].Cells["movieId"].Value.ToString();

                if (MoviesToShowTable.Columns[e.ColumnIndex].Name == "UpdateButton")
                {
                    UpdateMovies(moviesID);
                }
                else if (MoviesToShowTable.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    DeleteMovies(moviesID);
                }
                else if (MoviesToShowTable.Columns[e.ColumnIndex].Name == "ViewButton")
                {
                    ViewMovies(moviesID);
                }
            }
        }
        private void UpdateMovies(string movieID)
        {
            if (ObjectId.TryParse(movieID, out var objectId))
            {
                var movie = _movieService.GetMovieById(objectId);

                if (movie != null)
                {
                    var currentRow = MoviesToShowTable.Rows[MoviesToShowTable.CurrentCell.RowIndex];

                    // Update basic fields
                    movie.MovieTitle = currentRow.Cells["moviesTitle"].Value.ToString();
                    movie.MovieDescription = currentRow.Cells["moviesDescription"].Value.ToString();
                    movie.MoviePrice = Convert.ToDouble(currentRow.Cells["moviePrice"].Value.ToString());

                    // Sanitize the image path before updating
                    movie.MovieImagePath = SanitizeImagePath(currentRow.Cells["moviesImagePath"].Value.ToString());

                    movie.Day = currentRow.Cells["DayCB"].Value.ToString(); // Assuming "DayCB" contains the day as string

                    // Update StartTime and EndTime
                    try
                    {
                        // Parse StartTime and EndTime as DateTime
                        movie.StartTime = DateTime.Parse(currentRow.Cells["StartTimeCB"].Value.ToString());
                        movie.EndTime = DateTime.Parse(currentRow.Cells["EndTimeCB"].Value.ToString());
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show($"Invalid time format: {ex.Message}");
                        return;
                    }

                    try
                    {
                        _movieService.UpdateMovies(movie);
                        MessageBox.Show("Movie updated successfully.");
                        LoadMoviesInCinemaData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating the movie: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Movie not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID format.");
            }
        }

        private string SanitizeImagePath(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            input = RemoveSurroundingQuotes(input);

            string pattern = @"[^a-zA-Z0-9_\\:/.]";
            return Regex.Replace(input, pattern, string.Empty);
        }

        private string RemoveSurroundingQuotes(string input)
        {
            if (!string.IsNullOrEmpty(input) && input.StartsWith("\"") && input.EndsWith("\""))
            {
                return input.Substring(1, input.Length - 2);
            }
            return input;
        }

        private void DeleteMovies(string movieID)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this movie?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (ObjectId.TryParse(movieID, out var objectId))
                {
                    bool isDeleted = _movieService.DeleteMovieByID(objectId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Movie successfully deleted.");
                        LoadMoviesInCinemaData();
                    }
                    else
                    {
                        MessageBox.Show("Movie could not be deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID format.");
                }
            }
        }

        private void AddMoviesToShowButton_Click(object sender, EventArgs e)
        {
            string movieTitle = RemoveSurroundingQuotes(movieTitleInput.Text);
            string movieDescription = RemoveSurroundingQuotes(movieDescriptionInput.Text);
            string movieImagePath = RemoveSurroundingQuotes(movieDirectoryInput.Text);

            double moviePrice;
            try
            {
                moviePrice = Convert.ToDouble(RemoveSurroundingQuotes(moviePriceInput.Text));

                if (moviePrice < 0)
                {
                    MessageBox.Show("Price cannot be negative. Please enter a valid price.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid price format. Please enter a valid numeric value.");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Price value is too large. Please enter a reasonable value.");
                return;
            }

            var newMovie = new Movie
            {
                MovieTitle = movieTitle,
                MovieDescription = movieDescription,
                MoviePrice = moviePrice,
                MovieImagePath = movieImagePath

            };

            try
            {
                _movieService.AddMovies(newMovie);
                MessageBox.Show("Movie saved successfully.");
                LoadMoviesInCinemaData();
                ClearAdminInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the movie: {ex.Message}");
            }
        }

        private void ClearAdminInput()
        {
            movieTitleInput.Clear();
            movieDescriptionInput.Clear();
            moviePriceInput.Clear();
            movieDirectoryInput.Clear();
        }

        private void closeShowingImageBtn_Click_1(object sender, EventArgs e)
        {
            viewShowingImagePanel.Visible = false;
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            MainAdmin mainAdminForm = new MainAdmin();
            mainAdminForm.SetUserNamme(_userName, _profilePic);
            mainAdminForm.Visible = true;
            this.Close();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            if (formOptionsPanel.Visible == true)
            {
                formOptionsPanel.Visible = false;
            }
            else
            {
                formOptionsPanel.Visible = true;
            }
        }

        private void filmsBtn_Click(object sender, EventArgs e)
        {
            FilmsInCinemaForm filmsInCinemaForm = new FilmsInCinemaForm(_userName, _profilePic);
            filmsInCinemaForm.Show();
            this.Close();
        }

        private void comingSoonBtn_Click(object sender, EventArgs e)
        {
            ComingSoonMoviesForm csoon = new ComingSoonMoviesForm(_userName, _profilePic);
            csoon.Show();
            this.Close();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            EmployeesManagementForm employeelist = new EmployeesManagementForm(_userName, _profilePic);
            employeelist.Show();
            this.Close();
        }

        private string _userName;
        private string _profilePic;
        private void foodsBtn_Click(object sender, EventArgs e)
        {
            CinemaFoodDeals snack = new CinemaFoodDeals(_userName, _profilePic);
            snack.Show();
            this.Close();
        }
    }
}

using MongoDB.Bson;
using MovieMunch.Admin.FilmsInCinema;
using MovieMunch.Backend.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MovieMunch.Admin
{
    public partial class ComingSoonMoviesForm : Form
    {
        private readonly MovieService _movieService;
        public ComingSoonMoviesForm(string userName, string profilePic)
        {
            _userName = userName;
            _profilePic = profilePic;
            InitializeComponent();
            _movieService = new MovieService();
            LoadComingSoonInCinemaData();
            formOptionsPanel.BringToFront();

            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Update",
                Text = "Update",
                UseColumnTextForButtonValue = true,
                Name = "UpdateButton"
            };
            ComingSoonTable.Columns.Add(updateButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Name = "DeleteButton"
            };
            ComingSoonTable.Columns.Add(deleteButtonColumn);

            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "View",
                Text = "View Movie",
                UseColumnTextForButtonValue = true,
                Name = "ViewButton"
            };
            ComingSoonTable.Columns.Add(viewButtonColumn);

            ComingSoonTable.CellContentClick += ComingSoonTable_CellContentClick;
            ComingSoonTable.CellPainting += MoviesToShowTable_CellPainting;
        }

        private void MoviesToShowTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == ComingSoonTable.Columns["UpdateButton"].Index ||
                                    e.ColumnIndex == ComingSoonTable.Columns["DeleteButton"].Index ||
                                    e.ColumnIndex == ComingSoonTable.Columns["ViewButton"].Index))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);

                Color buttonColor = Color.Transparent;
                Color borderColor = Color.Black;
                if (e.ColumnIndex == ComingSoonTable.Columns["UpdateButton"].Index)
                {
                    buttonColor = Color.LightBlue;
                    borderColor = Color.DarkBlue;
                }
                else if (e.ColumnIndex == ComingSoonTable.Columns["DeleteButton"].Index)
                {
                    buttonColor = Color.IndianRed;
                    borderColor = Color.DarkRed;
                }
                else if (e.ColumnIndex == ComingSoonTable.Columns["ViewButton"].Index)
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

        private void ViewComingSoon(string csoonID)
        {
            viewComingSoonPanel.Visible = true;
            var csoon = _movieService.GetComingSoonById(new ObjectId(csoonID));

            if (csoon != null)
            {
                try
                {
                    viewComingSoonBox.BackgroundImage = Image.FromFile(csoon.ComingSoonImagePath);
                    viewComingSoonBox.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Movie not found.");
            }
        }

        private void LoadComingSoonInCinemaData()
        {
            List<MovieMunch.Backend.Models.ComingSoon> comingSoonMovies = _movieService.GetComingSoons();
            ComingSoonTable.Rows.Clear();

            foreach (var movie in comingSoonMovies)
            {
                ComingSoonTable.Rows.Add(movie.Id, movie.ComingSoonTitle, movie.ComingSoonDescription, movie.ComingSoonPrice, movie.ComingSoonImagePath, movie.Day, movie.StartTime, movie.EndTime);
            }
        }

        private void ComingSoonTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string movieID = ComingSoonTable.Rows[e.RowIndex].Cells["ComingSoonId"].Value.ToString();

                if (ComingSoonTable.Columns[e.ColumnIndex].Name == "UpdateButton")
                {
                    UpdateComingSoon(movieID);
                }
                else if (ComingSoonTable.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    DeleteComingSoon(movieID);
                }
                else if (ComingSoonTable.Columns[e.ColumnIndex].Name == "ViewButton")
                {
                    ViewComingSoon(movieID);
                }
            }
        }

        private void UpdateComingSoon(string movieID)
        {
            if (ObjectId.TryParse(movieID, out var objectId))
            {
                var movie = _movieService.GetComingSoonById(objectId);

                if (movie != null)
                {
                    var currentRow = ComingSoonTable.Rows[ComingSoonTable.CurrentCell.RowIndex];
                    movie.ComingSoonTitle = currentRow.Cells["ComingSoonTitle"].Value.ToString();
                    movie.ComingSoonDescription = currentRow.Cells["ComingSoonDescription"].Value.ToString();
                    movie.ComingSoonPrice = Convert.ToDouble(currentRow.Cells["csoonPrice"].Value.ToString());

                    movie.ComingSoonImagePath = SanitizeImagePath(currentRow.Cells["ComingSoonImagePath"].Value.ToString());

                    try
                    {
                        _movieService.UpdateComingSoon(movie);
                        MessageBox.Show("Coming soon movie updated successfully.");
                        LoadComingSoonInCinemaData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating the coming soon movie: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Coming soon movie not found.");
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



        private void DeleteComingSoon(string movieID)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this coming soon movie?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (ObjectId.TryParse(movieID, out var objectId))
                {
                    bool isDeleted = _movieService.DeleteComingSoonByID(objectId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Coming soon movie successfully deleted.");
                        LoadComingSoonInCinemaData();
                    }
                    else
                    {
                        MessageBox.Show("Coming soon movie could not be deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID format.");
                }
            }
        }
        private void ClearAdminInput()
        {
            comingSoonTitleInput.Clear();
            comingSoonDescriptionInput.Clear();
            csoonPriceInput.Clear();
            comingSoonDirectoryInput.Clear();
        }

        private void backComingSoonBtn_Click(object sender, EventArgs e)
        {
            MainAdmin mainAdminForm = new MainAdmin();
            mainAdminForm.SetUserNamme(_userName, _profilePic);
            mainAdminForm.Visible = true;
            this.Close();
        }

        private void AddComingSoonButton_Click(object sender, EventArgs e)
        {
            string movieTitle = RemoveSurroundingQuotes(comingSoonTitleInput.Text);
            string movieDescription = RemoveSurroundingQuotes(comingSoonDescriptionInput.Text);
            double csoonPrice = Convert.ToDouble(RemoveSurroundingQuotes(csoonPriceInput.Text));
            string movieImagePath = RemoveSurroundingQuotes(comingSoonDirectoryInput.Text);

            if (string.IsNullOrEmpty(movieTitle) || string.IsNullOrEmpty(movieDescription) || string.IsNullOrEmpty(movieImagePath))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var newMovie = new MovieMunch.Backend.Models.ComingSoon
            {
                ComingSoonTitle = movieTitle,
                ComingSoonDescription = movieDescription,
                ComingSoonPrice = csoonPrice,
                ComingSoonImagePath = movieImagePath
            };

            _movieService.AddComingSoon(newMovie);
            MessageBox.Show("Coming soon movie saved successfully.");
            LoadComingSoonInCinemaData();
            ClearAdminInput();
        }

        private void closeShowingImageBtn_Click(object sender, EventArgs e)
        {
            viewComingSoonPanel.Visible = false;
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

        private void showingBtn_Click(object sender, EventArgs e)
        {
            Showing showing = new Showing(_userName, _profilePic);
            showing.Show();
            this.Close();
        }

        private void filmsBtn_Click(object sender, EventArgs e)
        {
            FilmsInCinemaForm films = new FilmsInCinemaForm(_userName, _profilePic);
            films.Show();
            this.Close();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            EmployeesManagementForm employee = new EmployeesManagementForm(_userName, _profilePic);
            employee.Show();
            this.Close();
        }

        private string _userName;
        private string _profilePic;
        private void foodsBtn_Click(object sender, EventArgs e)
        {
            CinemaFoodDeals snackDeals = new CinemaFoodDeals(_userName, _profilePic);
            snackDeals.Show();
            this.Close();
        }
    }
}

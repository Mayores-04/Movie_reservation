using MongoDB.Bson;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Drawing;
using MovieMunch.Backend.Services;
using System.Drawing.Drawing2D;

namespace MovieMunch.Admin.FilmsInCinema
{
    public partial class FilmsInCinemaForm : Form
    {
        private readonly MovieService _movieService;

        public FilmsInCinemaForm(string userName, string profilePic)
        {
            _userName = userName;
            _profilePic = profilePic;
            InitializeComponent();
            _movieService = new MovieService();
            LoadFilmsInCinemaData();
            formOptionsPanel.BringToFront();

            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Update",
                Text = "Update",
                UseColumnTextForButtonValue = true,
                Name = "UpdateButton"
            };
            
            MoviesTable.Columns.Add(updateButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Name = "DeleteButton"
            };
            MoviesTable.Columns.Add(deleteButtonColumn);

            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "View",
                Text = "View Film",
                UseColumnTextForButtonValue = true,
                Name = "ViewButton"
            };
            MoviesTable.Columns.Add(viewButtonColumn);

            MoviesTable.CellContentClick += MoviesTable_CellContentClick;
            MoviesTable.CellPainting += MoviesToShowTable_CellPainting;
        }

        private void MoviesToShowTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == MoviesTable.Columns["UpdateButton"].Index ||
                                    e.ColumnIndex == MoviesTable.Columns["DeleteButton"].Index ||
                                    e.ColumnIndex == MoviesTable.Columns["ViewButton"].Index))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);

                Color buttonColor = Color.Transparent;
                Color borderColor = Color.Black;
                if (e.ColumnIndex == MoviesTable.Columns["UpdateButton"].Index)
                {
                    buttonColor = Color.LightBlue;
                    borderColor = Color.DarkBlue;
                }
                else if (e.ColumnIndex == MoviesTable.Columns["DeleteButton"].Index)
                {
                    buttonColor = Color.IndianRed;
                    borderColor = Color.DarkRed;
                }
                else if (e.ColumnIndex == MoviesTable.Columns["ViewButton"].Index)
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

        private void ViewFilm(string filmsId)
        {
            viewFilmPanel.Visible = true;
            var film = _movieService.GetFilmById(new ObjectId(filmsId));

            if (film != null)
            {
                try
                {
                    viewFilmBox.BackgroundImage = Image.FromFile(film.FilmImagePath);
                    viewFilmBox.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Snack not found.");
            }
        }


        private void LoadFilmsInCinemaData()
        {
            List<MovieMunch.Backend.Models.FilmsInCinema> films = _movieService.GetFilmsInCinemas();
            MoviesTable.Rows.Clear();

            foreach (var film in films)
            {
                MoviesTable.Rows.Add(film.Id, film.FilmTitle, film.FilmsDescription, film.FilmsPrice, film.FilmImagePath);
            }
        }

        private void MoviesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string filmId = MoviesTable.Rows[e.RowIndex].Cells["id"].Value.ToString();

                if (MoviesTable.Columns[e.ColumnIndex].Name == "UpdateButton")
                {
                    UpdateFilm(filmId);
                }
                else if (MoviesTable.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    DeleteFilm(filmId);
                }
                else if (MoviesTable.Columns[e.ColumnIndex].Name == "ViewButton")
                {
                    ViewFilm(filmId);
                }
            }
        }

        private void UpdateFilm(string filmId)
        {
            if (ObjectId.TryParse(filmId, out var objectId))
            {
                var film = _movieService.GetFilmById(objectId);

                if (film != null)
                {
                    var currentRow = MoviesTable.Rows[MoviesTable.CurrentCell.RowIndex];
                    film.FilmTitle = currentRow.Cells["Title"].Value.ToString(); 
                    film.FilmsDescription = currentRow.Cells["Description"].Value.ToString(); 
                    film.FilmsPrice = Convert.ToDouble(currentRow.Cells["filmPrice"].Value.ToString()); 
                    film.FilmImagePath = currentRow.Cells["imagePath"].Value.ToString(); 

                    _movieService.UpdateFilm(film);
                    MessageBox.Show("Film updated successfully.");
                    LoadFilmsInCinemaData();
                }
                else
                {
                    MessageBox.Show("Film not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID format.");
            }
        }

        private void DeleteFilm(string filmId)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this film?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (ObjectId.TryParse(filmId, out var objectId)) 
                {
                    bool isDeleted = _movieService.DeleteFilmById(objectId); 

                    if (isDeleted)
                    {
                        MessageBox.Show("Film successfully deleted.");
                        LoadFilmsInCinemaData(); 
                    }
                    else
                    {
                        MessageBox.Show("Film could not be deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID format.");
                }
            }
        }

        private string RemoveSurroundingQuotes(string input)
        {
            if (!string.IsNullOrEmpty(input) && input.StartsWith("\"") && input.EndsWith("\""))
            {
                return input.Substring(1, input.Length - 2);
            }
            return input;
        }

        private void ClearAdminInput()
        {
            titleInput.Clear();
            descriptionInput.Clear();
            filmsPriceInput.Clear();
            directoryInput.Clear();
        }

        private void AddFilm_Click(object sender, EventArgs e)
        {
            string movieTitle = RemoveSurroundingQuotes(titleInput.Text);
            string movieDescription = RemoveSurroundingQuotes(descriptionInput.Text);
            double filmsPrice = Convert.ToDouble(RemoveSurroundingQuotes(filmsPriceInput.Text));
            string movieImagePath = RemoveSurroundingQuotes(directoryInput.Text);

            if (string.IsNullOrEmpty(movieTitle) || string.IsNullOrEmpty(movieImagePath) || string.IsNullOrEmpty(movieDescription))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var newFilm = new MovieMunch.Backend.Models.FilmsInCinema
            {
                FilmTitle = movieTitle,
                FilmsDescription = movieDescription,
                FilmsPrice = filmsPrice,
                FilmImagePath = movieImagePath
            };

            _movieService.AddFilm(newFilm);
            MessageBox.Show("Film saved successfully.");
            LoadFilmsInCinemaData();
            ClearAdminInput();
        }

        private void backFilmBtn_Click_1(object sender, EventArgs e)
        {
            MainAdmin mainAdminForm = new MainAdmin();
            mainAdminForm.SetUserNamme(_userName, _profilePic);
            mainAdminForm.Visible = true;
            this.Close();
        }

        private void closeShowingImageBtn_Click(object sender, EventArgs e)
        {
            viewFilmPanel.Visible = false;
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

        private void comingSoonBtn_Click(object sender, EventArgs e)
        {
            ComingSoonMoviesForm csoon = new ComingSoonMoviesForm(_userName, _profilePic);
            csoon.Show();
            this.Close();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            EmployeeList employeeList = new EmployeeList(_userName, _profilePic);
            employeeList.Show();
            this.Close();
        }

        private string _userName;
        private string _profilePic;
        private void foodsBtn_Click(object sender, EventArgs e)
        {
            CinemaFoodDeals snackDealsForm = new CinemaFoodDeals(_userName, _profilePic);
            snackDealsForm.Show();
            this.Close();
        }
    }
}

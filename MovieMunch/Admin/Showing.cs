using MongoDB.Bson;
using MovieMunch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMunch.Admin
{
    public partial class Showing : Form
    {

        private readonly MovieService _movieService;
        public Showing()
        {
            InitializeComponent();
            _movieService = new MovieService();
            LoadMoviesInCinemaData();

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
        }

        private void LoadMoviesInCinemaData()
        {
            List<Movie> movies = _movieService.GetAllMovies();
            MoviesToShowTable.Rows.Clear();

            foreach (var movie in movies)
            {
                MoviesToShowTable.Rows.Add(movie.Id, movie.MovieTitle, movie.MovieDescription, movie.MoviePrice, movie.MovieImagePath);
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
                    movie.MovieTitle = currentRow.Cells["moviesTitle"].Value.ToString();
                    movie.MovieDescription = currentRow.Cells["moviesDescription"].Value.ToString(); 
                    movie.MoviePrice = Convert.ToDouble(currentRow.Cells["moviePrice"].Value.ToString());
                    movie.MovieImagePath = currentRow.Cells["moviesImagePath"].Value.ToString();

                    _movieService.UpdateMovies(movie);
                    MessageBox.Show("Movie updated successfully.");
                    LoadMoviesInCinemaData();
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
            double moviePrice = Convert.ToDouble(RemoveSurroundingQuotes(moviePriceInput.Text));
            string movieImagePath = RemoveSurroundingQuotes(movieDirectoryInput.Text);

            if (string.IsNullOrEmpty(movieTitle) || string.IsNullOrEmpty(movieImagePath) || string.IsNullOrEmpty(movieDescription))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var newMovie = new Movie
            {
                MovieTitle = movieTitle,
                MovieDescription = movieDescription,
                MoviePrice = moviePrice,
                MovieImagePath = movieImagePath
            };

            _movieService.AddMovies(newMovie);
            MessageBox.Show("Movie saved successfully.");
            LoadMoviesInCinemaData();
            ClearAdminInput();
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
            movieTitleInput.Clear();
            movieDescriptionInput.Clear();
            moviePriceInput.Clear();
            movieDirectoryInput.Clear();
        }

        private void closeShowingImageBtn_Click(object sender, EventArgs e)
        {
            viewShowingImagePanel.Visible = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainAdmin mainAdminForm = new MainAdmin();
            mainAdminForm.Visible = true;
            this.Close();
        }
    }
}

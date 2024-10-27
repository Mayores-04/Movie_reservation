using MongoDB.Bson;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace MovieMunch.Admin.Components
{
    public partial class FilmsInCinemaForm : Form
    {
        private readonly MovieService _movieService;

        public FilmsInCinemaForm()
        {
            InitializeComponent();
            _movieService = new MovieService();
            LoadFilmsInCinemaData();
        }

        private void LoadFilmsInCinemaData()
        {
            List<MovieMunch.Backend.Models.FilmsInCinema> films = _movieService.GetFilmsInCinemas();
            MoviesTable.Rows.Clear();

            foreach (var film in films)
            {
                MoviesTable.Rows.Add(film.Id, film.FilmTitle, film.FilmsDescription, film.FilmImagePath);
            }
        }

        private string RemoveSurroundingQuotes(string input)
        {
            if (!string.IsNullOrEmpty(input) && input.StartsWith("\"") && input.EndsWith("\""))
            {
                // Remove the first and last characters if they are both quotes
                return input.Substring(1, input.Length - 2);
            }
            return input;
        }

        private void SaveMoviesButton_Click(object sender, EventArgs e)
        {

            idInput.Visible = false;
            titleInput.Visible = true;
            descriptionInput.Visible = true;
            directoryInput.Visible = true;

            string movieTitle = RemoveSurroundingQuotes(titleInput.Text);
            string movieDescription = RemoveSurroundingQuotes(descriptionInput.Text);
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
                FilmImagePath = movieImagePath
            };

            _movieService.AddFilm(newFilm);
            MessageBox.Show("Film saved successfully.");
            LoadFilmsInCinemaData();
        }

        private void UpdateFilmButton_Click_1(object sender, EventArgs e)
        {

            idInput.Visible = false;
            titleInput.Visible = true;
            descriptionInput.Visible = true;
            directoryInput.Visible = true;

            string movieTitle = RemoveSurroundingQuotes(titleInput.Text);
            string movieDescription = RemoveSurroundingQuotes(descriptionInput.Text);
            string movieImagePath = RemoveSurroundingQuotes(directoryInput.Text);


            if (string.IsNullOrEmpty(movieTitle) || string.IsNullOrEmpty(movieImagePath) || string.IsNullOrEmpty(movieDescription))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var updatedFilm = new MovieMunch.Backend.Models.FilmsInCinema
            {
                FilmTitle = movieTitle,
                FilmsDescription = movieDescription,
                FilmImagePath = movieImagePath
            };

            _movieService.UpdateFilm(updatedFilm);
            MessageBox.Show("Film updated successfully.");
            LoadFilmsInCinemaData();
        }



        private void deleteBtn_Click(object sender, EventArgs e)
        {


            idInput.Visible = true;
            titleInput.Visible = false;
            descriptionInput.Visible = false;
            directoryInput.Visible = false;

            string movieId = idInput.Text; 

            if (string.IsNullOrEmpty(movieId))
            {
                MessageBox.Show("Please fill in the ID field.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this film?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (ObjectId.TryParse(movieId, out var objectId))
                {
                    var deleteFilm = new MovieMunch.Backend.Models.FilmsInCinema
                    {
                        Id = objectId.ToString()  
                    };

                    bool isDeleted = _movieService.DeleteFilm(deleteFilm);

                    if (isDeleted)
                    {
                        MessageBox.Show("Film successfully deleted.");
                        LoadFilmsInCinemaData(); 
                    }
                    else
                    {
                        MessageBox.Show("Film not found or could not be deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID format.");
                }
            }
        }

    }
}

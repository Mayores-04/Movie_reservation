﻿using MongoDB.Bson;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Drawing;

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

            DataGridViewButtonColumn ViewFilm = new DataGridViewButtonColumn
            {
                HeaderText = "View",
                Text = "View Film",
                UseColumnTextForButtonValue = true,
                Name = "ViewButton"
            };
            MoviesTable.Columns.Add(ViewFilm);

            MoviesTable.CellContentClick += MoviesTable_CellContentClick;
        }

        private void ViewFilm(string filmId)
        {
            MessageBox.Show($"Viewing film with ID: {filmId}");
        }


        private void MoviesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (MoviesTable.Columns[e.ColumnIndex].Name == "UpdateButton" || MoviesTable.Columns[e.ColumnIndex].Name == "DeleteButton"))
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
                return input.Substring(1, input.Length - 2);
            }
            return input;
        }

        private void ClearAdminInput()
        {
            titleInput.Clear();
            descriptionInput.Clear();
            directoryInput.Clear();
        }

        private void AddMoviesButton_Click(object sender, EventArgs e)
        {
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
            ClearAdminInput();
        }
    }
}

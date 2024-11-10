using MongoDB.Bson;
using MovieMunch.Backend.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MovieMunch.Admin
{
    public partial class ComingSoonMoviesForm : Form
    {
        private readonly MovieService _movieService;
        public ComingSoonMoviesForm()
        {
            InitializeComponent();
            _movieService = new MovieService();
            LoadComingSoonInCinemaData();

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
                ComingSoonTable.Rows.Add(movie.Id, movie.ComingSoonTitle, movie.ComingSoonDescription, movie.ComingSoonPrice, movie.ComingSoonImagePath);
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
                    movie.ComingSoonImagePath = currentRow.Cells["ComingSoonImagePath"].Value.ToString();

                    _movieService.UpdateComingSoon(movie);
                    MessageBox.Show("Coming soon movie updated successfully.");
                    LoadComingSoonInCinemaData();
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

        private void AddComingSoon_Click(object sender, EventArgs e)
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
            comingSoonTitleInput.Clear();
            comingSoonDescriptionInput.Clear();
            csoonPriceInput.Clear();
            comingSoonDirectoryInput.Clear();
        }

        private void closeImageBtn_Click(object sender, EventArgs e)
        {
            viewComingSoonPanel.Visible = false;
        }

        private void backComingSoonBtn_Click(object sender, EventArgs e)
        {
            MainAdmin mainAdminForm = new MainAdmin();
            mainAdminForm.Visible = true;
            this.Close();
        }
    }
}

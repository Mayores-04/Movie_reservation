using MovieMunch.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MovieMunch.Frontend.Forms
{
    public partial class WatchListForm : Form
    {
        private string _userName;
        private readonly UserService _userService;

        public WatchListForm(string userName)
        {
            InitializeComponent();

            // Set the user name passed from the previous form
            _userName = userName;
            userNameHolder.Text = _userName;
            _userService = new UserService();

            LoadWatchList();
        }

        private void LoadWatchList()
        {
            try
            {
                // Fetch the user's watchlist
                var watchLaterMovies = _userService.GetWatchLaterMovies(_userName);

                if (watchLaterMovies != null)
                {
                    //watchlistPanel.Controls.Clear(); // Clear any existing items in the panel.

                    foreach (var movie in watchLaterMovies)
                    {
                        // Create and add movie items dynamically
                        var movieItem = CreateMovieItemControl(movie);
                        //watchlistPanel.Controls.Add(movieItem);
                    }
                }
                else
                {
                    MessageBox.Show("No movies in the watchlist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading watchlist: {ex.Message}");
            }
        }

        private Control CreateMovieItemControl(MovieDetails movie)
        {
            // Example: Create a simple UI element for each movie
            var panel = new Panel
            {
                Width = 200,
                Height = 100,
                BorderStyle = BorderStyle.FixedSingle
            };

            var titleLabel = new Label
            {
                Text = movie.MovieTitle,
                Dock = DockStyle.Top
            };

            var priceLabel = new Label
            {
                Text = movie.MoviePrice.ToString("C"),
                Dock = DockStyle.Bottom
            };

            panel.Controls.Add(titleLabel);
            panel.Controls.Add(priceLabel);

            return panel;
        }

        private void homeBtn_Click_1(object sender, EventArgs e)
        {
            // Navigate back to the main page
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainPage)
                {
                    openForm.Close();
                    break;
                }
            }

            MainPage mainPage = new MainPage();
            mainPage.SetUserInfo(_userName); // Pass the user name to MainPage
            mainPage.Show();
            this.Close();
        }
    }
}

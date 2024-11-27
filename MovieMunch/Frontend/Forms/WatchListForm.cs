using MovieMunch.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MovieMunch.Frontend.Forms
{
    public partial class WatchListForm : Form
    {
        private string _userName;
        private string _userEmail;
        private string _movieId;
        private readonly UserService _userService;

        public WatchListForm(string movieID, string userName, string userEmail)
        {
            InitializeComponent();

            _userName = userName;
            _userEmail = userEmail;
            _movieId = movieID;
            _userService = new UserService();

            userNameHolder.Text = _userName;

            LoadWatchList();

        }

        private void LoadWatchList()
        {
            try
            {
                watchListFlowLayoutPanel.Controls.Clear();
                watchListFlowLayoutPanel.AutoScroll = true;
                watchListFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                watchListFlowLayoutPanel.WrapContents = false;

                var loadingLabel = new Label
                {
                    Text = "Loading watchlist...",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 14, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                watchListFlowLayoutPanel.Controls.Add(loadingLabel);

                var watchLaterMovies = _userService.GetWatchLaterMovies(_userName);

                watchListFlowLayoutPanel.Controls.Clear();

                if (watchLaterMovies != null && watchLaterMovies.Any())
                {
                    foreach (var movie in watchLaterMovies)
                    {
                        var moviePanel = CreateMoviePanel(movie);
                        watchListFlowLayoutPanel.Controls.Add(moviePanel);
                    }
                }
                else
                {
                    var noMoviesLabel = new Label
                    {
                        Text = "No movies in the watchlist.",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 14, FontStyle.Italic),
                        ForeColor = Color.Gray,
                        Dock = DockStyle.Top,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    watchListFlowLayoutPanel.Controls.Add(noMoviesLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading watchlist: {ex.Message}");
            }
        }

        private Guna.UI2.WinForms.Guna2Panel CreateMoviePanel(MovieDetails movie)
        {
            var moviePanel = new Guna.UI2.WinForms.Guna2Panel
            {
                Size = new System.Drawing.Size(1030, 400),  
                BorderRadius = 10,
                BorderThickness = 1,
                Margin = new Padding(10, 10, 0, 10),
            };


            var pictureBox = new Guna.UI2.WinForms.Guna2PictureBox
            {
                ImageLocation = movie.MoviePic,
                Size = new System.Drawing.Size(300, 388),
                Location = new System.Drawing.Point(10, 10),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderRadius = 8
            };

            pictureBox.LoadCompleted += (s, e) =>
            {
                if (e.Error != null)
                {
                    pictureBox.Image = Properties.Resources.applogo;
                }
            };

            var titleBackgroundPanel = new Guna.UI2.WinForms.Guna2Panel
            {
                Size = new System.Drawing.Size(1000, 60),
                Location = new System.Drawing.Point(340, 10),  
                BorderThickness = 2,
                BorderColor = ColorTranslator.FromHtml("#EE4540"),  
                FillColor = ColorTranslator.FromHtml("#510A32"),   
                BorderRadius = 5
            };

            var titleLabel = new Label
            {
                Text = movie.MovieTitle,
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                Location = new System.Drawing.Point(10, 3),  
                AutoSize = false,
                ForeColor = Color.White,  
                Size = new System.Drawing.Size(700, 50),
                BackColor = ColorTranslator.FromHtml("#510A32"),  
                TextAlign = ContentAlignment.MiddleLeft,
            };

            titleBackgroundPanel.Controls.Add(titleLabel);

            var descriptionLabel = new Label
            {
                Text = movie.MovieDescription,
                Font = new Font("Segoe UI", 12),
                Location = new System.Drawing.Point(350, 80),  
                Size = new System.Drawing.Size(200, 100),
                ForeColor = Color.LightGray,
                AutoEllipsis = true
            };

            var reserveSeatButton = new Guna.UI2.WinForms.Guna2Button
            {
                Text = "Reserve Seat",
                Size = new System.Drawing.Size(120, 40),
                Location = new System.Drawing.Point(340, 350),
                FillColor = Color.FromArgb(220, 53, 69), 
                ForeColor = Color.White,
                BorderRadius = 5
            };

            reserveSeatButton.Click += (sender, args) => ReserveSeat(movie);
            var removeButton = new Guna.UI2.WinForms.Guna2Button
            {
                Text = string.Empty, 
                Size = new System.Drawing.Size(45, 45), 
                Location = new System.Drawing.Point(480, 350), 
                FillColor = Color.Transparent,  
                BorderThickness = 0,  
                BorderRadius = 25, 
                Margin = new Padding(5, 5, 0, 0),  
                ImageOffset = new System.Drawing.Point(0, 3)  
            };

            try
            {
                removeButton.Image = Image.FromFile(@"C:\Users\jakem\source\repos\Movie_reservation\MovieMunch\Frontend\Forms\Icons\heartBreak.png");
                removeButton.ImageAlign = (HorizontalAlignment)ContentAlignment.MiddleCenter; 
                removeButton.ImageSize = new System.Drawing.Size(44, 44); 
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Image file not found!");
            }


            

            removeButton.Click += (sender, args) => ConfirmRemoveMovie(movie);

            moviePanel.Controls.Add(pictureBox);
            moviePanel.Controls.Add(titleBackgroundPanel); 
            moviePanel.Controls.Add(descriptionLabel);
            moviePanel.Controls.Add(reserveSeatButton);
            moviePanel.Controls.Add(removeButton);

            return moviePanel;
        }

        private void ReserveSeat(MovieDetails movie)
        {
            SeatReservation seatReservation = new SeatReservation(_movieId, movie.MovieTitle, movie.MovieDescription, movie.MoviePrice, movie.MoviePic, _userName);
            seatReservation.Show();
            this.Close();
        }

        private void ConfirmRemoveMovie(MovieDetails movie)
        {
            var confirmResult = MessageBox.Show($"Are you sure you want to remove '{movie.MovieTitle}' from your watchlist?",
                                                "Confirm Removal",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                RemoveMovieFromWatchlist(movie);
            }
        }

        private void RemoveMovieFromWatchlist(MovieDetails movie)
        {
            try
            {
                var result = _userService.RemoveMovieFromWatchlist(_userName, movie.MovieTitle);
                if (result)
                {
                    MessageBox.Show($"Movie '{movie.MovieTitle}' removed from the watchlist.");
                    LoadWatchList(); 
                }
                else
                {
                    MessageBox.Show($"Failed to remove '{movie.MovieTitle}'. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing movie: {ex.Message}");
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MainPage)
                {
                    openForm.Close();
                    break;
                }
            }

            MainPage mainPage = new MainPage();
            mainPage.SetLoggedInUserEmail(_userEmail);

            if(_userName == null || userNameHolder.Text == "")
            {

                mainPage.SetUserInfo("USERNAME");
            }
            else
            {
                mainPage.SetUserInfo(_userName);
                mainPage.Show();
            }
            this.Close();
        }

        private void ticketBtn_Click(object sender, EventArgs e)
        {
            if (_userName == null || userNameHolder.Text == "")
            {
                var ticketForm = new TicketForm(_movieId, "USERNAME", _userName);
                ticketForm.Show();
            }
            else
            {
                var ticketForm = new TicketForm(_movieId, _userName, _userName);
                ticketForm.Show();
            }
            this.Close();
        }
    }
}

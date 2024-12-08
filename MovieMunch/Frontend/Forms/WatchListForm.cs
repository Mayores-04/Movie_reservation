using MovieMunch.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieMunch.Frontend.Forms
{
    public partial class WatchListForm : Form
    {
        private string _userName;
        private string _userEmail;
        private string _movieId;
        private string _profilePic;
        private readonly UserService _userService;



        private string _movieDay;
        private DateTime _movieStart;
        private DateTime _movieEnd;
        public WatchListForm(string movieID, string userName, string userEmail, string profilePic,
            string movieDay, DateTime movieStart, DateTime movieEnd)
        {
            InitializeComponent();

            _userName = userName;
            _userEmail = userEmail;
            _movieId = movieID;
            _profilePic = profilePic;
            _userService = new UserService();
            userNameHolder.Text = _userName;
            LoadWatchList();

            //Schedule
            _movieDay = movieDay;
            _movieStart = movieStart;
            _movieEnd = movieEnd;

            defaultHeight = userPanel.Height;
            userPanel.Height = 0;
            userPanel.Visible = false;

            userPanelTimer.Interval = 15;
            userPanelTimer.Tick += smothFromLeftToRightTransition_Click;

            try
            {
                if (!string.IsNullOrEmpty(profilePic) && File.Exists(profilePic))
                {
                    userProfileBtn.Image = System.Drawing.Image.FromFile(profilePic);
                    userProfileBtn.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    userProfileBtn.Image = Properties.Resources.DefaultBackground;
                    userProfileBtn.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile picture: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (!string.IsNullOrEmpty(profilePic) && File.Exists(profilePic))
                {
                    userProfileCustomHolder.Image = System.Drawing.Image.FromFile(profilePic);
                    userProfileCustomHolder.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    userProfileCustomHolder.Image = Properties.Resources.DefaultBackground;
                    userProfileCustomHolder.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile picture: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            changeNewUsernameInput.PlaceholderText = userName;
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
                Size = new System.Drawing.Size(665, 250),
                ForeColor = Color.LightGray,
                AutoEllipsis = true,
                BackColor = Color.Transparent
            };

            var reserveSeatButton = new Guna.UI2.WinForms.Guna2Button
            {
                Text = "Reserve Seat",
                Size = new System.Drawing.Size(160, 40),
                Location = new System.Drawing.Point(340, 350),
                FillColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold), 
                BorderRadius = 20 
            };


            reserveSeatButton.Click += (sender, args) => ReserveSeat(movie);
            var removeButton = new Guna.UI2.WinForms.Guna2Button
            {
                Text = string.Empty, 
                Size = new System.Drawing.Size(45, 45), 
                Location = new System.Drawing.Point(510, 350), 
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
            SeatReservation seatReservation = new SeatReservation(_movieId, movie.MovieTitle, movie.MovieDescription, movie.MoviePrice, 
                movie.MoviePic,
                _userName, _profilePic, _movieDay, _movieStart, _movieEnd);
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

                mainPage.SetUserInfo("USERNAME", _profilePic);
            }
            else
            {
                mainPage.SetUserInfo(_userName, _profilePic);
                mainPage.Show();
            }
            this.Close();
        }

        private void ticketBtn_Click(object sender, EventArgs e)
        {
            if (_userName == null || userNameHolder.Text == "")
            {
                var ticketForm = new TicketForm(_movieId, "USERNAME", _userName, _profilePic, _movieDay, _movieStart, _movieEnd);
                ticketForm.Show();
            }
            else
            {
                var ticketForm = new TicketForm(_movieId, _userName, _userName, _profilePic, _movieDay, _movieStart, _movieEnd);
                ticketForm.Show();
            }
            this.Close();
        }


        int targetHeight;
        int defaultHeight;
        bool isExpanding;

        Timer userPanelTimer = new Timer();
        private User currentUser;

        private void smothFromLeftToRightTransition_Click(object sender, EventArgs e)
        {
            if (isExpanding)
            {
                if (userPanel.Height < targetHeight)
                {
                    userPanel.Height += 20;
                    if (userPanel.Height >= targetHeight)
                    {
                        userPanel.Height = targetHeight;
                        userPanelTimer.Stop();
                    }
                }
            }
            else
            {
                if (userPanel.Height > targetHeight)
                {
                    userPanel.Height -= 20;
                    if (userPanel.Height <= targetHeight)
                    {
                        userPanel.Height = targetHeight;
                        userPanelTimer.Stop();
                        userPanel.Visible = false;
                    }
                }
            }
        }

        private void userProfileBtn_Click(object sender, EventArgs e)
        {
            userPanelTimer.Start();

            if (userPanel.Height == 0)
            {
                targetHeight = defaultHeight;
                isExpanding = true;
                userPanel.Visible = true;
            }
            else
            {
                targetHeight = 0;
                isExpanding = false;
            }

            userPanelTimer.Start();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            var userService = new UserService();
            userService.Logout();
        }


        private string profilePicBase;

        private void saveUserPicOrNameBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            string username = userNameHolder.Text;
            string newUsername = changeNewUsernameInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(newUsername) && string.IsNullOrWhiteSpace(profilePicBase))
            {
                MessageBox.Show("Please provide either a new username or select a profile picture.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string profilePicPath = string.Empty;

            if (!string.IsNullOrWhiteSpace(profilePicBase))
            {
                profilePicPath = profilePicBase;
            }

            bool isUpdated = userService.UpdateUserProfile(username, newUsername, profilePicPath);

            if (isUpdated)
            {
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _profilePic = profilePicBase;
            }
            else
            {
                MessageBox.Show("Failed to update the profile. Please check the username and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var user = userService.GetUserByUsername(username);
            ReloadUserProfile(user?.Name);
        }

        private void changePicBtn_Click(object sender, EventArgs e)
        {
            string selectedFilePath = SelectImageFile();

            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                profilePicBase = selectedFilePath;
                _profilePic = selectedFilePath;

                userProfileBtn.Image = System.Drawing.Image.FromFile(profilePicBase);
                userProfileCustomHolder.Image = System.Drawing.Image.FromFile(profilePicBase);

                MessageBox.Show("Profile picture selected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string SelectImageFile()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select Profile Picture";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return string.Empty;
        }

        private void ReloadUserProfile(string username)
        {
            UserService userService = new UserService();
            var user = userService.GetUserByUsername(username);

            if (user != null)
            {
                userNameHolder.Text = user.Name;

                if (!string.IsNullOrWhiteSpace(user.userProfilePic) && File.Exists(user.userProfilePic))
                {
                    try
                    {
                        userProfileBtn.Image = System.Drawing.Image.FromFile(user.userProfilePic);
                        userProfileCustomHolder.Image = System.Drawing.Image.FromFile(user.userProfilePic);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Profile picture not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void saveUserNameOrPasswordBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();


            string email = changePrevEmailInput.Text.Trim();

            string password = prevPasswordInput.Text.Trim();

            string newPassword = changePasswordInput.Text.Trim();
            string confirmNewPassword = changeConfirmNewPasswordInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Email and password cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool prevAccount = userService.new_edited_account(email, newPassword);

            if (prevAccount)
            {
                MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                changePrevEmailInput.PlaceholderText = "TYPE TO CHANGE EMAIL";
                prevPasswordInput.PlaceholderText = "TYPE PREVIOUS PASSWORD INPUT";
            }
            else
            {
                MessageBox.Show("Failed to update the account. Please check the email and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.GetUsers(_userName, _profilePic);
            loginForm.ShowDialog();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            RegisterForm registerForm = new RegisterForm();
            registerForm.GetUsers(_userName, _profilePic);
            registerForm.ShowDialog();
        }

        private void exitApplicationBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

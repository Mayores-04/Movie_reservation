using Guna.UI2.WinForms;
using MovieMunch.Frontend.Forms;
using MovieMunch.Models;
using MovieMunch.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieMunch.Backend.Services;
using MovieMunch.Backend.Models;
using MongoDB.Driver;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Collections;

namespace MovieMunch
{
    public partial class SeatReservation : Form
    {
        private readonly SeatReservationServices _seatReservationService;
        private List<string> _allSeats;
        private string _movieName;
        private string _reservedBy;
        private decimal _moviePrice;
        private List<string> _selectedSeats;
        private string userName;
        private string _movieId;
        private string _movieDescription;
        private string _moviePic;

        private MovieService _movieService;
        private List<FilmsInCinema> _filmsInCinemas;
        private List<ComingSoon> _comingSoon;
        private List<MovieInfo> _movies;

        private FoodServices _foodServices;
        private List<RegularDeals> _foodsCollection;
        private List<SnackDeals> _snacksFoodsCollection;

        private string id;
        private string title;
        private string description;
        private decimal price;
        private string _profilePic;
        private Image image;
        private string reservedBy;

        private string _movieDays;
        private DateTime _movieStart;
        private DateTime _movieEnd;

        public SeatReservation(string Id, string movieTitle, string movieDescription, decimal moviePrice, 
            string moviePic, string reservedBy, string profilePic, string MovieDays, DateTime movieStartTime, DateTime movieEndTime)
        {
            _foodServices = new FoodServices();
            _foodsCollection = _foodServices.GetFoodsInCollection();
            _snacksFoodsCollection = _foodServices.GetSnackFoodsCollection();

            MainPage mainPage = new MainPage();
            mainPage.Close();

            InitializeComponent();

            _movieId = Id;
            _movieName = movieTitle;
            _moviePrice = moviePrice;
            _reservedBy = reservedBy;
            _moviePic = moviePic;
            _profilePic = profilePic;
            _movieDescription = movieDescription;
            
            //Dates
            _movieDays = MovieDays;
            _movieStart = movieStartTime;
            _movieEnd = movieEndTime;

            DayHolder.Text = $"{ _movieDays}";
            StartDateHolder.Text = $"{_movieStart} - {_movieEnd}";

            _movieService = new MovieService();
            _movies = _movieService.GetAllMovieInfos();
            _filmsInCinemas = _movieService.GetFilmsInCinemas();
            _comingSoon = _movieService.GetComingSoons();


            _foodServices = new FoodServices();
            _foodsCollection = _foodServices.GetFoodsInCollection();


            var dbConnection = new MongoDBConnection();
            _seatReservationService = new SeatReservationServices(dbConnection);

            _selectedSeats = new List<string>();

            _allSeats = new List<string>();
            for (int i = 1; i <= 24; i++)
            {
                for (char j = 'A'; j <= 'J'; j++)
                {
                    _allSeats.Add($"{j}{i}");
                }
            }
            userNameHolder.Text = reservedBy;

            movieTitlelbl.Text = _movieName;
            this.Load += SeatReservation_Load;
            userName = reservedBy;
            mainPage.SetUserInfo(userName, _profilePic);

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            FadeIn(this);
            defaultHeight = userPanel.Height;
            userPanel.Height = 0;
            userPanel.Visible = false;

            userPanelTimer.Interval = 15;
            userPanelTimer.Tick += smothFromLeftToRightTransition_Click;
            userPanel.BringToFront();
            SnacksDealsPanel.BringToFront();
            RegularDealsPanel.BringToFront();
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


        private void FadeIn(Control control)
        {
            control.Visible = true;

            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Tick += (s, e) =>
            {
                int alpha = control.BackColor.A;

                if (alpha < 255)
                {
                    alpha += 5;
                    if (alpha > 255) alpha = 255;
                }
                else
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };
            timer.Start();
        }


        private readonly UserService _userService = new UserService();
        private async void addToWatchLaterBtn_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_movieName) || string.IsNullOrEmpty(_movieDescription))
                {
                    MessageBox.Show("Please select a valid movie before adding it to the watchlist.",
                        "Invalid Movie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(userName) || userName == "USERNAME")
                {
                    MessageBox.Show("You must be logged in to add movies to your watchlist.",
                        "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    using (var loginForm = new LoginForm())
                    {
                        loginForm.ShowDialog();
                    }
                    return;
                }

                string movieTitle = _movieName;
                string movieDescription = _movieDescription;
                decimal moviePrice = _moviePrice;
                string moviePic = _moviePic.ToString(); 

                await _userService.AddMoviesToWatchListOfUser(userName, movieTitle, movieDescription, moviePrice, moviePic, _movieDays, _movieStart, _movieEnd);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while adding the movie to the watchlist: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void SeatReservation_Load(object sender, EventArgs e)
        {
            movieTitlelbl.Text = _movieName;

            string imagePath = await _seatReservationService.GetMovieImagePathAsync(_movieName);

            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {

                moviePicToReserve.BackgroundImage = Image.FromFile(imagePath);
            }
            else
            {
                moviePicToReserve.Image = Properties.Resources.BG;
            }

            await LoadSeatStatusAsync(_movieName);
        }


        private async Task LoadSeatStatusAsync(string movieName)
        {
            var reservedSeats = await _seatReservationService.CheckSeatStatusAsync(movieName);

            if (reservedSeats != null)
            {
                foreach (var reservation in reservedSeats)
                {
                    foreach (string seatNumber in reservation.SeatNumbers)
                    {
                        Control seatButton = this.Controls.Find(seatNumber, true).FirstOrDefault();

                        if (seatButton is Guna2Button btn)
                        {
                            btn.FillColor = reservation.IsReserved ? Color.FromArgb(199, 44, 65) : Color.White;
                            btn.Refresh();
                        }
                    }
                }
            }
        }

        private async void btnReserveSeat_Click(object sender, EventArgs e)
        {
            if (_selectedSeats.Count > 0)
            {
                PaymentForm paymentForm = new PaymentForm(_movieId, _movieName, _moviePrice, _selectedSeats, _reservedBy);
                paymentForm.ShowDialog();

                if (paymentForm.IsPaymentSuccessful)
                {
                    await _seatReservationService.ReserveSeatsAsync(_movieName, (double)_moviePrice, _selectedSeats, _reservedBy);
                    MessageBox.Show("Seats reserved successfully!");

                    foreach (string seat in _selectedSeats)
                    {
                        if (this.Controls[seat] is Guna2Button seatButton)
                        {
                            seatButton.FillColor = Color.FromArgb(199, 44, 65);
                            seatButton.Refresh();
                        }
                    }
                    await LoadSeatStatusAsync(_movieName);
                    _selectedSeats.Clear();
                }
                else
                {
                    MessageBox.Show("Payment was not successful. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("No seats selected.");
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button seatButton)
            {
                if (seatButton.FillColor == Color.White || seatButton.FillColor == Color.Yellow)
                {
                    if (!_selectedSeats.Contains(seatButton.Name))
                    {
                        seatButton.FillColor = Color.Yellow;
                        _selectedSeats.Add(seatButton.Name);
                    }
                    else
                    {
                        seatButton.FillColor = Color.White;
                        _selectedSeats.Remove(seatButton.Name);
                    }
                    seatButton.Refresh();
                }
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
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
            mainPage.SetUserInfo(userName, _profilePic);
            this.Visible = false;
        }

        private void gotoWatchListBtn_Click(object sender, EventArgs e)
        {
            if (userName == null || userNameHolder.Text == "")
            {
                var watchListForm = new WatchListForm(_movieId, "USERNAME", userName, _profilePic, _movieDays, _movieStart, _movieEnd);
                watchListForm.Show();
            }
            else
            {
                var watchListForm = new WatchListForm(_movieId, userName, userName, _profilePic, _movieDays, _movieStart, _movieEnd);
                watchListForm.Show();
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

        private void gotoTicketFormBtn_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm(_movieId, userNameHolder.Text, userName, _profilePic, _movieDays, _movieStart, _movieEnd);
            ticketForm.Show();
            this.Close();
        }

        private void regularDealsBtn_Click(object sender, EventArgs e)
        {
            if(SnacksDealsPanel.Visible == true)
            {
                SnacksDealsPanel.Visible = false;
                RegularDealsPanel.Visible = true;
            }
            else
            {
                RegularDealsPanel.Visible = true;
            }

            LoadFoodsToRegularFlowLayoutPanel();
        }

        private void snackDealsBtn_Click(object sender, EventArgs e)
        {
            if(RegularDealsPanel.Visible == true)
            {
                RegularDealsPanel.Visible = false;
                SnacksDealsPanel.Visible = true;
            }
            else
            {
                SnacksDealsPanel.Visible = true;
            }

            LoadFoodsToSnacksFlowLayoutPanel();
        }

        private void closeRegularDealsBtn_Click(object sender, EventArgs e)
        {
            RegularDealsPanel.Visible = false;
        }

        private void closeSnackDealsBtn_Click(object sender, EventArgs e)
        {
            SnacksDealsPanel.Visible = false;
        }

        private void userProfileBtn_Click_2(object sender, EventArgs e)
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
        private string imagePath;
        private string profilePic;
        private string day;
        private DateTime startTime;
        private DateTime endTime;

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
            loginForm.GetUsers(userName, _profilePic);
            loginForm.ShowDialog();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            RegisterForm registerForm = new RegisterForm();
            registerForm.GetUsers(userName, _profilePic);
            registerForm.ShowDialog();
        }
        
        private void LoadFoodsToSnacksFlowLayoutPanel()
        {
            if (snackFlowLayoutPanel == null)
            {
                MessageBox.Show("snackFlowLayoutPanel is not initialized.");
                return;
            }

            if (_snacksFoodsCollection == null || !_snacksFoodsCollection.Any())
            {
                MessageBox.Show("_snacksFoodsCollection is not initialized or empty.");
                return;
            }

            Panel[] snackPanels = { snack1panel, snack2panel, snack3panel, snack4panel, snack5panel };
            Panel[] snackPanelsContent = { snack1, snack2, snack3, snack4, snack5 };
            Guna2NumericUpDown[] numericNums = { snack1NumericUpDown, snack2NumericUpDown, snack3NumericUpDown, snack4NumericUpDown, snack5NumericUpDown };

            for (int i = 0; i < snackPanels.Length; i++)
            {
                if (snackPanels[i] == null)
                {
                    MessageBox.Show($"Parent panel {nameof(snackPanels)}[{i}] is not initialized.");
                    return;
                }

                if (snackPanelsContent[i] == null)
                {
                    MessageBox.Show($"Content panel {nameof(snackPanelsContent)}[{i}] is not initialized.");
                    return;
                }

                if (numericNums[i] == null)
                {
                    MessageBox.Show($"NumericUpDown {nameof(numericNums)}[{i}] is not initialized.");
                    return;
                }
            }

            for (int i = 0; i < _snacksFoodsCollection.Count; i++)
            {
                var food = _snacksFoodsCollection[i];
                if (food == null)
                {
                    MessageBox.Show($"Food item at index {i} is null.");
                    continue;
                }

                if (string.IsNullOrEmpty(food.SFoodImagePath))
                {
                    MessageBox.Show($"Food image path for item at index {i} is null or empty.");
                    continue;
                }

                PictureBox foodPictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Height = 119,
                    Width = 205,
                    ImageLocation = food.SFoodImagePath,
                    Cursor = Cursors.Hand
                };

                foodPictureBox.Tag = food;
                foodPictureBox.Click += RegularFoodPictureBox_Click;

                int panelIndex = i % snackPanelsContent.Length;

                snackPanelsContent[panelIndex].Controls.Add(foodPictureBox);

                numericNums[panelIndex].Tag = food;
            }

            foreach (var panel in snackPanels)
            {
                if (!snackFlowLayoutPanel.Controls.Contains(panel))
                {
                    snackFlowLayoutPanel.Controls.Add(panel);
                }
            }

            FadeIn(snackFlowLayoutPanel);
        }


        private void SnackFoodPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            var food = clickedPictureBox.Tag as SnackDeals;

            if (food != null)
            {
                MessageBox.Show("snacks foods");

                //closeFoodDetailsBtn.Visible = true;
                //foodDetailsPanel.Visible = true;

                //foodPicDetails.BackgroundImage = System.Drawing.Image.FromFile(food.SFoodImagePath);
                //foodNameDetails.Text = food.SFoodName;
                //foodPriceDetails.Text = food.SFoodPrice.ToString("C");
            }
        }

        private void snacksFlowLayoutPanel_Paint_1(object sender, PaintEventArgs e)
        {
            if (_snacksFoodsCollection == null || _snacksFoodsCollection.Count == 0)
            {
                LoadFoodsToSnacksFlowLayoutPanel();
            }
        }

        private void snackBuyFoodBtn_Click(object sender, EventArgs e)
        {
            Guna2NumericUpDown[] numericNums = { snack1NumericUpDown, snack2NumericUpDown, snack3NumericUpDown, snack4NumericUpDown, snack5NumericUpDown};

            var selectedFoods = new List<string>();

            foreach (var numericUpDown in numericNums)
            {
                if (numericUpDown != null && numericUpDown.Tag is SnackDeals food)
                {
                    int quantity = (int)numericUpDown.Value;

                    if (quantity > 0)
                    {
                        selectedFoods.Add($"{food.SFoodName} x {quantity}");
                    }
                }
            }

            if (selectedFoods.Any())
            {
                string message = "You selected the following items:\n" + string.Join("\n", selectedFoods);
                MessageBox.Show(message, "Selected Foods", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No items selected.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadFoodsToRegularFlowLayoutPanel()
        {
            if (regularDealsFlowLayoutPanel == null)
            {
                MessageBox.Show("regularDealsFlowLayoutPanel is not initialized.");
                return;
            }

            if (_foodsCollection == null || !_foodsCollection.Any())
            {
                MessageBox.Show("_foodsCollection is not initialized or empty.");
                return;
            }

            Panel[] regPanels = { reg1panel, reg2panel, reg3panel, reg4panel, reg5panel, reg6panel };
            Panel[] regPanelsContent = { reg1, reg2, reg3, reg4, reg5, reg6 };
            Guna2NumericUpDown[] numericNums = { reg1NumericUpDown, reg2NumericUpDown, reg3NumericUpDown, reg4NumericUpDown, reg5NumericUpDown, reg6NumericUpDown };

            for (int i = 0; i < regPanels.Length; i++)
            {
                if (regPanels[i] == null)
                {
                    MessageBox.Show($"Parent panel {nameof(regPanels)}[{i}] is not initialized.");
                    return;
                }

                if (regPanelsContent[i] == null)
                {
                    MessageBox.Show($"Content panel {nameof(regPanelsContent)}[{i}] is not initialized.");
                    return;
                }

                if (numericNums[i] == null)
                {
                    MessageBox.Show($"NumericUpDown {nameof(numericNums)}[{i}] is not initialized.");
                    return;
                }
            }

            for (int i = 0; i < _foodsCollection.Count; i++)
            {
                var food = _foodsCollection[i];
                if (food == null)
                {
                    MessageBox.Show($"Food item at index {i} is null.");
                    continue;
                }

                if (string.IsNullOrEmpty(food.FoodImagePath))
                {
                    MessageBox.Show($"Food image path for item at index {i} is null or empty.");
                    continue;
                }

                PictureBox foodPictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Height = 119,
                    Width = 205,
                    ImageLocation = food.FoodImagePath,
                    Cursor = Cursors.Hand
                };

                foodPictureBox.Tag = food;
                foodPictureBox.Click += RegularFoodPictureBox_Click;

                int panelIndex = i % regPanelsContent.Length;

                // Add the PictureBox to the panel
                regPanelsContent[panelIndex].Controls.Add(foodPictureBox);

                // Associate the NumericUpDown with the food item
                numericNums[panelIndex].Tag = food;
            }

            foreach (var panel in regPanels)
            {
                if (!regularDealsFlowLayoutPanel.Controls.Contains(panel))
                {
                    regularDealsFlowLayoutPanel.Controls.Add(panel);
                }
            }

            FadeIn(regularDealsFlowLayoutPanel);
        }


        private void regularDealsFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            if (_foodsCollection == null || _foodsCollection.Count == 0)
            {
                LoadFoodsToRegularFlowLayoutPanel();
            }
        }


        private void RegularFoodPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            var food = clickedPictureBox.Tag as RegularDeals;

            if (food != null)
            {

                MessageBox.Show("regular foods");
                //closeFoodDetailsBtn.Visible = true;
                //foodDetailsPanel.Visible = true;

                //foodPicDetails.BackgroundImage = System.Drawing.Image.FromFile(food.SFoodImagePath);
                //foodNameDetails.Text = food.SFoodName;
                //foodPriceDetails.Text = food.SFoodPrice.ToString("C");
            }
        }

        private void buyFoodsBtn_Click(object sender, EventArgs e)
        {
            Guna2NumericUpDown[] numericNums = { reg1NumericUpDown, reg2NumericUpDown, reg3NumericUpDown, reg4NumericUpDown, reg5NumericUpDown, reg6NumericUpDown };

            var selectedFoods = new List<string>();

            foreach (var numericUpDown in numericNums)
            {
                if (numericUpDown != null && numericUpDown.Tag is RegularDeals food)
                {
                    int quantity = (int)numericUpDown.Value;

                    if (quantity > 0)
                    {
                        selectedFoods.Add($"{food.FoodName} x {quantity}");
                    }
                }
            }

            if (selectedFoods.Any())
            {
                string message = "You selected the following items:\n" + string.Join("\n", selectedFoods);
                MessageBox.Show(message, "Selected Foods", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No items selected.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void exitApplicationBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}

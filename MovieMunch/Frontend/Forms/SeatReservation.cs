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
        private SettingsForm _settingsForm;
        private List<MovieInfo> _movies;
        private FoodServices _foodServices;
        private List<RegularDeals> _foodsCollection;
        private string id;
        private string title;
        private string description;
        private decimal price;
        private Image image;
        private string reservedBy;

        public SeatReservation(string Id, string movieTitle, string movieDescription, decimal moviePrice, string moviePic, string reservedBy)
        {

            MainPage mainPage = new MainPage();
            mainPage.Close();

            InitializeComponent();

            _movieId = Id;
            _movieName = movieTitle;
            _moviePrice = moviePrice;
            _reservedBy = reservedBy;
            _moviePic = moviePic;
            _movieDescription = movieDescription;


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
            mainPage.SetUserInfo(userName);



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

                await _userService.AddMoviesToWatchListOfUser(userName, movieTitle, movieDescription, moviePrice, moviePic);
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
            mainPage.SetUserInfo(userName);
            this.Visible = false;
        }

        private void gotoWatchListBtn_Click(object sender, EventArgs e)
        {
            if (userName == null || userNameHolder.Text == "")
            {
                var watchListForm = new WatchListForm(_movieId, "USERNAME", userName);
                watchListForm.Show();
            }
            else
            {
                var watchListForm = new WatchListForm(_movieId, userName, userName);
                watchListForm.Show();
            }
            this.Close();
        }

        int targetHeight;
        int defaultHeight;
        bool isExpanding;

        Timer userPanelTimer = new Timer();
        private User currentUser;
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Close();
        }

        private void gotoTicketFormBtn_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm(_movieId, userNameHolder.Text, userName);
            ticketForm.Show();
            this.Close();
        }

        private void regularDealsBtn_Click(object sender, EventArgs e)
        {
            RegularDealsPanel.Visible = true;
        }

        private void snackDealsBtn_Click(object sender, EventArgs e)
        {
            SnacksDealsPanel.Visible = true;
        }

        private void closeRegularDealsBtn_Click(object sender, EventArgs e)
        {
            RegularDealsPanel.Visible = false;
        }

        private void closeSnackDealsBtn_Click(object sender, EventArgs e)
        {
            SnacksDealsPanel.Visible = false;
        }
    }
}

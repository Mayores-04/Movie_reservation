﻿using Bunifu.UI.WinForms;
using MongoDB.Bson;
using MongoDB.Driver;
using MovieMunch.Admin;
using MovieMunch.Backend.Models;
using MovieMunch.Backend.Services;
using MovieMunch.Frontend.Forms;
using MovieMunch.Frontend.Forms.Components;
using MovieMunch.Models;
using MovieMunch.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Label = System.Windows.Forms.Label;

namespace MovieMunch
{
    public partial class MainPage : Form
    {
        private MovieService _movieService;
        private List<FilmsInCinema> _filmsInCinemas;
        private List<ComingSoon> _comingSoon;
        private SettingsForm _settingsForm;

        private FoodServices _foodServices; 
        private List<Foods> _foodsCollection;

        private int _currentImageIndex = 0;

        private readonly string coloredCirclePath = @"C:\Users\jakem\Source\Repos\Movie_reservation\MovieMunch\Frontend\Forms\Assets\ColoredCircle.png";
        private readonly string uncoloredCirclePath = @"C:\Users\jakem\Source\Repos\Movie_reservation\MovieMunch\Frontend\Forms\Assets\UncolloredCircle.png";

        private string[] _imagePaths;

        private System.Windows.Forms.Button _selectedButton = null;
        private List<MovieInfo> _movies; 
        private string userName;

        public MainPage()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            InitializeComponent();
            _movieService = new MovieService();
            _movies = _movieService.GetAllMovieInfos();
            _filmsInCinemas = _movieService.GetFilmsInCinemas();
            _comingSoon = _movieService.GetComingSoons();

            PopulateImagePaths();

            UpdateDisplayedImage();
            LoadFilmsInCinemaToFlowLayoutPanel();
            LoadComingSoonToFlowLayoutPanel();

            _foodServices = new FoodServices(); 
            _foodsCollection = _foodServices.GetFoodsInCollection();
            LoadFoodsToYummyFlowLayoutPanel();

            FadeIn(this);

            defaultHeight = userPanel.Height;
            userPanel.Height = 0;
            userPanel.Visible = false;

            userPanelTimer.Interval = 15;
            userPanelTimer.Tick += smothFromLeftToRightTransition_Click;
            userPanel.BringToFront();

            filmsDetailsPanel.BringToFront();
            comingSoonMovieDetailsPanel.BringToFront();
            trendingMoviesDetailsPanel.BringToFront();
            if(userName != "USERNAME")
            {
                userNameHolder.Text = "USERNAME";
            }
        }

        public void SetUserInfo(string name)
        {
            userName = name;
            userNameHolder.Text = userName;
        }

        private MovieInfo GetCurrentMovieInfo()
        {
            var seatReservationService = new MovieService();
            List<MovieInfo> movies = seatReservationService.GetAllMovieInfos();

            if (_currentImageIndex >= 0 && _currentImageIndex < movies.Count)
            {
                return movies[_currentImageIndex]; 
            }
            return null; 
        }


        private MovieInfo GetMovieInfoFromImagePath(string imagePath)
        {
            var seatReservationService = new MovieService();
            List<MovieInfo> movies = seatReservationService.GetAllMovieInfos();
            return movies.FirstOrDefault(m => m.ImagePath == imagePath);
        }

        public void ClearUserInfo()
        {
            userNameHolder.Text = "USERNAME";
            if(userNameHolder.Text == null)
            {
                userNameHolder.Text = "USERNAME";
            }
        }

        private void PopulateImagePaths()
        {
            _imagePaths = new string[_movies.Count];
            for (int i = 0; i < _movies.Count; i++)
            {
                _imagePaths[i] = _movies[i].ImagePath;
            }
        }

        private void closeTrendingMoviesDetails_Click_1(object sender, EventArgs e)
        {
            trendingMoviesDetailsPanel.Visible = false;
        }

        private void UpdateCircleColors()
        {
            SetCircleColor(firstCircle, uncoloredCirclePath);
            SetCircleColor(secondCircle, uncoloredCirclePath);
            SetCircleColor(thirdCircle, uncoloredCirclePath);
            SetCircleColor(fourthCircle, uncoloredCirclePath);

            switch (_currentImageIndex)
            {
                case 0:
                    SetCircleColor(firstCircle, coloredCirclePath);
                    break;
                case 1:
                    SetCircleColor(secondCircle, coloredCirclePath);
                    break;
                case 2:
                    SetCircleColor(thirdCircle, coloredCirclePath);
                    break;
                case 3:
                    SetCircleColor(fourthCircle, coloredCirclePath);
                    break;
            }
        }

        public void SetCircleColor(PictureBox pictureColor, string circleColorPath)
        {
            if (System.IO.File.Exists(circleColorPath))
            {
                if (pictureColor.Image != null)
                {
                    pictureColor.Image.Dispose();
                }

                pictureColor.Image = new Bitmap(circleColorPath);
                pictureColor.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Image not found at path: " + circleColorPath);
            }
        }

        private void SetImageInPictureBox(PictureBox pictureBox, string imagePath, float opacity = 1.0f)
        {
            if (!ValidateImagePath(imagePath)) return;

            if (pictureBox == pictureBoxMain)
            {
                MovieInfo imageInfo = GetMovieInfoFromImagePath(imagePath);
                if (imageInfo != null)
                {
                    pictureBoxMain.Click += MainImage_Click;  
                    pictureBoxMain.Tag = imageInfo;  
                }
            }

            LoadAndSetImage(pictureBox, imagePath, opacity);
        }

        private void UpdateDisplayedImage()
        {
            if (_imagePaths.Length == 0)
            {
                MessageBox.Show("No images found.");
                return;
            }

            int previousImageIndex = (_currentImageIndex - 1 + _imagePaths.Length) % _imagePaths.Length;
            int nextImageIndex = (_currentImageIndex + 1) % _imagePaths.Length;

            SetImageInPictureBox(pictureBoxLeft, _imagePaths[previousImageIndex], 0.5f);
            SetImageInPictureBox(pictureBoxMain, _imagePaths[_currentImageIndex], 1.0f);
            SetImageInPictureBox(pictureBoxRight, _imagePaths[nextImageIndex], 0.5f);

            pictureBoxLeft.Enabled = false;
            pictureBoxRight.Enabled = false;
            pictureBoxMain.Enabled = true;

            UpdateCircleColors();
        }

        private void MainImage_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            var movieInfo = clickedPictureBox?.Tag as MovieInfo;

            if (movieInfo != null)
            {
                closeTrendingMoviesDetails.Visible = true;
                trendingMoviesDetailsPanel.Visible = true;

                try
                {
                    trendingDetailsPictureBox.BackgroundImage = System.Drawing.Image.FromFile(movieInfo.ImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}");
                }

                trendingMovieTitleDetails.Text = movieInfo.Title;
                trendingDescriptionDetails.Text = movieInfo.Description;
                trendingMoviePriceDetails.Text = movieInfo.Price.ToString("C");

                trendingSelectedId = movieInfo.Id.ToString();
                movieID = trendingSelectedId;

                trendingSelectedTitle = movieInfo.Title;
                trendingSelectedDescription = movieInfo.Description;
                trendingSelectedPic = movieInfo.ImagePath;
                trendingSelectedPrice = Convert.ToDecimal(movieInfo.Price);
            }
            else
            {
                MessageBox.Show("Movie information is not available.");
            }
        }


        private bool ValidateImagePath(string imagePath)
        {
            if (!System.IO.File.Exists(imagePath))
            {
                MessageBox.Show("Image not found at path: " + imagePath);
                return false;
            }
            return true;
        }

        private void LoadAndSetImage(PictureBox pictureBox, string imagePath, float opacity)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
            }

            try
            {
                using (Bitmap image = new Bitmap(imagePath))
                {
                    System.Drawing.Image processedImage = ApplyOpacity(image, opacity);
                    pictureBox.Image = processedImage;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the image: " + ex.Message);
            }
        }

        private Bitmap ApplyOpacity(Bitmap image, float opacity)
        {
            Bitmap tempBitmap = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(tempBitmap))
            {
                ColorMatrix matrix = new ColorMatrix
                {
                    Matrix33 = opacity
                };

                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(matrix);
                    g.DrawImage(image, new Rectangle(0, 0, tempBitmap.Width, tempBitmap.Height),
                                0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            return tempBitmap;
        }

        private void rightTurnBtn_Click(object sender, EventArgs e)
        {
            _currentImageIndex = (_currentImageIndex + 1) % _imagePaths.Length;
            UpdateDisplayedImage();
        }

        private void LeftTurnBtn_Click_1(object sender, EventArgs e)
        {
            _currentImageIndex = (_currentImageIndex - 1 + _imagePaths.Length) % _imagePaths.Length;
            UpdateDisplayedImage();
        }
        private void SetButtonToDefault(System.Windows.Forms.Button button, string defaultImage)
        {
            if (System.IO.File.Exists(defaultImage))
            {
                button.BackgroundImage = new Bitmap(defaultImage);
                button.Image = default;
            }
            else
            {
                MessageBox.Show("Image not found: " + defaultImage);
            }
        }

        private void closeFilmsDetailsBtn_Click_1(object sender, EventArgs e)
        {
            filmsDetailsPanel.Visible = false;

        }
        private void LoadFilmsInCinemaToFlowLayoutPanel()
        {
            FilmsInCinemaFlowLayout.Controls.Clear();

            System.Windows.Forms.Panel[] films = { films1, films2, films3, films4, films5, films6, films7, films8 };

            foreach (var film in _filmsInCinemas)
            {

                PictureBox moviePictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Height = 250,
                    Width = 200,
                    ImageLocation = film.FilmImagePath,
                    Cursor = Cursors.Hand,
                    Tag = film
                };

                moviePictureBox.Click += new EventHandler(FilmsPictureBox_Click);

                int index = _filmsInCinemas.IndexOf(film) % films.Length;

                if (index < films.Length)
                {
                    films[index].Controls.Add(moviePictureBox);
                }
            }

            foreach (var panel in films)
            {
                FilmsInCinemaFlowLayout.Controls.Add(panel);
            }

            FadeIn(FilmsInCinemaFlowLayout);
        }


        private void FilmsPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            var films = clickedPictureBox.Tag as FilmsInCinema;

            if (films != null)
            {
                _selectedFilm = films;
                closeFilmsDetailsBtn.Visible = true;
                filmsDetailsPanel.Visible = true;

                filmsPictureBoxDetails.BackgroundImage = System.Drawing.Image.FromFile(films.FilmImagePath);
                filmsTitleDetails.Text = films.FilmTitle;
                filmsDescriptionDetails.Text = films.FilmsDescription;
                filmsPriceDetails.Text = films.FilmsPrice.ToString("C");

                FilmsSelectedId = films.Id.ToString();
                movieID = FilmsSelectedId;

                FilmsSelectedPic = films.FilmImagePath;
                FilmsSelectedTitle = films.FilmTitle;
                FilmsSelectedDescription = films.FilmsDescription;
                FilmsSelectedPrice = Convert.ToDecimal(films.FilmsPrice);
            }
        }

        private FilmsInCinema _selectedFilm;
        private void filmsInCinemaSeatReservationBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
             
            if (userNameHolder.Text == "USERNAME" || userNameHolder.Text == null)
            {

                filmsDetailsPanel.Visible = false;
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
                return;
            }
             
            if (_selectedFilm != null)
            { 
                decimal price = Convert.ToDecimal(_selectedFilm.FilmsPrice);
                string Id = _selectedFilm.Id.ToString();
                var seatReservationForm = new SeatReservation(
                    Id,
                    _selectedFilm.FilmTitle,
                    _selectedFilm.FilmsDescription,
                    price,   
                    _selectedFilm.FilmImagePath,
                    userName
                );

                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is SeatReservation)
                    {
                        openForm.Close();
                        break;
                    }
                }

                seatReservationForm.Show();

                this.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No movie selected to reserve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilmsInCinemaFlowLayout_Paint(object sender, PaintEventArgs e)
        {
            if (_filmsInCinemas == null || _filmsInCinemas.Count == 0)
            {
                LoadFilmsInCinemaToFlowLayoutPanel();
            }
        }

        private void closeComingSoonMovieDetailsBtn_Click_1(object sender, EventArgs e)
        {
            comingSoonMovieDetailsPanel.Visible = false;
        }

        private void LoadComingSoonToFlowLayoutPanel()
        {
            ComingSoonFlowLayoutPanel.Controls.Clear();

            System.Windows.Forms.Panel[] soons = { soon1, soon2, soon3, soon4, soon5, soon6, soon7, soon8 };

            foreach (var csoon in _comingSoon)
            {
                PictureBox moviePictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Height = 250,
                    Width = 200,
                    ImageLocation = csoon.ComingSoonImagePath,
                    Cursor = Cursors.Hand,
                    Tag = csoon 
                };

                moviePictureBox.Click += new EventHandler(ComingSoonPictureBox_Click);

                int index = _comingSoon.IndexOf(csoon) % soons.Length;

                if (index < soons.Length)
                {
                    soons[index].Controls.Add(moviePictureBox);
                }
            }

            foreach (var panel in soons)
            {
                ComingSoonFlowLayoutPanel.Controls.Add(panel);
            }

            FadeIn(ComingSoonFlowLayoutPanel);
        }



        private void ComingSoonPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            var csoon = clickedPictureBox.Tag as ComingSoon;

            if (csoon != null)
            {
                _selectedComingSoonMovie = csoon;
                closeComingSoonMovieDetailsBtn.Visible = true;
                comingSoonMovieDetailsPanel.Visible = true;

                comingSoonMoviePicBoxDetails.BackgroundImage = System.Drawing.Image.FromFile(csoon.ComingSoonImagePath);
                comingSoonTitleDetails.Text = csoon.ComingSoonTitle;
                comingSoonMovieDescriptionDetails.Text = csoon.ComingSoonDescription;
                comingSoonPriceDetails.Text = csoon.ComingSoonPrice.ToString("C");

                CsoonSelectedId = csoon.Id.ToString();
                movieID = CsoonSelectedId;

                CsoonSelectedTitle = csoon.ComingSoonTitle;
                CsoonSelectedDescription = csoon.ComingSoonDescription;
                CsoonSelectedPrice = Convert.ToDecimal(csoon.ComingSoonPrice);
                CsoonSelectedPic = csoon.ComingSoonImagePath;
            }
        }

        private ComingSoon _selectedComingSoonMovie;
        private void comingSoonMovieSeatReservationBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            if (userNameHolder.Text == "USERNAME" || userNameHolder.Text == null)
            {
                comingSoonMovieDetailsPanel.Visible = false;
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
                return;
            }

            if (_selectedComingSoonMovie != null)
            {
                decimal price = Convert.ToDecimal(_selectedComingSoonMovie.ComingSoonPrice);
                string Id = _selectedComingSoonMovie.Id.ToString();

                var seatReservationForm = new SeatReservation(
                    Id,
                    _selectedComingSoonMovie.ComingSoonTitle,
                    _selectedComingSoonMovie.ComingSoonDescription,
                    price,
                    _selectedComingSoonMovie.ComingSoonImagePath,
                    userName
                );

                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is SeatReservation)
                    {
                        openForm.Close();
                        break;
                    }
                }

                seatReservationForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No movie selected to reserve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComingSoonFlowLayout_Paint(object sender, PaintEventArgs e)
        {
            if (_comingSoon == null || _comingSoon.Count == 0)
            {
                LoadComingSoonToFlowLayoutPanel();
            }
        }

        private void closeFoodDetailsBtn_Click(object sender, EventArgs e)
        {
            foodDetailsPanel.Visible = false;
        }

        private void LoadFoodsToYummyFlowLayoutPanel()
        {
            yummyFlowLayoutPanel.Controls.Clear();

            System.Windows.Forms.Panel[] yummPanels = { yummy1, yummy2, yummy3 };

            foreach (var food in _foodsCollection)
            {
                if (food == null)
                {
                    MessageBox.Show("Null");
                    continue;
                }

                PictureBox foodPictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Height = 323,
                    Width = 560,
                    ImageLocation = food.FoodImagePath,
                    Cursor = Cursors.Hand
                };

                foodPictureBox.Tag = food;
                foodPictureBox.Click += new EventHandler(FoodPictureBox_Click);

                int index = _foodsCollection.IndexOf(food) % yummPanels.Length;

                if (index < yummPanels.Length)
                {
                    yummPanels[index].Controls.Add(foodPictureBox);
                }
            }

            foreach (var panel in yummPanels)
            {
                if (panel != null)
                {
                    yummyFlowLayoutPanel.Controls.Add(panel);
                }
            }

            FadeIn(yummyFlowLayoutPanel);
        }

        private void FoodPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            var food = clickedPictureBox.Tag as Foods;

            if (food != null)
            {
                closeFoodDetailsBtn.Visible = true;
                foodDetailsPanel.Visible = true;

                foodPicDetails.BackgroundImage = System.Drawing.Image.FromFile(food.FoodImagePath);
                foodNameDetails.Text = food.FoodName;
                foodPriceDetails.Text = food.FoodPrice.ToString("C");
            }
        }

        private void yummyFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            if (_foodsCollection == null || _foodsCollection.Count == 0)
            {
                LoadFoodsToYummyFlowLayoutPanel();
            }
        }

        private bool isDragging = false;
        private Point lastMousePosition;

        private void FilmsInCinemaFlowLayout_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void FilmsInCinemaFlowLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = lastMousePosition.X - e.Location.X;
                FilmsInCinemaFlowLayout.HorizontalScroll.Value = Math.Max(0, Math.Min(FilmsInCinemaFlowLayout.HorizontalScroll.Maximum, FilmsInCinemaFlowLayout.HorizontalScroll.Value + deltaX));
                lastMousePosition = e.Location;
            }
        }

        private void FilmsInCinemaFlowLayout_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void ComingSoonFlowLayout_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void ComingSoonFlowLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = lastMousePosition.X - e.Location.X;
                ComingSoonFlowLayoutPanel.HorizontalScroll.Value = Math.Max(0, Math.Min(ComingSoonFlowLayoutPanel.HorizontalScroll.Maximum, ComingSoonFlowLayoutPanel.HorizontalScroll.Value + deltaX));
                lastMousePosition = e.Location;
            }
        }

        private void ComingSoonFlowLayout_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void yummyFlowLayoutPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void yummyFlowLayoutPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = lastMousePosition.X - e.Location.X;
                yummyFlowLayoutPanel.HorizontalScroll.Value = Math.Max(0, Math.Min(yummyFlowLayoutPanel.HorizontalScroll.Maximum, yummyFlowLayoutPanel.HorizontalScroll.Value + deltaX));
                lastMousePosition = e.Location;
            }
        }

        private void yummyFlowLayoutPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
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

        private void FadeOut(Control control)
        {
            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Tick += (s, e) =>
            {
                var color = control.BackColor;
                int alpha = (int)(color.A * 0.95); 
                if (alpha > 0)
                {
                    control.BackColor = Color.FromArgb(alpha, color.R, color.G, color.B);
                }
                else
                {
                    control.Visible = false; 
                    timer.Stop();  
                    timer.Dispose();
                }
            };
            timer.Start();
        }

        private MovieInfo _reservedImageInfo;

        private void reserveSeatBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            if (userNameHolder.Text == "USERNAME" || userNameHolder.Text == null)
            {
                trendingMoviesDetailsPanel.Visible = false;
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
                return;
            }
            else
            {
                string _reservedBy = userName;
                var currentMovieInfo = GetCurrentMovieInfo();

                if (currentMovieInfo != null)
                {
                    var seatReservationForm = new SeatReservation(
                        currentMovieInfo.Id,  
                        currentMovieInfo.Title,
                        currentMovieInfo.Description,
                        currentMovieInfo.Price,
                        currentMovieInfo.ImagePath,
                        _reservedBy
                    );
                    seatReservationForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No movie selected to reserve.");
                }
            }
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
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            var userService = new UserService();
            userService.Logout();
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            exisSearchBtn.Visible = true;

            searchBtnBefore.Visible = false;
            searchInput.Visible = true;
            searchResultFlowWholePanel.Visible = false;
            searchResultsFlowLayoutPanel.Visible = false;
            
            LeftTurnBtn.BringToFront();
            rightTurnBtn.BringToFront();
        }

        private void exisSearchBtn_Click(object sender, EventArgs e)
        {
            searchBtnBefore.Visible = true;
            searchInput.Visible = false;
            searchResultFlowWholePanel.Visible = false;
            searchResultsFlowLayoutPanel.Visible = false;
            exisSearchBtn.Visible = false;

            LeftTurnBtn.BringToFront();
            rightTurnBtn.BringToFront();
        }

        private void searchInput_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = searchInput.Text.ToLower();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                searchResultFlowWholePanel.Visible = false;
                searchResultsFlowLayoutPanel.Visible = false;
            }
            else
            {
                searchResultFlowWholePanel.Visible = true;
                searchResultsFlowLayoutPanel.Visible = true;

                searchResultsFlowLayoutPanel.Controls.Clear();

                List<string> trendingMovies = _movieService.GetAllMovies().Select(movie => movie.MovieTitle).ToList();
                List<string> filmsInCinema = _movieService.GetFilmsInCinemas().Select(movie => movie.FilmTitle).ToList();
                List<string> comingSoon = _movieService.GetComingSoons().Select(movie => movie.ComingSoonTitle).ToList();
                List<string> snacks = _foodServices.GetFoodsInCollection().Select(snack => snack.FoodName).ToList();

                List<string> filteredTrendingMovies = trendingMovies.Where(title => title.ToLower().Contains(searchText)).ToList();
                List<string> filteredFilmsInCinema = filmsInCinema.Where(title => title.ToLower().Contains(searchText)).ToList();
                List<string> filteredComingSoon = comingSoon.Where(title => title.ToLower().Contains(searchText)).ToList();
                List<string> filteredSnacks = snacks.Where(name => name.ToLower().Contains(searchText)).ToList();

                DisplaySearchResults(filteredTrendingMovies, "Trending Movies");
                DisplaySearchResults(filteredFilmsInCinema, "Films in Cinema");
                DisplaySearchResults(filteredComingSoon, "Coming Soon");
                DisplaySearchResults(filteredSnacks, "Snacks");
            }
        }

        private void DisplaySearchResults(List<string> items, string category)
        {
            if (items.Count > 0)
            {
                Label categoryLabel = new Label
                {
                    Text = category,
                    Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                    AutoSize = true,
                    Margin = new Padding(0, 10, 0, 5)
                };
                searchResultsFlowLayoutPanel.Controls.Add(categoryLabel);

                foreach (string item in items)
                {
                    Label itemLabel = new Label();
                    itemLabel.Text = $"• {item}"; 
                    itemLabel.Font = new Font("Segoe UI", 12F);
                    itemLabel.AutoSize = true;
                    itemLabel.Margin = new Padding(20, 0, 0, 5);  
                    searchResultsFlowLayoutPanel.Controls.Add(itemLabel);
                }
            }
        }

        private void snackDealsReservedSeatBtn_Click(object sender, EventArgs e)
        {

        }

        private string FilmsSelectedId;
        private string FilmsSelectedTitle;
        private string FilmsSelectedDescription;
        private string FilmsSelectedPic;
        private decimal FilmsSelectedPrice;

        private async void btnFilmAddToWatchLater_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(FilmsSelectedTitle) ||
                    string.IsNullOrEmpty(FilmsSelectedDescription) ||
                    string.IsNullOrEmpty(FilmsSelectedPic))
                {
                    MessageBox.Show("Please select a valid movie before adding to the watchlist.");
                    return;
                }

                if (string.IsNullOrEmpty(userName) || userNameHolder.Text == "USERNAME")
                {
                    MessageBox.Show("No logged-in user found. Please log in.");
                    return;
                }

                string movieTitle = FilmsSelectedTitle;
                string movieDescription = FilmsSelectedDescription;
                decimal moviePrice = Convert.ToDecimal(FilmsSelectedPrice);
                string moviePic = FilmsSelectedPic;

                await _userService.AddMoviesToWatchListOfUser(userName, movieTitle, movieDescription, moviePrice, moviePic);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding movie to the watchlist: {ex.Message}");
            }
        }

        private string CsoonSelectedId;
        private string CsoonSelectedTitle;
        private string CsoonSelectedDescription;
        private string CsoonSelectedPic;
        private decimal CsoonSelectedPrice;

        private async void addComingSoonToWatchLater_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CsoonSelectedTitle) ||
                    string.IsNullOrEmpty(CsoonSelectedDescription) ||
                    string.IsNullOrEmpty(CsoonSelectedPic))
                {
                    MessageBox.Show("Please select a valid movie before adding to the watchlist.");
                    return;
                }

                if (string.IsNullOrEmpty(userName) || userNameHolder.Text == "USERNAME")
                {
                    return;
                }

                string movieTitle = CsoonSelectedTitle;
                string movieDescription = CsoonSelectedDescription;
                decimal moviePrice = Convert.ToDecimal(CsoonSelectedPrice);
                string moviePic = CsoonSelectedPic;

                await _userService.AddMoviesToWatchListOfUser(userName, movieTitle, movieDescription, moviePrice, moviePic);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding movie to the watchlist: {ex.Message}");
            }
        }

        private string movieID;
        private void gotoWatchListBtn_Click(object sender, EventArgs e)
        {
            if (userName == null || userNameHolder.Text == "")
            {
                var watchListForm = new WatchListForm(movieID, "USERNAME", userName);
                watchListForm.Show();
            }
            else
            {
                var watchListForm = new WatchListForm(movieID, userName, userName);
                watchListForm.Show();
            }
            this.Close();
        }

        private readonly UserService _userService = new UserService();


        private string trendingSelectedId;
        private string trendingSelectedTitle;
        private string trendingSelectedDescription;
        private string trendingSelectedPic;
        private decimal trendingSelectedPrice;
        private readonly IMongoCollection<User> _usersCollection;

        public void SetLoggedInUserEmail(string name)
        {
            if (string.IsNullOrEmpty(name) || userNameHolder.Text == "USERNAME")
            {
                return;
            }
            else
            {
                userName = name;
            }
        }

        private async void addTrendingToWatchLaterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(trendingSelectedTitle) ||
                    string.IsNullOrEmpty(trendingSelectedDescription) ||
                    string.IsNullOrEmpty(trendingSelectedPic))
                {
                    MessageBox.Show("Please select a valid movie before adding to the watchlist.");
                    return;
                }

                if (string.IsNullOrEmpty(userName) || userName == "USERNAME")
                {
                    return;
                }
                string movieTitle = trendingSelectedTitle;
                string movieDescription = trendingSelectedDescription;
                decimal moviePrice = trendingSelectedPrice;   
                string moviePic = trendingSelectedPic;

                await _userService.AddMoviesToWatchListOfUser(userName, movieTitle, movieDescription, moviePrice, moviePic);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding movie to the watchlist: {ex.Message}");
            }
        }

        private void gotoTicketFormBtn_Click(object sender, EventArgs e)
        {
            if (userName == null || userNameHolder.Text == "")
            {
                var ticketForm = new TicketForm(movieID, "USERNAME", userName);
                ticketForm.Show();
            }
            else
            {
                var ticketForm = new TicketForm(movieID, userName, userName);
                ticketForm.Show();
            }
            this.Close();
        }
    }
}

using Bunifu.UI.WinForms;
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
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

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

        private readonly string BtnBG = @"C:\Users\jakem\Source\Repos\Movie_reservation\MovieMunch\Frontend\Forms\Assets\Ellipse 7.png";
        private readonly string HomeImage = @"C:\Users\jakem\Source\Repos\Movie_reservation\MovieMunch\Frontend\Forms\Assets\homeIcon.png";
        private readonly string HomeDefaultImage = @"C:\Users\jakem\Source\Repos\Movie_reservation\MovieMunch\Frontend\Forms\Assets\home down 1.png";
        private readonly string TicketImage = @"C:\Users\jakem\Source\Repos\Movie_reservation\MovieMunch\Frontend\Forms\Assets\ticketup 1.png";
        private readonly string TicketDefaultImage = @"C:\Users\jakem\Source\Repos\Movie_reservation\MovieMunch\Frontend\Forms\Assets\TicketIcon.png";
        private readonly string FavImage = @"C:\Users\jakem\source\repos\Movie_reservation\MovieMunch\Frontend\Forms\Assets\heartup 1.png";
        private readonly string FavDefaultImage = @"C:\Users\jakem\Source\Repos\Movie_reservation\MovieMunch\Frontend\Forms\Assets\FavIcon.png";
        private readonly string SettingImage = @"C:\Users\jakem\source\repos\Movie_reservation\MovieMunch\Frontend\Forms\Assets\settingup.png";
        private readonly string SettingDefaultImage = @"C:\Users\jakem\source\repos\Movie_reservation\MovieMunch\Frontend\Forms\Assets\SettingIcon.png";

        private Button _selectedButton = null;
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
        }

        public void SetUserInfo(string name)
        {
            userNameHolder.Text = name.ToUpper();
        }

        //public void userNameHolderShow(string name)
        //{
        //    userName = name;
        //    char firstLetter = name[0];
        //    userNameHolder.Text = firstLetter.ToString().ToUpper();
        //}
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
            userNameHolder.Text = "MM";
        }

        private void CloseCurrentForm()
        {
            FadeOut(this);
            this.Close();
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
            var movieInfo = clickedPictureBox.Tag as MovieInfo;

            if (movieInfo != null)
            {
                closeTrendingMoviesDetails.Visible = true;
                trendingMoviesDetailsPanel.Visible = true;

                trendingDetailsPictureBox.BackgroundImage = Image.FromFile(movieInfo.ImagePath);
                trendingMovieTitleDetails.Text = movieInfo.Title;
                trendingDescriptionDetails.Text = movieInfo.Description;
                trendingMoviePriceDetails.Text = movieInfo.Price.ToString("C");
            }
            else
            {
                MessageBox.Show("movieInfo is null");
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
                    Image processedImage = ApplyOpacity(image, opacity);
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

        //private void ResetAllButtonsToDefault()
        //{
        //    SetButtonToDefault(SettingBtn, SettingDefaultImage);
        //    SetButtonToDefault(HomeBtn, HomeDefaultImage);
        //    SetButtonToDefault(FavBtn, FavDefaultImage);
        //    SetButtonToDefault(TicketBtn, TicketDefaultImage);
        //}

        private void SetButtonToDefault(Button button, string defaultImage)
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

        //private void SetButtonBackground(Button selectedButton, string selectedButtonImage)
        //{
        //    ResetAllButtonsToDefault();

        //    if (System.IO.File.Exists(BtnBG))
        //    {
        //        selectedButton.BackgroundImage = new Bitmap(BtnBG);
        //        selectedButton.Image = new Bitmap(selectedButtonImage);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Image not found: " + BtnBG);
        //    }
        //}

        //private void HomeBtn_Click(object sender, EventArgs e)
        //{
        //    ResetAllButtonsToDefault();
        //    SetButtonBackground(HomeBtn, HomeImage);
        //    //watchListWholePanel.Visible = false;
        //}

        //private void FavBtn_Click(object sender, EventArgs e)
        //{
        //    ResetAllButtonsToDefault();
        //    SetButtonBackground(FavBtn, FavImage);
        //    //watchListWholePanel.Visible = true;
        //    //this.Visible = false;
        //    //WatchListForm watchListForm = new WatchListForm();
        //    //watchListForm.ShowDialog();
        //}

        //private void TicketBtn_Click(object sender, EventArgs e)
        //{
        //    ResetAllButtonsToDefault();
        //    SetButtonBackground(TicketBtn, TicketImage);
        //}

        private void closeFilmsDetailsBtn_Click_1(object sender, EventArgs e)
        {
            filmsDetailsPanel.Visible = false;

        }
        private void LoadFilmsInCinemaToFlowLayoutPanel()
        {
            FilmsInCinemaFlowLayout.Controls.Clear();

            Panel[] films = { films1, films2, films3, films4, films5, films6, films7, films8 };

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

                filmsPictureBoxDetails.BackgroundImage = Image.FromFile(films.FilmImagePath);
                filmsTitleDetails.Text = films.FilmTitle;
                filmsDescriptionDetails.Text = films.FilmsDescription;
                filmsPriceDetails.Text = films.FilmsPrice.ToString("C");
            }
        }

        private FilmsInCinema _selectedFilm;

        private void filmsInCinemaSeatReservationBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
             
            if (userNameHolder.Text == "USERNAME")
            {

                filmsDetailsPanel.Visible = false;
                this.Close();
                MessageBox.Show("You must log in to reserve a seat.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                return;
            }
             
            if (_selectedFilm != null)
            { 
                decimal price = Convert.ToDecimal(_selectedFilm.FilmsPrice);

                var seatReservationForm = new SeatReservation(
                    _selectedFilm.FilmTitle,     
                    price,   
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

                this.Close();
                seatReservationForm.ShowDialog();
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

            Panel[] soons = { soon1, soon2, soon3, soon4, soon5, soon6, soon7, soon8 };

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

                comingSoonMoviePicBoxDetails.BackgroundImage = Image.FromFile(csoon.ComingSoonImagePath);
                comingSoonTitleDetails.Text = csoon.ComingSoonTitle;
                comingSoonMovieDescriptionDetails.Text = csoon.ComingSoonDescription;
                comingSoonPriceDetails.Text = csoon.ComingSoonPrice.ToString("C");
            }
        }

        private ComingSoon _selectedComingSoonMovie;
        private void comingSoonMovieSeatReservationBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            if (userNameHolder.Text == "USERNAME")
            {

                this.Close();
                comingSoonMovieDetailsPanel.Visible = false;
                MessageBox.Show("You must log in to reserve a seat.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                return;
            }

            if (_selectedComingSoonMovie != null)
            {
                decimal price = Convert.ToDecimal(_selectedComingSoonMovie.ComingSoonPrice);

                var seatReservationForm = new SeatReservation(
                    _selectedComingSoonMovie.ComingSoonTitle,
                    price,
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
                this.Close();
                seatReservationForm.ShowDialog();
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

            Panel[] yummPanels = { yummy1, yummy2, yummy3 };

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

                foodPicDetails.BackgroundImage = Image.FromFile(food.FoodImagePath);
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

            if (userNameHolder.Text == "USERNAME")
            {
                trendingMoviesDetailsPanel.Visible = false;
                this.Close();
                MessageBox.Show("You must log in to reserve a seat.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                return;
            }
            else
            {
                string _reservedBy = userName;
                var currentMovieInfo = GetCurrentMovieInfo();

                if (currentMovieInfo != null)
                {
                    var seatReservationForm = new SeatReservation(
                        currentMovieInfo.Title,
                        currentMovieInfo.Price,
                        _reservedBy
                    );
                    this.Visible = false;
                    seatReservationForm.Show();
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
                Label categoryLabel = new Label();
                categoryLabel.Text = category;
                categoryLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
                categoryLabel.AutoSize = true;
                categoryLabel.Margin = new Padding(0, 10, 0, 5);  
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

    }
}

using Bunifu.UI.WinForms;
using MongoDB.Driver;
using MovieMunch.Admin;
using MovieMunch.Backend.Models;
using MovieMunch.Backend.Services;
using MovieMunch.Frontend.Forms;
using MovieMunch.Models;
using MovieMunch.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MovieMunch
{
    public partial class MainPage : Form
    {

        private MovieService _movieService;
        private List<FilmsInCinema> _filmsInCinemas;
        private List<ComingSoon> _comingSoon;
        private SettingsForm _settingsForm;

        private FoodServices _foodServices; // Declare this at the class level
        private List<Foods> _foodsCollection; // Use List<Foods> instead of a generic collection


        private int _currentImageIndex = 0;

        // Circle image paths
        private readonly string coloredCirclePath = @"C:\Users\jakem\Source\Repos\Movie_reservation\MovieMunch\Frontend\Forms\Assets\ColoredCircle.png";
        private readonly string uncoloredCirclePath = @"C:\Users\jakem\Source\Repos\Movie_reservation\MovieMunch\Frontend\Forms\Assets\UncolloredCircle.png";

        // Array that stores image paths
        private string[] _imagePaths;

        // Button images 
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

            InitializeComponent();
            this.DoubleBuffered = true;
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

            defaultWidth = userPanel.Width;
            userPanel.Width = 0;
            userPanel.Visible = false;

            userPanelTimer.Interval = 10;
            userPanelTimer.Tick += smothFromLeftToRightTransition_Click;


        }
        public void SetUserInfo(string name)
        {
            userName = name;
            char firstLetter = name[0];
            userNameHolder.Text = firstLetter.ToString().ToUpper();
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
            userNameHolder.Text = string.Empty;
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

            UpdateCircleColors();
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
            if (File.Exists(circleColorPath))
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
                    imageToReserve(imageInfo); 
                }
            }

            LoadAndSetImage(pictureBox, imagePath, opacity);
        }

        private bool ValidateImagePath(string imagePath)
        {
            if (!File.Exists(imagePath))
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

        private void leftTurnBtn_Click(object sender, EventArgs e)
        {
            _currentImageIndex = (_currentImageIndex - 1 + _imagePaths.Length) % _imagePaths.Length;
            UpdateDisplayedImage();
        }

        private void ResetAllButtonsToDefault()
        {
            SetButtonToDefault(SettingBtn, SettingDefaultImage);
            SetButtonToDefault(HomeBtn, HomeDefaultImage);
            SetButtonToDefault(FavBtn, FavDefaultImage);
            SetButtonToDefault(TicketBtn, TicketDefaultImage);
        }

        private void SetButtonToDefault(Button button, string defaultImage)
        {
            if (File.Exists(defaultImage))
            {
                button.BackgroundImage = new Bitmap(defaultImage);
                button.Image = default;
            }
            else
            {
                MessageBox.Show("Image not found: " + defaultImage);
            }
        }

        private void SetButtonBackground(Button selectedButton, string selectedButtonImage)
        {
            ResetAllButtonsToDefault();

            if (File.Exists(BtnBG))
            {
                selectedButton.BackgroundImage = new Bitmap(BtnBG);
                selectedButton.Image = new Bitmap(selectedButtonImage);
            }
            else
            {
                MessageBox.Show("Image not found: " + BtnBG);
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ResetAllButtonsToDefault();
            SetButtonBackground(HomeBtn, HomeImage);
        }

        private void FavBtn_Click(object sender, EventArgs e)
        {
            ResetAllButtonsToDefault();
            SetButtonBackground(FavBtn, FavImage);
        }

        private void TicketBtn_Click(object sender, EventArgs e)
        {
            ResetAllButtonsToDefault();
            SetButtonBackground(TicketBtn, TicketImage);
        }


        private void LoadFilmsInCinemaToFlowLayoutPanel()
        {
            FilmsInCinemaFlowLayout.Controls.Clear();

            Panel[] films = { films1, films2, films3, films4, films5, films6, films7, films8 };

            foreach (var movie in _filmsInCinemas)
            {
                PictureBox moviePictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Height = 202,
                    Width = 152,
                    ImageLocation = movie.FilmImagePath,
                    
                    Cursor = Cursors.Hand
                };

                int index = _filmsInCinemas.IndexOf(movie) % films.Length;

                films[index].Controls.Add(moviePictureBox);
            }

            foreach (var panel in films)
            {
                FilmsInCinemaFlowLayout.Controls.Add(panel);
            }

            FadeIn(FilmsInCinemaFlowLayout);
        }

   
        private void FilmsInCinemaFlowLayout_Paint(object sender, PaintEventArgs e)
        {
            if (_filmsInCinemas == null || _filmsInCinemas.Count == 0)
            {
                LoadFilmsInCinemaToFlowLayoutPanel();
            }
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
                    Height = 202,
                    Width = 151,
                    ImageLocation = csoon.ComingSoonImagePath,
                    Cursor = Cursors.Hand
                };

                int index = _comingSoon.IndexOf(csoon) % soons.Length;

                soons[index].Controls.Add(moviePictureBox);
            }

            foreach (var panel in soons)
            {
                ComingSoonFlowLayoutPanel.Controls.Add(panel);
            }

            FadeIn(ComingSoonFlowLayoutPanel);
        }

        private void ComingSoonFlowLayout_Paint(object sender, PaintEventArgs e)
        {
            if (_comingSoon == null || _comingSoon.Count == 0)
            {
                LoadComingSoonToFlowLayoutPanel();
            }
        }

        //private void LoadFoodsToFlowLayoutPanel()
        //{
        //    foodFlowLayoutPanel.Controls.Clear();
        //    Panel[] foods = { food1, food2, food3 };

        //    foreach (var food in _foodsCollection)
        //    {
        //        if (food == null)
        //        {
        //            Console.WriteLine("Food item is null!");
        //            continue; // Skip null food items
        //        }

        //        PictureBox moviePictureBox = new PictureBox
        //        {
        //            SizeMode = PictureBoxSizeMode.StretchImage,
        //            Height = 250,
        //            Width = 484,
        //            ImageLocation = food.FoodImagePath,
        //            Cursor = Cursors.Hand
        //        };

        //        int index = _foodsCollection.IndexOf(food) % foods.Length;

        //        if (index < foods.Length)
        //        {
        //            foods[index].Controls.Add(moviePictureBox);
        //        }
        //    }

        //    foreach (var panel in foods)
        //    {
        //        if (panel != null)
        //        {
        //            foodFlowLayoutPanel.Controls.Add(panel);
        //        }
        //    }

        //    FadeIn(foodFlowLayoutPanel);
        //}


        //private void foodFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        //{
        //    if (_foodsCollection == null || _foodsCollection.Count == 0)
        //    {
        //        LoadFoodsToFlowLayoutPanel();
        //    }
        //}


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
                    Height = 245,
                    Width = 480,
                    ImageLocation = food.FoodImagePath, 
                    Cursor = Cursors.Hand
                };

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
                    alpha += 5; // Increase alpha (adjust as necessary)
                    if (alpha > 255) alpha = 255; // Clamp to 255
                }
                else
                {
                    timer.Stop(); // Stop the timer when fully visible
                    timer.Dispose();
                }
            };
            timer.Start();
        }


        private void FadeOut(Control control)
        {
            Timer timer = new Timer();
            timer.Interval = 50; // Adjust as necessary
            timer.Tick += (s, e) =>
            {
                // Create a color with reduced alpha
                var color = control.BackColor;
                int alpha = (int)(color.A * 0.95); // Decrease alpha
                if (alpha > 0)
                {
                    control.BackColor = Color.FromArgb(alpha, color.R, color.G, color.B);
                }
                else
                {
                    control.Visible = false; // Hide the control when fully transparent
                    timer.Stop(); // Stop the timer
                    timer.Dispose();
                }
            };
            timer.Start();
        }

        private MovieInfo _reservedImageInfo;

        public void imageToReserve(MovieInfo movieInfo)
        {
            _reservedImageInfo = movieInfo;
        }

        private void reserveSeatBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            if (userNameHolder.Text == "MM")
            {
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

                    seatReservationForm.Show();
                }
                else
                {
                    MessageBox.Show("No movie selected to reserve.");
                }
            }
        }

        int targetWidth;
        int defaultWidth;
        bool isExpanding;

        Timer userPanelTimer = new Timer();


        private void SettingBtn_Click(object sender, EventArgs e)
        {


            userPanelTimer.Start();
            ResetAllButtonsToDefault();
            SetButtonBackground(SettingBtn, SettingImage);

            if (userPanel.Width == 0) 
            {
                targetWidth = defaultWidth; 
                isExpanding = true;
                userPanel.Visible = true; 
            }
            else 
            {
                targetWidth = 0; 
                isExpanding = false;
            }

            userPanelTimer.Start(); 
        }


        private void smothFromLeftToRightTransition_Click(object sender, EventArgs e)
        {
            if (isExpanding)
            {
                if (userPanel.Width < targetWidth)
                {
                    userPanel.Width += 10;
                    if (userPanel.Width >= targetWidth)
                    {
                        userPanel.Width = targetWidth; 
                        userPanelTimer.Stop();       
                    }
                }
            }
            else 
            {
                if (userPanel.Width > targetWidth)
                {
                    userPanel.Width -= 10;
                    if (userPanel.Width <= targetWidth)
                    {
                        userPanel.Width = targetWidth; 
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
            
            var userService = new UserService();
            userService.Logout();
        }
    }
}

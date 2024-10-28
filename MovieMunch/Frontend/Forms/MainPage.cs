using Bunifu.UI.WinForms;
using MongoDB.Driver;
using MovieMunch.Admin;
using MovieMunch.Backend.Models;
using MovieMunch.Frontend.Forms;
using MovieMunch.Models;
using MovieMunch.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieMunch
{
    public partial class MainPage : Form
    {

        private MovieService _movieService;
        private List<Movie> _movies;
        private List<FilmsInCinema> _filmsInCinemas;
        private SettingsForm _settingsForm;

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

        public MainPage()
        {

            InitializeComponent();
            this.DoubleBuffered = true;
            _movieService = new MovieService();
            _movies = _movieService.GetAllMovies();

            _filmsInCinemas = _movieService.GetFilmsInCinemas();

            PopulateImagePaths();

            UpdateDisplayedImage();
            LoadMoviesToFlowLayoutPanel();

            FadeIn(this);

            defaultWidth = userPanel.Width;
            userPanel.Width = 0;
            userPanel.Visible = false;

            userPanelTimer.Interval = 10;
            userPanelTimer.Tick += smothFromLeftToRightTransition_Click;


        }
        public void SetUserInfo(string name)
        {
            char firstLetter = name[0];
            userNameHolder.Text = firstLetter.ToString().ToUpper();
            //userNameHolder.Email = email;
        }

        public void ClearUserInfo()
        {
            userNameHolder.Text = string.Empty;
            //userNameHolder.Email = string.Empty;
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
                _imagePaths[i] = _movies[i].MovieImagePath;
            }
        }


        private void UpdateDisplayedImage()
        {
            if (_imagePaths.Length == 0)
            {
                MessageBox.Show("No images found.");
                return;
            }

            // Load images into picture boxes
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
            if (File.Exists(imagePath))
            {
                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Dispose();
                }

                Bitmap image = new Bitmap(imagePath);
                pictureBox.Image = ApplyOpacity(image, opacity);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Image not found at path: " + imagePath);
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
                button.Image = null;
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


        private void LoadMoviesToFlowLayoutPanel()
        {
            FilmsInCinemaFlowLayout.Controls.Clear();

            Panel[] films = { films1, films2, films3, films4, films5, films6, films7, films8 };

            foreach (var movie in _filmsInCinemas)
            {
                PictureBox moviePictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(200, 250),
                    Margin = new Padding(10),
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
                LoadMoviesToFlowLayoutPanel();
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

            // Set the initial color to fully transparent
            //control.BackColor = Color.FromArgb(0, control.BackColor.R, control.BackColor.G, control.BackColor.B);

            Timer timer = new Timer();
            timer.Interval = 50; // Adjust as necessary
            timer.Tick += (s, e) =>
            {
                // Get the current alpha value
                int alpha = control.BackColor.A;

                // Increase alpha value
                if (alpha < 255)
                {
                    alpha += 5; // Increase alpha (adjust as necessary)
                    if (alpha > 255) alpha = 255; // Clamp to 255

                    // Set the new BackColor with updated alpha
                    //control.BackColor = Color.FromArgb(alpha, control.BackColor.R, control.BackColor.G, control.BackColor.B);
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

        private void reserveSeatBtn_Click(object sender, EventArgs e)
        {
            

            //Seat Reservation
            var dbConnection = new MongoDBConnection();
            var seatReservationService = new SeatReservationServices(dbConnection);

            var seatReservationForm = new SeatReservation(seatReservationService);
            seatReservationForm.Show();
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

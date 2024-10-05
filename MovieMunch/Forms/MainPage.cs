using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MovieMunch
{
    public partial class MainPage : Form
    {
        //Instances
        private LoginForm _loginFormInstance;
        private RegisterForm _registerFormInstance;

        //images Arrays
        private readonly string[] _imagePaths;
        private int _currentImageIndex = 0;


        public MainPage()
        {
            InitializeComponent();

            _imagePaths = new string[] // List to lods baka malito lang kayo
            {
                @"C:\Users\jakem\Downloads\OneDrive\Desktop\movie_reservation\movie_reservation\Forms\Assets\movie1.png",
                @"C:\Users\jakem\Downloads\OneDrive\Desktop\movie_reservation\movie_reservation\Forms\Assets\movie2.png",
                @"C:\Users\jakem\Downloads\OneDrive\Desktop\movie_reservation\movie_reservation\Forms\Assets\movie3.png",
                @"C:\Users\jakem\Downloads\OneDrive\Desktop\movie_reservation\movie_reservation\Forms\Assets\movie4.png"
            };

            // Set the default image and text
            UpdateDisplayedImage();
        }


        private void SetImageInPictureBox(PictureBox pictureBox, string imagePath, float opacity = 1.0f)
        {
            if (File.Exists(imagePath)) //Checking lang alam nyona yan
            {
                if (pictureBox.Image != null) //Checking lang din kung di empty yung imageBox
                {
                    pictureBox.Image.Dispose(); //Displaying the image 
                }

                Bitmap image = new Bitmap(imagePath); //Passing the image inside the BitMap
                pictureBox.Image = ApplyOpacity(image, opacity); //Calling the ApplyOpacity and passing the image that position in left and right box
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; //Just fitting the image in the image box
            }
            else
            {
                MessageBox.Show("Image not found at path: " + imagePath);
            }
        }

        private Bitmap ApplyOpacity(Bitmap image, float opacity)
        {
            // Create a new bitmap with the same size as the original
            Bitmap tempBitmap = new Bitmap(image.Width, image.Height);

            // Create a graphics object to draw on the new bitmap
            using (Graphics g = Graphics.FromImage(tempBitmap))
            {
                // Create a color matrix with the specified opacity
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity; // Set the opacity

                // Create an ImageAttributes object and set the color matrix
                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(matrix);

                    // Draw the original image onto the new bitmap with the specified opacity
                    g.DrawImage(image, new Rectangle(0, 0, tempBitmap.Width, tempBitmap.Height),
                                0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            return tempBitmap; //tempBitmap because it returns the temperature or the opacity of the image box in left and right image box
        }

        private void UpdateDisplayedImage()
        {
            try
            {
                if (_imagePaths.Length == 0)
                {
                    MessageBox.Show("No images found.");
                    return;
                }

                // Ensure the index wraps around
                _currentImageIndex = (_currentImageIndex + _imagePaths.Length) % _imagePaths.Length;

                int previousImageIndex = (_currentImageIndex - 1 + _imagePaths.Length) % _imagePaths.Length;
                int nextImageIndex = (_currentImageIndex + 1) % _imagePaths.Length;

                // Set images with opacity for left and right PictureBoxes
                SetImageInPictureBox(pictureBoxLeft, _imagePaths[previousImageIndex], 0.5f); //Half opacity
                SetImageInPictureBox(pictureBoxMain, _imagePaths[_currentImageIndex], 1.0f); // Full opacity
                SetImageInPictureBox(pictureBoxRight, _imagePaths[nextImageIndex], 0.5f); //Half opacity
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Open Login Form
            if (_loginFormInstance != null && !_loginFormInstance.IsDisposed)
            {
                _loginFormInstance.Close();  // Close the previous instance if it's still open
            }

            _loginFormInstance = new LoginForm();  // Create a new instance
            _loginFormInstance.Show(); //Display loginForm
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            // Open Register Form
            if (_registerFormInstance != null && !_registerFormInstance.IsDisposed)
            {
                _registerFormInstance.Close();  // Close the previous instance if it's still open
            }

            _registerFormInstance = new RegisterForm(); // Create a new instance
            _registerFormInstance.Show(); //Display registerForm
        }

        private void rightTurnBtn_Click(object sender, EventArgs e)
        {
            _currentImageIndex++; //naga increment lang sya kase index yung gamit sa imagePath para malaman kung anong position na yung nakalagay sa midImage Box
            UpdateDisplayedImage();
        }

        private void leftTurnBtn_Click(object sender, EventArgs e)
        {
            _currentImageIndex--; //Decrement lang 
            UpdateDisplayedImage();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

            this.Hide();
            RegisterForm registrationForm = new RegisterForm();
            registrationForm.Show();
        }

        //private void ReservedSeatBtn_Click(object sender, EventArgs e)
        //{
        //    // Open seat reservation form
        //    var seatReservationForm = new SeatReservationForm(); // Ensure this form exists
        //    seatReservationForm.ShowDialog();
        //}
    }
}

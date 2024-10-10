﻿using MovieMunch.Forms.Components;
using MovieMunch.Frontend.Forms;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MovieMunch
{
    public partial class MainPage : Form
    {
        //images Arrays
        private readonly string[] _imagePaths;
        private int _currentImageIndex = 0;

        private readonly string[] _circleColors;
        private PictureBox[] _circleColorBoxes; // 4 circles for image index
        private SettingsForm _settingsForm;

        public MainPage()
        {
            InitializeComponent();

            _imagePaths = new string[]
            {
                @"C:\Users\jakem\source\repos\MovieMunch\MovieMunch\Frontend\Forms\Assets\movie1.png",
                @"C:\Users\jakem\source\repos\MovieMunch\MovieMunch\Frontend\Forms\Assets\movie2.png",
                @"C:\Users\jakem\source\repos\MovieMunch\MovieMunch\Frontend\Forms\Assets\movie3.png",
                @"C:\Users\jakem\source\repos\MovieMunch\MovieMunch\Frontend\Forms\Assets\movie4.png"
            };

            _circleColors = new string[]
            {
                @"C:\Users\jakem\source\repos\MovieMunch\MovieMunch\Frontend\Forms\Assets\ColoredCircle.png",
                @"C:\Users\jakem\source\repos\MovieMunch\MovieMunch\Frontend\Forms\Assets\UncolloredCircle.png"
            };

            // Initialize circle color boxes
            _circleColorBoxes = new PictureBox[] { FirstCircle, SecondCircle, ThirdCircle, FourthCircle };

            // Set the default image and text
            UpdateDisplayedImage();
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
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;

                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(matrix);
                    g.DrawImage(image, new Rectangle(0, 0, tempBitmap.Width, tempBitmap.Height),
                                0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            return tempBitmap;
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

                _currentImageIndex = (_currentImageIndex + _imagePaths.Length) % _imagePaths.Length;

                int previousImageIndex = (_currentImageIndex - 1 + _imagePaths.Length) % _imagePaths.Length;
                int nextImageIndex = (_currentImageIndex + 1) % _imagePaths.Length;

                SetImageInPictureBox(pictureBoxLeft, _imagePaths[previousImageIndex], 0.5f);
                SetImageInPictureBox(pictureBoxMain, _imagePaths[_currentImageIndex], 1.0f);
                SetImageInPictureBox(pictureBoxRight, _imagePaths[nextImageIndex], 0.5f);

                UpdateCircleColors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void UpdateCircleColors()
        {
            for (int i = 0; i < _circleColorBoxes.Length; i++)
            {
                // If current image index is the same as the circle index, set the colored circle
                if (i == _currentImageIndex)
                {
                    SetCircleColor(_circleColorBoxes[i], _circleColors[0]); // colored circle
                }
                else
                {
                    SetCircleColor(_circleColorBoxes[i], _circleColors[1]); // uncolored circle
                }
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

                Bitmap image = new Bitmap(circleColorPath);
                pictureColor.Image = image;
                pictureColor.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Image not found at path: " + circleColorPath);
            }
        }

        private void rightTurnBtn_Click(object sender, EventArgs e)
        {
            _currentImageIndex++;
            UpdateDisplayedImage();
        }

        private void leftTurnBtn_Click(object sender, EventArgs e)
        {
            _currentImageIndex--;
            UpdateDisplayedImage();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registrationForm = new RegisterForm();
            registrationForm.Show();
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            _settingsForm = new SettingsForm();
            _settingsForm.Show();
        }
    }
}

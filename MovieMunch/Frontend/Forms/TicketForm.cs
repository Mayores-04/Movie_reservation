using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Markup;
using Zen.Barcode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieMunch.Frontend.Forms
{
    public partial class TicketForm : Form
    {
        private string _userName;
        private string _userEmail;
        private string _movieId;
        private string _profilePic;
        private UserService _userService;



        private string _movieDay;
        private DateTime _movieStart;
        private DateTime _movieEnd;

        private string reference;
        private string _ticketReference;
        public TicketForm(string movieId, string userName, string userEmail, string profilePic, string movieDay, 
            DateTime movieStart, DateTime movieEnd)
        {
            InitializeComponent();

            _userName = userName ?? "Guest";
            _userEmail = userEmail ?? "N/A";
            _movieId = movieId;
            _profilePic = profilePic;
            _userService = new UserService();


            _movieDay = movieDay;
            _movieStart = movieStart;
            _movieEnd = movieEnd;

            userNameHolder.Text = _userName;
            LoadTicketList();

            MainPage mainPage = new MainPage();
            mainPage.Close();

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

        private string _referenceId;
        private void LoadTicketList()
        {
            try
            {
                ticketsListWholeFlowLayoutPanel.Controls.Clear();
                ticketsListWholeFlowLayoutPanel.AutoScroll = true;
                ticketsListWholeFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                ticketsListWholeFlowLayoutPanel.WrapContents = false;

                var loadingLabel = new Label
                {
                    Text = "Loading tickets...",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 14, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                ticketsListWholeFlowLayoutPanel.Controls.Add(loadingLabel);

                var recentlyPurchasedTickets = _userService.GetRecentlyPurchasedTickets(_userName);
                var purchasedTickets = _userService.GetPurchasedTickets(_userName);

                ticketsListWholeFlowLayoutPanel.Controls.Clear();

                if (recentlyPurchasedTickets.Any() || purchasedTickets.Any())
                {
                    AddTicketCategories(ticketsListWholeFlowLayoutPanel, recentlyPurchasedTickets, purchasedTickets);
                }
                else
                {
                    var noTicketsLabel = new Label
                    {
                        Text = "No tickets available.",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 14, FontStyle.Italic),
                        ForeColor = Color.Gray,
                        Dock = DockStyle.Top,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    ticketsListWholeFlowLayoutPanel.Controls.Add(noTicketsLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tickets: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTicketCategories(FlowLayoutPanel flowLayoutPanel, List<TicketDetails> recentlyPurchasedTickets, List<TicketDetails> purchasedTickets)
        {
            if (recentlyPurchasedTickets.Any())
            {
                var recentlyPurchasedHeader = CreateCategoryHeader("Recently Purchased Tickets");
                flowLayoutPanel.Controls.Add(recentlyPurchasedHeader);

                foreach (var ticket in recentlyPurchasedTickets)
                {
                    var ticketPanel = CreateTicketPanel(ticket);
                    flowLayoutPanel.Controls.Add(ticketPanel);
                }
            }

            if (purchasedTickets.Any())
            {
                var purchasedHeader = CreateCategoryHeader("Purchased Tickets");
                flowLayoutPanel.Controls.Add(purchasedHeader);

                foreach (var ticket in purchasedTickets)
                {
                    var ticketPanel = CreateTicketPanel(ticket);
                    flowLayoutPanel.Controls.Add(ticketPanel);
                }
            }
        }

        private Panel CreateCategoryHeader(string headerText)
        {
            Label label = new Label
            {
                Text = headerText,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#FFFFFF"),
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,  
                Padding = new Padding(10, 0, 0, 0)  
            };

            Panel panel = new Panel
            {
                BackColor = ColorTranslator.FromHtml("#510A32"),
                Size = new System.Drawing.Size(1036, 48),  
                Margin = new Padding(-10, 20, 0, 10),
                BorderStyle = BorderStyle.None,
                AutoScroll = false,  
                HorizontalScroll = { Enabled = false, Visible = false },
            };

            panel.Paint += (s, e) =>
            {
                var borderColor = ColorTranslator.FromHtml("#EE4540");
                var borderThickness = 2;

                var rect = panel.ClientRectangle;

                e.Graphics.DrawLine(new Pen(borderColor, borderThickness), rect.Left, rect.Top, rect.Right, rect.Top);

                e.Graphics.DrawLine(new Pen(borderColor, borderThickness), rect.Left, rect.Bottom - borderThickness, rect.Right, rect.Bottom - borderThickness);
            };

            panel.Controls.Add(label);

            return panel;
        }

        private Guna.UI2.WinForms.Guna2Panel CreateTicketPanel(TicketDetails ticket)
        {
            var ticketId = ticket.MovieId ?? Guid.NewGuid().ToString();

            CodeQrBarcodeDraw barcode = BarcodeDrawFactory.CodeQr;
            Image qrCodeImage = barcode.Draw(ticketId, 100);

            // Main panel for the ticket
            var moviePanel = new Guna.UI2.WinForms.Guna2Panel
            {
                Size = new System.Drawing.Size(1018, 250),
                BorderRadius = 10,
                BorderThickness = 1,
                Margin = new Padding(10, 10, 0, 10),
                FillColor = ColorTranslator.FromHtml("#801336"),
                BorderColor = ColorTranslator.FromHtml("#EE4540")
            };

            // Ticket Header Panel 
            var ticketHeaderPanel = new Guna.UI2.WinForms.Guna2Panel
            {
                FillColor = ColorTranslator.FromHtml("#510A32"),
                BorderColor = ColorTranslator.FromHtml("#C72C41"),
                BorderThickness = 1,
                Size = new System.Drawing.Size(988, 46),
                Location = new System.Drawing.Point(15, 15)
            };

            // purchased date   
            var purchaseDateLabel = new Label
            {
                Text = $"Date of Purchase: {ticket.DatePurchased:dd MMMM yyyy}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new System.Drawing.Point(10, 13),
                ForeColor = Color.White,
                Size = new System.Drawing.Size(300, 20),
                BackColor = Color.Transparent
            };

            // MOVIE MUNCH TICKET Text 
            var ticketTextLabel = new Label
            {
                Text = "MOVIE MUNCH TICKET",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new System.Drawing.Point(720, 10),
                ForeColor = Color.White,
                Size = new System.Drawing.Size(250, 30),
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.TopRight
            };

            ticketHeaderPanel.Controls.Add(purchaseDateLabel);
            ticketHeaderPanel.Controls.Add(ticketTextLabel);

            // QR Code 
            var qrCodePictureBox = new Guna2PictureBox
            {
                Size = new System.Drawing.Size(150, 150),
                Location = new System.Drawing.Point(15, 80),
                BackColor = Color.Transparent,
                BorderRadius = 5,
                Image = qrCodeImage,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            // Movie Name  
            var movieNameTextBox = new Label
            {
                Text = ticket.MovieTitle ?? "Movie Title",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                Location = new System.Drawing.Point(175, 190),  
                ForeColor = Color.White,
                Size = new System.Drawing.Size(580, 40),
                BackColor = Color.Transparent
            };

            // Seats and Theater Info  
            var seatsInfoLabel = new Label
            {
                Text = $"Theater: 01\nSeats: {string.Join(", ", ticket.SeatTicketMapping.Keys)}\n" +
                       $"Date: {ticket.DatePurchased:dd MMMM yyyy}\nTicket Id: {ticketId}",
                Font = new Font("Segoe UI", 10),
                Location = new System.Drawing.Point(180, 75),
                Size = new System.Drawing.Size(255, 110), 
                ForeColor = Color.White,
                BackColor = Color.Transparent
            };


            // Center Section - Snacks/Regular Foods
            var foodDetails = string.Empty;
            if (ticket.RegularFoodsName != null && ticket.RegularFoodsName.Any())
            {
                foodDetails += $"Regular Foods: {string.Join(", ", ticket.RegularFoodsName)}\n";
            }
            if (ticket.SnackFoodsName != null && ticket.SnackFoodsName.Any())
            {
                foodDetails += $"Snack Foods: {string.Join(", ", ticket.SnackFoodsName)}";
            }

            var foodDetailsLabel = new Label
            {
                Text = foodDetails,
                Font = new Font("Segoe UI", 10),
                Location = new System.Drawing.Point(450, 75),
                ForeColor = Color.White,
                Size = new System.Drawing.Size(310, 110),
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.TopLeft
            };

            string movieMunchLogoPath = "C:\\Users\\jakem\\source\\repos\\Movie_reservation\\MovieMunch\\Frontend\\Forms\\Assets\\movieMunchWhite.png";
            Image movieMunchLogo = Image.FromFile(movieMunchLogoPath);

            // Movie Munch Logo
            var logoPictureBox = new PictureBox
            {
                Size = new System.Drawing.Size(200, 100),
                Location = new System.Drawing.Point(780, 100),
                BackColor = Color.Transparent,
                Image = movieMunchLogo,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            moviePanel.Controls.Add(ticketHeaderPanel); 
            moviePanel.Controls.Add(qrCodePictureBox);
            moviePanel.Controls.Add(movieNameTextBox);
            moviePanel.Controls.Add(foodDetailsLabel);
            moviePanel.Controls.Add(seatsInfoLabel);
            moviePanel.Controls.Add(logoPictureBox);

            ticketHeaderPanel.BringToFront();
            logoPictureBox.BringToFront();
            return moviePanel;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            var mainPage = new MainPage();
            mainPage.SetLoggedInUserEmail(_userEmail);
            mainPage.SetUserInfo(_userName ?? "USERNAME", _profilePic);
            this.Close();
        }

        private void gotoWatchListBtn_Click(object sender, EventArgs e)
        {
            var watchListForm = new WatchListForm(_movieId, _userName ?? "Guest", _userEmail, _profilePic, _movieDay, _movieStart, _movieEnd);
            watchListForm.Show();
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

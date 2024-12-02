using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieMunch.Frontend.Forms
{
    public partial class TicketForm : Form
    {
        private readonly string _userName;
        private readonly string _userEmail;
        private readonly string _movieId;
        private readonly string _profilePic;
        private readonly UserService _userService;

        public TicketForm(string movieId, string userName, string userEmail, string profilePic)
        {
            InitializeComponent();

            _userName = userName ?? "Guest";
            _userEmail = userEmail ?? "N/A";
            _movieId = movieId;
            _profilePic = profilePic;
            _userService = new UserService();

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
            // Add "Recently Purchased Tickets" section
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

            // Add "Purchased Tickets" section
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
            var moviePanel = new Guna.UI2.WinForms.Guna2Panel
            {
                Size = new System.Drawing.Size(1018, 170),
                BorderRadius = 10,
                BorderThickness = 1,
                Margin = new Padding(10, 10, 0, 10),
                FillColor = ColorTranslator.FromHtml("#510A32"),
                BorderColor = ColorTranslator.FromHtml("#EE4540")
            };

            var logoPictureBox = new PictureBox
            {
                Size = new System.Drawing.Size(100, 100),
                Location = new System.Drawing.Point(10, 10),
                BackColor = Color.Transparent,
                Image = Properties.Resources.MovieMunchLogo_removebg_preview,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            var titleLabel = new Label
            {
                Text = ticket.MovieTitle,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new System.Drawing.Point(120, 10),
                ForeColor = Color.White,
                Size = new System.Drawing.Size(500, 30),
                BackColor = Color.Transparent
            };

            var userNameLabel = new Label
            {
                Text = $"User: {ticket.UserName}",
                Font = new Font("Segoe UI", 12),
                Location = new System.Drawing.Point(120, 50),
                ForeColor = Color.White,
                Size = new System.Drawing.Size(300, 20),
                BackColor = Color.Transparent
            };
            
            var seatLabels = new List<string>();
            foreach (var seat in ticket.SeatTicketMapping)
            {
                seatLabels.Add(seat.Key); 
            }

            var seatsLabel = new Label
            {
                Text = $"Seat(s): {string.Join(", ", seatLabels)}",  
                Font = new Font("Segoe UI", 12),
                Location = new System.Drawing.Point(120, 80),
                ForeColor = Color.White,
                Size = new System.Drawing.Size(300, 20),
                BackColor = Color.Transparent
            };

            var referenceNumber = new Label
            {
                Text = $"Reference: {ticket.MovieId}", 
                Font = new Font("Segoe UI", 12),
                Location = new System.Drawing.Point(120, 110),
                ForeColor = Color.White,
                Size = new System.Drawing.Size(300, 20),
                BackColor = Color.Transparent
            };

            var barcodePictureBox = new PictureBox
            {
                Size = new System.Drawing.Size(150, 50),
                Location = new System.Drawing.Point(850, 10),
                BackColor = Color.White,
                Image = Properties.Resources.MovieMunchLogo_removebg_preview, 
                SizeMode = PictureBoxSizeMode.Zoom
            };

            var brandingLabel = new Label
            {
                Text = "MovieMunch",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new System.Drawing.Point(850, 70),
                ForeColor = ColorTranslator.FromHtml("#EE4540"),
                Size = new System.Drawing.Size(150, 30),
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleCenter
            };

            moviePanel.Controls.Add(logoPictureBox);
            moviePanel.Controls.Add(titleLabel);
            moviePanel.Controls.Add(userNameLabel);
            moviePanel.Controls.Add(seatsLabel);
            moviePanel.Controls.Add(referenceNumber);
            moviePanel.Controls.Add(barcodePictureBox);
            moviePanel.Controls.Add(brandingLabel);

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
            var watchListForm = new WatchListForm(_movieId, _userName ?? "Guest", _userEmail, _profilePic);
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
    }
}

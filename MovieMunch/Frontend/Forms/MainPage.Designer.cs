
﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieMunch
{
    partial class MainPage 
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                if (pictureBoxMain.Image != null)
                {
                    pictureBoxMain.Image.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges73 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges74 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges75 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges76 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges77 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges78 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges79 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges80 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges81 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges82 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges83 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges84 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges85 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges86 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges87 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges88 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges89 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges90 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.TicketBtn = new System.Windows.Forms.Button();
            this.FavBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.filmsInCinemaPanel = new System.Windows.Forms.Panel();
            this.LeftTurnBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.rightTurnBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.reserveSeatBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.yummyFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.yummy1 = new System.Windows.Forms.Panel();
            this.yummy2 = new System.Windows.Forms.Panel();
            this.yummy3 = new System.Windows.Forms.Panel();
            this.fourthCircle = new System.Windows.Forms.PictureBox();
            this.thirdCircle = new System.Windows.Forms.PictureBox();
            this.secondCircle = new System.Windows.Forms.PictureBox();
            this.firstCircle = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ComingSoonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.soon1 = new System.Windows.Forms.Panel();
            this.soon2 = new System.Windows.Forms.Panel();
            this.soon3 = new System.Windows.Forms.Panel();
            this.soon4 = new System.Windows.Forms.Panel();
            this.soon5 = new System.Windows.Forms.Panel();
            this.soon6 = new System.Windows.Forms.Panel();
            this.soon7 = new System.Windows.Forms.Panel();
            this.soon8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FilmsInCinemaFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.films1 = new System.Windows.Forms.Panel();
            this.films2 = new System.Windows.Forms.Panel();
            this.films3 = new System.Windows.Forms.Panel();
            this.films4 = new System.Windows.Forms.Panel();
            this.films5 = new System.Windows.Forms.Panel();
            this.films6 = new System.Windows.Forms.Panel();
            this.films7 = new System.Windows.Forms.Panel();
            this.films8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.food1 = new System.Windows.Forms.Panel();
            this.food2 = new System.Windows.Forms.Panel();
            this.food3 = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.LogoutBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SignUpBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.LoginBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.smothFromLeftToRightTransition = new System.Windows.Forms.Timer(this.components);
            this.searchResultsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchResultFlowWholePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.trendingMoviesDetailsPanel = new System.Windows.Forms.Panel();
            this.trendingDescriptionDetails = new System.Windows.Forms.Label();
            this.closeTrendingMoviesDetails = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.trendingMovieSeatReservationBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.trendingMoviePriceDetails = new System.Windows.Forms.Label();
            this.bunifuIconButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.trendingMovieTitleDetails = new System.Windows.Forms.Label();
            this.trendingDetailsPictureBox = new System.Windows.Forms.PictureBox();
            this.comingSoonMovieDetailsPanel = new System.Windows.Forms.Panel();
            this.comingSoonMovieDescriptionDetails = new System.Windows.Forms.Label();
            this.closeComingSoonMovieDetailsBtn = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.comingSoonMovieSeatReservationBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.comingSoonPriceDetails = new System.Windows.Forms.Label();
            this.bunifuIconButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.comingSoonTitleDetails = new System.Windows.Forms.Label();
            this.comingSoonMoviePicBoxDetails = new System.Windows.Forms.PictureBox();
            this.filmsDetailsPanel = new System.Windows.Forms.Panel();
            this.filmsDescriptionDetails = new System.Windows.Forms.Label();
            this.closeFilmsDetailsBtn = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.filmsMovieSeatReservationBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.filmsPriceDetails = new System.Windows.Forms.Label();
            this.bunifuIconButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.filmsTitleDetails = new System.Windows.Forms.Label();
            this.filmsPictureBoxDetails = new System.Windows.Forms.PictureBox();
            this.foodDetailsPanel = new System.Windows.Forms.Panel();
            this.closeFoodDetailsBtn = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.snackDealsReservedSeatBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.foodPriceDetails = new System.Windows.Forms.Label();
            this.bunifuIconButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.foodNameDetails = new System.Windows.Forms.Label();
            this.foodPicDetails = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.exisSearchBtn = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.userNameHolder = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.searchInput = new Bunifu.UI.WinForms.BunifuTextBox();
            this.logoBefore = new System.Windows.Forms.PictureBox();
            this.searchBtnBefore = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.logoAfter = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.filmsInCinemaPanel.SuspendLayout();
            this.panel13.SuspendLayout();
            this.yummyFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fourthCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCircle)).BeginInit();
            this.panel5.SuspendLayout();
            this.ComingSoonFlowLayoutPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.FilmsInCinemaFlowLayout.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.userPanel.SuspendLayout();
            this.searchResultFlowWholePanel.SuspendLayout();
            this.trendingMoviesDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trendingDetailsPictureBox)).BeginInit();
            this.comingSoonMovieDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comingSoonMoviePicBoxDetails)).BeginInit();
            this.filmsDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsPictureBoxDetails)).BeginInit();
            this.foodDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicDetails)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.HomeBtn);
            this.panel2.Controls.Add(this.TicketBtn);
            this.panel2.Controls.Add(this.FavBtn);
            this.panel2.Controls.Add(this.SettingBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 650);
            this.panel2.TabIndex = 7;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.HomeBtn.BackgroundImage = global::MovieMunch.Properties.Resources.Ellipse_7;
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = global::MovieMunch.Properties.Resources.homeIcon;
            this.HomeBtn.Location = new System.Drawing.Point(3, 29);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(0, 28, 1, 0);
            this.HomeBtn.Size = new System.Drawing.Size(98, 98);
            this.HomeBtn.TabIndex = 16;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // TicketBtn
            // 
            this.TicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.TicketBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TicketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TicketBtn.FlatAppearance.BorderSize = 0;
            this.TicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketBtn.ForeColor = System.Drawing.Color.White;
            this.TicketBtn.Image = global::MovieMunch.Properties.Resources.TicketIcon;
            this.TicketBtn.Location = new System.Drawing.Point(0, 193);
            this.TicketBtn.Name = "TicketBtn";
            this.TicketBtn.Size = new System.Drawing.Size(98, 98);
            this.TicketBtn.TabIndex = 15;
            this.TicketBtn.UseVisualStyleBackColor = false;
            this.TicketBtn.Click += new System.EventHandler(this.TicketBtn_Click);
            // 
            // FavBtn
            // 
            this.FavBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavBtn.FlatAppearance.BorderSize = 0;
            this.FavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavBtn.Image = global::MovieMunch.Properties.Resources.FavIcon;
            this.FavBtn.Location = new System.Drawing.Point(3, 340);
            this.FavBtn.Name = "FavBtn";
            this.FavBtn.Padding = new System.Windows.Forms.Padding(26, 9, 0, 0);
            this.FavBtn.Size = new System.Drawing.Size(98, 98);
            this.FavBtn.TabIndex = 14;
            this.FavBtn.UseVisualStyleBackColor = true;
            this.FavBtn.Click += new System.EventHandler(this.FavBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.SettingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBtn.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.Image = global::MovieMunch.Properties.Resources.SettingIcon;
            this.SettingBtn.Location = new System.Drawing.Point(3, 497);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(98, 98);
            this.SettingBtn.TabIndex = 10;
            this.SettingBtn.UseVisualStyleBackColor = false;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.flowLayoutPanel1.Controls.Add(this.filmsInCinemaPanel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(96, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1114, 593);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // filmsInCinemaPanel
            // 
            this.filmsInCinemaPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.filmsInCinemaPanel.BackColor = System.Drawing.Color.Transparent;
            this.filmsInCinemaPanel.Controls.Add(this.LeftTurnBtn);
            this.filmsInCinemaPanel.Controls.Add(this.rightTurnBtn);
            this.filmsInCinemaPanel.Controls.Add(this.reserveSeatBtn);
            this.filmsInCinemaPanel.Controls.Add(this.panel13);
            this.filmsInCinemaPanel.Controls.Add(this.yummyFlowLayoutPanel);
            this.filmsInCinemaPanel.Controls.Add(this.fourthCircle);
            this.filmsInCinemaPanel.Controls.Add(this.thirdCircle);
            this.filmsInCinemaPanel.Controls.Add(this.secondCircle);
            this.filmsInCinemaPanel.Controls.Add(this.firstCircle);
            this.filmsInCinemaPanel.Controls.Add(this.panel5);
            this.filmsInCinemaPanel.Controls.Add(this.ComingSoonFlowLayoutPanel);
            this.filmsInCinemaPanel.Controls.Add(this.panel3);
            this.filmsInCinemaPanel.Controls.Add(this.FilmsInCinemaFlowLayout);
            this.filmsInCinemaPanel.Controls.Add(this.panel4);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxRight);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxLeft);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxMain);
            this.filmsInCinemaPanel.Location = new System.Drawing.Point(3, 3);
            this.filmsInCinemaPanel.Name = "filmsInCinemaPanel";
            this.filmsInCinemaPanel.Size = new System.Drawing.Size(1089, 1734);
            this.filmsInCinemaPanel.TabIndex = 0;
            // 
            // LeftTurnBtn
            // 
            this.LeftTurnBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LeftTurnBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LeftTurnBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LeftTurnBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LeftTurnBtn.FillColor = System.Drawing.Color.Transparent;
            this.LeftTurnBtn.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftTurnBtn.ForeColor = System.Drawing.Color.White;
            this.LeftTurnBtn.Image = ((System.Drawing.Image)(resources.GetObject("LeftTurnBtn.Image")));
            this.LeftTurnBtn.ImageSize = new System.Drawing.Size(80, 80);
            this.LeftTurnBtn.Location = new System.Drawing.Point(157, 224);
            this.LeftTurnBtn.Name = "LeftTurnBtn";
            this.LeftTurnBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.LeftTurnBtn.Size = new System.Drawing.Size(91, 91);
            this.LeftTurnBtn.TabIndex = 45;
            this.LeftTurnBtn.Click += new System.EventHandler(this.LeftTurnBtn_Click_1);
            // 
            // rightTurnBtn
            // 
            this.rightTurnBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rightTurnBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rightTurnBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rightTurnBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rightTurnBtn.FillColor = System.Drawing.Color.Transparent;
            this.rightTurnBtn.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightTurnBtn.ForeColor = System.Drawing.Color.White;
            this.rightTurnBtn.Image = global::MovieMunch.Properties.Resources.right;
            this.rightTurnBtn.ImageSize = new System.Drawing.Size(80, 80);
            this.rightTurnBtn.Location = new System.Drawing.Point(830, 224);
            this.rightTurnBtn.Name = "rightTurnBtn";
            this.rightTurnBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.rightTurnBtn.Size = new System.Drawing.Size(91, 91);
            this.rightTurnBtn.TabIndex = 44;
            this.rightTurnBtn.Click += new System.EventHandler(this.rightTurnBtn_Click);
            // 
            // reserveSeatBtn
            // 
            this.reserveSeatBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reserveSeatBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reserveSeatBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reserveSeatBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reserveSeatBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.reserveSeatBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reserveSeatBtn.ForeColor = System.Drawing.Color.White;
            this.reserveSeatBtn.Location = new System.Drawing.Point(598, 347);
            this.reserveSeatBtn.Name = "reserveSeatBtn";
            this.reserveSeatBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.reserveSeatBtn.Size = new System.Drawing.Size(143, 37);
            this.reserveSeatBtn.TabIndex = 43;
            this.reserveSeatBtn.Text = "RESERVE SEAT";
            this.reserveSeatBtn.Click += new System.EventHandler(this.reserveSeatBtn_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.label4);
            this.panel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.Location = new System.Drawing.Point(-33, 529);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1218, 46);
            this.panel13.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(441, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "FILMS IN CINEMA";
            // 
            // yummyFlowLayoutPanel
            // 
            this.yummyFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yummyFlowLayoutPanel.AutoScroll = true;
            this.yummyFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.yummyFlowLayoutPanel.Controls.Add(this.yummy1);
            this.yummyFlowLayoutPanel.Controls.Add(this.yummy2);
            this.yummyFlowLayoutPanel.Controls.Add(this.yummy3);
            this.yummyFlowLayoutPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yummyFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.yummyFlowLayoutPanel.Location = new System.Drawing.Point(-3, 1289);
            this.yummyFlowLayoutPanel.MinimumSize = new System.Drawing.Size(150, 250);
            this.yummyFlowLayoutPanel.Name = "yummyFlowLayoutPanel";
            this.yummyFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 20, 8, 10);
            this.yummyFlowLayoutPanel.Size = new System.Drawing.Size(1089, 472);
            this.yummyFlowLayoutPanel.TabIndex = 35;
            this.yummyFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.yummyFlowLayoutPanel_Paint);
            this.yummyFlowLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.yummyFlowLayoutPanel_MouseDown);
            this.yummyFlowLayoutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.yummyFlowLayoutPanel_MouseMove);
            this.yummyFlowLayoutPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.yummyFlowLayoutPanel_MouseUp);
            // 
            // yummy1
            // 
            this.yummy1.BackColor = System.Drawing.Color.Transparent;
            this.yummy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yummy1.Location = new System.Drawing.Point(25, 25);
            this.yummy1.Margin = new System.Windows.Forms.Padding(25, 5, 20, 5);
            this.yummy1.MinimumSize = new System.Drawing.Size(150, 250);
            this.yummy1.Name = "yummy1";
            this.yummy1.Size = new System.Drawing.Size(560, 323);
            this.yummy1.TabIndex = 3;
            // 
            // yummy2
            // 
            this.yummy2.BackColor = System.Drawing.Color.Transparent;
            this.yummy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yummy2.Location = new System.Drawing.Point(605, 25);
            this.yummy2.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.yummy2.MinimumSize = new System.Drawing.Size(150, 250);
            this.yummy2.Name = "yummy2";
            this.yummy2.Size = new System.Drawing.Size(560, 323);
            this.yummy2.TabIndex = 3;
            // 
            // yummy3
            // 
            this.yummy3.BackColor = System.Drawing.Color.Transparent;
            this.yummy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yummy3.Location = new System.Drawing.Point(1185, 25);
            this.yummy3.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.yummy3.MinimumSize = new System.Drawing.Size(150, 250);
            this.yummy3.Name = "yummy3";
            this.yummy3.Size = new System.Drawing.Size(560, 323);
            this.yummy3.TabIndex = 3;
            // 
            // fourthCircle
            // 
            this.fourthCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fourthCircle.Image = global::MovieMunch.Properties.Resources.UncolloredCircle;
            this.fourthCircle.Location = new System.Drawing.Point(598, 457);
            this.fourthCircle.Name = "fourthCircle";
            this.fourthCircle.Size = new System.Drawing.Size(38, 35);
            this.fourthCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fourthCircle.TabIndex = 29;
            this.fourthCircle.TabStop = false;
            // 
            // thirdCircle
            // 
            this.thirdCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thirdCircle.Image = global::MovieMunch.Properties.Resources.UncolloredCircle;
            this.thirdCircle.Location = new System.Drawing.Point(547, 457);
            this.thirdCircle.Name = "thirdCircle";
            this.thirdCircle.Size = new System.Drawing.Size(36, 35);
            this.thirdCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.thirdCircle.TabIndex = 28;
            this.thirdCircle.TabStop = false;
            // 
            // secondCircle
            // 
            this.secondCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondCircle.Image = global::MovieMunch.Properties.Resources.UncolloredCircle;
            this.secondCircle.Location = new System.Drawing.Point(491, 457);
            this.secondCircle.Name = "secondCircle";
            this.secondCircle.Size = new System.Drawing.Size(39, 35);
            this.secondCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.secondCircle.TabIndex = 27;
            this.secondCircle.TabStop = false;
            // 
            // firstCircle
            // 
            this.firstCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstCircle.Image = global::MovieMunch.Properties.Resources.UncolloredCircle;
            this.firstCircle.Location = new System.Drawing.Point(436, 457);
            this.firstCircle.Name = "firstCircle";
            this.firstCircle.Size = new System.Drawing.Size(38, 35);
            this.firstCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.firstCircle.TabIndex = 26;
            this.firstCircle.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(-44, 1241);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1217, 46);
            this.panel5.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(413, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SNACKS AND BEVERAGE";
            // 
            // ComingSoonFlowLayoutPanel
            // 
            this.ComingSoonFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComingSoonFlowLayoutPanel.AutoScroll = true;
            this.ComingSoonFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ComingSoonFlowLayoutPanel.Controls.Add(this.soon1);
            this.ComingSoonFlowLayoutPanel.Controls.Add(this.soon2);
            this.ComingSoonFlowLayoutPanel.Controls.Add(this.soon3);
            this.ComingSoonFlowLayoutPanel.Controls.Add(this.soon4);
            this.ComingSoonFlowLayoutPanel.Controls.Add(this.soon5);
            this.ComingSoonFlowLayoutPanel.Controls.Add(this.soon6);
            this.ComingSoonFlowLayoutPanel.Controls.Add(this.soon7);
            this.ComingSoonFlowLayoutPanel.Controls.Add(this.soon8);
            this.ComingSoonFlowLayoutPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComingSoonFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ComingSoonFlowLayoutPanel.Location = new System.Drawing.Point(-3, 932);
            this.ComingSoonFlowLayoutPanel.MinimumSize = new System.Drawing.Size(150, 250);
            this.ComingSoonFlowLayoutPanel.Name = "ComingSoonFlowLayoutPanel";
            this.ComingSoonFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 20, 8, 10);
            this.ComingSoonFlowLayoutPanel.Size = new System.Drawing.Size(1092, 339);
            this.ComingSoonFlowLayoutPanel.TabIndex = 34;
            this.ComingSoonFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ComingSoonFlowLayout_Paint);
            this.ComingSoonFlowLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ComingSoonFlowLayout_MouseDown);
            this.ComingSoonFlowLayoutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ComingSoonFlowLayout_MouseMove);
            this.ComingSoonFlowLayoutPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ComingSoonFlowLayout_MouseUp);
            // 
            // soon1
            // 
            this.soon1.BackColor = System.Drawing.Color.Transparent;
            this.soon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soon1.Location = new System.Drawing.Point(20, 25);
            this.soon1.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.soon1.MinimumSize = new System.Drawing.Size(150, 250);
            this.soon1.Name = "soon1";
            this.soon1.Size = new System.Drawing.Size(200, 250);
            this.soon1.TabIndex = 0;
            // 
            // soon2
            // 
            this.soon2.BackColor = System.Drawing.Color.Transparent;
            this.soon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soon2.Location = new System.Drawing.Point(240, 25);
            this.soon2.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.soon2.MinimumSize = new System.Drawing.Size(150, 250);
            this.soon2.Name = "soon2";
            this.soon2.Size = new System.Drawing.Size(200, 250);
            this.soon2.TabIndex = 1;
            // 
            // soon3
            // 
            this.soon3.BackColor = System.Drawing.Color.Transparent;
            this.soon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soon3.Location = new System.Drawing.Point(460, 25);
            this.soon3.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.soon3.MinimumSize = new System.Drawing.Size(150, 250);
            this.soon3.Name = "soon3";
            this.soon3.Size = new System.Drawing.Size(200, 250);
            this.soon3.TabIndex = 2;
            // 
            // soon4
            // 
            this.soon4.BackColor = System.Drawing.Color.Transparent;
            this.soon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soon4.Location = new System.Drawing.Point(680, 25);
            this.soon4.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.soon4.MinimumSize = new System.Drawing.Size(150, 250);
            this.soon4.Name = "soon4";
            this.soon4.Size = new System.Drawing.Size(200, 250);
            this.soon4.TabIndex = 2;
            // 
            // soon5
            // 
            this.soon5.BackColor = System.Drawing.Color.Transparent;
            this.soon5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soon5.Location = new System.Drawing.Point(900, 25);
            this.soon5.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.soon5.MinimumSize = new System.Drawing.Size(150, 250);
            this.soon5.Name = "soon5";
            this.soon5.Size = new System.Drawing.Size(200, 250);
            this.soon5.TabIndex = 3;
            // 
            // soon6
            // 
            this.soon6.BackColor = System.Drawing.Color.Transparent;
            this.soon6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soon6.Location = new System.Drawing.Point(1120, 25);
            this.soon6.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.soon6.MinimumSize = new System.Drawing.Size(150, 250);
            this.soon6.Name = "soon6";
            this.soon6.Size = new System.Drawing.Size(200, 250);
            this.soon6.TabIndex = 3;
            // 
            // soon7
            // 
            this.soon7.BackColor = System.Drawing.Color.Transparent;
            this.soon7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soon7.Location = new System.Drawing.Point(1340, 25);
            this.soon7.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.soon7.MinimumSize = new System.Drawing.Size(150, 250);
            this.soon7.Name = "soon7";
            this.soon7.Size = new System.Drawing.Size(200, 250);
            this.soon7.TabIndex = 3;
            // 
            // soon8
            // 
            this.soon8.BackColor = System.Drawing.Color.Transparent;
            this.soon8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soon8.Location = new System.Drawing.Point(1560, 25);
            this.soon8.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.soon8.MinimumSize = new System.Drawing.Size(150, 250);
            this.soon8.Name = "soon8";
            this.soon8.Size = new System.Drawing.Size(200, 250);
            this.soon8.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(-44, 884);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1218, 46);
            this.panel3.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(462, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "COMING SOON";
            // 
            // FilmsInCinemaFlowLayout
            // 
            this.FilmsInCinemaFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilmsInCinemaFlowLayout.AutoScroll = true;
            this.FilmsInCinemaFlowLayout.BackColor = System.Drawing.Color.Transparent;
            this.FilmsInCinemaFlowLayout.Controls.Add(this.films1);
            this.FilmsInCinemaFlowLayout.Controls.Add(this.films2);
            this.FilmsInCinemaFlowLayout.Controls.Add(this.films3);
            this.FilmsInCinemaFlowLayout.Controls.Add(this.films4);
            this.FilmsInCinemaFlowLayout.Controls.Add(this.films5);
            this.FilmsInCinemaFlowLayout.Controls.Add(this.films6);
            this.FilmsInCinemaFlowLayout.Controls.Add(this.films7);
            this.FilmsInCinemaFlowLayout.Controls.Add(this.films8);
            this.FilmsInCinemaFlowLayout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilmsInCinemaFlowLayout.Location = new System.Drawing.Point(-3, 577);
            this.FilmsInCinemaFlowLayout.MinimumSize = new System.Drawing.Size(150, 250);
            this.FilmsInCinemaFlowLayout.Name = "FilmsInCinemaFlowLayout";
            this.FilmsInCinemaFlowLayout.Padding = new System.Windows.Forms.Padding(0, 20, 8, 10);
            this.FilmsInCinemaFlowLayout.Size = new System.Drawing.Size(1089, 336);
            this.FilmsInCinemaFlowLayout.TabIndex = 25;
            this.FilmsInCinemaFlowLayout.WrapContents = false;
            this.FilmsInCinemaFlowLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.FilmsInCinemaFlowLayout_Paint);
            this.FilmsInCinemaFlowLayout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FilmsInCinemaFlowLayout_MouseDown);
            this.FilmsInCinemaFlowLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FilmsInCinemaFlowLayout_MouseMove);
            this.FilmsInCinemaFlowLayout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FilmsInCinemaFlowLayout_MouseUp);
            // 
            // films1
            // 
            this.films1.BackColor = System.Drawing.Color.Transparent;
            this.films1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.films1.Location = new System.Drawing.Point(20, 25);
            this.films1.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.films1.MinimumSize = new System.Drawing.Size(150, 250);
            this.films1.Name = "films1";
            this.films1.Size = new System.Drawing.Size(200, 250);
            this.films1.TabIndex = 4;
            // 
            // films2
            // 
            this.films2.BackColor = System.Drawing.Color.Transparent;
            this.films2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.films2.Location = new System.Drawing.Point(240, 25);
            this.films2.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.films2.MinimumSize = new System.Drawing.Size(150, 250);
            this.films2.Name = "films2";
            this.films2.Size = new System.Drawing.Size(200, 250);
            this.films2.TabIndex = 5;
            // 
            // films3
            // 
            this.films3.BackColor = System.Drawing.Color.Transparent;
            this.films3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.films3.Location = new System.Drawing.Point(460, 25);
            this.films3.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.films3.MinimumSize = new System.Drawing.Size(150, 250);
            this.films3.Name = "films3";
            this.films3.Size = new System.Drawing.Size(200, 250);
            this.films3.TabIndex = 6;
            // 
            // films4
            // 
            this.films4.BackColor = System.Drawing.Color.Transparent;
            this.films4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.films4.Location = new System.Drawing.Point(680, 25);
            this.films4.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.films4.MinimumSize = new System.Drawing.Size(150, 250);
            this.films4.Name = "films4";
            this.films4.Size = new System.Drawing.Size(200, 250);
            this.films4.TabIndex = 7;
            // 
            // films5
            // 
            this.films5.BackColor = System.Drawing.Color.Transparent;
            this.films5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.films5.Location = new System.Drawing.Point(900, 25);
            this.films5.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.films5.MinimumSize = new System.Drawing.Size(150, 250);
            this.films5.Name = "films5";
            this.films5.Size = new System.Drawing.Size(200, 250);
            this.films5.TabIndex = 8;
            // 
            // films6
            // 
            this.films6.BackColor = System.Drawing.Color.Transparent;
            this.films6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.films6.Location = new System.Drawing.Point(1120, 25);
            this.films6.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.films6.MinimumSize = new System.Drawing.Size(150, 250);
            this.films6.Name = "films6";
            this.films6.Size = new System.Drawing.Size(200, 250);
            this.films6.TabIndex = 9;
            // 
            // films7
            // 
            this.films7.BackColor = System.Drawing.Color.Transparent;
            this.films7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.films7.Location = new System.Drawing.Point(1340, 25);
            this.films7.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.films7.MinimumSize = new System.Drawing.Size(150, 250);
            this.films7.Name = "films7";
            this.films7.Size = new System.Drawing.Size(200, 250);
            this.films7.TabIndex = 10;
            // 
            // films8
            // 
            this.films8.BackColor = System.Drawing.Color.Transparent;
            this.films8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.films8.Location = new System.Drawing.Point(1560, 25);
            this.films8.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.films8.MinimumSize = new System.Drawing.Size(150, 250);
            this.films8.Name = "films8";
            this.films8.Size = new System.Drawing.Size(200, 250);
            this.films8.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(-3, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1208, 46);
            this.panel4.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(445, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "TRENDING";
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.BackColor = System.Drawing.Color.Black;
            this.pictureBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRight.Location = new System.Drawing.Point(934, 87);
            this.pictureBoxRight.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(548, 349);
            this.pictureBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRight.TabIndex = 19;
            this.pictureBoxRight.TabStop = false;
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.BackColor = System.Drawing.Color.Black;
            this.pictureBoxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLeft.Location = new System.Drawing.Point(-406, 87);
            this.pictureBoxLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(548, 349);
            this.pictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeft.TabIndex = 18;
            this.pictureBoxLeft.TabStop = false;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMain.Location = new System.Drawing.Point(266, 87);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(548, 349);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 12;
            this.pictureBoxMain.TabStop = false;
            // 
            // food1
            // 
            this.food1.Location = new System.Drawing.Point(0, 0);
            this.food1.Name = "food1";
            this.food1.Size = new System.Drawing.Size(200, 100);
            this.food1.TabIndex = 0;
            // 
            // food2
            // 
            this.food2.Location = new System.Drawing.Point(0, 0);
            this.food2.Name = "food2";
            this.food2.Size = new System.Drawing.Size(200, 100);
            this.food2.TabIndex = 0;
            // 
            // food3
            // 
            this.food3.Location = new System.Drawing.Point(0, 0);
            this.food3.Name = "food3";
            this.food3.Size = new System.Drawing.Size(200, 100);
            this.food3.TabIndex = 0;
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.userPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userPanel.Controls.Add(this.LogoutBtn);
            this.userPanel.Controls.Add(this.SignUpBtn);
            this.userPanel.Controls.Add(this.LoginBtn);
            this.userPanel.Location = new System.Drawing.Point(96, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(256, 650);
            this.userPanel.TabIndex = 43;
            this.userPanel.Visible = false;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.AllowAnimations = true;
            this.LogoutBtn.AllowMouseEffects = true;
            this.LogoutBtn.AllowToggling = false;
            this.LogoutBtn.AnimationSpeed = 200;
            this.LogoutBtn.AutoGenerateColors = false;
            this.LogoutBtn.AutoRoundBorders = false;
            this.LogoutBtn.AutoSizeLeftIcon = true;
            this.LogoutBtn.AutoSizeRightIcon = true;
            this.LogoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.LogoutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.BackgroundImage")));
            this.LogoutBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LogoutBtn.ButtonText = "Logout";
            this.LogoutBtn.ButtonTextMarginLeft = 0;
            this.LogoutBtn.ColorContrastOnClick = 45;
            this.LogoutBtn.ColorContrastOnHover = 45;
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges73.BottomLeft = true;
            borderEdges73.BottomRight = true;
            borderEdges73.TopLeft = true;
            borderEdges73.TopRight = true;
            this.LogoutBtn.CustomizableEdges = borderEdges73;
            this.LogoutBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogoutBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LogoutBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LogoutBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LogoutBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LogoutBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LogoutBtn.IconMarginLeft = 11;
            this.LogoutBtn.IconPadding = 10;
            this.LogoutBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LogoutBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LogoutBtn.IconSize = 25;
            this.LogoutBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.LogoutBtn.IdleBorderRadius = 20;
            this.LogoutBtn.IdleBorderThickness = 1;
            this.LogoutBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.LogoutBtn.IdleIconLeftImage = null;
            this.LogoutBtn.IdleIconRightImage = null;
            this.LogoutBtn.IndicateFocus = false;
            this.LogoutBtn.Location = new System.Drawing.Point(60, 137);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LogoutBtn.OnDisabledState.BorderRadius = 20;
            this.LogoutBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LogoutBtn.OnDisabledState.BorderThickness = 1;
            this.LogoutBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LogoutBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LogoutBtn.OnDisabledState.IconLeftImage = null;
            this.LogoutBtn.OnDisabledState.IconRightImage = null;
            this.LogoutBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LogoutBtn.onHoverState.BorderRadius = 20;
            this.LogoutBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LogoutBtn.onHoverState.BorderThickness = 1;
            this.LogoutBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LogoutBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.onHoverState.IconLeftImage = null;
            this.LogoutBtn.onHoverState.IconRightImage = null;
            this.LogoutBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.LogoutBtn.OnIdleState.BorderRadius = 20;
            this.LogoutBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LogoutBtn.OnIdleState.BorderThickness = 1;
            this.LogoutBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.LogoutBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.OnIdleState.IconLeftImage = null;
            this.LogoutBtn.OnIdleState.IconRightImage = null;
            this.LogoutBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LogoutBtn.OnPressedState.BorderRadius = 20;
            this.LogoutBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LogoutBtn.OnPressedState.BorderThickness = 1;
            this.LogoutBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LogoutBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.OnPressedState.IconLeftImage = null;
            this.LogoutBtn.OnPressedState.IconRightImage = null;
            this.LogoutBtn.Size = new System.Drawing.Size(150, 39);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogoutBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogoutBtn.TextMarginLeft = 0;
            this.LogoutBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.LogoutBtn.UseDefaultRadiusAndThickness = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.AllowAnimations = true;
            this.SignUpBtn.AllowMouseEffects = true;
            this.SignUpBtn.AllowToggling = false;
            this.SignUpBtn.AnimationSpeed = 200;
            this.SignUpBtn.AutoGenerateColors = false;
            this.SignUpBtn.AutoRoundBorders = false;
            this.SignUpBtn.AutoSizeLeftIcon = true;
            this.SignUpBtn.AutoSizeRightIcon = true;
            this.SignUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignUpBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.SignUpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpBtn.BackgroundImage")));
            this.SignUpBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SignUpBtn.ButtonText = "Sign Up";
            this.SignUpBtn.ButtonTextMarginLeft = 0;
            this.SignUpBtn.ColorContrastOnClick = 45;
            this.SignUpBtn.ColorContrastOnHover = 45;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges74.BottomLeft = true;
            borderEdges74.BottomRight = true;
            borderEdges74.TopLeft = true;
            borderEdges74.TopRight = true;
            this.SignUpBtn.CustomizableEdges = borderEdges74;
            this.SignUpBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SignUpBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignUpBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignUpBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignUpBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.SignUpBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignUpBtn.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignUpBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SignUpBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SignUpBtn.IconMarginLeft = 11;
            this.SignUpBtn.IconPadding = 10;
            this.SignUpBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignUpBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SignUpBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SignUpBtn.IconSize = 25;
            this.SignUpBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.SignUpBtn.IdleBorderRadius = 20;
            this.SignUpBtn.IdleBorderThickness = 1;
            this.SignUpBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.SignUpBtn.IdleIconLeftImage = null;
            this.SignUpBtn.IdleIconRightImage = null;
            this.SignUpBtn.IndicateFocus = false;
            this.SignUpBtn.Location = new System.Drawing.Point(60, 78);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignUpBtn.OnDisabledState.BorderRadius = 20;
            this.SignUpBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SignUpBtn.OnDisabledState.BorderThickness = 1;
            this.SignUpBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignUpBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignUpBtn.OnDisabledState.IconLeftImage = null;
            this.SignUpBtn.OnDisabledState.IconRightImage = null;
            this.SignUpBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SignUpBtn.onHoverState.BorderRadius = 20;
            this.SignUpBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SignUpBtn.onHoverState.BorderThickness = 1;
            this.SignUpBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SignUpBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.onHoverState.IconLeftImage = null;
            this.SignUpBtn.onHoverState.IconRightImage = null;
            this.SignUpBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.SignUpBtn.OnIdleState.BorderRadius = 20;
            this.SignUpBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SignUpBtn.OnIdleState.BorderThickness = 1;
            this.SignUpBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.SignUpBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.OnIdleState.IconLeftImage = null;
            this.SignUpBtn.OnIdleState.IconRightImage = null;
            this.SignUpBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SignUpBtn.OnPressedState.BorderRadius = 20;
            this.SignUpBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SignUpBtn.OnPressedState.BorderThickness = 1;
            this.SignUpBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SignUpBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.OnPressedState.IconLeftImage = null;
            this.SignUpBtn.OnPressedState.IconRightImage = null;
            this.SignUpBtn.Size = new System.Drawing.Size(150, 39);
            this.SignUpBtn.TabIndex = 1;
            this.SignUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUpBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignUpBtn.TextMarginLeft = 0;
            this.SignUpBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.SignUpBtn.UseDefaultRadiusAndThickness = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.AllowAnimations = true;
            this.LoginBtn.AllowMouseEffects = true;
            this.LoginBtn.AllowToggling = false;
            this.LoginBtn.AnimationSpeed = 200;
            this.LoginBtn.AutoGenerateColors = false;
            this.LoginBtn.AutoRoundBorders = false;
            this.LoginBtn.AutoSizeLeftIcon = true;
            this.LoginBtn.AutoSizeRightIcon = true;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LoginBtn.ButtonText = "Login";
            this.LoginBtn.ButtonTextMarginLeft = 0;
            this.LoginBtn.ColorContrastOnClick = 45;
            this.LoginBtn.ColorContrastOnHover = 45;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges75.BottomLeft = true;
            borderEdges75.BottomRight = true;
            borderEdges75.TopLeft = true;
            borderEdges75.TopRight = true;
            this.LoginBtn.CustomizableEdges = borderEdges75;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoginBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoginBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LoginBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LoginBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LoginBtn.IconMarginLeft = 11;
            this.LoginBtn.IconPadding = 10;
            this.LoginBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LoginBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LoginBtn.IconSize = 25;
            this.LoginBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.LoginBtn.IdleBorderRadius = 20;
            this.LoginBtn.IdleBorderThickness = 1;
            this.LoginBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.LoginBtn.IdleIconLeftImage = null;
            this.LoginBtn.IdleIconRightImage = null;
            this.LoginBtn.IndicateFocus = false;
            this.LoginBtn.Location = new System.Drawing.Point(60, 19);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoginBtn.OnDisabledState.BorderRadius = 20;
            this.LoginBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LoginBtn.OnDisabledState.BorderThickness = 1;
            this.LoginBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoginBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LoginBtn.OnDisabledState.IconLeftImage = null;
            this.LoginBtn.OnDisabledState.IconRightImage = null;
            this.LoginBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LoginBtn.onHoverState.BorderRadius = 20;
            this.LoginBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LoginBtn.onHoverState.BorderThickness = 1;
            this.LoginBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LoginBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.onHoverState.IconLeftImage = null;
            this.LoginBtn.onHoverState.IconRightImage = null;
            this.LoginBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.LoginBtn.OnIdleState.BorderRadius = 20;
            this.LoginBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LoginBtn.OnIdleState.BorderThickness = 1;
            this.LoginBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.LoginBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnIdleState.IconLeftImage = null;
            this.LoginBtn.OnIdleState.IconRightImage = null;
            this.LoginBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LoginBtn.OnPressedState.BorderRadius = 20;
            this.LoginBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LoginBtn.OnPressedState.BorderThickness = 1;
            this.LoginBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LoginBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnPressedState.IconLeftImage = null;
            this.LoginBtn.OnPressedState.IconRightImage = null;
            this.LoginBtn.Size = new System.Drawing.Size(150, 39);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBtn.TextMarginLeft = 0;
            this.LoginBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.LoginBtn.UseDefaultRadiusAndThickness = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // smothFromLeftToRightTransition
            // 
            this.smothFromLeftToRightTransition.Tick += new System.EventHandler(this.smothFromLeftToRightTransition_Click);
            // 
            // searchResultsFlowLayoutPanel
            // 
            this.searchResultsFlowLayoutPanel.AutoScroll = true;
            this.searchResultsFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.searchResultsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.searchResultsFlowLayoutPanel.Location = new System.Drawing.Point(36, 3);
            this.searchResultsFlowLayoutPanel.Name = "searchResultsFlowLayoutPanel";
            this.searchResultsFlowLayoutPanel.Size = new System.Drawing.Size(421, 182);
            this.searchResultsFlowLayoutPanel.TabIndex = 42;
            this.searchResultsFlowLayoutPanel.Visible = false;
            this.searchResultsFlowLayoutPanel.WrapContents = false;
            // 
            // searchResultFlowWholePanel
            // 
            this.searchResultFlowWholePanel.BackColor = System.Drawing.Color.White;
            this.searchResultFlowWholePanel.Controls.Add(this.searchResultsFlowLayoutPanel);
            this.searchResultFlowWholePanel.Location = new System.Drawing.Point(588, 66);
            this.searchResultFlowWholePanel.Name = "searchResultFlowWholePanel";
            this.searchResultFlowWholePanel.Size = new System.Drawing.Size(460, 185);
            this.searchResultFlowWholePanel.TabIndex = 44;
            this.searchResultFlowWholePanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1212, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 29);
            this.label5.TabIndex = 50;
            this.label5.Text = "P";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1212, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 29);
            this.label6.TabIndex = 51;
            this.label6.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1212, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 29);
            this.label7.TabIndex = 52;
            this.label7.Text = "S";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1212, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 29);
            this.label8.TabIndex = 53;
            this.label8.Text = "O";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1215, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 29);
            this.label9.TabIndex = 52;
            this.label9.Text = "B";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1215, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 29);
            this.label10.TabIndex = 52;
            this.label10.Text = "R";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1217, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 29);
            this.label11.TabIndex = 52;
            this.label11.Text = "A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1216, 491);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 29);
            this.label12.TabIndex = 54;
            this.label12.Text = "M";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1216, 529);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 29);
            this.label13.TabIndex = 55;
            this.label13.Text = "U";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1216, 566);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 29);
            this.label14.TabIndex = 53;
            this.label14.Text = "N";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1215, 605);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 29);
            this.label15.TabIndex = 53;
            this.label15.Text = "A";
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.AutoScroll = true;
            this.guna2VScrollBar1.AutoSize = true;
            this.guna2VScrollBar1.BindingContainer = this.flowLayoutPanel1;
            this.guna2VScrollBar1.CausesValidation = false;
            this.guna2VScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 572;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1189, 78);
            this.guna2VScrollBar1.Maximum = 1739;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 21;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(21, 593);
            this.guna2VScrollBar1.SmallChange = 5;
            this.guna2VScrollBar1.TabIndex = 56;
            this.guna2VScrollBar1.ThumbSize = 9F;
            this.guna2VScrollBar1.Value = 120;
            // 
            // trendingMoviesDetailsPanel
            // 
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingDescriptionDetails);
            this.trendingMoviesDetailsPanel.Controls.Add(this.closeTrendingMoviesDetails);
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingMovieSeatReservationBtn);
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingMoviePriceDetails);
            this.trendingMoviesDetailsPanel.Controls.Add(this.bunifuIconButton2);
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingMovieTitleDetails);
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingDetailsPictureBox);
            this.trendingMoviesDetailsPanel.Location = new System.Drawing.Point(233, 124);
            this.trendingMoviesDetailsPanel.Name = "trendingMoviesDetailsPanel";
            this.trendingMoviesDetailsPanel.Size = new System.Drawing.Size(770, 435);
            this.trendingMoviesDetailsPanel.TabIndex = 57;
            this.trendingMoviesDetailsPanel.Visible = false;
            // 
            // trendingDescriptionDetails
            // 
            this.trendingDescriptionDetails.AutoSize = true;
            this.trendingDescriptionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trendingDescriptionDetails.ForeColor = System.Drawing.Color.White;
            this.trendingDescriptionDetails.Location = new System.Drawing.Point(490, 31);
            this.trendingDescriptionDetails.Name = "trendingDescriptionDetails";
            this.trendingDescriptionDetails.Size = new System.Drawing.Size(135, 29);
            this.trendingDescriptionDetails.TabIndex = 64;
            this.trendingDescriptionDetails.Text = "Description";
            // 
            // closeTrendingMoviesDetails
            // 
            this.closeTrendingMoviesDetails.AllowAnimations = true;
            this.closeTrendingMoviesDetails.AllowBorderColorChanges = true;
            this.closeTrendingMoviesDetails.AllowDefaults = true;
            this.closeTrendingMoviesDetails.AllowMouseEffects = true;
            this.closeTrendingMoviesDetails.AnimationSpeed = 200;
            this.closeTrendingMoviesDetails.AutoSizeCaptions = true;
            this.closeTrendingMoviesDetails.BackColor = System.Drawing.Color.Transparent;
            this.closeTrendingMoviesDetails.BackgroundColor = System.Drawing.Color.White;
            this.closeTrendingMoviesDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeTrendingMoviesDetails.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.closeTrendingMoviesDetails.BackPressedColor = System.Drawing.Color.Silver;
            this.closeTrendingMoviesDetails.BorderColor = System.Drawing.Color.White;
            this.closeTrendingMoviesDetails.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.closeTrendingMoviesDetails.BorderPressedColor = System.Drawing.Color.White;
            this.closeTrendingMoviesDetails.BorderRadius = 0;
            this.closeTrendingMoviesDetails.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.closeTrendingMoviesDetails.BorderThickness = 0;
            this.closeTrendingMoviesDetails.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            this.closeTrendingMoviesDetails.ColorContrastOnClick = 30;
            this.closeTrendingMoviesDetails.ColorContrastOnHover = 30;
            this.closeTrendingMoviesDetails.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges76.BottomLeft = true;
            borderEdges76.BottomRight = true;
            borderEdges76.TopLeft = true;
            borderEdges76.TopRight = true;
            this.closeTrendingMoviesDetails.CustomizableEdges = borderEdges76;
            this.closeTrendingMoviesDetails.DefaultBorderColor = System.Drawing.Color.White;
            this.closeTrendingMoviesDetails.DefaultColor = System.Drawing.Color.White;
            this.closeTrendingMoviesDetails.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeTrendingMoviesDetails.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.closeTrendingMoviesDetails.IconHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.closeTrendingMoviesDetails.IconPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.closeTrendingMoviesDetails.Image = ((System.Drawing.Image)(resources.GetObject("closeTrendingMoviesDetails.Image")));
            this.closeTrendingMoviesDetails.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.closeTrendingMoviesDetails.ImageSize = new System.Drawing.Size(30, 30);
            this.closeTrendingMoviesDetails.Location = new System.Drawing.Point(720, 11);
            this.closeTrendingMoviesDetails.Name = "closeTrendingMoviesDetails";
            this.closeTrendingMoviesDetails.ShowBorders = false;
            this.closeTrendingMoviesDetails.Size = new System.Drawing.Size(40, 38);
            this.closeTrendingMoviesDetails.TabIndex = 62;
            this.closeTrendingMoviesDetails.Visible = false;
            this.closeTrendingMoviesDetails.Click += new System.EventHandler(this.closeTrendingMoviesDetails_Click_1);
            // 
            // trendingMovieSeatReservationBtn
            // 
            this.trendingMovieSeatReservationBtn.AllowAnimations = true;
            this.trendingMovieSeatReservationBtn.AllowMouseEffects = true;
            this.trendingMovieSeatReservationBtn.AllowToggling = false;
            this.trendingMovieSeatReservationBtn.AnimationSpeed = 200;
            this.trendingMovieSeatReservationBtn.AutoGenerateColors = false;
            this.trendingMovieSeatReservationBtn.AutoRoundBorders = true;
            this.trendingMovieSeatReservationBtn.AutoSizeLeftIcon = true;
            this.trendingMovieSeatReservationBtn.AutoSizeRightIcon = true;
            this.trendingMovieSeatReservationBtn.BackColor = System.Drawing.Color.Transparent;
            this.trendingMovieSeatReservationBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.trendingMovieSeatReservationBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trendingMovieSeatReservationBtn.BackgroundImage")));
            this.trendingMovieSeatReservationBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.trendingMovieSeatReservationBtn.ButtonText = "RESERVE SEAT";
            this.trendingMovieSeatReservationBtn.ButtonTextMarginLeft = 0;
            this.trendingMovieSeatReservationBtn.ColorContrastOnClick = 45;
            this.trendingMovieSeatReservationBtn.ColorContrastOnHover = 45;
            this.trendingMovieSeatReservationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges77.BottomLeft = true;
            borderEdges77.BottomRight = true;
            borderEdges77.TopLeft = true;
            borderEdges77.TopRight = true;
            this.trendingMovieSeatReservationBtn.CustomizableEdges = borderEdges77;
            this.trendingMovieSeatReservationBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.trendingMovieSeatReservationBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.trendingMovieSeatReservationBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.trendingMovieSeatReservationBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.trendingMovieSeatReservationBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.trendingMovieSeatReservationBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.trendingMovieSeatReservationBtn.ForeColor = System.Drawing.Color.White;
            this.trendingMovieSeatReservationBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trendingMovieSeatReservationBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.trendingMovieSeatReservationBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.trendingMovieSeatReservationBtn.IconMarginLeft = 11;
            this.trendingMovieSeatReservationBtn.IconPadding = 10;
            this.trendingMovieSeatReservationBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trendingMovieSeatReservationBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.trendingMovieSeatReservationBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.trendingMovieSeatReservationBtn.IconSize = 25;
            this.trendingMovieSeatReservationBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.trendingMovieSeatReservationBtn.IdleBorderRadius = 52;
            this.trendingMovieSeatReservationBtn.IdleBorderThickness = 1;
            this.trendingMovieSeatReservationBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.trendingMovieSeatReservationBtn.IdleIconLeftImage = null;
            this.trendingMovieSeatReservationBtn.IdleIconRightImage = null;
            this.trendingMovieSeatReservationBtn.IndicateFocus = false;
            this.trendingMovieSeatReservationBtn.Location = new System.Drawing.Point(118, 367);
            this.trendingMovieSeatReservationBtn.Name = "trendingMovieSeatReservationBtn";
            this.trendingMovieSeatReservationBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.trendingMovieSeatReservationBtn.OnDisabledState.BorderRadius = 1;
            this.trendingMovieSeatReservationBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.trendingMovieSeatReservationBtn.OnDisabledState.BorderThickness = 1;
            this.trendingMovieSeatReservationBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.trendingMovieSeatReservationBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.trendingMovieSeatReservationBtn.OnDisabledState.IconLeftImage = null;
            this.trendingMovieSeatReservationBtn.OnDisabledState.IconRightImage = null;
            this.trendingMovieSeatReservationBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.trendingMovieSeatReservationBtn.onHoverState.BorderRadius = 1;
            this.trendingMovieSeatReservationBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.trendingMovieSeatReservationBtn.onHoverState.BorderThickness = 1;
            this.trendingMovieSeatReservationBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.trendingMovieSeatReservationBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.trendingMovieSeatReservationBtn.onHoverState.IconLeftImage = null;
            this.trendingMovieSeatReservationBtn.onHoverState.IconRightImage = null;
            this.trendingMovieSeatReservationBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.trendingMovieSeatReservationBtn.OnIdleState.BorderRadius = 1;
            this.trendingMovieSeatReservationBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.trendingMovieSeatReservationBtn.OnIdleState.BorderThickness = 1;
            this.trendingMovieSeatReservationBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.trendingMovieSeatReservationBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.trendingMovieSeatReservationBtn.OnIdleState.IconLeftImage = null;
            this.trendingMovieSeatReservationBtn.OnIdleState.IconRightImage = null;
            this.trendingMovieSeatReservationBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.trendingMovieSeatReservationBtn.OnPressedState.BorderRadius = 1;
            this.trendingMovieSeatReservationBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.trendingMovieSeatReservationBtn.OnPressedState.BorderThickness = 1;
            this.trendingMovieSeatReservationBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.trendingMovieSeatReservationBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.trendingMovieSeatReservationBtn.OnPressedState.IconLeftImage = null;
            this.trendingMovieSeatReservationBtn.OnPressedState.IconRightImage = null;
            this.trendingMovieSeatReservationBtn.Size = new System.Drawing.Size(190, 54);
            this.trendingMovieSeatReservationBtn.TabIndex = 61;
            this.trendingMovieSeatReservationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trendingMovieSeatReservationBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.trendingMovieSeatReservationBtn.TextMarginLeft = 0;
            this.trendingMovieSeatReservationBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.trendingMovieSeatReservationBtn.UseDefaultRadiusAndThickness = true;
            this.trendingMovieSeatReservationBtn.Click += new System.EventHandler(this.reserveSeatBtn_Click);
            // 
            // trendingMoviePriceDetails
            // 
            this.trendingMoviePriceDetails.AutoSize = true;
            this.trendingMoviePriceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trendingMoviePriceDetails.ForeColor = System.Drawing.Color.White;
            this.trendingMoviePriceDetails.Location = new System.Drawing.Point(487, 248);
            this.trendingMoviePriceDetails.Name = "trendingMoviePriceDetails";
            this.trendingMoviePriceDetails.Size = new System.Drawing.Size(112, 46);
            this.trendingMoviePriceDetails.TabIndex = 60;
            this.trendingMoviePriceDetails.Text = "Price";
            // 
            // bunifuIconButton2
            // 
            this.bunifuIconButton2.AllowAnimations = true;
            this.bunifuIconButton2.AllowBorderColorChanges = true;
            this.bunifuIconButton2.AllowMouseEffects = true;
            this.bunifuIconButton2.AnimationSpeed = 200;
            this.bunifuIconButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuIconButton2.BackgroundImage")));
            this.bunifuIconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuIconButton2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton2.BorderRadius = 1;
            this.bunifuIconButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButton2.BorderThickness = 1;
            this.bunifuIconButton2.ColorContrastOnClick = 30;
            this.bunifuIconButton2.ColorContrastOnHover = 30;
            this.bunifuIconButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges78.BottomLeft = true;
            borderEdges78.BottomRight = true;
            borderEdges78.TopLeft = true;
            borderEdges78.TopRight = true;
            this.bunifuIconButton2.CustomizableEdges = borderEdges78;
            this.bunifuIconButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton2.Image = null;
            this.bunifuIconButton2.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButton2.Location = new System.Drawing.Point(39, 367);
            this.bunifuIconButton2.Name = "bunifuIconButton2";
            this.bunifuIconButton2.RoundBorders = true;
            this.bunifuIconButton2.ShowBorders = true;
            this.bunifuIconButton2.Size = new System.Drawing.Size(57, 57);
            this.bunifuIconButton2.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButton2.TabIndex = 59;
            // 
            // trendingMovieTitleDetails
            // 
            this.trendingMovieTitleDetails.AutoSize = true;
            this.trendingMovieTitleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trendingMovieTitleDetails.ForeColor = System.Drawing.Color.White;
            this.trendingMovieTitleDetails.Location = new System.Drawing.Point(31, 304);
            this.trendingMovieTitleDetails.Name = "trendingMovieTitleDetails";
            this.trendingMovieTitleDetails.Size = new System.Drawing.Size(293, 46);
            this.trendingMovieTitleDetails.TabIndex = 58;
            this.trendingMovieTitleDetails.Text = "Trending Movie";
            // 
            // trendingDetailsPictureBox
            // 
            this.trendingDetailsPictureBox.BackColor = System.Drawing.Color.Blue;
            this.trendingDetailsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trendingDetailsPictureBox.Location = new System.Drawing.Point(35, 31);
            this.trendingDetailsPictureBox.Name = "trendingDetailsPictureBox";
            this.trendingDetailsPictureBox.Size = new System.Drawing.Size(440, 263);
            this.trendingDetailsPictureBox.TabIndex = 57;
            this.trendingDetailsPictureBox.TabStop = false;
            // 
            // comingSoonMovieDetailsPanel
            // 
            this.comingSoonMovieDetailsPanel.Controls.Add(this.comingSoonMovieDescriptionDetails);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.closeComingSoonMovieDetailsBtn);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.comingSoonMovieSeatReservationBtn);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.comingSoonPriceDetails);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.bunifuIconButton1);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.comingSoonTitleDetails);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.comingSoonMoviePicBoxDetails);
            this.comingSoonMovieDetailsPanel.Location = new System.Drawing.Point(236, 124);
            this.comingSoonMovieDetailsPanel.Name = "comingSoonMovieDetailsPanel";
            this.comingSoonMovieDetailsPanel.Size = new System.Drawing.Size(767, 435);
            this.comingSoonMovieDetailsPanel.TabIndex = 63;
            this.comingSoonMovieDetailsPanel.Visible = false;
            // 
            // comingSoonMovieDescriptionDetails
            // 
            this.comingSoonMovieDescriptionDetails.AutoSize = true;
            this.comingSoonMovieDescriptionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comingSoonMovieDescriptionDetails.ForeColor = System.Drawing.Color.White;
            this.comingSoonMovieDescriptionDetails.Location = new System.Drawing.Point(281, 156);
            this.comingSoonMovieDescriptionDetails.Name = "comingSoonMovieDescriptionDetails";
            this.comingSoonMovieDescriptionDetails.Size = new System.Drawing.Size(135, 29);
            this.comingSoonMovieDescriptionDetails.TabIndex = 63;
            this.comingSoonMovieDescriptionDetails.Text = "Description";
            // 
            // closeComingSoonMovieDetailsBtn
            // 
            this.closeComingSoonMovieDetailsBtn.AllowAnimations = true;
            this.closeComingSoonMovieDetailsBtn.AllowBorderColorChanges = true;
            this.closeComingSoonMovieDetailsBtn.AllowDefaults = true;
            this.closeComingSoonMovieDetailsBtn.AllowMouseEffects = true;
            this.closeComingSoonMovieDetailsBtn.AnimationSpeed = 200;
            this.closeComingSoonMovieDetailsBtn.AutoSizeCaptions = true;
            this.closeComingSoonMovieDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeComingSoonMovieDetailsBtn.BackgroundColor = System.Drawing.Color.White;
            this.closeComingSoonMovieDetailsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeComingSoonMovieDetailsBtn.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.closeComingSoonMovieDetailsBtn.BackPressedColor = System.Drawing.Color.Silver;
            this.closeComingSoonMovieDetailsBtn.BorderColor = System.Drawing.Color.White;
            this.closeComingSoonMovieDetailsBtn.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.closeComingSoonMovieDetailsBtn.BorderPressedColor = System.Drawing.Color.White;
            this.closeComingSoonMovieDetailsBtn.BorderRadius = 0;
            this.closeComingSoonMovieDetailsBtn.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.closeComingSoonMovieDetailsBtn.BorderThickness = 0;
            this.closeComingSoonMovieDetailsBtn.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            this.closeComingSoonMovieDetailsBtn.ColorContrastOnClick = 30;
            this.closeComingSoonMovieDetailsBtn.ColorContrastOnHover = 30;
            this.closeComingSoonMovieDetailsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges79.BottomLeft = true;
            borderEdges79.BottomRight = true;
            borderEdges79.TopLeft = true;
            borderEdges79.TopRight = true;
            this.closeComingSoonMovieDetailsBtn.CustomizableEdges = borderEdges79;
            this.closeComingSoonMovieDetailsBtn.DefaultBorderColor = System.Drawing.Color.White;
            this.closeComingSoonMovieDetailsBtn.DefaultColor = System.Drawing.Color.White;
            this.closeComingSoonMovieDetailsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeComingSoonMovieDetailsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.closeComingSoonMovieDetailsBtn.IconHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.closeComingSoonMovieDetailsBtn.IconPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.closeComingSoonMovieDetailsBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeComingSoonMovieDetailsBtn.Image")));
            this.closeComingSoonMovieDetailsBtn.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.closeComingSoonMovieDetailsBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.closeComingSoonMovieDetailsBtn.Location = new System.Drawing.Point(720, 11);
            this.closeComingSoonMovieDetailsBtn.Name = "closeComingSoonMovieDetailsBtn";
            this.closeComingSoonMovieDetailsBtn.ShowBorders = false;
            this.closeComingSoonMovieDetailsBtn.Size = new System.Drawing.Size(40, 38);
            this.closeComingSoonMovieDetailsBtn.TabIndex = 62;
            this.closeComingSoonMovieDetailsBtn.Visible = false;
            this.closeComingSoonMovieDetailsBtn.Click += new System.EventHandler(this.closeComingSoonMovieDetailsBtn_Click_1);
            // 
            // comingSoonMovieSeatReservationBtn
            // 
            this.comingSoonMovieSeatReservationBtn.AllowAnimations = true;
            this.comingSoonMovieSeatReservationBtn.AllowMouseEffects = true;
            this.comingSoonMovieSeatReservationBtn.AllowToggling = false;
            this.comingSoonMovieSeatReservationBtn.AnimationSpeed = 200;
            this.comingSoonMovieSeatReservationBtn.AutoGenerateColors = false;
            this.comingSoonMovieSeatReservationBtn.AutoRoundBorders = true;
            this.comingSoonMovieSeatReservationBtn.AutoSizeLeftIcon = true;
            this.comingSoonMovieSeatReservationBtn.AutoSizeRightIcon = true;
            this.comingSoonMovieSeatReservationBtn.BackColor = System.Drawing.Color.Transparent;
            this.comingSoonMovieSeatReservationBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.comingSoonMovieSeatReservationBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comingSoonMovieSeatReservationBtn.BackgroundImage")));
            this.comingSoonMovieSeatReservationBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.comingSoonMovieSeatReservationBtn.ButtonText = "RESERVE SEAT";
            this.comingSoonMovieSeatReservationBtn.ButtonTextMarginLeft = 0;
            this.comingSoonMovieSeatReservationBtn.ColorContrastOnClick = 45;
            this.comingSoonMovieSeatReservationBtn.ColorContrastOnHover = 45;
            this.comingSoonMovieSeatReservationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges80.BottomLeft = true;
            borderEdges80.BottomRight = true;
            borderEdges80.TopLeft = true;
            borderEdges80.TopRight = true;
            this.comingSoonMovieSeatReservationBtn.CustomizableEdges = borderEdges80;
            this.comingSoonMovieSeatReservationBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.comingSoonMovieSeatReservationBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.comingSoonMovieSeatReservationBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comingSoonMovieSeatReservationBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.comingSoonMovieSeatReservationBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.comingSoonMovieSeatReservationBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comingSoonMovieSeatReservationBtn.ForeColor = System.Drawing.Color.White;
            this.comingSoonMovieSeatReservationBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comingSoonMovieSeatReservationBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.comingSoonMovieSeatReservationBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.comingSoonMovieSeatReservationBtn.IconMarginLeft = 11;
            this.comingSoonMovieSeatReservationBtn.IconPadding = 10;
            this.comingSoonMovieSeatReservationBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.comingSoonMovieSeatReservationBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.comingSoonMovieSeatReservationBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.comingSoonMovieSeatReservationBtn.IconSize = 25;
            this.comingSoonMovieSeatReservationBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.comingSoonMovieSeatReservationBtn.IdleBorderRadius = 52;
            this.comingSoonMovieSeatReservationBtn.IdleBorderThickness = 1;
            this.comingSoonMovieSeatReservationBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.comingSoonMovieSeatReservationBtn.IdleIconLeftImage = null;
            this.comingSoonMovieSeatReservationBtn.IdleIconRightImage = null;
            this.comingSoonMovieSeatReservationBtn.IndicateFocus = false;
            this.comingSoonMovieSeatReservationBtn.Location = new System.Drawing.Point(359, 337);
            this.comingSoonMovieSeatReservationBtn.Name = "comingSoonMovieSeatReservationBtn";
            this.comingSoonMovieSeatReservationBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.comingSoonMovieSeatReservationBtn.OnDisabledState.BorderRadius = 1;
            this.comingSoonMovieSeatReservationBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.comingSoonMovieSeatReservationBtn.OnDisabledState.BorderThickness = 1;
            this.comingSoonMovieSeatReservationBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.comingSoonMovieSeatReservationBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.comingSoonMovieSeatReservationBtn.OnDisabledState.IconLeftImage = null;
            this.comingSoonMovieSeatReservationBtn.OnDisabledState.IconRightImage = null;
            this.comingSoonMovieSeatReservationBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.comingSoonMovieSeatReservationBtn.onHoverState.BorderRadius = 1;
            this.comingSoonMovieSeatReservationBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.comingSoonMovieSeatReservationBtn.onHoverState.BorderThickness = 1;
            this.comingSoonMovieSeatReservationBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.comingSoonMovieSeatReservationBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.comingSoonMovieSeatReservationBtn.onHoverState.IconLeftImage = null;
            this.comingSoonMovieSeatReservationBtn.onHoverState.IconRightImage = null;
            this.comingSoonMovieSeatReservationBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.comingSoonMovieSeatReservationBtn.OnIdleState.BorderRadius = 1;
            this.comingSoonMovieSeatReservationBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.comingSoonMovieSeatReservationBtn.OnIdleState.BorderThickness = 1;
            this.comingSoonMovieSeatReservationBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.comingSoonMovieSeatReservationBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.comingSoonMovieSeatReservationBtn.OnIdleState.IconLeftImage = null;
            this.comingSoonMovieSeatReservationBtn.OnIdleState.IconRightImage = null;
            this.comingSoonMovieSeatReservationBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.comingSoonMovieSeatReservationBtn.OnPressedState.BorderRadius = 1;
            this.comingSoonMovieSeatReservationBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.comingSoonMovieSeatReservationBtn.OnPressedState.BorderThickness = 1;
            this.comingSoonMovieSeatReservationBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.comingSoonMovieSeatReservationBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.comingSoonMovieSeatReservationBtn.OnPressedState.IconLeftImage = null;
            this.comingSoonMovieSeatReservationBtn.OnPressedState.IconRightImage = null;
            this.comingSoonMovieSeatReservationBtn.Size = new System.Drawing.Size(190, 54);
            this.comingSoonMovieSeatReservationBtn.TabIndex = 61;
            this.comingSoonMovieSeatReservationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.comingSoonMovieSeatReservationBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.comingSoonMovieSeatReservationBtn.TextMarginLeft = 0;
            this.comingSoonMovieSeatReservationBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.comingSoonMovieSeatReservationBtn.UseDefaultRadiusAndThickness = true;
            this.comingSoonMovieSeatReservationBtn.Click += new System.EventHandler(this.comingSoonMovieSeatReservationBtn_Click);
            // 
            // comingSoonPriceDetails
            // 
            this.comingSoonPriceDetails.AutoSize = true;
            this.comingSoonPriceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comingSoonPriceDetails.ForeColor = System.Drawing.Color.White;
            this.comingSoonPriceDetails.Location = new System.Drawing.Point(281, 240);
            this.comingSoonPriceDetails.Name = "comingSoonPriceDetails";
            this.comingSoonPriceDetails.Size = new System.Drawing.Size(112, 46);
            this.comingSoonPriceDetails.TabIndex = 60;
            this.comingSoonPriceDetails.Text = "Price";
            // 
            // bunifuIconButton1
            // 
            this.bunifuIconButton1.AllowAnimations = true;
            this.bunifuIconButton1.AllowBorderColorChanges = true;
            this.bunifuIconButton1.AllowMouseEffects = true;
            this.bunifuIconButton1.AnimationSpeed = 200;
            this.bunifuIconButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuIconButton1.BackgroundImage")));
            this.bunifuIconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuIconButton1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton1.BorderRadius = 1;
            this.bunifuIconButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButton1.BorderThickness = 1;
            this.bunifuIconButton1.ColorContrastOnClick = 30;
            this.bunifuIconButton1.ColorContrastOnHover = 30;
            this.bunifuIconButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges81.BottomLeft = true;
            borderEdges81.BottomRight = true;
            borderEdges81.TopLeft = true;
            borderEdges81.TopRight = true;
            this.bunifuIconButton1.CustomizableEdges = borderEdges81;
            this.bunifuIconButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton1.Image = null;
            this.bunifuIconButton1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButton1.Location = new System.Drawing.Point(286, 334);
            this.bunifuIconButton1.Name = "bunifuIconButton1";
            this.bunifuIconButton1.RoundBorders = true;
            this.bunifuIconButton1.ShowBorders = true;
            this.bunifuIconButton1.Size = new System.Drawing.Size(57, 57);
            this.bunifuIconButton1.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButton1.TabIndex = 59;
            // 
            // comingSoonTitleDetails
            // 
            this.comingSoonTitleDetails.AutoSize = true;
            this.comingSoonTitleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comingSoonTitleDetails.ForeColor = System.Drawing.Color.White;
            this.comingSoonTitleDetails.Location = new System.Drawing.Point(274, 68);
            this.comingSoonTitleDetails.Name = "comingSoonTitleDetails";
            this.comingSoonTitleDetails.Size = new System.Drawing.Size(381, 46);
            this.comingSoonTitleDetails.TabIndex = 58;
            this.comingSoonTitleDetails.Text = "Coming Soon Movie";
            // 
            // comingSoonMoviePicBoxDetails
            // 
            this.comingSoonMoviePicBoxDetails.BackColor = System.Drawing.Color.Blue;
            this.comingSoonMoviePicBoxDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.comingSoonMoviePicBoxDetails.Location = new System.Drawing.Point(46, 68);
            this.comingSoonMoviePicBoxDetails.Name = "comingSoonMoviePicBoxDetails";
            this.comingSoonMoviePicBoxDetails.Size = new System.Drawing.Size(218, 323);
            this.comingSoonMoviePicBoxDetails.TabIndex = 57;
            this.comingSoonMoviePicBoxDetails.TabStop = false;
            // 
            // filmsDetailsPanel
            // 
            this.filmsDetailsPanel.Controls.Add(this.filmsDescriptionDetails);
            this.filmsDetailsPanel.Controls.Add(this.closeFilmsDetailsBtn);
            this.filmsDetailsPanel.Controls.Add(this.filmsMovieSeatReservationBtn);
            this.filmsDetailsPanel.Controls.Add(this.filmsPriceDetails);
            this.filmsDetailsPanel.Controls.Add(this.bunifuIconButton3);
            this.filmsDetailsPanel.Controls.Add(this.filmsTitleDetails);
            this.filmsDetailsPanel.Controls.Add(this.filmsPictureBoxDetails);
            this.filmsDetailsPanel.Location = new System.Drawing.Point(233, 123);
            this.filmsDetailsPanel.Name = "filmsDetailsPanel";
            this.filmsDetailsPanel.Size = new System.Drawing.Size(767, 435);
            this.filmsDetailsPanel.TabIndex = 64;
            this.filmsDetailsPanel.Visible = false;
            // 
            // filmsDescriptionDetails
            // 
            this.filmsDescriptionDetails.AutoSize = true;
            this.filmsDescriptionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmsDescriptionDetails.ForeColor = System.Drawing.Color.White;
            this.filmsDescriptionDetails.Location = new System.Drawing.Point(281, 156);
            this.filmsDescriptionDetails.Name = "filmsDescriptionDetails";
            this.filmsDescriptionDetails.Size = new System.Drawing.Size(135, 29);
            this.filmsDescriptionDetails.TabIndex = 63;
            this.filmsDescriptionDetails.Text = "Description";
            // 
            // closeFilmsDetailsBtn
            // 
            this.closeFilmsDetailsBtn.AllowAnimations = true;
            this.closeFilmsDetailsBtn.AllowBorderColorChanges = true;
            this.closeFilmsDetailsBtn.AllowDefaults = true;
            this.closeFilmsDetailsBtn.AllowMouseEffects = true;
            this.closeFilmsDetailsBtn.AnimationSpeed = 200;
            this.closeFilmsDetailsBtn.AutoSizeCaptions = true;
            this.closeFilmsDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeFilmsDetailsBtn.BackgroundColor = System.Drawing.Color.White;
            this.closeFilmsDetailsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeFilmsDetailsBtn.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.closeFilmsDetailsBtn.BackPressedColor = System.Drawing.Color.Silver;
            this.closeFilmsDetailsBtn.BorderColor = System.Drawing.Color.White;
            this.closeFilmsDetailsBtn.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.closeFilmsDetailsBtn.BorderPressedColor = System.Drawing.Color.White;
            this.closeFilmsDetailsBtn.BorderRadius = 0;
            this.closeFilmsDetailsBtn.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.closeFilmsDetailsBtn.BorderThickness = 0;
            this.closeFilmsDetailsBtn.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            this.closeFilmsDetailsBtn.ColorContrastOnClick = 30;
            this.closeFilmsDetailsBtn.ColorContrastOnHover = 30;
            this.closeFilmsDetailsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges82.BottomLeft = true;
            borderEdges82.BottomRight = true;
            borderEdges82.TopLeft = true;
            borderEdges82.TopRight = true;
            this.closeFilmsDetailsBtn.CustomizableEdges = borderEdges82;
            this.closeFilmsDetailsBtn.DefaultBorderColor = System.Drawing.Color.White;
            this.closeFilmsDetailsBtn.DefaultColor = System.Drawing.Color.White;
            this.closeFilmsDetailsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeFilmsDetailsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.closeFilmsDetailsBtn.IconHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.closeFilmsDetailsBtn.IconPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.closeFilmsDetailsBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeFilmsDetailsBtn.Image")));
            this.closeFilmsDetailsBtn.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.closeFilmsDetailsBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.closeFilmsDetailsBtn.Location = new System.Drawing.Point(720, 11);
            this.closeFilmsDetailsBtn.Name = "closeFilmsDetailsBtn";
            this.closeFilmsDetailsBtn.ShowBorders = false;
            this.closeFilmsDetailsBtn.Size = new System.Drawing.Size(40, 38);
            this.closeFilmsDetailsBtn.TabIndex = 62;
            this.closeFilmsDetailsBtn.Visible = false;
            this.closeFilmsDetailsBtn.Click += new System.EventHandler(this.closeFilmsDetailsBtn_Click_1);
            // 
            // filmsMovieSeatReservationBtn
            // 
            this.filmsMovieSeatReservationBtn.AllowAnimations = true;
            this.filmsMovieSeatReservationBtn.AllowMouseEffects = true;
            this.filmsMovieSeatReservationBtn.AllowToggling = false;
            this.filmsMovieSeatReservationBtn.AnimationSpeed = 200;
            this.filmsMovieSeatReservationBtn.AutoGenerateColors = false;
            this.filmsMovieSeatReservationBtn.AutoRoundBorders = true;
            this.filmsMovieSeatReservationBtn.AutoSizeLeftIcon = true;
            this.filmsMovieSeatReservationBtn.AutoSizeRightIcon = true;
            this.filmsMovieSeatReservationBtn.BackColor = System.Drawing.Color.Transparent;
            this.filmsMovieSeatReservationBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.filmsMovieSeatReservationBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("filmsMovieSeatReservationBtn.BackgroundImage")));
            this.filmsMovieSeatReservationBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.filmsMovieSeatReservationBtn.ButtonText = "RESERVE SEAT";
            this.filmsMovieSeatReservationBtn.ButtonTextMarginLeft = 0;
            this.filmsMovieSeatReservationBtn.ColorContrastOnClick = 45;
            this.filmsMovieSeatReservationBtn.ColorContrastOnHover = 45;
            this.filmsMovieSeatReservationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges83.BottomLeft = true;
            borderEdges83.BottomRight = true;
            borderEdges83.TopLeft = true;
            borderEdges83.TopRight = true;
            this.filmsMovieSeatReservationBtn.CustomizableEdges = borderEdges83;
            this.filmsMovieSeatReservationBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.filmsMovieSeatReservationBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.filmsMovieSeatReservationBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.filmsMovieSeatReservationBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.filmsMovieSeatReservationBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.filmsMovieSeatReservationBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filmsMovieSeatReservationBtn.ForeColor = System.Drawing.Color.White;
            this.filmsMovieSeatReservationBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filmsMovieSeatReservationBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.filmsMovieSeatReservationBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.filmsMovieSeatReservationBtn.IconMarginLeft = 11;
            this.filmsMovieSeatReservationBtn.IconPadding = 10;
            this.filmsMovieSeatReservationBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filmsMovieSeatReservationBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.filmsMovieSeatReservationBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.filmsMovieSeatReservationBtn.IconSize = 25;
            this.filmsMovieSeatReservationBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.filmsMovieSeatReservationBtn.IdleBorderRadius = 52;
            this.filmsMovieSeatReservationBtn.IdleBorderThickness = 1;
            this.filmsMovieSeatReservationBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.filmsMovieSeatReservationBtn.IdleIconLeftImage = null;
            this.filmsMovieSeatReservationBtn.IdleIconRightImage = null;
            this.filmsMovieSeatReservationBtn.IndicateFocus = false;
            this.filmsMovieSeatReservationBtn.Location = new System.Drawing.Point(359, 337);
            this.filmsMovieSeatReservationBtn.Name = "filmsMovieSeatReservationBtn";
            this.filmsMovieSeatReservationBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.filmsMovieSeatReservationBtn.OnDisabledState.BorderRadius = 1;
            this.filmsMovieSeatReservationBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.filmsMovieSeatReservationBtn.OnDisabledState.BorderThickness = 1;
            this.filmsMovieSeatReservationBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.filmsMovieSeatReservationBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.filmsMovieSeatReservationBtn.OnDisabledState.IconLeftImage = null;
            this.filmsMovieSeatReservationBtn.OnDisabledState.IconRightImage = null;
            this.filmsMovieSeatReservationBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.filmsMovieSeatReservationBtn.onHoverState.BorderRadius = 1;
            this.filmsMovieSeatReservationBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.filmsMovieSeatReservationBtn.onHoverState.BorderThickness = 1;
            this.filmsMovieSeatReservationBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.filmsMovieSeatReservationBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.filmsMovieSeatReservationBtn.onHoverState.IconLeftImage = null;
            this.filmsMovieSeatReservationBtn.onHoverState.IconRightImage = null;
            this.filmsMovieSeatReservationBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.filmsMovieSeatReservationBtn.OnIdleState.BorderRadius = 1;
            this.filmsMovieSeatReservationBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.filmsMovieSeatReservationBtn.OnIdleState.BorderThickness = 1;
            this.filmsMovieSeatReservationBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.filmsMovieSeatReservationBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.filmsMovieSeatReservationBtn.OnIdleState.IconLeftImage = null;
            this.filmsMovieSeatReservationBtn.OnIdleState.IconRightImage = null;
            this.filmsMovieSeatReservationBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.filmsMovieSeatReservationBtn.OnPressedState.BorderRadius = 1;
            this.filmsMovieSeatReservationBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.filmsMovieSeatReservationBtn.OnPressedState.BorderThickness = 1;
            this.filmsMovieSeatReservationBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.filmsMovieSeatReservationBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.filmsMovieSeatReservationBtn.OnPressedState.IconLeftImage = null;
            this.filmsMovieSeatReservationBtn.OnPressedState.IconRightImage = null;
            this.filmsMovieSeatReservationBtn.Size = new System.Drawing.Size(190, 54);
            this.filmsMovieSeatReservationBtn.TabIndex = 61;
            this.filmsMovieSeatReservationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filmsMovieSeatReservationBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.filmsMovieSeatReservationBtn.TextMarginLeft = 0;
            this.filmsMovieSeatReservationBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.filmsMovieSeatReservationBtn.UseDefaultRadiusAndThickness = true;
            this.filmsMovieSeatReservationBtn.Click += new System.EventHandler(this.filmsInCinemaSeatReservationBtn_Click);
            // 
            // filmsPriceDetails
            // 
            this.filmsPriceDetails.AutoSize = true;
            this.filmsPriceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmsPriceDetails.ForeColor = System.Drawing.Color.White;
            this.filmsPriceDetails.Location = new System.Drawing.Point(281, 240);
            this.filmsPriceDetails.Name = "filmsPriceDetails";
            this.filmsPriceDetails.Size = new System.Drawing.Size(112, 46);
            this.filmsPriceDetails.TabIndex = 60;
            this.filmsPriceDetails.Text = "Price";
            // 
            // bunifuIconButton3
            // 
            this.bunifuIconButton3.AllowAnimations = true;
            this.bunifuIconButton3.AllowBorderColorChanges = true;
            this.bunifuIconButton3.AllowMouseEffects = true;
            this.bunifuIconButton3.AnimationSpeed = 200;
            this.bunifuIconButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuIconButton3.BackgroundImage")));
            this.bunifuIconButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuIconButton3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton3.BorderRadius = 1;
            this.bunifuIconButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButton3.BorderThickness = 1;
            this.bunifuIconButton3.ColorContrastOnClick = 30;
            this.bunifuIconButton3.ColorContrastOnHover = 30;
            this.bunifuIconButton3.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges84.BottomLeft = true;
            borderEdges84.BottomRight = true;
            borderEdges84.TopLeft = true;
            borderEdges84.TopRight = true;
            this.bunifuIconButton3.CustomizableEdges = borderEdges84;
            this.bunifuIconButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton3.Image = null;
            this.bunifuIconButton3.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButton3.Location = new System.Drawing.Point(286, 334);
            this.bunifuIconButton3.Name = "bunifuIconButton3";
            this.bunifuIconButton3.RoundBorders = true;
            this.bunifuIconButton3.ShowBorders = true;
            this.bunifuIconButton3.Size = new System.Drawing.Size(57, 57);
            this.bunifuIconButton3.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButton3.TabIndex = 59;
            // 
            // filmsTitleDetails
            // 
            this.filmsTitleDetails.AutoSize = true;
            this.filmsTitleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmsTitleDetails.ForeColor = System.Drawing.Color.White;
            this.filmsTitleDetails.Location = new System.Drawing.Point(274, 68);
            this.filmsTitleDetails.Name = "filmsTitleDetails";
            this.filmsTitleDetails.Size = new System.Drawing.Size(212, 46);
            this.filmsTitleDetails.TabIndex = 58;
            this.filmsTitleDetails.Text = "Film Movie";
            // 
            // filmsPictureBoxDetails
            // 
            this.filmsPictureBoxDetails.BackColor = System.Drawing.Color.Blue;
            this.filmsPictureBoxDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filmsPictureBoxDetails.Location = new System.Drawing.Point(46, 68);
            this.filmsPictureBoxDetails.Name = "filmsPictureBoxDetails";
            this.filmsPictureBoxDetails.Size = new System.Drawing.Size(218, 323);
            this.filmsPictureBoxDetails.TabIndex = 57;
            this.filmsPictureBoxDetails.TabStop = false;
            // 
            // foodDetailsPanel
            // 
            this.foodDetailsPanel.Controls.Add(this.closeFoodDetailsBtn);
            this.foodDetailsPanel.Controls.Add(this.snackDealsReservedSeatBtn);
            this.foodDetailsPanel.Controls.Add(this.foodPriceDetails);
            this.foodDetailsPanel.Controls.Add(this.bunifuIconButton4);
            this.foodDetailsPanel.Controls.Add(this.foodNameDetails);
            this.foodDetailsPanel.Controls.Add(this.foodPicDetails);
            this.foodDetailsPanel.Location = new System.Drawing.Point(233, 123);
            this.foodDetailsPanel.Name = "foodDetailsPanel";
            this.foodDetailsPanel.Size = new System.Drawing.Size(770, 435);
            this.foodDetailsPanel.TabIndex = 65;
            this.foodDetailsPanel.Visible = false;
            // 
            // closeFoodDetailsBtn
            // 
            this.closeFoodDetailsBtn.AllowAnimations = true;
            this.closeFoodDetailsBtn.AllowBorderColorChanges = true;
            this.closeFoodDetailsBtn.AllowDefaults = true;
            this.closeFoodDetailsBtn.AllowMouseEffects = true;
            this.closeFoodDetailsBtn.AnimationSpeed = 200;
            this.closeFoodDetailsBtn.AutoSizeCaptions = true;
            this.closeFoodDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeFoodDetailsBtn.BackgroundColor = System.Drawing.Color.White;
            this.closeFoodDetailsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeFoodDetailsBtn.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.closeFoodDetailsBtn.BackPressedColor = System.Drawing.Color.Silver;
            this.closeFoodDetailsBtn.BorderColor = System.Drawing.Color.White;
            this.closeFoodDetailsBtn.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.closeFoodDetailsBtn.BorderPressedColor = System.Drawing.Color.White;
            this.closeFoodDetailsBtn.BorderRadius = 0;
            this.closeFoodDetailsBtn.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.closeFoodDetailsBtn.BorderThickness = 0;
            this.closeFoodDetailsBtn.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            this.closeFoodDetailsBtn.ColorContrastOnClick = 30;
            this.closeFoodDetailsBtn.ColorContrastOnHover = 30;
            this.closeFoodDetailsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges85.BottomLeft = true;
            borderEdges85.BottomRight = true;
            borderEdges85.TopLeft = true;
            borderEdges85.TopRight = true;
            this.closeFoodDetailsBtn.CustomizableEdges = borderEdges85;
            this.closeFoodDetailsBtn.DefaultBorderColor = System.Drawing.Color.White;
            this.closeFoodDetailsBtn.DefaultColor = System.Drawing.Color.White;
            this.closeFoodDetailsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeFoodDetailsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.closeFoodDetailsBtn.IconHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.closeFoodDetailsBtn.IconPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.closeFoodDetailsBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeFoodDetailsBtn.Image")));
            this.closeFoodDetailsBtn.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.closeFoodDetailsBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.closeFoodDetailsBtn.Location = new System.Drawing.Point(720, 11);
            this.closeFoodDetailsBtn.Name = "closeFoodDetailsBtn";
            this.closeFoodDetailsBtn.ShowBorders = false;
            this.closeFoodDetailsBtn.Size = new System.Drawing.Size(40, 38);
            this.closeFoodDetailsBtn.TabIndex = 62;
            this.closeFoodDetailsBtn.Visible = false;
            this.closeFoodDetailsBtn.Click += new System.EventHandler(this.closeFoodDetailsBtn_Click);
            // 
            // snackDealsReservedSeatBtn
            // 
            this.snackDealsReservedSeatBtn.AllowAnimations = true;
            this.snackDealsReservedSeatBtn.AllowMouseEffects = true;
            this.snackDealsReservedSeatBtn.AllowToggling = false;
            this.snackDealsReservedSeatBtn.AnimationSpeed = 200;
            this.snackDealsReservedSeatBtn.AutoGenerateColors = false;
            this.snackDealsReservedSeatBtn.AutoRoundBorders = true;
            this.snackDealsReservedSeatBtn.AutoSizeLeftIcon = true;
            this.snackDealsReservedSeatBtn.AutoSizeRightIcon = true;
            this.snackDealsReservedSeatBtn.BackColor = System.Drawing.Color.Transparent;
            this.snackDealsReservedSeatBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.snackDealsReservedSeatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("snackDealsReservedSeatBtn.BackgroundImage")));
            this.snackDealsReservedSeatBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.snackDealsReservedSeatBtn.ButtonText = "RESERVE SEAT";
            this.snackDealsReservedSeatBtn.ButtonTextMarginLeft = 0;
            this.snackDealsReservedSeatBtn.ColorContrastOnClick = 45;
            this.snackDealsReservedSeatBtn.ColorContrastOnHover = 45;
            this.snackDealsReservedSeatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges86.BottomLeft = true;
            borderEdges86.BottomRight = true;
            borderEdges86.TopLeft = true;
            borderEdges86.TopRight = true;
            this.snackDealsReservedSeatBtn.CustomizableEdges = borderEdges86;
            this.snackDealsReservedSeatBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.snackDealsReservedSeatBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.snackDealsReservedSeatBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.snackDealsReservedSeatBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.snackDealsReservedSeatBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.snackDealsReservedSeatBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.snackDealsReservedSeatBtn.ForeColor = System.Drawing.Color.White;
            this.snackDealsReservedSeatBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.snackDealsReservedSeatBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.snackDealsReservedSeatBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.snackDealsReservedSeatBtn.IconMarginLeft = 11;
            this.snackDealsReservedSeatBtn.IconPadding = 10;
            this.snackDealsReservedSeatBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.snackDealsReservedSeatBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.snackDealsReservedSeatBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.snackDealsReservedSeatBtn.IconSize = 25;
            this.snackDealsReservedSeatBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.snackDealsReservedSeatBtn.IdleBorderRadius = 52;
            this.snackDealsReservedSeatBtn.IdleBorderThickness = 1;
            this.snackDealsReservedSeatBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.snackDealsReservedSeatBtn.IdleIconLeftImage = null;
            this.snackDealsReservedSeatBtn.IdleIconRightImage = null;
            this.snackDealsReservedSeatBtn.IndicateFocus = false;
            this.snackDealsReservedSeatBtn.Location = new System.Drawing.Point(540, 240);
            this.snackDealsReservedSeatBtn.Name = "snackDealsReservedSeatBtn";
            this.snackDealsReservedSeatBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.snackDealsReservedSeatBtn.OnDisabledState.BorderRadius = 1;
            this.snackDealsReservedSeatBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.snackDealsReservedSeatBtn.OnDisabledState.BorderThickness = 1;
            this.snackDealsReservedSeatBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.snackDealsReservedSeatBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.snackDealsReservedSeatBtn.OnDisabledState.IconLeftImage = null;
            this.snackDealsReservedSeatBtn.OnDisabledState.IconRightImage = null;
            this.snackDealsReservedSeatBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.snackDealsReservedSeatBtn.onHoverState.BorderRadius = 1;
            this.snackDealsReservedSeatBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.snackDealsReservedSeatBtn.onHoverState.BorderThickness = 1;
            this.snackDealsReservedSeatBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.snackDealsReservedSeatBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.snackDealsReservedSeatBtn.onHoverState.IconLeftImage = null;
            this.snackDealsReservedSeatBtn.onHoverState.IconRightImage = null;
            this.snackDealsReservedSeatBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.snackDealsReservedSeatBtn.OnIdleState.BorderRadius = 1;
            this.snackDealsReservedSeatBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.snackDealsReservedSeatBtn.OnIdleState.BorderThickness = 1;
            this.snackDealsReservedSeatBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.snackDealsReservedSeatBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.snackDealsReservedSeatBtn.OnIdleState.IconLeftImage = null;
            this.snackDealsReservedSeatBtn.OnIdleState.IconRightImage = null;
            this.snackDealsReservedSeatBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.snackDealsReservedSeatBtn.OnPressedState.BorderRadius = 1;
            this.snackDealsReservedSeatBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.snackDealsReservedSeatBtn.OnPressedState.BorderThickness = 1;
            this.snackDealsReservedSeatBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.snackDealsReservedSeatBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.snackDealsReservedSeatBtn.OnPressedState.IconLeftImage = null;
            this.snackDealsReservedSeatBtn.OnPressedState.IconRightImage = null;
            this.snackDealsReservedSeatBtn.Size = new System.Drawing.Size(190, 54);
            this.snackDealsReservedSeatBtn.TabIndex = 61;
            this.snackDealsReservedSeatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.snackDealsReservedSeatBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.snackDealsReservedSeatBtn.TextMarginLeft = 0;
            this.snackDealsReservedSeatBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.snackDealsReservedSeatBtn.UseDefaultRadiusAndThickness = true;
            this.snackDealsReservedSeatBtn.Click += new System.EventHandler(this.snackDealsReservedSeatBtn_Click);
            // 
            // foodPriceDetails
            // 
            this.foodPriceDetails.AutoSize = true;
            this.foodPriceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodPriceDetails.ForeColor = System.Drawing.Color.White;
            this.foodPriceDetails.Location = new System.Drawing.Point(19, 368);
            this.foodPriceDetails.Name = "foodPriceDetails";
            this.foodPriceDetails.Size = new System.Drawing.Size(112, 46);
            this.foodPriceDetails.TabIndex = 60;
            this.foodPriceDetails.Text = "Price";
            // 
            // bunifuIconButton4
            // 
            this.bunifuIconButton4.AllowAnimations = true;
            this.bunifuIconButton4.AllowBorderColorChanges = true;
            this.bunifuIconButton4.AllowMouseEffects = true;
            this.bunifuIconButton4.AnimationSpeed = 200;
            this.bunifuIconButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton4.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuIconButton4.BackgroundImage")));
            this.bunifuIconButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuIconButton4.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton4.BorderRadius = 1;
            this.bunifuIconButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButton4.BorderThickness = 1;
            this.bunifuIconButton4.ColorContrastOnClick = 30;
            this.bunifuIconButton4.ColorContrastOnHover = 30;
            this.bunifuIconButton4.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges87.BottomLeft = true;
            borderEdges87.BottomRight = true;
            borderEdges87.TopLeft = true;
            borderEdges87.TopRight = true;
            this.bunifuIconButton4.CustomizableEdges = borderEdges87;
            this.bunifuIconButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton4.Image = null;
            this.bunifuIconButton4.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButton4.Location = new System.Drawing.Point(540, 177);
            this.bunifuIconButton4.Name = "bunifuIconButton4";
            this.bunifuIconButton4.RoundBorders = true;
            this.bunifuIconButton4.ShowBorders = true;
            this.bunifuIconButton4.Size = new System.Drawing.Size(57, 57);
            this.bunifuIconButton4.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButton4.TabIndex = 59;
            // 
            // foodNameDetails
            // 
            this.foodNameDetails.AutoSize = true;
            this.foodNameDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameDetails.ForeColor = System.Drawing.Color.White;
            this.foodNameDetails.Location = new System.Drawing.Point(19, 304);
            this.foodNameDetails.Name = "foodNameDetails";
            this.foodNameDetails.Size = new System.Drawing.Size(245, 46);
            this.foodNameDetails.TabIndex = 58;
            this.foodNameDetails.Text = "Snack Deals";
            // 
            // foodPicDetails
            // 
            this.foodPicDetails.BackColor = System.Drawing.Color.Blue;
            this.foodPicDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodPicDetails.Location = new System.Drawing.Point(21, 17);
            this.foodPicDetails.Name = "foodPicDetails";
            this.foodPicDetails.Size = new System.Drawing.Size(491, 277);
            this.foodPicDetails.TabIndex = 57;
            this.foodPicDetails.TabStop = false;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.exisSearchBtn);
            this.bunifuPanel1.Controls.Add(this.userNameHolder);
            this.bunifuPanel1.Controls.Add(this.searchInput);
            this.bunifuPanel1.Controls.Add(this.logoBefore);
            this.bunifuPanel1.Controls.Add(this.searchBtnBefore);
            this.bunifuPanel1.Controls.Add(this.logoAfter);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(101, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1101, 79);
            this.bunifuPanel1.TabIndex = 41;
            // 
            // exisSearchBtn
            // 
            this.exisSearchBtn.AllowAnimations = true;
            this.exisSearchBtn.AllowBorderColorChanges = true;
            this.exisSearchBtn.AllowDefaults = true;
            this.exisSearchBtn.AllowMouseEffects = true;
            this.exisSearchBtn.AnimationSpeed = 200;
            this.exisSearchBtn.AutoSizeCaptions = true;
            this.exisSearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.exisSearchBtn.BackgroundColor = System.Drawing.Color.White;
            this.exisSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exisSearchBtn.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.exisSearchBtn.BackPressedColor = System.Drawing.Color.Silver;
            this.exisSearchBtn.BorderColor = System.Drawing.Color.White;
            this.exisSearchBtn.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.exisSearchBtn.BorderPressedColor = System.Drawing.Color.White;
            this.exisSearchBtn.BorderRadius = 0;
            this.exisSearchBtn.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.exisSearchBtn.BorderThickness = 0;
            this.exisSearchBtn.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            this.exisSearchBtn.ColorContrastOnClick = 30;
            this.exisSearchBtn.ColorContrastOnHover = 30;
            this.exisSearchBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges88.BottomLeft = true;
            borderEdges88.BottomRight = true;
            borderEdges88.TopLeft = true;
            borderEdges88.TopRight = true;
            this.exisSearchBtn.CustomizableEdges = borderEdges88;
            this.exisSearchBtn.DefaultBorderColor = System.Drawing.Color.White;
            this.exisSearchBtn.DefaultColor = System.Drawing.Color.White;
            this.exisSearchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exisSearchBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.exisSearchBtn.IconHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.exisSearchBtn.IconPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.exisSearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("exisSearchBtn.Image")));
            this.exisSearchBtn.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.exisSearchBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.exisSearchBtn.Location = new System.Drawing.Point(920, 20);
            this.exisSearchBtn.Name = "exisSearchBtn";
            this.exisSearchBtn.ShowBorders = false;
            this.exisSearchBtn.Size = new System.Drawing.Size(40, 38);
            this.exisSearchBtn.TabIndex = 49;
            this.exisSearchBtn.Visible = false;
            this.exisSearchBtn.Click += new System.EventHandler(this.exisSearchBtn_Click);
            // 
            // userNameHolder
            // 
            this.userNameHolder.AllowAnimations = true;
            this.userNameHolder.AllowMouseEffects = true;
            this.userNameHolder.AllowToggling = false;
            this.userNameHolder.AnimationSpeed = 200;
            this.userNameHolder.AutoGenerateColors = false;
            this.userNameHolder.AutoRoundBorders = true;
            this.userNameHolder.AutoSizeLeftIcon = true;
            this.userNameHolder.AutoSizeRightIcon = true;
            this.userNameHolder.BackColor = System.Drawing.Color.Transparent;
            this.userNameHolder.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.userNameHolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userNameHolder.BackgroundImage")));
            this.userNameHolder.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.userNameHolder.ButtonText = "MM";
            this.userNameHolder.ButtonTextMarginLeft = 0;
            this.userNameHolder.ColorContrastOnClick = 45;
            this.userNameHolder.ColorContrastOnHover = 45;
            this.userNameHolder.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges89.BottomLeft = true;
            borderEdges89.BottomRight = true;
            borderEdges89.TopLeft = true;
            borderEdges89.TopRight = true;
            this.userNameHolder.CustomizableEdges = borderEdges89;
            this.userNameHolder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.userNameHolder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.userNameHolder.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.userNameHolder.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.userNameHolder.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.userNameHolder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userNameHolder.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userNameHolder.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.userNameHolder.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.userNameHolder.IconMarginLeft = 11;
            this.userNameHolder.IconPadding = 10;
            this.userNameHolder.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userNameHolder.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.userNameHolder.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.userNameHolder.IconSize = 25;
            this.userNameHolder.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.userNameHolder.IdleBorderRadius = 55;
            this.userNameHolder.IdleBorderThickness = 1;
            this.userNameHolder.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.userNameHolder.IdleIconLeftImage = null;
            this.userNameHolder.IdleIconRightImage = null;
            this.userNameHolder.IndicateFocus = false;
            this.userNameHolder.Location = new System.Drawing.Point(977, 12);
            this.userNameHolder.Name = "userNameHolder";
            this.userNameHolder.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.userNameHolder.OnDisabledState.BorderRadius = 50;
            this.userNameHolder.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.userNameHolder.OnDisabledState.BorderThickness = 1;
            this.userNameHolder.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.userNameHolder.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.userNameHolder.OnDisabledState.IconLeftImage = null;
            this.userNameHolder.OnDisabledState.IconRightImage = null;
            this.userNameHolder.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.userNameHolder.onHoverState.BorderRadius = 50;
            this.userNameHolder.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.userNameHolder.onHoverState.BorderThickness = 1;
            this.userNameHolder.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.userNameHolder.onHoverState.ForeColor = System.Drawing.Color.White;
            this.userNameHolder.onHoverState.IconLeftImage = null;
            this.userNameHolder.onHoverState.IconRightImage = null;
            this.userNameHolder.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.userNameHolder.OnIdleState.BorderRadius = 50;
            this.userNameHolder.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.userNameHolder.OnIdleState.BorderThickness = 1;
            this.userNameHolder.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.userNameHolder.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userNameHolder.OnIdleState.IconLeftImage = null;
            this.userNameHolder.OnIdleState.IconRightImage = null;
            this.userNameHolder.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.userNameHolder.OnPressedState.BorderRadius = 50;
            this.userNameHolder.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.userNameHolder.OnPressedState.BorderThickness = 1;
            this.userNameHolder.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.userNameHolder.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.userNameHolder.OnPressedState.IconLeftImage = null;
            this.userNameHolder.OnPressedState.IconRightImage = null;
            this.userNameHolder.Size = new System.Drawing.Size(57, 57);
            this.userNameHolder.TabIndex = 43;
            this.userNameHolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userNameHolder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNameHolder.TextMarginLeft = 0;
            this.userNameHolder.TextPadding = new System.Windows.Forms.Padding(0);
            this.userNameHolder.UseDefaultRadiusAndThickness = true;
            // 
            // searchInput
            // 
            this.searchInput.AcceptsReturn = false;
            this.searchInput.AcceptsTab = false;
            this.searchInput.AnimationSpeed = 200;
            this.searchInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchInput.AutoSizeHeight = true;
            this.searchInput.BackColor = System.Drawing.Color.Transparent;
            this.searchInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchInput.BackgroundImage")));
            this.searchInput.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.searchInput.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchInput.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.searchInput.BorderRadius = 37;
            this.searchInput.BorderThickness = 2;
            this.searchInput.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.searchInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchInput.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.DefaultText = "";
            this.searchInput.FillColor = System.Drawing.Color.White;
            this.searchInput.HideSelection = true;
            this.searchInput.IconLeft = global::MovieMunch.Properties.Resources.SearchBtn;
            this.searchInput.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchInput.IconPadding = 4;
            this.searchInput.IconRight = null;
            this.searchInput.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchInput.Lines = new string[0];
            this.searchInput.Location = new System.Drawing.Point(460, 12);
            this.searchInput.MaxLength = 32767;
            this.searchInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchInput.Modified = false;
            this.searchInput.Multiline = false;
            this.searchInput.Name = "searchInput";
            stateProperties17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchInput.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchInput.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchInput.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchInput.OnIdleState = stateProperties20;
            this.searchInput.Padding = new System.Windows.Forms.Padding(3);
            this.searchInput.PasswordChar = '\0';
            this.searchInput.PlaceholderForeColor = System.Drawing.Color.Black;
            this.searchInput.PlaceholderText = "SEARCH";
            this.searchInput.ReadOnly = false;
            this.searchInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchInput.SelectedText = "";
            this.searchInput.SelectionLength = 0;
            this.searchInput.SelectionStart = 0;
            this.searchInput.ShortcutsEnabled = true;
            this.searchInput.Size = new System.Drawing.Size(511, 57);
            this.searchInput.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchInput.TabIndex = 48;
            this.searchInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchInput.TextMarginBottom = 0;
            this.searchInput.TextMarginLeft = 3;
            this.searchInput.TextMarginTop = 0;
            this.searchInput.TextPlaceholder = "SEARCH";
            this.searchInput.UseSystemPasswordChar = false;
            this.searchInput.Visible = false;
            this.searchInput.WordWrap = true;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged_1);
            // 
            // logoBefore
            // 
            this.logoBefore.BackColor = System.Drawing.Color.Transparent;
            this.logoBefore.BackgroundImage = global::MovieMunch.Properties.Resources.MovieM_removebg_preview;
            this.logoBefore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoBefore.Location = new System.Drawing.Point(719, -18);
            this.logoBefore.Name = "logoBefore";
            this.logoBefore.Size = new System.Drawing.Size(195, 135);
            this.logoBefore.TabIndex = 42;
            this.logoBefore.TabStop = false;
            // 
            // searchBtnBefore
            // 
            this.searchBtnBefore.AllowAnimations = true;
            this.searchBtnBefore.AllowBorderColorChanges = true;
            this.searchBtnBefore.AllowMouseEffects = true;
            this.searchBtnBefore.AnimationSpeed = 200;
            this.searchBtnBefore.BackColor = System.Drawing.Color.Transparent;
            this.searchBtnBefore.BackgroundColor = System.Drawing.Color.Transparent;
            this.searchBtnBefore.BackgroundImage = global::MovieMunch.Properties.Resources.SearchBtn;
            this.searchBtnBefore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtnBefore.BorderColor = System.Drawing.Color.Transparent;
            this.searchBtnBefore.BorderRadius = 1;
            this.searchBtnBefore.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.searchBtnBefore.BorderThickness = 1;
            this.searchBtnBefore.ColorContrastOnClick = 30;
            this.searchBtnBefore.ColorContrastOnHover = 30;
            this.searchBtnBefore.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges90.BottomLeft = true;
            borderEdges90.BottomRight = true;
            borderEdges90.TopLeft = true;
            borderEdges90.TopRight = true;
            this.searchBtnBefore.CustomizableEdges = borderEdges90;
            this.searchBtnBefore.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchBtnBefore.Image = null;
            this.searchBtnBefore.ImageMargin = new System.Windows.Forms.Padding(0);
            this.searchBtnBefore.Location = new System.Drawing.Point(914, 12);
            this.searchBtnBefore.Name = "searchBtnBefore";
            this.searchBtnBefore.RoundBorders = true;
            this.searchBtnBefore.ShowBorders = true;
            this.searchBtnBefore.Size = new System.Drawing.Size(57, 57);
            this.searchBtnBefore.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.searchBtnBefore.TabIndex = 44;
            this.searchBtnBefore.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // logoAfter
            // 
            this.logoAfter.BackColor = System.Drawing.Color.Transparent;
            this.logoAfter.BackgroundImage = global::MovieMunch.Properties.Resources.MovieM_removebg_preview;
            this.logoAfter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoAfter.Location = new System.Drawing.Point(282, -18);
            this.logoAfter.Name = "logoAfter";
            this.logoAfter.Size = new System.Drawing.Size(195, 135);
            this.logoAfter.TabIndex = 46;
            this.logoAfter.TabStop = false;
            this.logoAfter.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 650);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.foodDetailsPanel);
            this.Controls.Add(this.filmsDetailsPanel);
            this.Controls.Add(this.comingSoonMovieDetailsPanel);
            this.Controls.Add(this.trendingMoviesDetailsPanel);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchResultFlowWholePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.filmsInCinemaPanel.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.yummyFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fourthCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCircle)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ComingSoonFlowLayoutPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.FilmsInCinemaFlowLayout.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.userPanel.ResumeLayout(false);
            this.searchResultFlowWholePanel.ResumeLayout(false);
            this.trendingMoviesDetailsPanel.ResumeLayout(false);
            this.trendingMoviesDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trendingDetailsPictureBox)).EndInit();
            this.comingSoonMovieDetailsPanel.ResumeLayout(false);
            this.comingSoonMovieDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comingSoonMoviePicBoxDetails)).EndInit();
            this.filmsDetailsPanel.ResumeLayout(false);
            this.filmsDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsPictureBoxDetails)).EndInit();
            this.foodDetailsPanel.ResumeLayout(false);
            this.foodDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicDetails)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Panel panel2;
        private Button SettingBtn;
        private Button FavBtn;
        private PictureBox fourthCircle;
        private PictureBox thirdCircle;
        private PictureBox secondCircle;
        private PictureBox firstCircle;
        private Button TicketBtn;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private PictureBox logoBefore;
        private Timer timer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel filmsInCinemaPanel;
        private Panel panel5;
        private Label label1;
        private FlowLayoutPanel ComingSoonFlowLayoutPanel;
        private Panel soon1;
        private Panel soon2;
        private Panel soon3;
        private Panel soon4;
        private Panel soon5;
        private Panel soon6;
        private Panel soon7;
        private Panel soon8;
        private Panel panel3;
        private Label label2;
        private Panel panel13;
        private Label label4;
        private FlowLayoutPanel FilmsInCinemaFlowLayout;
        private Panel films1;
        private Panel films2;
        private Panel films3;
        private Panel films4;
        private Panel films5;
        private Panel films6;
        private Panel films7;
        private Panel films8;
        private Panel panel4;
        private Label label3;
        private PictureBox pictureBoxRight;
        private PictureBox pictureBoxLeft;
        private PictureBox pictureBoxMain;
       
        private FlowLayoutPanel FilmsInCinemaFlowLayouPanel;
        private Panel panel1;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel12;
        private Panel panel11;
        private Panel panel10;
        private Button reservedBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 userNameHolder;
        private Panel userPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 LoginBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 SignUpBtn;
        private Timer smothFromLeftToRightTransition;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 LogoutBtn;
        private Panel food1;
        private Panel food2;
        private Panel food3;
        private FlowLayoutPanel yummyFlowLayoutPanel;
        private Panel yummy1;
        private Panel yummy2;
        private Panel yummy3;
        private Button HomeBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton searchBtnBefore;
        private PictureBox logoAfter;
        private Bunifu.UI.WinForms.BunifuTextBox searchInput;
        private FlowLayoutPanel searchResultsFlowLayoutPanel;
        private Panel searchResultFlowWholePanel;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton exisSearchBtn;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Panel trendingMoviesDetailsPanel;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton closeTrendingMoviesDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 trendingMovieSeatReservationBtn;
        private Label trendingMoviePriceDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton2;
        private Label trendingMovieTitleDetails;
        private PictureBox trendingDetailsPictureBox;
        private Panel comingSoonMovieDetailsPanel;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton closeComingSoonMovieDetailsBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 comingSoonMovieSeatReservationBtn;
        private Label comingSoonPriceDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton1;
        private Label comingSoonTitleDetails;
        private PictureBox comingSoonMoviePicBoxDetails;
        private Label comingSoonMovieDescriptionDetails;
        private Label trendingDescriptionDetails;
        private Panel filmsDetailsPanel;
        private Label filmsDescriptionDetails;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton closeFilmsDetailsBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 filmsMovieSeatReservationBtn;
        private Label filmsPriceDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton3;
        private Label filmsTitleDetails;
        private PictureBox filmsPictureBoxDetails;
        private Panel foodDetailsPanel;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton closeFoodDetailsBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 snackDealsReservedSeatBtn;
        private Label foodPriceDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton4;
        private Label foodNameDetails;
        private PictureBox foodPicDetails;
        private Guna.UI2.WinForms.Guna2Button reserveSeatBtn;
        private Guna.UI2.WinForms.Guna2CircleButton LeftTurnBtn;
        private Guna.UI2.WinForms.Guna2CircleButton rightTurnBtn;
    }
}

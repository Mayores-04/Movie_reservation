
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
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges18 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges19 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges20 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges22 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges23 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges24 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges25 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges26 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges27 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges28 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges29 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges30 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges31 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges32 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges33 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges34 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.filmsInCinemaPanel = new System.Windows.Forms.Panel();
            this.snacksFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.snack1 = new System.Windows.Forms.Panel();
            this.snack2 = new System.Windows.Forms.Panel();
            this.snack3 = new System.Windows.Forms.Panel();
            this.snack4 = new System.Windows.Forms.Panel();
            this.snack5 = new System.Windows.Forms.Panel();
            this.LeftTurnBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rightTurnBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.reserveSeatBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.yummyFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.yummy1 = new System.Windows.Forms.Panel();
            this.yummy2 = new System.Windows.Forms.Panel();
            this.yummy3 = new System.Windows.Forms.Panel();
            this.yummy4 = new System.Windows.Forms.Panel();
            this.yummy5 = new System.Windows.Forms.Panel();
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
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuFormCaptionButton1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.bunifuIconButton5 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.SignUpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changePicBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.prevPasswordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.userProfileCustomHolder = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.saveUserNameOrPasswordBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.changeConfirmNewPasswordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.changePasswordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.changePrevEmailInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveUserPicOrNameBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.changeNewUsernameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.smothFromLeftToRightTransition = new System.Windows.Forms.Timer(this.components);
            this.searchResultsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchResultFlowWholePanel = new System.Windows.Forms.Panel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.trendingMoviesDetailsPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.trendingDescriptionDetails = new System.Windows.Forms.RichTextBox();
            this.closeTrendingMoviesDetails = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.trendingMovieSeatReservationBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.trendingMoviePriceDetails = new System.Windows.Forms.Label();
            this.addTrendingToWatchLaterBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.trendingMovieTitleDetails = new System.Windows.Forms.Label();
            this.trendingDetailsPictureBox = new System.Windows.Forms.PictureBox();
            this.comingSoonMovieDetailsPanel = new System.Windows.Forms.Panel();
            this.comingSoonMovieDescriptionDetails = new System.Windows.Forms.Label();
            this.closeComingSoonMovieDetailsBtn = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.comingSoonMovieSeatReservationBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.comingSoonPriceDetails = new System.Windows.Forms.Label();
            this.addComingSoonToWatchLater = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.comingSoonTitleDetails = new System.Windows.Forms.Label();
            this.comingSoonMoviePicBoxDetails = new System.Windows.Forms.PictureBox();
            this.filmsDetailsPanel = new System.Windows.Forms.Panel();
            this.filmsDescriptionDetails = new System.Windows.Forms.RichTextBox();
            this.closeFilmsDetailsBtn = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.filmsMovieSeatReservationBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.filmsPriceDetails = new System.Windows.Forms.Label();
            this.addFilmMovieToWatchLaterBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.filmsTitleDetails = new System.Windows.Forms.Label();
            this.filmsPictureBoxDetails = new System.Windows.Forms.PictureBox();
            this.foodDetailsPanel = new System.Windows.Forms.Panel();
            this.closeFoodDetailsBtn = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.snackDealsReservedSeatBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.foodPriceDetails = new System.Windows.Forms.Label();
            this.foodNameDetails = new System.Windows.Forms.Label();
            this.foodPicDetails = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.logoBefore = new System.Windows.Forms.PictureBox();
            this.exisSearchBtn = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.searchInput = new Bunifu.UI.WinForms.BunifuTextBox();
            this.searchBtnBefore = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.userProfileBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LogoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.gotoWatchListBtn = new Guna.UI2.WinForms.Guna2Button();
            this.gotoTicketFormBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userNameHolder = new Guna.UI2.WinForms.Guna2TextBox();
            this.SettingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.exitApplicationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.filmsInCinemaPanel.SuspendLayout();
            this.snacksFlowLayoutPanel.SuspendLayout();
            this.panel18.SuspendLayout();
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
            this.bunifuPanel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileCustomHolder)).BeginInit();
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
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBefore)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.flowLayoutPanel1.Controls.Add(this.filmsInCinemaPanel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(157, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1053, 599);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // filmsInCinemaPanel
            // 
            this.filmsInCinemaPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.filmsInCinemaPanel.BackColor = System.Drawing.Color.Transparent;
            this.filmsInCinemaPanel.Controls.Add(this.snacksFlowLayoutPanel);
            this.filmsInCinemaPanel.Controls.Add(this.LeftTurnBtn);
            this.filmsInCinemaPanel.Controls.Add(this.panel18);
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
            this.filmsInCinemaPanel.Size = new System.Drawing.Size(1029, 2150);
            this.filmsInCinemaPanel.TabIndex = 0;
            // 
            // snacksFlowLayoutPanel
            // 
            this.snacksFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.snacksFlowLayoutPanel.AutoScroll = true;
            this.snacksFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.snacksFlowLayoutPanel.Controls.Add(this.snack1);
            this.snacksFlowLayoutPanel.Controls.Add(this.snack2);
            this.snacksFlowLayoutPanel.Controls.Add(this.snack3);
            this.snacksFlowLayoutPanel.Controls.Add(this.snack4);
            this.snacksFlowLayoutPanel.Controls.Add(this.snack5);
            this.snacksFlowLayoutPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snacksFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.snacksFlowLayoutPanel.Location = new System.Drawing.Point(-3, 1707);
            this.snacksFlowLayoutPanel.MinimumSize = new System.Drawing.Size(150, 250);
            this.snacksFlowLayoutPanel.Name = "snacksFlowLayoutPanel";
            this.snacksFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 20, 8, 10);
            this.snacksFlowLayoutPanel.Size = new System.Drawing.Size(1032, 446);
            this.snacksFlowLayoutPanel.TabIndex = 46;
            this.snacksFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.snacksFlowLayoutPanel_Paint);
            // 
            // snack1
            // 
            this.snack1.BackColor = System.Drawing.Color.Transparent;
            this.snack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snack1.Location = new System.Drawing.Point(25, 25);
            this.snack1.Margin = new System.Windows.Forms.Padding(25, 5, 20, 5);
            this.snack1.MinimumSize = new System.Drawing.Size(150, 250);
            this.snack1.Name = "snack1";
            this.snack1.Size = new System.Drawing.Size(560, 323);
            this.snack1.TabIndex = 3;
            // 
            // snack2
            // 
            this.snack2.BackColor = System.Drawing.Color.Transparent;
            this.snack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snack2.Location = new System.Drawing.Point(605, 25);
            this.snack2.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.snack2.MinimumSize = new System.Drawing.Size(150, 250);
            this.snack2.Name = "snack2";
            this.snack2.Size = new System.Drawing.Size(560, 323);
            this.snack2.TabIndex = 3;
            // 
            // snack3
            // 
            this.snack3.BackColor = System.Drawing.Color.Transparent;
            this.snack3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snack3.Location = new System.Drawing.Point(1185, 25);
            this.snack3.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.snack3.MinimumSize = new System.Drawing.Size(150, 250);
            this.snack3.Name = "snack3";
            this.snack3.Size = new System.Drawing.Size(560, 323);
            this.snack3.TabIndex = 3;
            // 
            // snack4
            // 
            this.snack4.BackColor = System.Drawing.Color.Transparent;
            this.snack4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snack4.Location = new System.Drawing.Point(1780, 25);
            this.snack4.Margin = new System.Windows.Forms.Padding(25, 5, 20, 5);
            this.snack4.MinimumSize = new System.Drawing.Size(150, 250);
            this.snack4.Name = "snack4";
            this.snack4.Size = new System.Drawing.Size(560, 323);
            this.snack4.TabIndex = 4;
            // 
            // snack5
            // 
            this.snack5.BackColor = System.Drawing.Color.Transparent;
            this.snack5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snack5.Location = new System.Drawing.Point(2385, 25);
            this.snack5.Margin = new System.Windows.Forms.Padding(25, 5, 20, 5);
            this.snack5.MinimumSize = new System.Drawing.Size(150, 250);
            this.snack5.Name = "snack5";
            this.snack5.Size = new System.Drawing.Size(560, 323);
            this.snack5.TabIndex = 4;
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
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.label5);
            this.panel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel18.Location = new System.Drawing.Point(-33, 1665);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1130, 46);
            this.panel18.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(413, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "SNACKS DEALS";
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
            this.yummyFlowLayoutPanel.Controls.Add(this.yummy4);
            this.yummyFlowLayoutPanel.Controls.Add(this.yummy5);
            this.yummyFlowLayoutPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yummyFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.yummyFlowLayoutPanel.Location = new System.Drawing.Point(-3, 1289);
            this.yummyFlowLayoutPanel.MinimumSize = new System.Drawing.Size(150, 250);
            this.yummyFlowLayoutPanel.Name = "yummyFlowLayoutPanel";
            this.yummyFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 20, 8, 10);
            this.yummyFlowLayoutPanel.Size = new System.Drawing.Size(1029, 403);
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
            // yummy4
            // 
            this.yummy4.BackColor = System.Drawing.Color.Transparent;
            this.yummy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yummy4.Location = new System.Drawing.Point(1780, 25);
            this.yummy4.Margin = new System.Windows.Forms.Padding(25, 5, 20, 5);
            this.yummy4.MinimumSize = new System.Drawing.Size(150, 250);
            this.yummy4.Name = "yummy4";
            this.yummy4.Size = new System.Drawing.Size(560, 323);
            this.yummy4.TabIndex = 4;
            // 
            // yummy5
            // 
            this.yummy5.BackColor = System.Drawing.Color.Transparent;
            this.yummy5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yummy5.Location = new System.Drawing.Point(2385, 25);
            this.yummy5.Margin = new System.Windows.Forms.Padding(25, 5, 20, 5);
            this.yummy5.MinimumSize = new System.Drawing.Size(150, 250);
            this.yummy5.Name = "yummy5";
            this.yummy5.Size = new System.Drawing.Size(560, 323);
            this.yummy5.TabIndex = 4;
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
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGULAR DEALS";
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
            this.ComingSoonFlowLayoutPanel.Size = new System.Drawing.Size(1032, 348);
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
            this.FilmsInCinemaFlowLayout.Size = new System.Drawing.Size(1029, 336);
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
            this.userPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.userPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userPanel.Controls.Add(this.bunifuPanel2);
            this.userPanel.Controls.Add(this.bunifuPanel3);
            this.userPanel.Controls.Add(this.flowLayoutPanel2);
            this.userPanel.Location = new System.Drawing.Point(200, 97);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(957, 429);
            this.userPanel.TabIndex = 43;
            this.userPanel.Visible = false;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(29)))));
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 2;
            this.bunifuPanel2.Controls.Add(this.exitApplicationBtn);
            this.bunifuPanel2.Controls.Add(this.bunifuFormCaptionButton1);
            this.bunifuPanel2.Controls.Add(this.bunifuIconButton5);
            this.bunifuPanel2.Controls.Add(this.guna2Panel3);
            this.bunifuPanel2.Location = new System.Drawing.Point(-5, -3);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(970, 80);
            this.bunifuPanel2.TabIndex = 42;
            // 
            // bunifuFormCaptionButton1
            // 
            this.bunifuFormCaptionButton1.AllowAnimations = true;
            this.bunifuFormCaptionButton1.AllowBorderColorChanges = true;
            this.bunifuFormCaptionButton1.AllowDefaults = true;
            this.bunifuFormCaptionButton1.AllowMouseEffects = true;
            this.bunifuFormCaptionButton1.AnimationSpeed = 200;
            this.bunifuFormCaptionButton1.AutoSizeCaptions = true;
            this.bunifuFormCaptionButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuFormCaptionButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFormCaptionButton1.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.bunifuFormCaptionButton1.BackPressedColor = System.Drawing.Color.Silver;
            this.bunifuFormCaptionButton1.BorderColor = System.Drawing.Color.White;
            this.bunifuFormCaptionButton1.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.bunifuFormCaptionButton1.BorderPressedColor = System.Drawing.Color.White;
            this.bunifuFormCaptionButton1.BorderRadius = 0;
            this.bunifuFormCaptionButton1.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.bunifuFormCaptionButton1.BorderThickness = 0;
            this.bunifuFormCaptionButton1.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            this.bunifuFormCaptionButton1.ColorContrastOnClick = 30;
            this.bunifuFormCaptionButton1.ColorContrastOnHover = 30;
            this.bunifuFormCaptionButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges18.BottomLeft = true;
            borderEdges18.BottomRight = true;
            borderEdges18.TopLeft = true;
            borderEdges18.TopRight = true;
            this.bunifuFormCaptionButton1.CustomizableEdges = borderEdges18;
            this.bunifuFormCaptionButton1.DefaultBorderColor = System.Drawing.Color.White;
            this.bunifuFormCaptionButton1.DefaultColor = System.Drawing.Color.White;
            this.bunifuFormCaptionButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuFormCaptionButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.bunifuFormCaptionButton1.IconHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.bunifuFormCaptionButton1.IconPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.bunifuFormCaptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuFormCaptionButton1.Image")));
            this.bunifuFormCaptionButton1.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.bunifuFormCaptionButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.bunifuFormCaptionButton1.Location = new System.Drawing.Point(1086, 20);
            this.bunifuFormCaptionButton1.Name = "bunifuFormCaptionButton1";
            this.bunifuFormCaptionButton1.ShowBorders = false;
            this.bunifuFormCaptionButton1.Size = new System.Drawing.Size(41, 38);
            this.bunifuFormCaptionButton1.TabIndex = 49;
            this.bunifuFormCaptionButton1.Visible = false;
            // 
            // bunifuIconButton5
            // 
            this.bunifuIconButton5.AllowAnimations = true;
            this.bunifuIconButton5.AllowBorderColorChanges = true;
            this.bunifuIconButton5.AllowMouseEffects = true;
            this.bunifuIconButton5.AnimationSpeed = 200;
            this.bunifuIconButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton5.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton5.BackgroundImage = global::MovieMunch.Properties.Resources.SearchBtn;
            this.bunifuIconButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuIconButton5.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton5.BorderRadius = 1;
            this.bunifuIconButton5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButton5.BorderThickness = 1;
            this.bunifuIconButton5.ColorContrastOnClick = 30;
            this.bunifuIconButton5.ColorContrastOnHover = 30;
            this.bunifuIconButton5.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges19.BottomLeft = true;
            borderEdges19.BottomRight = true;
            borderEdges19.TopLeft = true;
            borderEdges19.TopRight = true;
            this.bunifuIconButton5.CustomizableEdges = borderEdges19;
            this.bunifuIconButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton5.Image = null;
            this.bunifuIconButton5.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButton5.Location = new System.Drawing.Point(1086, 9);
            this.bunifuIconButton5.Name = "bunifuIconButton5";
            this.bunifuIconButton5.RoundBorders = true;
            this.bunifuIconButton5.ShowBorders = true;
            this.bunifuIconButton5.Size = new System.Drawing.Size(57, 57);
            this.bunifuIconButton5.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButton5.TabIndex = 44;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(7)))), ((int)(((byte)(29)))));
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.label16);
            this.guna2Panel3.Location = new System.Drawing.Point(-2, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(207, 77);
            this.guna2Panel3.TabIndex = 50;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(14, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(186, 36);
            this.label16.TabIndex = 0;
            this.label16.Text = "ACCOUNT SETTING";
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(29)))));
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 2;
            this.bunifuPanel3.Controls.Add(this.SignUpBtn);
            this.bunifuPanel3.Controls.Add(this.LoginBtn);
            this.bunifuPanel3.Controls.Add(this.guna2Button1);
            this.bunifuPanel3.Location = new System.Drawing.Point(-7, 58);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(210, 382);
            this.bunifuPanel3.TabIndex = 51;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignUpBtn.BorderRadius = 10;
            this.SignUpBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.SignUpBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignUpBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignUpBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignUpBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignUpBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.SignUpBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SignUpBtn.ImageSize = new System.Drawing.Size(30, 25);
            this.SignUpBtn.IndicateFocus = true;
            this.SignUpBtn.Location = new System.Drawing.Point(20, 219);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(176, 35);
            this.SignUpBtn.TabIndex = 46;
            this.SignUpBtn.Text = "SIGN UP";
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BorderRadius = 10;
            this.LoginBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LoginBtn.ImageSize = new System.Drawing.Size(30, 25);
            this.LoginBtn.IndicateFocus = true;
            this.LoginBtn.Location = new System.Drawing.Point(20, 272);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(176, 35);
            this.LoginBtn.TabIndex = 45;
            this.LoginBtn.Text = "SIGN IN";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 25);
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(20, 86);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(176, 35);
            this.guna2Button1.TabIndex = 44;
            this.guna2Button1.Text = "USER CUSTOMIZATION";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(197, 61);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(793, 376);
            this.flowLayoutPanel2.TabIndex = 67;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.changePicBtn);
            this.panel2.Controls.Add(this.guna2TextBox5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.prevPasswordInput);
            this.panel2.Controls.Add(this.userProfileCustomHolder);
            this.panel2.Controls.Add(this.saveUserNameOrPasswordBtn);
            this.panel2.Controls.Add(this.changeConfirmNewPasswordInput);
            this.panel2.Controls.Add(this.changePasswordInput);
            this.panel2.Controls.Add(this.changePrevEmailInput);
            this.panel2.Controls.Add(this.guna2TextBox3);
            this.panel2.Controls.Add(this.guna2TextBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.saveUserPicOrNameBtn);
            this.panel2.Controls.Add(this.changeNewUsernameInput);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 678);
            this.panel2.TabIndex = 0;
            // 
            // changePicBtn
            // 
            this.changePicBtn.BackColor = System.Drawing.Color.Transparent;
            this.changePicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changePicBtn.BorderRadius = 2;
            this.changePicBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.changePicBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePicBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePicBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePicBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePicBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.changePicBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePicBtn.ForeColor = System.Drawing.Color.White;
            this.changePicBtn.Image = ((System.Drawing.Image)(resources.GetObject("changePicBtn.Image")));
            this.changePicBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.changePicBtn.IndicateFocus = true;
            this.changePicBtn.Location = new System.Drawing.Point(318, 140);
            this.changePicBtn.Name = "changePicBtn";
            this.changePicBtn.Size = new System.Drawing.Size(35, 35);
            this.changePicBtn.TabIndex = 47;
            this.changePicBtn.Click += new System.EventHandler(this.changePicBtn_Click);
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.guna2TextBox5.BorderRadius = 10;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "********";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox5.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.guna2TextBox5.Location = new System.Drawing.Point(209, 499);
            this.guna2TextBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBox5.PlaceholderText = "";
            this.guna2TextBox5.ReadOnly = true;
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.Size = new System.Drawing.Size(508, 30);
            this.guna2TextBox5.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 36);
            this.label8.TabIndex = 73;
            this.label8.Text = "NEW PASSWORD:";
            // 
            // prevPasswordInput
            // 
            this.prevPasswordInput.BackColor = System.Drawing.Color.Transparent;
            this.prevPasswordInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.prevPasswordInput.BorderRadius = 8;
            this.prevPasswordInput.BorderThickness = 2;
            this.prevPasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prevPasswordInput.DefaultText = "";
            this.prevPasswordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prevPasswordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prevPasswordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prevPasswordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prevPasswordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prevPasswordInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevPasswordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.prevPasswordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.prevPasswordInput.IconRight = ((System.Drawing.Image)(resources.GetObject("prevPasswordInput.IconRight")));
            this.prevPasswordInput.IconRightSize = new System.Drawing.Size(18, 18);
            this.prevPasswordInput.Location = new System.Drawing.Point(42, 453);
            this.prevPasswordInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prevPasswordInput.Name = "prevPasswordInput";
            this.prevPasswordInput.PasswordChar = '\0';
            this.prevPasswordInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.prevPasswordInput.PlaceholderText = "TYPE PREVIOUS PASSWORD";
            this.prevPasswordInput.SelectedText = "";
            this.prevPasswordInput.Size = new System.Drawing.Size(675, 30);
            this.prevPasswordInput.TabIndex = 72;
            // 
            // userProfileCustomHolder
            // 
            this.userProfileCustomHolder.BackColor = System.Drawing.Color.Transparent;
            this.userProfileCustomHolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userProfileCustomHolder.BackgroundImage")));
            this.userProfileCustomHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userProfileCustomHolder.FillColor = System.Drawing.Color.Transparent;
            this.userProfileCustomHolder.ImageRotate = 0F;
            this.userProfileCustomHolder.Location = new System.Drawing.Point(309, 26);
            this.userProfileCustomHolder.Name = "userProfileCustomHolder";
            this.userProfileCustomHolder.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userProfileCustomHolder.Size = new System.Drawing.Size(150, 150);
            this.userProfileCustomHolder.TabIndex = 71;
            this.userProfileCustomHolder.TabStop = false;
            // 
            // saveUserNameOrPasswordBtn
            // 
            this.saveUserNameOrPasswordBtn.AllowAnimations = true;
            this.saveUserNameOrPasswordBtn.AllowMouseEffects = true;
            this.saveUserNameOrPasswordBtn.AllowToggling = false;
            this.saveUserNameOrPasswordBtn.AnimationSpeed = 200;
            this.saveUserNameOrPasswordBtn.AutoGenerateColors = false;
            this.saveUserNameOrPasswordBtn.AutoRoundBorders = false;
            this.saveUserNameOrPasswordBtn.AutoSizeLeftIcon = true;
            this.saveUserNameOrPasswordBtn.AutoSizeRightIcon = true;
            this.saveUserNameOrPasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveUserNameOrPasswordBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.saveUserNameOrPasswordBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveUserNameOrPasswordBtn.BackgroundImage")));
            this.saveUserNameOrPasswordBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.saveUserNameOrPasswordBtn.ButtonText = "SAVE CHANGES";
            this.saveUserNameOrPasswordBtn.ButtonTextMarginLeft = 0;
            this.saveUserNameOrPasswordBtn.ColorContrastOnClick = 45;
            this.saveUserNameOrPasswordBtn.ColorContrastOnHover = 45;
            this.saveUserNameOrPasswordBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges20.BottomLeft = true;
            borderEdges20.BottomRight = true;
            borderEdges20.TopLeft = true;
            borderEdges20.TopRight = true;
            this.saveUserNameOrPasswordBtn.CustomizableEdges = borderEdges20;
            this.saveUserNameOrPasswordBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveUserNameOrPasswordBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveUserNameOrPasswordBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveUserNameOrPasswordBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveUserNameOrPasswordBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.saveUserNameOrPasswordBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUserNameOrPasswordBtn.ForeColor = System.Drawing.Color.White;
            this.saveUserNameOrPasswordBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveUserNameOrPasswordBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.saveUserNameOrPasswordBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.saveUserNameOrPasswordBtn.IconMarginLeft = 11;
            this.saveUserNameOrPasswordBtn.IconPadding = 10;
            this.saveUserNameOrPasswordBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveUserNameOrPasswordBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.saveUserNameOrPasswordBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.saveUserNameOrPasswordBtn.IconSize = 25;
            this.saveUserNameOrPasswordBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.saveUserNameOrPasswordBtn.IdleBorderRadius = 20;
            this.saveUserNameOrPasswordBtn.IdleBorderThickness = 1;
            this.saveUserNameOrPasswordBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.saveUserNameOrPasswordBtn.IdleIconLeftImage = null;
            this.saveUserNameOrPasswordBtn.IdleIconRightImage = null;
            this.saveUserNameOrPasswordBtn.IndicateFocus = false;
            this.saveUserNameOrPasswordBtn.Location = new System.Drawing.Point(299, 623);
            this.saveUserNameOrPasswordBtn.Name = "saveUserNameOrPasswordBtn";
            this.saveUserNameOrPasswordBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveUserNameOrPasswordBtn.OnDisabledState.BorderRadius = 20;
            this.saveUserNameOrPasswordBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.saveUserNameOrPasswordBtn.OnDisabledState.BorderThickness = 1;
            this.saveUserNameOrPasswordBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveUserNameOrPasswordBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveUserNameOrPasswordBtn.OnDisabledState.IconLeftImage = null;
            this.saveUserNameOrPasswordBtn.OnDisabledState.IconRightImage = null;
            this.saveUserNameOrPasswordBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.saveUserNameOrPasswordBtn.onHoverState.BorderRadius = 20;
            this.saveUserNameOrPasswordBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.saveUserNameOrPasswordBtn.onHoverState.BorderThickness = 1;
            this.saveUserNameOrPasswordBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.saveUserNameOrPasswordBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.saveUserNameOrPasswordBtn.onHoverState.IconLeftImage = null;
            this.saveUserNameOrPasswordBtn.onHoverState.IconRightImage = null;
            this.saveUserNameOrPasswordBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.saveUserNameOrPasswordBtn.OnIdleState.BorderRadius = 20;
            this.saveUserNameOrPasswordBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.saveUserNameOrPasswordBtn.OnIdleState.BorderThickness = 1;
            this.saveUserNameOrPasswordBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.saveUserNameOrPasswordBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.saveUserNameOrPasswordBtn.OnIdleState.IconLeftImage = null;
            this.saveUserNameOrPasswordBtn.OnIdleState.IconRightImage = null;
            this.saveUserNameOrPasswordBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.saveUserNameOrPasswordBtn.OnPressedState.BorderRadius = 20;
            this.saveUserNameOrPasswordBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.saveUserNameOrPasswordBtn.OnPressedState.BorderThickness = 1;
            this.saveUserNameOrPasswordBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.saveUserNameOrPasswordBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.saveUserNameOrPasswordBtn.OnPressedState.IconLeftImage = null;
            this.saveUserNameOrPasswordBtn.OnPressedState.IconRightImage = null;
            this.saveUserNameOrPasswordBtn.Size = new System.Drawing.Size(176, 39);
            this.saveUserNameOrPasswordBtn.TabIndex = 68;
            this.saveUserNameOrPasswordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveUserNameOrPasswordBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveUserNameOrPasswordBtn.TextMarginLeft = 0;
            this.saveUserNameOrPasswordBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.saveUserNameOrPasswordBtn.UseDefaultRadiusAndThickness = true;
            this.saveUserNameOrPasswordBtn.Click += new System.EventHandler(this.saveUserNameOrPasswordBtn_Click);
            // 
            // changeConfirmNewPasswordInput
            // 
            this.changeConfirmNewPasswordInput.BackColor = System.Drawing.Color.Transparent;
            this.changeConfirmNewPasswordInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.changeConfirmNewPasswordInput.BorderRadius = 8;
            this.changeConfirmNewPasswordInput.BorderThickness = 2;
            this.changeConfirmNewPasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.changeConfirmNewPasswordInput.DefaultText = "";
            this.changeConfirmNewPasswordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.changeConfirmNewPasswordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.changeConfirmNewPasswordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeConfirmNewPasswordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeConfirmNewPasswordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeConfirmNewPasswordInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeConfirmNewPasswordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.changeConfirmNewPasswordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.changeConfirmNewPasswordInput.IconRight = ((System.Drawing.Image)(resources.GetObject("changeConfirmNewPasswordInput.IconRight")));
            this.changeConfirmNewPasswordInput.IconRightSize = new System.Drawing.Size(18, 18);
            this.changeConfirmNewPasswordInput.Location = new System.Drawing.Point(42, 578);
            this.changeConfirmNewPasswordInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeConfirmNewPasswordInput.Name = "changeConfirmNewPasswordInput";
            this.changeConfirmNewPasswordInput.PasswordChar = '\0';
            this.changeConfirmNewPasswordInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.changeConfirmNewPasswordInput.PlaceholderText = "CONFIRM NEW PASSWORD";
            this.changeConfirmNewPasswordInput.SelectedText = "";
            this.changeConfirmNewPasswordInput.Size = new System.Drawing.Size(675, 30);
            this.changeConfirmNewPasswordInput.TabIndex = 67;
            // 
            // changePasswordInput
            // 
            this.changePasswordInput.BackColor = System.Drawing.Color.Transparent;
            this.changePasswordInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.changePasswordInput.BorderRadius = 8;
            this.changePasswordInput.BorderThickness = 2;
            this.changePasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.changePasswordInput.DefaultText = "";
            this.changePasswordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.changePasswordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.changePasswordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changePasswordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changePasswordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changePasswordInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.changePasswordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.changePasswordInput.IconRight = ((System.Drawing.Image)(resources.GetObject("changePasswordInput.IconRight")));
            this.changePasswordInput.IconRightSize = new System.Drawing.Size(18, 18);
            this.changePasswordInput.Location = new System.Drawing.Point(42, 540);
            this.changePasswordInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changePasswordInput.Name = "changePasswordInput";
            this.changePasswordInput.PasswordChar = '\0';
            this.changePasswordInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.changePasswordInput.PlaceholderText = "TYPE TO CHANGE PASSWORD";
            this.changePasswordInput.SelectedText = "";
            this.changePasswordInput.Size = new System.Drawing.Size(675, 30);
            this.changePasswordInput.TabIndex = 66;
            // 
            // changePrevEmailInput
            // 
            this.changePrevEmailInput.BackColor = System.Drawing.Color.Transparent;
            this.changePrevEmailInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.changePrevEmailInput.BorderRadius = 8;
            this.changePrevEmailInput.BorderThickness = 2;
            this.changePrevEmailInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.changePrevEmailInput.DefaultText = "";
            this.changePrevEmailInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.changePrevEmailInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.changePrevEmailInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changePrevEmailInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changePrevEmailInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changePrevEmailInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePrevEmailInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.changePrevEmailInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.changePrevEmailInput.IconRight = ((System.Drawing.Image)(resources.GetObject("changePrevEmailInput.IconRight")));
            this.changePrevEmailInput.IconRightSize = new System.Drawing.Size(18, 18);
            this.changePrevEmailInput.Location = new System.Drawing.Point(42, 366);
            this.changePrevEmailInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changePrevEmailInput.Name = "changePrevEmailInput";
            this.changePrevEmailInput.PasswordChar = '\0';
            this.changePrevEmailInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.changePrevEmailInput.PlaceholderText = "TYPE PREVIOUS EMAIL";
            this.changePrevEmailInput.SelectedText = "";
            this.changePrevEmailInput.Size = new System.Drawing.Size(675, 30);
            this.changePrevEmailInput.TabIndex = 65;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.guna2TextBox3.BorderRadius = 10;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "********";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(264, 414);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.ReadOnly = true;
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(453, 30);
            this.guna2TextBox3.TabIndex = 64;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.guna2TextBox2.BorderRadius = 10;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "example@gmail.com";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(217, 319);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.ReadOnly = true;
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(501, 30);
            this.guna2TextBox2.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 36);
            this.label7.TabIndex = 62;
            this.label7.Text = "PREVIOUS PASSWORD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 36);
            this.label6.TabIndex = 61;
            this.label6.Text = "PREVIOUS EMAIL:";
            // 
            // saveUserPicOrNameBtn
            // 
            this.saveUserPicOrNameBtn.AllowAnimations = true;
            this.saveUserPicOrNameBtn.AllowMouseEffects = true;
            this.saveUserPicOrNameBtn.AllowToggling = false;
            this.saveUserPicOrNameBtn.AnimationSpeed = 200;
            this.saveUserPicOrNameBtn.AutoGenerateColors = false;
            this.saveUserPicOrNameBtn.AutoRoundBorders = false;
            this.saveUserPicOrNameBtn.AutoSizeLeftIcon = true;
            this.saveUserPicOrNameBtn.AutoSizeRightIcon = true;
            this.saveUserPicOrNameBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveUserPicOrNameBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.saveUserPicOrNameBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveUserPicOrNameBtn.BackgroundImage")));
            this.saveUserPicOrNameBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.saveUserPicOrNameBtn.ButtonText = "APPLY CHANGES";
            this.saveUserPicOrNameBtn.ButtonTextMarginLeft = 0;
            this.saveUserPicOrNameBtn.ColorContrastOnClick = 45;
            this.saveUserPicOrNameBtn.ColorContrastOnHover = 45;
            this.saveUserPicOrNameBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges21.BottomLeft = true;
            borderEdges21.BottomRight = true;
            borderEdges21.TopLeft = true;
            borderEdges21.TopRight = true;
            this.saveUserPicOrNameBtn.CustomizableEdges = borderEdges21;
            this.saveUserPicOrNameBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveUserPicOrNameBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveUserPicOrNameBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveUserPicOrNameBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveUserPicOrNameBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.saveUserPicOrNameBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUserPicOrNameBtn.ForeColor = System.Drawing.Color.White;
            this.saveUserPicOrNameBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveUserPicOrNameBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.saveUserPicOrNameBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.saveUserPicOrNameBtn.IconMarginLeft = 11;
            this.saveUserPicOrNameBtn.IconPadding = 10;
            this.saveUserPicOrNameBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveUserPicOrNameBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.saveUserPicOrNameBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.saveUserPicOrNameBtn.IconSize = 25;
            this.saveUserPicOrNameBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.saveUserPicOrNameBtn.IdleBorderRadius = 20;
            this.saveUserPicOrNameBtn.IdleBorderThickness = 1;
            this.saveUserPicOrNameBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.saveUserPicOrNameBtn.IdleIconLeftImage = null;
            this.saveUserPicOrNameBtn.IdleIconRightImage = null;
            this.saveUserPicOrNameBtn.IndicateFocus = false;
            this.saveUserPicOrNameBtn.Location = new System.Drawing.Point(299, 254);
            this.saveUserPicOrNameBtn.Name = "saveUserPicOrNameBtn";
            this.saveUserPicOrNameBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveUserPicOrNameBtn.OnDisabledState.BorderRadius = 20;
            this.saveUserPicOrNameBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.saveUserPicOrNameBtn.OnDisabledState.BorderThickness = 1;
            this.saveUserPicOrNameBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveUserPicOrNameBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveUserPicOrNameBtn.OnDisabledState.IconLeftImage = null;
            this.saveUserPicOrNameBtn.OnDisabledState.IconRightImage = null;
            this.saveUserPicOrNameBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.saveUserPicOrNameBtn.onHoverState.BorderRadius = 20;
            this.saveUserPicOrNameBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.saveUserPicOrNameBtn.onHoverState.BorderThickness = 1;
            this.saveUserPicOrNameBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.saveUserPicOrNameBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.saveUserPicOrNameBtn.onHoverState.IconLeftImage = null;
            this.saveUserPicOrNameBtn.onHoverState.IconRightImage = null;
            this.saveUserPicOrNameBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.saveUserPicOrNameBtn.OnIdleState.BorderRadius = 20;
            this.saveUserPicOrNameBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.saveUserPicOrNameBtn.OnIdleState.BorderThickness = 1;
            this.saveUserPicOrNameBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.saveUserPicOrNameBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.saveUserPicOrNameBtn.OnIdleState.IconLeftImage = null;
            this.saveUserPicOrNameBtn.OnIdleState.IconRightImage = null;
            this.saveUserPicOrNameBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.saveUserPicOrNameBtn.OnPressedState.BorderRadius = 20;
            this.saveUserPicOrNameBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.saveUserPicOrNameBtn.OnPressedState.BorderThickness = 1;
            this.saveUserPicOrNameBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.saveUserPicOrNameBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.saveUserPicOrNameBtn.OnPressedState.IconLeftImage = null;
            this.saveUserPicOrNameBtn.OnPressedState.IconRightImage = null;
            this.saveUserPicOrNameBtn.Size = new System.Drawing.Size(176, 39);
            this.saveUserPicOrNameBtn.TabIndex = 60;
            this.saveUserPicOrNameBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveUserPicOrNameBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveUserPicOrNameBtn.TextMarginLeft = 0;
            this.saveUserPicOrNameBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.saveUserPicOrNameBtn.UseDefaultRadiusAndThickness = true;
            this.saveUserPicOrNameBtn.Click += new System.EventHandler(this.saveUserPicOrNameBtn_Click);
            // 
            // changeNewUsernameInput
            // 
            this.changeNewUsernameInput.BackColor = System.Drawing.Color.Transparent;
            this.changeNewUsernameInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.changeNewUsernameInput.BorderRadius = 8;
            this.changeNewUsernameInput.BorderThickness = 2;
            this.changeNewUsernameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.changeNewUsernameInput.DefaultText = "";
            this.changeNewUsernameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.changeNewUsernameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.changeNewUsernameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeNewUsernameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeNewUsernameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeNewUsernameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeNewUsernameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.changeNewUsernameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.changeNewUsernameInput.IconRight = ((System.Drawing.Image)(resources.GetObject("changeNewUsernameInput.IconRight")));
            this.changeNewUsernameInput.IconRightSize = new System.Drawing.Size(18, 18);
            this.changeNewUsernameInput.Location = new System.Drawing.Point(234, 202);
            this.changeNewUsernameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeNewUsernameInput.Name = "changeNewUsernameInput";
            this.changeNewUsernameInput.PasswordChar = '\0';
            this.changeNewUsernameInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.changeNewUsernameInput.PlaceholderText = "NICKNAME";
            this.changeNewUsernameInput.SelectedText = "";
            this.changeNewUsernameInput.Size = new System.Drawing.Size(313, 30);
            this.changeNewUsernameInput.TabIndex = 58;
            this.changeNewUsernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.searchResultsFlowLayoutPanel.Location = new System.Drawing.Point(39, 3);
            this.searchResultsFlowLayoutPanel.Name = "searchResultsFlowLayoutPanel";
            this.searchResultsFlowLayoutPanel.Size = new System.Drawing.Size(405, 182);
            this.searchResultsFlowLayoutPanel.TabIndex = 42;
            this.searchResultsFlowLayoutPanel.Visible = false;
            this.searchResultsFlowLayoutPanel.WrapContents = false;
            // 
            // searchResultFlowWholePanel
            // 
            this.searchResultFlowWholePanel.BackColor = System.Drawing.Color.White;
            this.searchResultFlowWholePanel.Controls.Add(this.searchResultsFlowLayoutPanel);
            this.searchResultFlowWholePanel.Location = new System.Drawing.Point(675, 66);
            this.searchResultFlowWholePanel.Name = "searchResultFlowWholePanel";
            this.searchResultFlowWholePanel.Size = new System.Drawing.Size(447, 185);
            this.searchResultFlowWholePanel.TabIndex = 44;
            this.searchResultFlowWholePanel.Visible = false;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.AutoScroll = true;
            this.guna2VScrollBar1.AutoSize = true;
            this.guna2VScrollBar1.BindingContainer = this.flowLayoutPanel1;
            this.guna2VScrollBar1.CausesValidation = false;
            this.guna2VScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 599;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1189, 76);
            this.guna2VScrollBar1.Maximum = 2155;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 21;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(21, 599);
            this.guna2VScrollBar1.SmallChange = 5;
            this.guna2VScrollBar1.TabIndex = 56;
            this.guna2VScrollBar1.ThumbSize = 9F;
            // 
            // trendingMoviesDetailsPanel
            // 
            this.trendingMoviesDetailsPanel.Controls.Add(this.label9);
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingDescriptionDetails);
            this.trendingMoviesDetailsPanel.Controls.Add(this.closeTrendingMoviesDetails);
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingMovieSeatReservationBtn);
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingMoviePriceDetails);
            this.trendingMoviesDetailsPanel.Controls.Add(this.addTrendingToWatchLaterBtn);
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingMovieTitleDetails);
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingDetailsPictureBox);
            this.trendingMoviesDetailsPanel.Location = new System.Drawing.Point(233, 124);
            this.trendingMoviesDetailsPanel.Name = "trendingMoviesDetailsPanel";
            this.trendingMoviesDetailsPanel.Size = new System.Drawing.Size(770, 435);
            this.trendingMoviesDetailsPanel.TabIndex = 57;
            this.trendingMoviesDetailsPanel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(481, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 38);
            this.label9.TabIndex = 66;
            this.label9.Text = "Description";
            // 
            // trendingDescriptionDetails
            // 
            this.trendingDescriptionDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.trendingDescriptionDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trendingDescriptionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trendingDescriptionDetails.ForeColor = System.Drawing.Color.White;
            this.trendingDescriptionDetails.Location = new System.Drawing.Point(485, 82);
            this.trendingDescriptionDetails.Name = "trendingDescriptionDetails";
            this.trendingDescriptionDetails.Size = new System.Drawing.Size(266, 212);
            this.trendingDescriptionDetails.TabIndex = 65;
            this.trendingDescriptionDetails.Text = "Description area";
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
            borderEdges22.BottomLeft = true;
            borderEdges22.BottomRight = true;
            borderEdges22.TopLeft = true;
            borderEdges22.TopRight = true;
            this.closeTrendingMoviesDetails.CustomizableEdges = borderEdges22;
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
            borderEdges23.BottomLeft = true;
            borderEdges23.BottomRight = true;
            borderEdges23.TopLeft = true;
            borderEdges23.TopRight = true;
            this.trendingMovieSeatReservationBtn.CustomizableEdges = borderEdges23;
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
            this.trendingMovieSeatReservationBtn.Location = new System.Drawing.Point(551, 337);
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
            this.trendingMoviePriceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trendingMoviePriceDetails.ForeColor = System.Drawing.Color.White;
            this.trendingMoviePriceDetails.Location = new System.Drawing.Point(39, 367);
            this.trendingMoviePriceDetails.Name = "trendingMoviePriceDetails";
            this.trendingMoviePriceDetails.Size = new System.Drawing.Size(92, 38);
            this.trendingMoviePriceDetails.TabIndex = 60;
            this.trendingMoviePriceDetails.Text = "Price";
            // 
            // addTrendingToWatchLaterBtn
            // 
            this.addTrendingToWatchLaterBtn.AllowAnimations = true;
            this.addTrendingToWatchLaterBtn.AllowBorderColorChanges = true;
            this.addTrendingToWatchLaterBtn.AllowMouseEffects = true;
            this.addTrendingToWatchLaterBtn.AnimationSpeed = 200;
            this.addTrendingToWatchLaterBtn.BackColor = System.Drawing.Color.Transparent;
            this.addTrendingToWatchLaterBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.addTrendingToWatchLaterBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTrendingToWatchLaterBtn.BackgroundImage")));
            this.addTrendingToWatchLaterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTrendingToWatchLaterBtn.BorderColor = System.Drawing.Color.Transparent;
            this.addTrendingToWatchLaterBtn.BorderRadius = 1;
            this.addTrendingToWatchLaterBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.addTrendingToWatchLaterBtn.BorderThickness = 1;
            this.addTrendingToWatchLaterBtn.ColorContrastOnClick = 30;
            this.addTrendingToWatchLaterBtn.ColorContrastOnHover = 30;
            this.addTrendingToWatchLaterBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges24.BottomLeft = true;
            borderEdges24.BottomRight = true;
            borderEdges24.TopLeft = true;
            borderEdges24.TopRight = true;
            this.addTrendingToWatchLaterBtn.CustomizableEdges = borderEdges24;
            this.addTrendingToWatchLaterBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addTrendingToWatchLaterBtn.Image = null;
            this.addTrendingToWatchLaterBtn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.addTrendingToWatchLaterBtn.Location = new System.Drawing.Point(472, 337);
            this.addTrendingToWatchLaterBtn.Name = "addTrendingToWatchLaterBtn";
            this.addTrendingToWatchLaterBtn.RoundBorders = true;
            this.addTrendingToWatchLaterBtn.ShowBorders = true;
            this.addTrendingToWatchLaterBtn.Size = new System.Drawing.Size(57, 57);
            this.addTrendingToWatchLaterBtn.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.addTrendingToWatchLaterBtn.TabIndex = 59;
            this.addTrendingToWatchLaterBtn.Click += new System.EventHandler(this.addTrendingToWatchLaterBtn_Click);
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
            this.comingSoonMovieDetailsPanel.Controls.Add(this.addComingSoonToWatchLater);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.comingSoonTitleDetails);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.comingSoonMoviePicBoxDetails);
            this.comingSoonMovieDetailsPanel.Location = new System.Drawing.Point(233, 123);
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
            borderEdges25.BottomLeft = true;
            borderEdges25.BottomRight = true;
            borderEdges25.TopLeft = true;
            borderEdges25.TopRight = true;
            this.closeComingSoonMovieDetailsBtn.CustomizableEdges = borderEdges25;
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
            borderEdges26.BottomLeft = true;
            borderEdges26.BottomRight = true;
            borderEdges26.TopLeft = true;
            borderEdges26.TopRight = true;
            this.comingSoonMovieSeatReservationBtn.CustomizableEdges = borderEdges26;
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
            // addComingSoonToWatchLater
            // 
            this.addComingSoonToWatchLater.AllowAnimations = true;
            this.addComingSoonToWatchLater.AllowBorderColorChanges = true;
            this.addComingSoonToWatchLater.AllowMouseEffects = true;
            this.addComingSoonToWatchLater.AnimationSpeed = 200;
            this.addComingSoonToWatchLater.BackColor = System.Drawing.Color.Transparent;
            this.addComingSoonToWatchLater.BackgroundColor = System.Drawing.Color.Transparent;
            this.addComingSoonToWatchLater.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addComingSoonToWatchLater.BackgroundImage")));
            this.addComingSoonToWatchLater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addComingSoonToWatchLater.BorderColor = System.Drawing.Color.Transparent;
            this.addComingSoonToWatchLater.BorderRadius = 1;
            this.addComingSoonToWatchLater.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.addComingSoonToWatchLater.BorderThickness = 1;
            this.addComingSoonToWatchLater.ColorContrastOnClick = 30;
            this.addComingSoonToWatchLater.ColorContrastOnHover = 30;
            this.addComingSoonToWatchLater.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges27.BottomLeft = true;
            borderEdges27.BottomRight = true;
            borderEdges27.TopLeft = true;
            borderEdges27.TopRight = true;
            this.addComingSoonToWatchLater.CustomizableEdges = borderEdges27;
            this.addComingSoonToWatchLater.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addComingSoonToWatchLater.Image = null;
            this.addComingSoonToWatchLater.ImageMargin = new System.Windows.Forms.Padding(0);
            this.addComingSoonToWatchLater.Location = new System.Drawing.Point(286, 334);
            this.addComingSoonToWatchLater.Name = "addComingSoonToWatchLater";
            this.addComingSoonToWatchLater.RoundBorders = true;
            this.addComingSoonToWatchLater.ShowBorders = true;
            this.addComingSoonToWatchLater.Size = new System.Drawing.Size(57, 57);
            this.addComingSoonToWatchLater.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.addComingSoonToWatchLater.TabIndex = 59;
            this.addComingSoonToWatchLater.Click += new System.EventHandler(this.addComingSoonToWatchLater_Click);
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
            this.filmsDetailsPanel.Controls.Add(this.addFilmMovieToWatchLaterBtn);
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
            this.filmsDescriptionDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.filmsDescriptionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmsDescriptionDetails.Location = new System.Drawing.Point(253, 68);
            this.filmsDescriptionDetails.Name = "filmsDescriptionDetails";
            this.filmsDescriptionDetails.Size = new System.Drawing.Size(477, 271);
            this.filmsDescriptionDetails.TabIndex = 64;
            this.filmsDescriptionDetails.Text = "";
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
            borderEdges28.BottomLeft = true;
            borderEdges28.BottomRight = true;
            borderEdges28.TopLeft = true;
            borderEdges28.TopRight = true;
            this.closeFilmsDetailsBtn.CustomizableEdges = borderEdges28;
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
            borderEdges29.BottomLeft = true;
            borderEdges29.BottomRight = true;
            borderEdges29.TopLeft = true;
            borderEdges29.TopRight = true;
            this.filmsMovieSeatReservationBtn.CustomizableEdges = borderEdges29;
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
            this.filmsPriceDetails.Location = new System.Drawing.Point(19, 376);
            this.filmsPriceDetails.Name = "filmsPriceDetails";
            this.filmsPriceDetails.Size = new System.Drawing.Size(112, 46);
            this.filmsPriceDetails.TabIndex = 60;
            this.filmsPriceDetails.Text = "Price";
            // 
            // addFilmMovieToWatchLaterBtn
            // 
            this.addFilmMovieToWatchLaterBtn.AllowAnimations = true;
            this.addFilmMovieToWatchLaterBtn.AllowBorderColorChanges = true;
            this.addFilmMovieToWatchLaterBtn.AllowMouseEffects = true;
            this.addFilmMovieToWatchLaterBtn.AnimationSpeed = 200;
            this.addFilmMovieToWatchLaterBtn.BackColor = System.Drawing.Color.Transparent;
            this.addFilmMovieToWatchLaterBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.addFilmMovieToWatchLaterBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addFilmMovieToWatchLaterBtn.BackgroundImage")));
            this.addFilmMovieToWatchLaterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addFilmMovieToWatchLaterBtn.BorderColor = System.Drawing.Color.Transparent;
            this.addFilmMovieToWatchLaterBtn.BorderRadius = 1;
            this.addFilmMovieToWatchLaterBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.addFilmMovieToWatchLaterBtn.BorderThickness = 1;
            this.addFilmMovieToWatchLaterBtn.ColorContrastOnClick = 30;
            this.addFilmMovieToWatchLaterBtn.ColorContrastOnHover = 30;
            this.addFilmMovieToWatchLaterBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges30.BottomLeft = true;
            borderEdges30.BottomRight = true;
            borderEdges30.TopLeft = true;
            borderEdges30.TopRight = true;
            this.addFilmMovieToWatchLaterBtn.CustomizableEdges = borderEdges30;
            this.addFilmMovieToWatchLaterBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addFilmMovieToWatchLaterBtn.Image = null;
            this.addFilmMovieToWatchLaterBtn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.addFilmMovieToWatchLaterBtn.Location = new System.Drawing.Point(286, 334);
            this.addFilmMovieToWatchLaterBtn.Name = "addFilmMovieToWatchLaterBtn";
            this.addFilmMovieToWatchLaterBtn.RoundBorders = true;
            this.addFilmMovieToWatchLaterBtn.ShowBorders = true;
            this.addFilmMovieToWatchLaterBtn.Size = new System.Drawing.Size(57, 57);
            this.addFilmMovieToWatchLaterBtn.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.addFilmMovieToWatchLaterBtn.TabIndex = 59;
            this.addFilmMovieToWatchLaterBtn.Click += new System.EventHandler(this.btnFilmAddToWatchLater_Click);
            // 
            // filmsTitleDetails
            // 
            this.filmsTitleDetails.AutoSize = true;
            this.filmsTitleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmsTitleDetails.ForeColor = System.Drawing.Color.White;
            this.filmsTitleDetails.Location = new System.Drawing.Point(245, 17);
            this.filmsTitleDetails.Name = "filmsTitleDetails";
            this.filmsTitleDetails.Size = new System.Drawing.Size(212, 46);
            this.filmsTitleDetails.TabIndex = 58;
            this.filmsTitleDetails.Text = "Film Movie";
            this.filmsTitleDetails.Click += new System.EventHandler(this.filmsTitleDetails_Click);
            // 
            // filmsPictureBoxDetails
            // 
            this.filmsPictureBoxDetails.BackColor = System.Drawing.Color.Blue;
            this.filmsPictureBoxDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filmsPictureBoxDetails.Location = new System.Drawing.Point(21, 17);
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
            borderEdges31.BottomLeft = true;
            borderEdges31.BottomRight = true;
            borderEdges31.TopLeft = true;
            borderEdges31.TopRight = true;
            this.closeFoodDetailsBtn.CustomizableEdges = borderEdges31;
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
            borderEdges32.BottomLeft = true;
            borderEdges32.BottomRight = true;
            borderEdges32.TopLeft = true;
            borderEdges32.TopRight = true;
            this.snackDealsReservedSeatBtn.CustomizableEdges = borderEdges32;
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
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(29)))));
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 2;
            this.bunifuPanel1.Controls.Add(this.guna2Panel2);
            this.bunifuPanel1.Controls.Add(this.exisSearchBtn);
            this.bunifuPanel1.Controls.Add(this.searchInput);
            this.bunifuPanel1.Controls.Add(this.searchBtnBefore);
            this.bunifuPanel1.Location = new System.Drawing.Point(-5, -3);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1215, 80);
            this.bunifuPanel1.TabIndex = 41;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(7)))), ((int)(((byte)(29)))));
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.logoBefore);
            this.guna2Panel2.Location = new System.Drawing.Point(-2, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(171, 77);
            this.guna2Panel2.TabIndex = 50;
            // 
            // logoBefore
            // 
            this.logoBefore.BackColor = System.Drawing.Color.Transparent;
            this.logoBefore.BackgroundImage = global::MovieMunch.Properties.Resources.MovieM_removebg_preview;
            this.logoBefore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoBefore.Location = new System.Drawing.Point(5, -15);
            this.logoBefore.Name = "logoBefore";
            this.logoBefore.Size = new System.Drawing.Size(169, 126);
            this.logoBefore.TabIndex = 46;
            this.logoBefore.TabStop = false;
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
            borderEdges33.BottomLeft = true;
            borderEdges33.BottomRight = true;
            borderEdges33.TopLeft = true;
            borderEdges33.TopRight = true;
            this.exisSearchBtn.CustomizableEdges = borderEdges33;
            this.exisSearchBtn.DefaultBorderColor = System.Drawing.Color.White;
            this.exisSearchBtn.DefaultColor = System.Drawing.Color.White;
            this.exisSearchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exisSearchBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.exisSearchBtn.IconHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.exisSearchBtn.IconPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.exisSearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("exisSearchBtn.Image")));
            this.exisSearchBtn.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.exisSearchBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.exisSearchBtn.Location = new System.Drawing.Point(1086, 20);
            this.exisSearchBtn.Name = "exisSearchBtn";
            this.exisSearchBtn.ShowBorders = false;
            this.exisSearchBtn.Size = new System.Drawing.Size(41, 38);
            this.exisSearchBtn.TabIndex = 49;
            this.exisSearchBtn.Visible = false;
            this.exisSearchBtn.Click += new System.EventHandler(this.exisSearchBtn_Click);
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
            this.searchInput.Location = new System.Drawing.Point(646, 12);
            this.searchInput.MaxLength = 32767;
            this.searchInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchInput.Modified = false;
            this.searchInput.Multiline = false;
            this.searchInput.Name = "searchInput";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchInput.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchInput.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchInput.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchInput.OnIdleState = stateProperties8;
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
            this.searchInput.Size = new System.Drawing.Size(497, 57);
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
            borderEdges34.BottomLeft = true;
            borderEdges34.BottomRight = true;
            borderEdges34.TopLeft = true;
            borderEdges34.TopRight = true;
            this.searchBtnBefore.CustomizableEdges = borderEdges34;
            this.searchBtnBefore.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchBtnBefore.Image = null;
            this.searchBtnBefore.ImageMargin = new System.Windows.Forms.Padding(0);
            this.searchBtnBefore.Location = new System.Drawing.Point(1086, 9);
            this.searchBtnBefore.Name = "searchBtnBefore";
            this.searchBtnBefore.RoundBorders = true;
            this.searchBtnBefore.ShowBorders = true;
            this.searchBtnBefore.Size = new System.Drawing.Size(57, 57);
            this.searchBtnBefore.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.searchBtnBefore.TabIndex = 44;
            this.searchBtnBefore.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(29)))));
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.userProfileBtn);
            this.guna2Panel1.Controls.Add(this.LogoutBtn);
            this.guna2Panel1.Controls.Add(this.gotoWatchListBtn);
            this.guna2Panel1.Controls.Add(this.gotoTicketFormBtn);
            this.guna2Panel1.Controls.Add(this.userNameHolder);
            this.guna2Panel1.Controls.Add(this.SettingBtn);
            this.guna2Panel1.Location = new System.Drawing.Point(-5, 69);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(170, 591);
            this.guna2Panel1.TabIndex = 43;
            // 
            // userProfileBtn
            // 
            this.userProfileBtn.BackColor = System.Drawing.Color.Transparent;
            this.userProfileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userProfileBtn.BackgroundImage")));
            this.userProfileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userProfileBtn.FillColor = System.Drawing.Color.Transparent;
            this.userProfileBtn.ImageRotate = 0F;
            this.userProfileBtn.Location = new System.Drawing.Point(39, 47);
            this.userProfileBtn.Name = "userProfileBtn";
            this.userProfileBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userProfileBtn.Size = new System.Drawing.Size(100, 100);
            this.userProfileBtn.TabIndex = 70;
            this.userProfileBtn.TabStop = false;
            this.userProfileBtn.Click += new System.EventHandler(this.userProfileBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BorderRadius = 10;
            this.LogoutBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.LogoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogoutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.IndicateFocus = true;
            this.LogoutBtn.Location = new System.Drawing.Point(14, 530);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(144, 35);
            this.LogoutBtn.TabIndex = 48;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // gotoWatchListBtn
            // 
            this.gotoWatchListBtn.BorderRadius = 10;
            this.gotoWatchListBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.gotoWatchListBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gotoWatchListBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gotoWatchListBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gotoWatchListBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gotoWatchListBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.gotoWatchListBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoWatchListBtn.ForeColor = System.Drawing.Color.White;
            this.gotoWatchListBtn.Image = ((System.Drawing.Image)(resources.GetObject("gotoWatchListBtn.Image")));
            this.gotoWatchListBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gotoWatchListBtn.ImageSize = new System.Drawing.Size(30, 25);
            this.gotoWatchListBtn.IndicateFocus = true;
            this.gotoWatchListBtn.Location = new System.Drawing.Point(17, 375);
            this.gotoWatchListBtn.Name = "gotoWatchListBtn";
            this.gotoWatchListBtn.Size = new System.Drawing.Size(144, 35);
            this.gotoWatchListBtn.TabIndex = 47;
            this.gotoWatchListBtn.Text = "WATCH LATER";
            this.gotoWatchListBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gotoWatchListBtn.Click += new System.EventHandler(this.gotoWatchListBtn_Click);
            // 
            // gotoTicketFormBtn
            // 
            this.gotoTicketFormBtn.BorderRadius = 10;
            this.gotoTicketFormBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.gotoTicketFormBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gotoTicketFormBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gotoTicketFormBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gotoTicketFormBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gotoTicketFormBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.gotoTicketFormBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoTicketFormBtn.ForeColor = System.Drawing.Color.White;
            this.gotoTicketFormBtn.Image = ((System.Drawing.Image)(resources.GetObject("gotoTicketFormBtn.Image")));
            this.gotoTicketFormBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gotoTicketFormBtn.ImageSize = new System.Drawing.Size(30, 25);
            this.gotoTicketFormBtn.IndicateFocus = true;
            this.gotoTicketFormBtn.Location = new System.Drawing.Point(17, 331);
            this.gotoTicketFormBtn.Name = "gotoTicketFormBtn";
            this.gotoTicketFormBtn.Size = new System.Drawing.Size(144, 35);
            this.gotoTicketFormBtn.TabIndex = 46;
            this.gotoTicketFormBtn.Text = "TICKET";
            this.gotoTicketFormBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gotoTicketFormBtn.Click += new System.EventHandler(this.gotoTicketFormBtn_Click);
            // 
            // userNameHolder
            // 
            this.userNameHolder.BackColor = System.Drawing.Color.Transparent;
            this.userNameHolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.userNameHolder.BorderRadius = 10;
            this.userNameHolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameHolder.DefaultText = "USERNAME";
            this.userNameHolder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameHolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameHolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameHolder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameHolder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.userNameHolder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameHolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userNameHolder.ForeColor = System.Drawing.Color.White;
            this.userNameHolder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.userNameHolder.Location = new System.Drawing.Point(17, 161);
            this.userNameHolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userNameHolder.Name = "userNameHolder";
            this.userNameHolder.PasswordChar = '\0';
            this.userNameHolder.PlaceholderForeColor = System.Drawing.Color.White;
            this.userNameHolder.PlaceholderText = "";
            this.userNameHolder.ReadOnly = true;
            this.userNameHolder.SelectedText = "";
            this.userNameHolder.Size = new System.Drawing.Size(144, 30);
            this.userNameHolder.TabIndex = 45;
            this.userNameHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingBtn.BorderRadius = 10;
            this.SettingBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.SettingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SettingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SettingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SettingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SettingBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.SettingBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBtn.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingBtn.Image")));
            this.SettingBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingBtn.ImageSize = new System.Drawing.Size(30, 25);
            this.SettingBtn.IndicateFocus = true;
            this.SettingBtn.Location = new System.Drawing.Point(17, 283);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(144, 35);
            this.SettingBtn.TabIndex = 43;
            this.SettingBtn.Text = "HOME";
            this.SettingBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // exitApplicationBtn
            // 
            this.exitApplicationBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitApplicationBtn.BorderRadius = 10;
            this.exitApplicationBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.exitApplicationBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitApplicationBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitApplicationBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitApplicationBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitApplicationBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.exitApplicationBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApplicationBtn.ForeColor = System.Drawing.Color.White;
            this.exitApplicationBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.exitApplicationBtn.ImageSize = new System.Drawing.Size(30, 25);
            this.exitApplicationBtn.IndicateFocus = true;
            this.exitApplicationBtn.Location = new System.Drawing.Point(501, 23);
            this.exitApplicationBtn.Name = "exitApplicationBtn";
            this.exitApplicationBtn.Size = new System.Drawing.Size(176, 35);
            this.exitApplicationBtn.TabIndex = 47;
            this.exitApplicationBtn.Text = "EXIT APPLICATION";
            this.exitApplicationBtn.Click += new System.EventHandler(this.exitApplicationBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.searchResultFlowWholePanel);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.foodDetailsPanel);
            this.Controls.Add(this.filmsDetailsPanel);
            this.Controls.Add(this.comingSoonMovieDetailsPanel);
            this.Controls.Add(this.trendingMoviesDetailsPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.filmsInCinemaPanel.ResumeLayout(false);
            this.snacksFlowLayoutPanel.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
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
            this.bunifuPanel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileCustomHolder)).EndInit();
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
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBefore)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private PictureBox fourthCircle;
        private PictureBox thirdCircle;
        private PictureBox secondCircle;
        private PictureBox firstCircle;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
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
        private Panel userPanel;
        private Timer smothFromLeftToRightTransition;
        private Panel food1;
        private Panel food2;
        private Panel food3;
        private FlowLayoutPanel yummyFlowLayoutPanel;
        private Panel yummy1;
        private Panel yummy2;
        private Panel yummy3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton searchBtnBefore;
        private Bunifu.UI.WinForms.BunifuTextBox searchInput;
        private FlowLayoutPanel searchResultsFlowLayoutPanel;
        private Panel searchResultFlowWholePanel;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton exisSearchBtn;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Panel trendingMoviesDetailsPanel;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton closeTrendingMoviesDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 trendingMovieSeatReservationBtn;
        private Label trendingMoviePriceDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton addTrendingToWatchLaterBtn;
        private Label trendingMovieTitleDetails;
        private PictureBox trendingDetailsPictureBox;
        private Panel comingSoonMovieDetailsPanel;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton closeComingSoonMovieDetailsBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 comingSoonMovieSeatReservationBtn;
        private Label comingSoonPriceDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton addComingSoonToWatchLater;
        private Label comingSoonTitleDetails;
        private PictureBox comingSoonMoviePicBoxDetails;
        private Label comingSoonMovieDescriptionDetails;
        private Panel filmsDetailsPanel;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton closeFilmsDetailsBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 filmsMovieSeatReservationBtn;
        private Label filmsPriceDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton addFilmMovieToWatchLaterBtn;
        private Label filmsTitleDetails;
        private PictureBox filmsPictureBoxDetails;
        private Panel foodDetailsPanel;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton closeFoodDetailsBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 snackDealsReservedSeatBtn;
        private Label foodPriceDetails;
        private Label foodNameDetails;
        private PictureBox foodPicDetails;
        private Guna.UI2.WinForms.Guna2Button reserveSeatBtn;
        private Guna.UI2.WinForms.Guna2CircleButton LeftTurnBtn;
        private Guna.UI2.WinForms.Guna2CircleButton rightTurnBtn;
        private PictureBox logoBefore;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button SettingBtn;
        private Guna.UI2.WinForms.Guna2Button LogoutBtn;
        private Guna.UI2.WinForms.Guna2Button gotoWatchListBtn;
        private Guna.UI2.WinForms.Guna2Button gotoTicketFormBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox userNameHolder;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton bunifuFormCaptionButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Label label16;
        private Panel yummy4;
        private Panel yummy5;
        private FlowLayoutPanel snacksFlowLayoutPanel;
        private Panel snack1;
        private Panel snack2;
        private Panel snack3;
        private Panel snack4;
        private Panel snack5;
        private Panel panel18;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox changeNewUsernameInput;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 saveUserNameOrPasswordBtn;
        private Guna.UI2.WinForms.Guna2TextBox changeConfirmNewPasswordInput;
        private Guna.UI2.WinForms.Guna2TextBox changePasswordInput;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 saveUserPicOrNameBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userProfileBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userProfileCustomHolder;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button SignUpBtn;
        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Label label8;
        private Guna.UI2.WinForms.Guna2TextBox prevPasswordInput;
        private Guna.UI2.WinForms.Guna2TextBox changePrevEmailInput;
        private Guna.UI2.WinForms.Guna2Button changePicBtn;
        private RichTextBox filmsDescriptionDetails;
        private RichTextBox trendingDescriptionDetails;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Button exitApplicationBtn;
    }
}


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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges137 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges138 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges139 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges140 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges141 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties33 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties34 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties35 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties36 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges142 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges143 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges144 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges145 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges146 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges147 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges148 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges149 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges150 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges151 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges152 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges153 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.TicketBtn = new System.Windows.Forms.Button();
            this.FavBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.filmsInCinemaPanel = new System.Windows.Forms.Panel();
            this.reserveSeatBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.panel15 = new System.Windows.Forms.Panel();
            this.LeftTurnBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.rightTurnBtn = new Bunifu.UI.WinForms.BunifuImageButton();
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
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
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.exisSearchBtn = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.searchInput = new Bunifu.UI.WinForms.BunifuTextBox();
            this.logoBefore = new System.Windows.Forms.PictureBox();
            this.searchBtnBefore = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.userNameHolder = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.logoAfter = new System.Windows.Forms.PictureBox();
            this.searchResultsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchResultFlowWholePanel = new System.Windows.Forms.Panel();
            this.foodDetailsPanel = new System.Windows.Forms.Panel();
            this.closeDetails = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.foodPriceDetails = new System.Windows.Forms.Label();
            this.foodNameDetails = new System.Windows.Forms.Label();
            this.foodPicDetails = new System.Windows.Forms.PictureBox();
            this.comingSoonMovieDetailsPanel = new System.Windows.Forms.Panel();
            this.reservedBtnFromDetails = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.comingSoonPriceDetails = new System.Windows.Forms.Label();
            this.addToWatchLaterBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.closeComingSoonMovieDetailsBtn = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.comingSoonMovieDescriptionDetails = new System.Windows.Forms.Label();
            this.comingSoonTitleDetails = new System.Windows.Forms.Label();
            this.comingSoonMoviePicBoxDetails = new System.Windows.Forms.PictureBox();
            this.filmsDetailsPanel = new System.Windows.Forms.Panel();
            this.bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.filmsPriceDetails = new System.Windows.Forms.Label();
            this.bunifuIconButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.closeFilmsDetailsBtn = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.filmsDescriptionDetails = new System.Windows.Forms.Label();
            this.filmsTitleDetails = new System.Windows.Forms.Label();
            this.filmsPictureBoxDetails = new System.Windows.Forms.PictureBox();
            this.trendingMoviesDetailsPanel = new System.Windows.Forms.Panel();
            this.bunifuButton22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.trendingMoviePriceDetails = new System.Windows.Forms.Label();
            this.bunifuIconButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.closeTrendingMoviesDetails = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.trendingMovieTitleDetails = new System.Windows.Forms.Label();
            this.trendingDetailsPictureBox = new System.Windows.Forms.PictureBox();
            this.trendingDescriptionDetails = new System.Windows.Forms.Label();
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
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.filmsInCinemaPanel.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.yummyFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fourthCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCircle)).BeginInit();
            this.panel5.SuspendLayout();
            this.ComingSoonFlowLayoutPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel13.SuspendLayout();
            this.FilmsInCinemaFlowLayout.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.userPanel.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoAfter)).BeginInit();
            this.searchResultFlowWholePanel.SuspendLayout();
            this.foodDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicDetails)).BeginInit();
            this.comingSoonMovieDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comingSoonMoviePicBoxDetails)).BeginInit();
            this.filmsDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsPictureBoxDetails)).BeginInit();
            this.trendingMoviesDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trendingDetailsPictureBox)).BeginInit();
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(101, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1094, 599);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // filmsInCinemaPanel
            // 
            this.filmsInCinemaPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.filmsInCinemaPanel.BackColor = System.Drawing.Color.Transparent;
            this.filmsInCinemaPanel.Controls.Add(this.reserveSeatBtn);
            this.filmsInCinemaPanel.Controls.Add(this.panel15);
            this.filmsInCinemaPanel.Controls.Add(this.panel14);
            this.filmsInCinemaPanel.Controls.Add(this.yummyFlowLayoutPanel);
            this.filmsInCinemaPanel.Controls.Add(this.fourthCircle);
            this.filmsInCinemaPanel.Controls.Add(this.thirdCircle);
            this.filmsInCinemaPanel.Controls.Add(this.secondCircle);
            this.filmsInCinemaPanel.Controls.Add(this.firstCircle);
            this.filmsInCinemaPanel.Controls.Add(this.panel5);
            this.filmsInCinemaPanel.Controls.Add(this.ComingSoonFlowLayoutPanel);
            this.filmsInCinemaPanel.Controls.Add(this.panel3);
            this.filmsInCinemaPanel.Controls.Add(this.panel13);
            this.filmsInCinemaPanel.Controls.Add(this.FilmsInCinemaFlowLayout);
            this.filmsInCinemaPanel.Controls.Add(this.panel4);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxRight);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxLeft);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxMain);
            this.filmsInCinemaPanel.Location = new System.Drawing.Point(3, 3);
            this.filmsInCinemaPanel.Name = "filmsInCinemaPanel";
            this.filmsInCinemaPanel.Size = new System.Drawing.Size(1083, 1734);
            this.filmsInCinemaPanel.TabIndex = 0;
            // 
            // reserveSeatBtn
            // 
            this.reserveSeatBtn.AllowAnimations = true;
            this.reserveSeatBtn.AllowMouseEffects = true;
            this.reserveSeatBtn.AllowToggling = false;
            this.reserveSeatBtn.AnimationSpeed = 200;
            this.reserveSeatBtn.AutoGenerateColors = false;
            this.reserveSeatBtn.AutoRoundBorders = false;
            this.reserveSeatBtn.AutoSizeLeftIcon = true;
            this.reserveSeatBtn.AutoSizeRightIcon = true;
            this.reserveSeatBtn.BackColor = System.Drawing.Color.Transparent;
            this.reserveSeatBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.reserveSeatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reserveSeatBtn.BackgroundImage")));
            this.reserveSeatBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.reserveSeatBtn.ButtonText = "RESERVE SEAT";
            this.reserveSeatBtn.ButtonTextMarginLeft = 0;
            this.reserveSeatBtn.ColorContrastOnClick = 45;
            this.reserveSeatBtn.ColorContrastOnHover = 45;
            this.reserveSeatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges137.BottomLeft = true;
            borderEdges137.BottomRight = true;
            borderEdges137.TopLeft = true;
            borderEdges137.TopRight = true;
            this.reserveSeatBtn.CustomizableEdges = borderEdges137;
            this.reserveSeatBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.reserveSeatBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.reserveSeatBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.reserveSeatBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.reserveSeatBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.reserveSeatBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reserveSeatBtn.ForeColor = System.Drawing.Color.White;
            this.reserveSeatBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reserveSeatBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.reserveSeatBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.reserveSeatBtn.IconMarginLeft = 11;
            this.reserveSeatBtn.IconPadding = 10;
            this.reserveSeatBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reserveSeatBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.reserveSeatBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.reserveSeatBtn.IconSize = 25;
            this.reserveSeatBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.reserveSeatBtn.IdleBorderRadius = 1;
            this.reserveSeatBtn.IdleBorderThickness = 1;
            this.reserveSeatBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.reserveSeatBtn.IdleIconLeftImage = null;
            this.reserveSeatBtn.IdleIconRightImage = null;
            this.reserveSeatBtn.IndicateFocus = false;
            this.reserveSeatBtn.Location = new System.Drawing.Point(598, 355);
            this.reserveSeatBtn.Name = "reserveSeatBtn";
            this.reserveSeatBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.reserveSeatBtn.OnDisabledState.BorderRadius = 1;
            this.reserveSeatBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.reserveSeatBtn.OnDisabledState.BorderThickness = 1;
            this.reserveSeatBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.reserveSeatBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.reserveSeatBtn.OnDisabledState.IconLeftImage = null;
            this.reserveSeatBtn.OnDisabledState.IconRightImage = null;
            this.reserveSeatBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.reserveSeatBtn.onHoverState.BorderRadius = 1;
            this.reserveSeatBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.reserveSeatBtn.onHoverState.BorderThickness = 1;
            this.reserveSeatBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.reserveSeatBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.reserveSeatBtn.onHoverState.IconLeftImage = null;
            this.reserveSeatBtn.onHoverState.IconRightImage = null;
            this.reserveSeatBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.reserveSeatBtn.OnIdleState.BorderRadius = 1;
            this.reserveSeatBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.reserveSeatBtn.OnIdleState.BorderThickness = 1;
            this.reserveSeatBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.reserveSeatBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.reserveSeatBtn.OnIdleState.IconLeftImage = null;
            this.reserveSeatBtn.OnIdleState.IconRightImage = null;
            this.reserveSeatBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.reserveSeatBtn.OnPressedState.BorderRadius = 1;
            this.reserveSeatBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.reserveSeatBtn.OnPressedState.BorderThickness = 1;
            this.reserveSeatBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.reserveSeatBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.reserveSeatBtn.OnPressedState.IconLeftImage = null;
            this.reserveSeatBtn.OnPressedState.IconRightImage = null;
            this.reserveSeatBtn.Size = new System.Drawing.Size(143, 37);
            this.reserveSeatBtn.TabIndex = 40;
            this.reserveSeatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reserveSeatBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.reserveSeatBtn.TextMarginLeft = 0;
            this.reserveSeatBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.reserveSeatBtn.UseDefaultRadiusAndThickness = true;
            this.reserveSeatBtn.Click += new System.EventHandler(this.reserveSeatBtn_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.LeftTurnBtn);
            this.panel15.Location = new System.Drawing.Point(161, 226);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(90, 90);
            this.panel15.TabIndex = 42;
            // 
            // LeftTurnBtn
            // 
            this.LeftTurnBtn.ActiveImage = null;
            this.LeftTurnBtn.AllowAnimations = true;
            this.LeftTurnBtn.AllowBuffering = false;
            this.LeftTurnBtn.AllowToggling = false;
            this.LeftTurnBtn.AllowZooming = true;
            this.LeftTurnBtn.AllowZoomingOnFocus = true;
            this.LeftTurnBtn.BackColor = System.Drawing.Color.Transparent;
            this.LeftTurnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LeftTurnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftTurnBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LeftTurnBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("LeftTurnBtn.ErrorImage")));
            this.LeftTurnBtn.FadeWhenInactive = false;
            this.LeftTurnBtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.LeftTurnBtn.Image = global::MovieMunch.Properties.Resources.leftBtn;
            this.LeftTurnBtn.ImageActive = null;
            this.LeftTurnBtn.ImageLocation = null;
            this.LeftTurnBtn.ImageMargin = 20;
            this.LeftTurnBtn.ImageSize = new System.Drawing.Size(70, 70);
            this.LeftTurnBtn.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.LeftTurnBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("LeftTurnBtn.InitialImage")));
            this.LeftTurnBtn.Location = new System.Drawing.Point(0, -3);
            this.LeftTurnBtn.Name = "LeftTurnBtn";
            this.LeftTurnBtn.Rotation = 0;
            this.LeftTurnBtn.ShowActiveImage = true;
            this.LeftTurnBtn.ShowCursorChanges = true;
            this.LeftTurnBtn.ShowImageBorders = false;
            this.LeftTurnBtn.ShowSizeMarkers = false;
            this.LeftTurnBtn.Size = new System.Drawing.Size(90, 90);
            this.LeftTurnBtn.TabIndex = 38;
            this.LeftTurnBtn.ToolTipText = "";
            this.LeftTurnBtn.WaitOnLoad = false;
            this.LeftTurnBtn.Zoom = 20;
            this.LeftTurnBtn.ZoomSpeed = 10;
            this.LeftTurnBtn.Click += new System.EventHandler(this.LeftTurnBtn_Click_1);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.rightTurnBtn);
            this.panel14.Location = new System.Drawing.Point(831, 223);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(90, 90);
            this.panel14.TabIndex = 41;
            // 
            // rightTurnBtn
            // 
            this.rightTurnBtn.ActiveImage = null;
            this.rightTurnBtn.AllowAnimations = true;
            this.rightTurnBtn.AllowBuffering = false;
            this.rightTurnBtn.AllowToggling = false;
            this.rightTurnBtn.AllowZooming = true;
            this.rightTurnBtn.AllowZoomingOnFocus = true;
            this.rightTurnBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rightTurnBtn.BackColor = System.Drawing.Color.Transparent;
            this.rightTurnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rightTurnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightTurnBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rightTurnBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("rightTurnBtn.ErrorImage")));
            this.rightTurnBtn.FadeWhenInactive = false;
            this.rightTurnBtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.rightTurnBtn.Image = global::MovieMunch.Properties.Resources.right;
            this.rightTurnBtn.ImageActive = null;
            this.rightTurnBtn.ImageLocation = null;
            this.rightTurnBtn.ImageMargin = 20;
            this.rightTurnBtn.ImageSize = new System.Drawing.Size(70, 70);
            this.rightTurnBtn.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.rightTurnBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rightTurnBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("rightTurnBtn.InitialImage")));
            this.rightTurnBtn.Location = new System.Drawing.Point(0, 3);
            this.rightTurnBtn.Name = "rightTurnBtn";
            this.rightTurnBtn.Rotation = 0;
            this.rightTurnBtn.ShowActiveImage = true;
            this.rightTurnBtn.ShowCursorChanges = true;
            this.rightTurnBtn.ShowImageBorders = false;
            this.rightTurnBtn.ShowSizeMarkers = false;
            this.rightTurnBtn.Size = new System.Drawing.Size(90, 90);
            this.rightTurnBtn.TabIndex = 38;
            this.rightTurnBtn.ToolTipText = "";
            this.rightTurnBtn.WaitOnLoad = false;
            this.rightTurnBtn.Zoom = 20;
            this.rightTurnBtn.ZoomSpeed = 10;
            this.rightTurnBtn.Click += new System.EventHandler(this.rightTurnBtn_Click);
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
            this.yummyFlowLayoutPanel.Size = new System.Drawing.Size(1083, 482);
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
            this.yummy1.Location = new System.Drawing.Point(0, 25);
            this.yummy1.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.yummy1.MinimumSize = new System.Drawing.Size(150, 250);
            this.yummy1.Name = "yummy1";
            this.yummy1.Size = new System.Drawing.Size(560, 323);
            this.yummy1.TabIndex = 3;
            // 
            // yummy2
            // 
            this.yummy2.BackColor = System.Drawing.Color.Transparent;
            this.yummy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yummy2.Location = new System.Drawing.Point(580, 25);
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
            this.yummy3.Location = new System.Drawing.Point(1160, 25);
            this.yummy3.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
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
            this.ComingSoonFlowLayoutPanel.Size = new System.Drawing.Size(1086, 340);
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
            this.soon8.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
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
            this.FilmsInCinemaFlowLayout.Size = new System.Drawing.Size(1083, 342);
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
            this.films8.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
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
            this.userPanel.Location = new System.Drawing.Point(101, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(254, 650);
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
            borderEdges138.BottomLeft = true;
            borderEdges138.BottomRight = true;
            borderEdges138.TopLeft = true;
            borderEdges138.TopRight = true;
            this.LogoutBtn.CustomizableEdges = borderEdges138;
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
            borderEdges139.BottomLeft = true;
            borderEdges139.BottomRight = true;
            borderEdges139.TopLeft = true;
            borderEdges139.TopRight = true;
            this.SignUpBtn.CustomizableEdges = borderEdges139;
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
            borderEdges140.BottomLeft = true;
            borderEdges140.BottomRight = true;
            borderEdges140.TopLeft = true;
            borderEdges140.TopRight = true;
            this.LoginBtn.CustomizableEdges = borderEdges140;
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
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.exisSearchBtn);
            this.bunifuPanel1.Controls.Add(this.searchInput);
            this.bunifuPanel1.Controls.Add(this.logoBefore);
            this.bunifuPanel1.Controls.Add(this.searchBtnBefore);
            this.bunifuPanel1.Controls.Add(this.userNameHolder);
            this.bunifuPanel1.Controls.Add(this.logoAfter);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(101, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1162, 79);
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
            borderEdges141.BottomLeft = true;
            borderEdges141.BottomRight = true;
            borderEdges141.TopLeft = true;
            borderEdges141.TopRight = true;
            this.exisSearchBtn.CustomizableEdges = borderEdges141;
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
            stateProperties33.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            stateProperties33.FillColor = System.Drawing.Color.Empty;
            stateProperties33.ForeColor = System.Drawing.Color.Empty;
            stateProperties33.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchInput.OnActiveState = stateProperties33;
            stateProperties34.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties34.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties34.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchInput.OnDisabledState = stateProperties34;
            stateProperties35.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties35.FillColor = System.Drawing.Color.Empty;
            stateProperties35.ForeColor = System.Drawing.Color.Empty;
            stateProperties35.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchInput.OnHoverState = stateProperties35;
            stateProperties36.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            stateProperties36.FillColor = System.Drawing.Color.White;
            stateProperties36.ForeColor = System.Drawing.Color.Empty;
            stateProperties36.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchInput.OnIdleState = stateProperties36;
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
            this.logoBefore.Location = new System.Drawing.Point(680, -18);
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
            borderEdges142.BottomLeft = true;
            borderEdges142.BottomRight = true;
            borderEdges142.TopLeft = true;
            borderEdges142.TopRight = true;
            this.searchBtnBefore.CustomizableEdges = borderEdges142;
            this.searchBtnBefore.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchBtnBefore.Image = null;
            this.searchBtnBefore.ImageMargin = new System.Windows.Forms.Padding(0);
            this.searchBtnBefore.Location = new System.Drawing.Point(906, 12);
            this.searchBtnBefore.Name = "searchBtnBefore";
            this.searchBtnBefore.RoundBorders = true;
            this.searchBtnBefore.ShowBorders = true;
            this.searchBtnBefore.Size = new System.Drawing.Size(57, 57);
            this.searchBtnBefore.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.searchBtnBefore.TabIndex = 44;
            this.searchBtnBefore.Click += new System.EventHandler(this.searchBtn_Click_1);
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
            this.userNameHolder.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.userNameHolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userNameHolder.BackgroundImage")));
            this.userNameHolder.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.userNameHolder.ButtonText = "MM";
            this.userNameHolder.ButtonTextMarginLeft = 0;
            this.userNameHolder.ColorContrastOnClick = 45;
            this.userNameHolder.ColorContrastOnHover = 45;
            this.userNameHolder.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges143.BottomLeft = true;
            borderEdges143.BottomRight = true;
            borderEdges143.TopLeft = true;
            borderEdges143.TopRight = true;
            this.userNameHolder.CustomizableEdges = borderEdges143;
            this.userNameHolder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.userNameHolder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.userNameHolder.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.userNameHolder.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.userNameHolder.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.userNameHolder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameHolder.ForeColor = System.Drawing.Color.White;
            this.userNameHolder.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userNameHolder.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.userNameHolder.IconLeftPadding = new System.Windows.Forms.Padding(3);
            this.userNameHolder.IconMarginLeft = 11;
            this.userNameHolder.IconPadding = 10;
            this.userNameHolder.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userNameHolder.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.userNameHolder.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.userNameHolder.IconSize = 25;
            this.userNameHolder.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.userNameHolder.IdleBorderRadius = 55;
            this.userNameHolder.IdleBorderThickness = 1;
            this.userNameHolder.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
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
            this.userNameHolder.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.userNameHolder.OnIdleState.BorderRadius = 50;
            this.userNameHolder.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.userNameHolder.OnIdleState.BorderThickness = 1;
            this.userNameHolder.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.userNameHolder.OnIdleState.ForeColor = System.Drawing.Color.White;
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
            // logoAfter
            // 
            this.logoAfter.BackColor = System.Drawing.Color.Transparent;
            this.logoAfter.BackgroundImage = global::MovieMunch.Properties.Resources.MovieM_removebg_preview;
            this.logoAfter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoAfter.Location = new System.Drawing.Point(245, -18);
            this.logoAfter.Name = "logoAfter";
            this.logoAfter.Size = new System.Drawing.Size(195, 135);
            this.logoAfter.TabIndex = 46;
            this.logoAfter.TabStop = false;
            this.logoAfter.Visible = false;
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
            // foodDetailsPanel
            // 
            this.foodDetailsPanel.Controls.Add(this.closeDetails);
            this.foodDetailsPanel.Controls.Add(this.foodPriceDetails);
            this.foodDetailsPanel.Controls.Add(this.foodNameDetails);
            this.foodDetailsPanel.Controls.Add(this.foodPicDetails);
            this.foodDetailsPanel.Location = new System.Drawing.Point(101, 0);
            this.foodDetailsPanel.Name = "foodDetailsPanel";
            this.foodDetailsPanel.Size = new System.Drawing.Size(1097, 650);
            this.foodDetailsPanel.TabIndex = 45;
            this.foodDetailsPanel.Visible = false;
            // 
            // closeDetails
            // 
            this.closeDetails.AllowAnimations = true;
            this.closeDetails.AllowBorderColorChanges = true;
            this.closeDetails.AllowDefaults = true;
            this.closeDetails.AllowMouseEffects = true;
            this.closeDetails.AnimationSpeed = 200;
            this.closeDetails.AutoSizeCaptions = true;
            this.closeDetails.BackColor = System.Drawing.Color.Transparent;
            this.closeDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.closeDetails.BackHoverColor = System.Drawing.Color.LightGray;
            this.closeDetails.BackPressedColor = System.Drawing.Color.Silver;
            this.closeDetails.BorderColor = System.Drawing.Color.LightGray;
            this.closeDetails.BorderHoverColor = System.Drawing.Color.DarkGray;
            this.closeDetails.BorderPressedColor = System.Drawing.Color.DarkGray;
            this.closeDetails.BorderRadius = 0;
            this.closeDetails.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.closeDetails.BorderThickness = 1;
            this.closeDetails.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            this.closeDetails.ColorContrastOnClick = 30;
            this.closeDetails.ColorContrastOnHover = 30;
            this.closeDetails.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges144.BottomLeft = true;
            borderEdges144.BottomRight = true;
            borderEdges144.TopLeft = true;
            borderEdges144.TopRight = true;
            this.closeDetails.CustomizableEdges = borderEdges144;
            this.closeDetails.DefaultBorderColor = System.Drawing.Color.Silver;
            this.closeDetails.DefaultColor = System.Drawing.Color.Gainsboro;
            this.closeDetails.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeDetails.IconColor = System.Drawing.Color.Black;
            this.closeDetails.IconHoverColor = System.Drawing.Color.Black;
            this.closeDetails.IconPressedColor = System.Drawing.Color.Black;
            this.closeDetails.Image = ((System.Drawing.Image)(resources.GetObject("closeDetails.Image")));
            this.closeDetails.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.closeDetails.ImageSize = new System.Drawing.Size(20, 20);
            this.closeDetails.Location = new System.Drawing.Point(1046, 12);
            this.closeDetails.Name = "closeDetails";
            this.closeDetails.ShowBorders = true;
            this.closeDetails.Size = new System.Drawing.Size(40, 38);
            this.closeDetails.TabIndex = 5;
            this.closeDetails.Click += new System.EventHandler(this.closeFoodDetails_Click);
            // 
            // foodPriceDetails
            // 
            this.foodPriceDetails.AutoSize = true;
            this.foodPriceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodPriceDetails.ForeColor = System.Drawing.Color.White;
            this.foodPriceDetails.Location = new System.Drawing.Point(668, 182);
            this.foodPriceDetails.Name = "foodPriceDetails";
            this.foodPriceDetails.Size = new System.Drawing.Size(200, 69);
            this.foodPriceDetails.TabIndex = 2;
            this.foodPriceDetails.Text = "Price: ";
            // 
            // foodNameDetails
            // 
            this.foodNameDetails.AutoSize = true;
            this.foodNameDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameDetails.ForeColor = System.Drawing.Color.White;
            this.foodNameDetails.Location = new System.Drawing.Point(668, 61);
            this.foodNameDetails.Name = "foodNameDetails";
            this.foodNameDetails.Size = new System.Drawing.Size(358, 69);
            this.foodNameDetails.TabIndex = 1;
            this.foodNameDetails.Text = "Food Name:";
            // 
            // foodPicDetails
            // 
            this.foodPicDetails.Location = new System.Drawing.Point(53, 39);
            this.foodPicDetails.Name = "foodPicDetails";
            this.foodPicDetails.Size = new System.Drawing.Size(560, 323);
            this.foodPicDetails.TabIndex = 0;
            this.foodPicDetails.TabStop = false;
            // 
            // comingSoonMovieDetailsPanel
            // 
            this.comingSoonMovieDetailsPanel.Controls.Add(this.reservedBtnFromDetails);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.comingSoonPriceDetails);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.addToWatchLaterBtn);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.closeComingSoonMovieDetailsBtn);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.comingSoonMovieDescriptionDetails);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.comingSoonTitleDetails);
            this.comingSoonMovieDetailsPanel.Controls.Add(this.comingSoonMoviePicBoxDetails);
            this.comingSoonMovieDetailsPanel.Location = new System.Drawing.Point(101, 0);
            this.comingSoonMovieDetailsPanel.Name = "comingSoonMovieDetailsPanel";
            this.comingSoonMovieDetailsPanel.Size = new System.Drawing.Size(1097, 650);
            this.comingSoonMovieDetailsPanel.TabIndex = 46;
            this.comingSoonMovieDetailsPanel.Visible = false;
            // 
            // reservedBtnFromDetails
            // 
            this.reservedBtnFromDetails.AllowAnimations = true;
            this.reservedBtnFromDetails.AllowMouseEffects = true;
            this.reservedBtnFromDetails.AllowToggling = false;
            this.reservedBtnFromDetails.AnimationSpeed = 200;
            this.reservedBtnFromDetails.AutoGenerateColors = false;
            this.reservedBtnFromDetails.AutoRoundBorders = true;
            this.reservedBtnFromDetails.AutoSizeLeftIcon = true;
            this.reservedBtnFromDetails.AutoSizeRightIcon = true;
            this.reservedBtnFromDetails.BackColor = System.Drawing.Color.Transparent;
            this.reservedBtnFromDetails.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.reservedBtnFromDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reservedBtnFromDetails.BackgroundImage")));
            this.reservedBtnFromDetails.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.reservedBtnFromDetails.ButtonText = "RESERVE SEAT";
            this.reservedBtnFromDetails.ButtonTextMarginLeft = 0;
            this.reservedBtnFromDetails.ColorContrastOnClick = 45;
            this.reservedBtnFromDetails.ColorContrastOnHover = 45;
            this.reservedBtnFromDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges145.BottomLeft = true;
            borderEdges145.BottomRight = true;
            borderEdges145.TopLeft = true;
            borderEdges145.TopRight = true;
            this.reservedBtnFromDetails.CustomizableEdges = borderEdges145;
            this.reservedBtnFromDetails.DialogResult = System.Windows.Forms.DialogResult.None;
            this.reservedBtnFromDetails.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.reservedBtnFromDetails.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.reservedBtnFromDetails.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.reservedBtnFromDetails.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.reservedBtnFromDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reservedBtnFromDetails.ForeColor = System.Drawing.Color.White;
            this.reservedBtnFromDetails.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservedBtnFromDetails.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.reservedBtnFromDetails.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.reservedBtnFromDetails.IconMarginLeft = 11;
            this.reservedBtnFromDetails.IconPadding = 10;
            this.reservedBtnFromDetails.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reservedBtnFromDetails.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.reservedBtnFromDetails.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.reservedBtnFromDetails.IconSize = 25;
            this.reservedBtnFromDetails.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.reservedBtnFromDetails.IdleBorderRadius = 52;
            this.reservedBtnFromDetails.IdleBorderThickness = 1;
            this.reservedBtnFromDetails.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.reservedBtnFromDetails.IdleIconLeftImage = null;
            this.reservedBtnFromDetails.IdleIconRightImage = null;
            this.reservedBtnFromDetails.IndicateFocus = false;
            this.reservedBtnFromDetails.Location = new System.Drawing.Point(756, 301);
            this.reservedBtnFromDetails.Name = "reservedBtnFromDetails";
            this.reservedBtnFromDetails.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.reservedBtnFromDetails.OnDisabledState.BorderRadius = 1;
            this.reservedBtnFromDetails.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.reservedBtnFromDetails.OnDisabledState.BorderThickness = 1;
            this.reservedBtnFromDetails.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.reservedBtnFromDetails.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.reservedBtnFromDetails.OnDisabledState.IconLeftImage = null;
            this.reservedBtnFromDetails.OnDisabledState.IconRightImage = null;
            this.reservedBtnFromDetails.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.reservedBtnFromDetails.onHoverState.BorderRadius = 1;
            this.reservedBtnFromDetails.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.reservedBtnFromDetails.onHoverState.BorderThickness = 1;
            this.reservedBtnFromDetails.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.reservedBtnFromDetails.onHoverState.ForeColor = System.Drawing.Color.White;
            this.reservedBtnFromDetails.onHoverState.IconLeftImage = null;
            this.reservedBtnFromDetails.onHoverState.IconRightImage = null;
            this.reservedBtnFromDetails.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.reservedBtnFromDetails.OnIdleState.BorderRadius = 1;
            this.reservedBtnFromDetails.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.reservedBtnFromDetails.OnIdleState.BorderThickness = 1;
            this.reservedBtnFromDetails.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.reservedBtnFromDetails.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.reservedBtnFromDetails.OnIdleState.IconLeftImage = null;
            this.reservedBtnFromDetails.OnIdleState.IconRightImage = null;
            this.reservedBtnFromDetails.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.reservedBtnFromDetails.OnPressedState.BorderRadius = 1;
            this.reservedBtnFromDetails.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.reservedBtnFromDetails.OnPressedState.BorderThickness = 1;
            this.reservedBtnFromDetails.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.reservedBtnFromDetails.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.reservedBtnFromDetails.OnPressedState.IconLeftImage = null;
            this.reservedBtnFromDetails.OnPressedState.IconRightImage = null;
            this.reservedBtnFromDetails.Size = new System.Drawing.Size(165, 54);
            this.reservedBtnFromDetails.TabIndex = 47;
            this.reservedBtnFromDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reservedBtnFromDetails.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.reservedBtnFromDetails.TextMarginLeft = 0;
            this.reservedBtnFromDetails.TextPadding = new System.Windows.Forms.Padding(0);
            this.reservedBtnFromDetails.UseDefaultRadiusAndThickness = true;
            // 
            // comingSoonPriceDetails
            // 
            this.comingSoonPriceDetails.AutoSize = true;
            this.comingSoonPriceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comingSoonPriceDetails.ForeColor = System.Drawing.Color.White;
            this.comingSoonPriceDetails.Location = new System.Drawing.Point(630, 182);
            this.comingSoonPriceDetails.Name = "comingSoonPriceDetails";
            this.comingSoonPriceDetails.Size = new System.Drawing.Size(167, 69);
            this.comingSoonPriceDetails.TabIndex = 46;
            this.comingSoonPriceDetails.Text = "Price";
            // 
            // addToWatchLaterBtn
            // 
            this.addToWatchLaterBtn.AllowAnimations = true;
            this.addToWatchLaterBtn.AllowBorderColorChanges = true;
            this.addToWatchLaterBtn.AllowMouseEffects = true;
            this.addToWatchLaterBtn.AnimationSpeed = 200;
            this.addToWatchLaterBtn.BackColor = System.Drawing.Color.Transparent;
            this.addToWatchLaterBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.addToWatchLaterBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addToWatchLaterBtn.BackgroundImage")));
            this.addToWatchLaterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addToWatchLaterBtn.BorderColor = System.Drawing.Color.Transparent;
            this.addToWatchLaterBtn.BorderRadius = 1;
            this.addToWatchLaterBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.addToWatchLaterBtn.BorderThickness = 1;
            this.addToWatchLaterBtn.ColorContrastOnClick = 30;
            this.addToWatchLaterBtn.ColorContrastOnHover = 30;
            this.addToWatchLaterBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges146.BottomLeft = true;
            borderEdges146.BottomRight = true;
            borderEdges146.TopLeft = true;
            borderEdges146.TopRight = true;
            this.addToWatchLaterBtn.CustomizableEdges = borderEdges146;
            this.addToWatchLaterBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addToWatchLaterBtn.Image = null;
            this.addToWatchLaterBtn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.addToWatchLaterBtn.Location = new System.Drawing.Point(661, 298);
            this.addToWatchLaterBtn.Name = "addToWatchLaterBtn";
            this.addToWatchLaterBtn.RoundBorders = true;
            this.addToWatchLaterBtn.ShowBorders = true;
            this.addToWatchLaterBtn.Size = new System.Drawing.Size(57, 57);
            this.addToWatchLaterBtn.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.addToWatchLaterBtn.TabIndex = 45;
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
            this.closeComingSoonMovieDetailsBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.closeComingSoonMovieDetailsBtn.BackHoverColor = System.Drawing.Color.LightGray;
            this.closeComingSoonMovieDetailsBtn.BackPressedColor = System.Drawing.Color.Silver;
            this.closeComingSoonMovieDetailsBtn.BorderColor = System.Drawing.Color.LightGray;
            this.closeComingSoonMovieDetailsBtn.BorderHoverColor = System.Drawing.Color.DarkGray;
            this.closeComingSoonMovieDetailsBtn.BorderPressedColor = System.Drawing.Color.DarkGray;
            this.closeComingSoonMovieDetailsBtn.BorderRadius = 0;
            this.closeComingSoonMovieDetailsBtn.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.closeComingSoonMovieDetailsBtn.BorderThickness = 1;
            this.closeComingSoonMovieDetailsBtn.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            this.closeComingSoonMovieDetailsBtn.ColorContrastOnClick = 30;
            this.closeComingSoonMovieDetailsBtn.ColorContrastOnHover = 30;
            this.closeComingSoonMovieDetailsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges147.BottomLeft = true;
            borderEdges147.BottomRight = true;
            borderEdges147.TopLeft = true;
            borderEdges147.TopRight = true;
            this.closeComingSoonMovieDetailsBtn.CustomizableEdges = borderEdges147;
            this.closeComingSoonMovieDetailsBtn.DefaultBorderColor = System.Drawing.Color.Silver;
            this.closeComingSoonMovieDetailsBtn.DefaultColor = System.Drawing.Color.Gainsboro;
            this.closeComingSoonMovieDetailsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeComingSoonMovieDetailsBtn.IconColor = System.Drawing.Color.Black;
            this.closeComingSoonMovieDetailsBtn.IconHoverColor = System.Drawing.Color.Black;
            this.closeComingSoonMovieDetailsBtn.IconPressedColor = System.Drawing.Color.Black;
            this.closeComingSoonMovieDetailsBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeComingSoonMovieDetailsBtn.Image")));
            this.closeComingSoonMovieDetailsBtn.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.closeComingSoonMovieDetailsBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.closeComingSoonMovieDetailsBtn.Location = new System.Drawing.Point(1046, 12);
            this.closeComingSoonMovieDetailsBtn.Name = "closeComingSoonMovieDetailsBtn";
            this.closeComingSoonMovieDetailsBtn.ShowBorders = true;
            this.closeComingSoonMovieDetailsBtn.Size = new System.Drawing.Size(40, 38);
            this.closeComingSoonMovieDetailsBtn.TabIndex = 5;
            this.closeComingSoonMovieDetailsBtn.Click += new System.EventHandler(this.closeComingSoonMovieDetailsBtn_Click);
            // 
            // comingSoonMovieDescriptionDetails
            // 
            this.comingSoonMovieDescriptionDetails.AutoSize = true;
            this.comingSoonMovieDescriptionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comingSoonMovieDescriptionDetails.ForeColor = System.Drawing.Color.White;
            this.comingSoonMovieDescriptionDetails.Location = new System.Drawing.Point(45, 458);
            this.comingSoonMovieDescriptionDetails.Name = "comingSoonMovieDescriptionDetails";
            this.comingSoonMovieDescriptionDetails.Size = new System.Drawing.Size(165, 36);
            this.comingSoonMovieDescriptionDetails.TabIndex = 2;
            this.comingSoonMovieDescriptionDetails.Text = "Description";
            // 
            // comingSoonTitleDetails
            // 
            this.comingSoonTitleDetails.AutoSize = true;
            this.comingSoonTitleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comingSoonTitleDetails.ForeColor = System.Drawing.Color.White;
            this.comingSoonTitleDetails.Location = new System.Drawing.Point(48, 369);
            this.comingSoonTitleDetails.Name = "comingSoonTitleDetails";
            this.comingSoonTitleDetails.Size = new System.Drawing.Size(522, 69);
            this.comingSoonTitleDetails.TabIndex = 1;
            this.comingSoonTitleDetails.Text = "Coming Soon Title";
            // 
            // comingSoonMoviePicBoxDetails
            // 
            this.comingSoonMoviePicBoxDetails.Location = new System.Drawing.Point(53, 39);
            this.comingSoonMoviePicBoxDetails.Name = "comingSoonMoviePicBoxDetails";
            this.comingSoonMoviePicBoxDetails.Size = new System.Drawing.Size(560, 323);
            this.comingSoonMoviePicBoxDetails.TabIndex = 0;
            this.comingSoonMoviePicBoxDetails.TabStop = false;
            // 
            // filmsDetailsPanel
            // 
            this.filmsDetailsPanel.Controls.Add(this.bunifuButton21);
            this.filmsDetailsPanel.Controls.Add(this.filmsPriceDetails);
            this.filmsDetailsPanel.Controls.Add(this.bunifuIconButton1);
            this.filmsDetailsPanel.Controls.Add(this.closeFilmsDetailsBtn);
            this.filmsDetailsPanel.Controls.Add(this.filmsDescriptionDetails);
            this.filmsDetailsPanel.Controls.Add(this.filmsTitleDetails);
            this.filmsDetailsPanel.Controls.Add(this.filmsPictureBoxDetails);
            this.filmsDetailsPanel.Location = new System.Drawing.Point(101, 0);
            this.filmsDetailsPanel.Name = "filmsDetailsPanel";
            this.filmsDetailsPanel.Size = new System.Drawing.Size(1097, 650);
            this.filmsDetailsPanel.TabIndex = 48;
            this.filmsDetailsPanel.Visible = false;
            // 
            // bunifuButton21
            // 
            this.bunifuButton21.AllowAnimations = true;
            this.bunifuButton21.AllowMouseEffects = true;
            this.bunifuButton21.AllowToggling = false;
            this.bunifuButton21.AnimationSpeed = 200;
            this.bunifuButton21.AutoGenerateColors = false;
            this.bunifuButton21.AutoRoundBorders = true;
            this.bunifuButton21.AutoSizeLeftIcon = true;
            this.bunifuButton21.AutoSizeRightIcon = true;
            this.bunifuButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton21.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.bunifuButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.BackgroundImage")));
            this.bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.ButtonText = "RESERVE SEAT";
            this.bunifuButton21.ButtonTextMarginLeft = 0;
            this.bunifuButton21.ColorContrastOnClick = 45;
            this.bunifuButton21.ColorContrastOnHover = 45;
            this.bunifuButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges148.BottomLeft = true;
            borderEdges148.BottomRight = true;
            borderEdges148.TopLeft = true;
            borderEdges148.TopRight = true;
            this.bunifuButton21.CustomizableEdges = borderEdges148;
            this.bunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton21.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton21.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton21.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton21.IconMarginLeft = 11;
            this.bunifuButton21.IconPadding = 10;
            this.bunifuButton21.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton21.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton21.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton21.IconSize = 25;
            this.bunifuButton21.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.bunifuButton21.IdleBorderRadius = 52;
            this.bunifuButton21.IdleBorderThickness = 1;
            this.bunifuButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.bunifuButton21.IdleIconLeftImage = null;
            this.bunifuButton21.IdleIconRightImage = null;
            this.bunifuButton21.IndicateFocus = false;
            this.bunifuButton21.Location = new System.Drawing.Point(756, 301);
            this.bunifuButton21.Name = "bunifuButton21";
            this.bunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.OnDisabledState.BorderRadius = 1;
            this.bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnDisabledState.BorderThickness = 1;
            this.bunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.OnDisabledState.IconLeftImage = null;
            this.bunifuButton21.OnDisabledState.IconRightImage = null;
            this.bunifuButton21.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.BorderRadius = 1;
            this.bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.onHoverState.BorderThickness = 1;
            this.bunifuButton21.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.onHoverState.IconLeftImage = null;
            this.bunifuButton21.onHoverState.IconRightImage = null;
            this.bunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.bunifuButton21.OnIdleState.BorderRadius = 1;
            this.bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnIdleState.BorderThickness = 1;
            this.bunifuButton21.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.bunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnIdleState.IconLeftImage = null;
            this.bunifuButton21.OnIdleState.IconRightImage = null;
            this.bunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.BorderRadius = 1;
            this.bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnPressedState.BorderThickness = 1;
            this.bunifuButton21.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnPressedState.IconLeftImage = null;
            this.bunifuButton21.OnPressedState.IconRightImage = null;
            this.bunifuButton21.Size = new System.Drawing.Size(165, 54);
            this.bunifuButton21.TabIndex = 47;
            this.bunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton21.TextMarginLeft = 0;
            this.bunifuButton21.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton21.UseDefaultRadiusAndThickness = true;
            // 
            // filmsPriceDetails
            // 
            this.filmsPriceDetails.AutoSize = true;
            this.filmsPriceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmsPriceDetails.ForeColor = System.Drawing.Color.White;
            this.filmsPriceDetails.Location = new System.Drawing.Point(630, 182);
            this.filmsPriceDetails.Name = "filmsPriceDetails";
            this.filmsPriceDetails.Size = new System.Drawing.Size(167, 69);
            this.filmsPriceDetails.TabIndex = 46;
            this.filmsPriceDetails.Text = "Price";
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
            borderEdges149.BottomLeft = true;
            borderEdges149.BottomRight = true;
            borderEdges149.TopLeft = true;
            borderEdges149.TopRight = true;
            this.bunifuIconButton1.CustomizableEdges = borderEdges149;
            this.bunifuIconButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton1.Image = null;
            this.bunifuIconButton1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButton1.Location = new System.Drawing.Point(661, 298);
            this.bunifuIconButton1.Name = "bunifuIconButton1";
            this.bunifuIconButton1.RoundBorders = true;
            this.bunifuIconButton1.ShowBorders = true;
            this.bunifuIconButton1.Size = new System.Drawing.Size(57, 57);
            this.bunifuIconButton1.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButton1.TabIndex = 45;
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
            this.closeFilmsDetailsBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.closeFilmsDetailsBtn.BackHoverColor = System.Drawing.Color.LightGray;
            this.closeFilmsDetailsBtn.BackPressedColor = System.Drawing.Color.Silver;
            this.closeFilmsDetailsBtn.BorderColor = System.Drawing.Color.LightGray;
            this.closeFilmsDetailsBtn.BorderHoverColor = System.Drawing.Color.DarkGray;
            this.closeFilmsDetailsBtn.BorderPressedColor = System.Drawing.Color.DarkGray;
            this.closeFilmsDetailsBtn.BorderRadius = 0;
            this.closeFilmsDetailsBtn.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.closeFilmsDetailsBtn.BorderThickness = 1;
            this.closeFilmsDetailsBtn.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            this.closeFilmsDetailsBtn.ColorContrastOnClick = 30;
            this.closeFilmsDetailsBtn.ColorContrastOnHover = 30;
            this.closeFilmsDetailsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges150.BottomLeft = true;
            borderEdges150.BottomRight = true;
            borderEdges150.TopLeft = true;
            borderEdges150.TopRight = true;
            this.closeFilmsDetailsBtn.CustomizableEdges = borderEdges150;
            this.closeFilmsDetailsBtn.DefaultBorderColor = System.Drawing.Color.Silver;
            this.closeFilmsDetailsBtn.DefaultColor = System.Drawing.Color.Gainsboro;
            this.closeFilmsDetailsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeFilmsDetailsBtn.IconColor = System.Drawing.Color.Black;
            this.closeFilmsDetailsBtn.IconHoverColor = System.Drawing.Color.Black;
            this.closeFilmsDetailsBtn.IconPressedColor = System.Drawing.Color.Black;
            this.closeFilmsDetailsBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeFilmsDetailsBtn.Image")));
            this.closeFilmsDetailsBtn.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.closeFilmsDetailsBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.closeFilmsDetailsBtn.Location = new System.Drawing.Point(1046, 12);
            this.closeFilmsDetailsBtn.Name = "closeFilmsDetailsBtn";
            this.closeFilmsDetailsBtn.ShowBorders = true;
            this.closeFilmsDetailsBtn.Size = new System.Drawing.Size(40, 38);
            this.closeFilmsDetailsBtn.TabIndex = 5;
            this.closeFilmsDetailsBtn.Click += new System.EventHandler(this.closeFilmsDetailsBtn_Click);
            // 
            // filmsDescriptionDetails
            // 
            this.filmsDescriptionDetails.AutoSize = true;
            this.filmsDescriptionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmsDescriptionDetails.ForeColor = System.Drawing.Color.White;
            this.filmsDescriptionDetails.Location = new System.Drawing.Point(69, 463);
            this.filmsDescriptionDetails.Name = "filmsDescriptionDetails";
            this.filmsDescriptionDetails.Size = new System.Drawing.Size(165, 36);
            this.filmsDescriptionDetails.TabIndex = 2;
            this.filmsDescriptionDetails.Text = "Description";
            // 
            // filmsTitleDetails
            // 
            this.filmsTitleDetails.AutoSize = true;
            this.filmsTitleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmsTitleDetails.ForeColor = System.Drawing.Color.White;
            this.filmsTitleDetails.Location = new System.Drawing.Point(63, 373);
            this.filmsTitleDetails.Name = "filmsTitleDetails";
            this.filmsTitleDetails.Size = new System.Drawing.Size(276, 69);
            this.filmsTitleDetails.TabIndex = 1;
            this.filmsTitleDetails.Text = "Film Title";
            // 
            // filmsPictureBoxDetails
            // 
            this.filmsPictureBoxDetails.Location = new System.Drawing.Point(53, 39);
            this.filmsPictureBoxDetails.Name = "filmsPictureBoxDetails";
            this.filmsPictureBoxDetails.Size = new System.Drawing.Size(560, 323);
            this.filmsPictureBoxDetails.TabIndex = 0;
            this.filmsPictureBoxDetails.TabStop = false;
            // 
            // trendingMoviesDetailsPanel
            // 
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingDescriptionDetails);
            this.trendingMoviesDetailsPanel.Controls.Add(this.bunifuButton22);
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingMoviePriceDetails);
            this.trendingMoviesDetailsPanel.Controls.Add(this.bunifuIconButton2);
            this.trendingMoviesDetailsPanel.Controls.Add(this.closeTrendingMoviesDetails);
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingMovieTitleDetails);
            this.trendingMoviesDetailsPanel.Controls.Add(this.trendingDetailsPictureBox);
            this.trendingMoviesDetailsPanel.Location = new System.Drawing.Point(101, 0);
            this.trendingMoviesDetailsPanel.Name = "trendingMoviesDetailsPanel";
            this.trendingMoviesDetailsPanel.Size = new System.Drawing.Size(1097, 650);
            this.trendingMoviesDetailsPanel.TabIndex = 49;
            this.trendingMoviesDetailsPanel.Visible = false;
            // 
            // bunifuButton22
            // 
            this.bunifuButton22.AllowAnimations = true;
            this.bunifuButton22.AllowMouseEffects = true;
            this.bunifuButton22.AllowToggling = false;
            this.bunifuButton22.AnimationSpeed = 200;
            this.bunifuButton22.AutoGenerateColors = false;
            this.bunifuButton22.AutoRoundBorders = true;
            this.bunifuButton22.AutoSizeLeftIcon = true;
            this.bunifuButton22.AutoSizeRightIcon = true;
            this.bunifuButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton22.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.bunifuButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton22.BackgroundImage")));
            this.bunifuButton22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.ButtonText = "RESERVE SEAT";
            this.bunifuButton22.ButtonTextMarginLeft = 0;
            this.bunifuButton22.ColorContrastOnClick = 45;
            this.bunifuButton22.ColorContrastOnHover = 45;
            this.bunifuButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges151.BottomLeft = true;
            borderEdges151.BottomRight = true;
            borderEdges151.TopLeft = true;
            borderEdges151.TopRight = true;
            this.bunifuButton22.CustomizableEdges = borderEdges151;
            this.bunifuButton22.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton22.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton22.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton22.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton22.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton22.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuButton22.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton22.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton22.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton22.IconMarginLeft = 11;
            this.bunifuButton22.IconPadding = 10;
            this.bunifuButton22.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton22.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton22.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton22.IconSize = 25;
            this.bunifuButton22.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.bunifuButton22.IdleBorderRadius = 52;
            this.bunifuButton22.IdleBorderThickness = 1;
            this.bunifuButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.bunifuButton22.IdleIconLeftImage = null;
            this.bunifuButton22.IdleIconRightImage = null;
            this.bunifuButton22.IndicateFocus = false;
            this.bunifuButton22.Location = new System.Drawing.Point(756, 301);
            this.bunifuButton22.Name = "bunifuButton22";
            this.bunifuButton22.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton22.OnDisabledState.BorderRadius = 1;
            this.bunifuButton22.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.OnDisabledState.BorderThickness = 1;
            this.bunifuButton22.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton22.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton22.OnDisabledState.IconLeftImage = null;
            this.bunifuButton22.OnDisabledState.IconRightImage = null;
            this.bunifuButton22.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton22.onHoverState.BorderRadius = 1;
            this.bunifuButton22.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.onHoverState.BorderThickness = 1;
            this.bunifuButton22.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton22.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton22.onHoverState.IconLeftImage = null;
            this.bunifuButton22.onHoverState.IconRightImage = null;
            this.bunifuButton22.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.bunifuButton22.OnIdleState.BorderRadius = 1;
            this.bunifuButton22.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.OnIdleState.BorderThickness = 1;
            this.bunifuButton22.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.bunifuButton22.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton22.OnIdleState.IconLeftImage = null;
            this.bunifuButton22.OnIdleState.IconRightImage = null;
            this.bunifuButton22.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton22.OnPressedState.BorderRadius = 1;
            this.bunifuButton22.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.OnPressedState.BorderThickness = 1;
            this.bunifuButton22.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton22.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton22.OnPressedState.IconLeftImage = null;
            this.bunifuButton22.OnPressedState.IconRightImage = null;
            this.bunifuButton22.Size = new System.Drawing.Size(165, 54);
            this.bunifuButton22.TabIndex = 47;
            this.bunifuButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton22.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton22.TextMarginLeft = 0;
            this.bunifuButton22.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton22.UseDefaultRadiusAndThickness = true;
            // 
            // trendingMoviePriceDetails
            // 
            this.trendingMoviePriceDetails.AutoSize = true;
            this.trendingMoviePriceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trendingMoviePriceDetails.ForeColor = System.Drawing.Color.White;
            this.trendingMoviePriceDetails.Location = new System.Drawing.Point(630, 182);
            this.trendingMoviePriceDetails.Name = "trendingMoviePriceDetails";
            this.trendingMoviePriceDetails.Size = new System.Drawing.Size(167, 69);
            this.trendingMoviePriceDetails.TabIndex = 46;
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
            borderEdges152.BottomLeft = true;
            borderEdges152.BottomRight = true;
            borderEdges152.TopLeft = true;
            borderEdges152.TopRight = true;
            this.bunifuIconButton2.CustomizableEdges = borderEdges152;
            this.bunifuIconButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton2.Image = null;
            this.bunifuIconButton2.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButton2.Location = new System.Drawing.Point(661, 298);
            this.bunifuIconButton2.Name = "bunifuIconButton2";
            this.bunifuIconButton2.RoundBorders = true;
            this.bunifuIconButton2.ShowBorders = true;
            this.bunifuIconButton2.Size = new System.Drawing.Size(57, 57);
            this.bunifuIconButton2.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButton2.TabIndex = 45;
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
            this.closeTrendingMoviesDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.closeTrendingMoviesDetails.BackHoverColor = System.Drawing.Color.LightGray;
            this.closeTrendingMoviesDetails.BackPressedColor = System.Drawing.Color.Silver;
            this.closeTrendingMoviesDetails.BorderColor = System.Drawing.Color.LightGray;
            this.closeTrendingMoviesDetails.BorderHoverColor = System.Drawing.Color.DarkGray;
            this.closeTrendingMoviesDetails.BorderPressedColor = System.Drawing.Color.DarkGray;
            this.closeTrendingMoviesDetails.BorderRadius = 0;
            this.closeTrendingMoviesDetails.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.closeTrendingMoviesDetails.BorderThickness = 1;
            this.closeTrendingMoviesDetails.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            this.closeTrendingMoviesDetails.ColorContrastOnClick = 30;
            this.closeTrendingMoviesDetails.ColorContrastOnHover = 30;
            this.closeTrendingMoviesDetails.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges153.BottomLeft = true;
            borderEdges153.BottomRight = true;
            borderEdges153.TopLeft = true;
            borderEdges153.TopRight = true;
            this.closeTrendingMoviesDetails.CustomizableEdges = borderEdges153;
            this.closeTrendingMoviesDetails.DefaultBorderColor = System.Drawing.Color.Silver;
            this.closeTrendingMoviesDetails.DefaultColor = System.Drawing.Color.Gainsboro;
            this.closeTrendingMoviesDetails.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeTrendingMoviesDetails.IconColor = System.Drawing.Color.Black;
            this.closeTrendingMoviesDetails.IconHoverColor = System.Drawing.Color.Black;
            this.closeTrendingMoviesDetails.IconPressedColor = System.Drawing.Color.Black;
            this.closeTrendingMoviesDetails.Image = ((System.Drawing.Image)(resources.GetObject("closeTrendingMoviesDetails.Image")));
            this.closeTrendingMoviesDetails.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.closeTrendingMoviesDetails.ImageSize = new System.Drawing.Size(20, 20);
            this.closeTrendingMoviesDetails.Location = new System.Drawing.Point(1046, 12);
            this.closeTrendingMoviesDetails.Name = "closeTrendingMoviesDetails";
            this.closeTrendingMoviesDetails.ShowBorders = true;
            this.closeTrendingMoviesDetails.Size = new System.Drawing.Size(40, 38);
            this.closeTrendingMoviesDetails.TabIndex = 5;
            this.closeTrendingMoviesDetails.Click += new System.EventHandler(this.closeTrendingMoviesDetails_Click);
            // 
            // trendingMovieTitleDetails
            // 
            this.trendingMovieTitleDetails.AutoSize = true;
            this.trendingMovieTitleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trendingMovieTitleDetails.ForeColor = System.Drawing.Color.White;
            this.trendingMovieTitleDetails.Location = new System.Drawing.Point(48, 373);
            this.trendingMovieTitleDetails.Name = "trendingMovieTitleDetails";
            this.trendingMovieTitleDetails.Size = new System.Drawing.Size(442, 69);
            this.trendingMovieTitleDetails.TabIndex = 1;
            this.trendingMovieTitleDetails.Text = "Trending Movie";
            // 
            // trendingDetailsPictureBox
            // 
            this.trendingDetailsPictureBox.Location = new System.Drawing.Point(53, 39);
            this.trendingDetailsPictureBox.Name = "trendingDetailsPictureBox";
            this.trendingDetailsPictureBox.Size = new System.Drawing.Size(560, 323);
            this.trendingDetailsPictureBox.TabIndex = 0;
            this.trendingDetailsPictureBox.TabStop = false;
            // 
            // trendingDescriptionDetails
            // 
            this.trendingDescriptionDetails.AutoSize = true;
            this.trendingDescriptionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trendingDescriptionDetails.ForeColor = System.Drawing.Color.White;
            this.trendingDescriptionDetails.Location = new System.Drawing.Point(107, 463);
            this.trendingDescriptionDetails.Name = "trendingDescriptionDetails";
            this.trendingDescriptionDetails.Size = new System.Drawing.Size(153, 32);
            this.trendingDescriptionDetails.TabIndex = 48;
            this.trendingDescriptionDetails.Text = "description";
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
            // MainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 650);
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
            this.Controls.Add(this.trendingMoviesDetailsPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filmsDetailsPanel);
            this.Controls.Add(this.comingSoonMovieDetailsPanel);
            this.Controls.Add(this.foodDetailsPanel);
            this.Controls.Add(this.searchResultFlowWholePanel);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.filmsInCinemaPanel.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
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
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.FilmsInCinemaFlowLayout.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.userPanel.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoAfter)).EndInit();
            this.searchResultFlowWholePanel.ResumeLayout(false);
            this.foodDetailsPanel.ResumeLayout(false);
            this.foodDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicDetails)).EndInit();
            this.comingSoonMovieDetailsPanel.ResumeLayout(false);
            this.comingSoonMovieDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comingSoonMoviePicBoxDetails)).EndInit();
            this.filmsDetailsPanel.ResumeLayout(false);
            this.filmsDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsPictureBoxDetails)).EndInit();
            this.trendingMoviesDetailsPanel.ResumeLayout(false);
            this.trendingMoviesDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trendingDetailsPictureBox)).EndInit();
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 reserveSeatBtn;
        private Bunifu.UI.WinForms.BunifuImageButton rightTurnBtn;
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
        private Bunifu.UI.WinForms.BunifuImageButton LeftTurnBtn;
        private Panel panel14;
        private Panel panel15;
        private FlowLayoutPanel searchResultsFlowLayoutPanel;
        private Panel searchResultFlowWholePanel;
        private Panel foodDetailsPanel;
        private PictureBox foodPicDetails;
        private Label foodNameDetails;
        private Label foodPriceDetails;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton closeDetails;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton exisSearchBtn;
        private Panel comingSoonMovieDetailsPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton addToWatchLaterBtn;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton closeComingSoonMovieDetailsBtn;
        private Label comingSoonMovieDescriptionDetails;
        private Label comingSoonTitleDetails;
        private PictureBox comingSoonMoviePicBoxDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 reservedBtnFromDetails;
        private Label comingSoonPriceDetails;
        private Panel filmsDetailsPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        private Label filmsPriceDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton1;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton closeFilmsDetailsBtn;
        private Label filmsDescriptionDetails;
        private Label filmsTitleDetails;
        private PictureBox filmsPictureBoxDetails;
        private Panel trendingMoviesDetailsPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton22;
        private Label trendingMoviePriceDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton2;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton closeTrendingMoviesDetails;
        private Label trendingMovieTitleDetails;
        private PictureBox trendingDetailsPictureBox;
        private Label trendingDescriptionDetails;
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
    }
}

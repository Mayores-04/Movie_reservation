
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.filmsInCinemaPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.FilmsInCinemaFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.films1 = new System.Windows.Forms.Panel();
            this.films4 = new System.Windows.Forms.Panel();
            this.films5 = new System.Windows.Forms.Panel();
            this.films6 = new System.Windows.Forms.Panel();
            this.films7 = new System.Windows.Forms.Panel();
            this.films8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.smothFromLeftToRightTransition = new System.Windows.Forms.Timer(this.components);
            this.LogoutBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SignUpBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.LoginBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.userProfileBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reserveSeatBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.rightTurnBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.LeftTurnBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.fourthCircle = new System.Windows.Forms.PictureBox();
            this.thirdCircle = new System.Windows.Forms.PictureBox();
            this.secondCircle = new System.Windows.Forms.PictureBox();
            this.firstCircle = new System.Windows.Forms.PictureBox();
            this.films2 = new System.Windows.Forms.Panel();
            this.films3 = new System.Windows.Forms.Panel();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.TicketBtn = new System.Windows.Forms.Button();
            this.FavBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.filmsInCinemaPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel13.SuspendLayout();
            this.FilmsInCinemaFlowLayout.SuspendLayout();
            this.panel4.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(144, 686);
            this.panel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.flowLayoutPanel1.Controls.Add(this.filmsInCinemaPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(144, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1187, 594);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // filmsInCinemaPanel
            // 
            this.filmsInCinemaPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.filmsInCinemaPanel.BackColor = System.Drawing.Color.Transparent;
            this.filmsInCinemaPanel.Controls.Add(this.reserveSeatBtn);
            this.filmsInCinemaPanel.Controls.Add(this.rightTurnBtn);
            this.filmsInCinemaPanel.Controls.Add(this.LeftTurnBtn);
            this.filmsInCinemaPanel.Controls.Add(this.fourthCircle);
            this.filmsInCinemaPanel.Controls.Add(this.thirdCircle);
            this.filmsInCinemaPanel.Controls.Add(this.secondCircle);
            this.filmsInCinemaPanel.Controls.Add(this.firstCircle);
            this.filmsInCinemaPanel.Controls.Add(this.panel5);
            this.filmsInCinemaPanel.Controls.Add(this.flowLayoutPanel2);
            this.filmsInCinemaPanel.Controls.Add(this.panel3);
            this.filmsInCinemaPanel.Controls.Add(this.panel13);
            this.filmsInCinemaPanel.Controls.Add(this.FilmsInCinemaFlowLayout);
            this.filmsInCinemaPanel.Controls.Add(this.panel4);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxRight);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxLeft);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxMain);
            this.filmsInCinemaPanel.Location = new System.Drawing.Point(3, 3);
            this.filmsInCinemaPanel.Name = "filmsInCinemaPanel";
            this.filmsInCinemaPanel.Size = new System.Drawing.Size(1159, 1585);
            this.filmsInCinemaPanel.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(-3, 1255);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1218, 48);
            this.panel5.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SNACKS AND BEVERAGE";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.panel15);
            this.flowLayoutPanel2.Controls.Add(this.panel16);
            this.flowLayoutPanel2.Controls.Add(this.panel17);
            this.flowLayoutPanel2.Controls.Add(this.panel18);
            this.flowLayoutPanel2.Controls.Add(this.panel19);
            this.flowLayoutPanel2.Controls.Add(this.panel20);
            this.flowLayoutPanel2.Controls.Add(this.panel21);
            this.flowLayoutPanel2.Controls.Add(this.panel22);
            this.flowLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(-3, 949);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(150, 250);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 20, 8, 10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1162, 335);
            this.flowLayoutPanel2.TabIndex = 34;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Red;
            this.panel15.Location = new System.Drawing.Point(20, 25);
            this.panel15.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.panel15.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(200, 250);
            this.panel15.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Orange;
            this.panel16.Location = new System.Drawing.Point(240, 25);
            this.panel16.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel16.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(200, 250);
            this.panel16.TabIndex = 1;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Yellow;
            this.panel17.Location = new System.Drawing.Point(460, 25);
            this.panel17.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel17.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(200, 250);
            this.panel17.TabIndex = 2;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Green;
            this.panel18.Location = new System.Drawing.Point(680, 25);
            this.panel18.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel18.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(200, 250);
            this.panel18.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Blue;
            this.panel19.Location = new System.Drawing.Point(900, 25);
            this.panel19.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel19.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(200, 250);
            this.panel19.TabIndex = 3;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Indigo;
            this.panel20.Location = new System.Drawing.Point(1120, 25);
            this.panel20.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel20.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(200, 250);
            this.panel20.TabIndex = 3;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Violet;
            this.panel21.Location = new System.Drawing.Point(1340, 25);
            this.panel21.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel21.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(200, 250);
            this.panel21.TabIndex = 3;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.White;
            this.panel22.Location = new System.Drawing.Point(1560, 25);
            this.panel22.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel22.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(200, 250);
            this.panel22.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(-3, 903);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1218, 52);
            this.panel3.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(481, 7);
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
            this.panel13.Location = new System.Drawing.Point(-3, 551);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1218, 53);
            this.panel13.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(441, 11);
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
            this.FilmsInCinemaFlowLayout.Location = new System.Drawing.Point(-3, 598);
            this.FilmsInCinemaFlowLayout.MinimumSize = new System.Drawing.Size(150, 250);
            this.FilmsInCinemaFlowLayout.Name = "FilmsInCinemaFlowLayout";
            this.FilmsInCinemaFlowLayout.Padding = new System.Windows.Forms.Padding(0, 20, 8, 10);
            this.FilmsInCinemaFlowLayout.Size = new System.Drawing.Size(1162, 345);
            this.FilmsInCinemaFlowLayout.TabIndex = 25;
            this.FilmsInCinemaFlowLayout.WrapContents = false;
            this.FilmsInCinemaFlowLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.FilmsInCinemaFlowLayout_Paint);
            this.FilmsInCinemaFlowLayout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FilmsInCinemaFlowLayout_MouseDown);
            this.FilmsInCinemaFlowLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FilmsInCinemaFlowLayout_MouseMove);
            this.FilmsInCinemaFlowLayout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FilmsInCinemaFlowLayout_MouseUp);
            // 
            // films1
            // 
            this.films1.BackColor = System.Drawing.Color.Red;
            this.films1.Location = new System.Drawing.Point(20, 25);
            this.films1.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.films1.MinimumSize = new System.Drawing.Size(150, 250);
            this.films1.Name = "films1";
            this.films1.Size = new System.Drawing.Size(200, 250);
            this.films1.TabIndex = 4;
            // 
            // films4
            // 
            this.films4.BackColor = System.Drawing.Color.Green;
            this.films4.Location = new System.Drawing.Point(680, 25);
            this.films4.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.films4.MinimumSize = new System.Drawing.Size(150, 250);
            this.films4.Name = "films4";
            this.films4.Size = new System.Drawing.Size(200, 250);
            this.films4.TabIndex = 7;
            // 
            // films5
            // 
            this.films5.BackColor = System.Drawing.Color.Blue;
            this.films5.Location = new System.Drawing.Point(900, 25);
            this.films5.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.films5.MinimumSize = new System.Drawing.Size(150, 250);
            this.films5.Name = "films5";
            this.films5.Size = new System.Drawing.Size(200, 250);
            this.films5.TabIndex = 8;
            // 
            // films6
            // 
            this.films6.BackColor = System.Drawing.Color.Indigo;
            this.films6.Location = new System.Drawing.Point(1120, 25);
            this.films6.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.films6.MinimumSize = new System.Drawing.Size(150, 250);
            this.films6.Name = "films6";
            this.films6.Size = new System.Drawing.Size(200, 250);
            this.films6.TabIndex = 9;
            // 
            // films7
            // 
            this.films7.BackColor = System.Drawing.Color.Violet;
            this.films7.Location = new System.Drawing.Point(1340, 25);
            this.films7.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.films7.MinimumSize = new System.Drawing.Size(150, 250);
            this.films7.Name = "films7";
            this.films7.Size = new System.Drawing.Size(200, 250);
            this.films7.TabIndex = 10;
            // 
            // films8
            // 
            this.films8.BackColor = System.Drawing.Color.White;
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
            this.panel4.Size = new System.Drawing.Size(1208, 53);
            this.panel4.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(481, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "TRENDING";
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.userPanel.Controls.Add(this.LogoutBtn);
            this.userPanel.Controls.Add(this.SignUpBtn);
            this.userPanel.Controls.Add(this.LoginBtn);
            this.userPanel.Location = new System.Drawing.Point(144, 3);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(265, 683);
            this.userPanel.TabIndex = 43;
            this.userPanel.Visible = false;
            // 
            // smothFromLeftToRightTransition
            // 
            this.smothFromLeftToRightTransition.Tick += new System.EventHandler(this.smothFromLeftToRightTransition_Click);
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
            this.LogoutBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.LogoutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.BackgroundImage")));
            this.LogoutBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LogoutBtn.ButtonText = "Logout";
            this.LogoutBtn.ButtonTextMarginLeft = 0;
            this.LogoutBtn.ColorContrastOnClick = 45;
            this.LogoutBtn.ColorContrastOnHover = 45;
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.LogoutBtn.CustomizableEdges = borderEdges7;
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
            this.LogoutBtn.IdleBorderColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.IdleBorderRadius = 20;
            this.LogoutBtn.IdleBorderThickness = 1;
            this.LogoutBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.LogoutBtn.IdleIconLeftImage = null;
            this.LogoutBtn.IdleIconRightImage = null;
            this.LogoutBtn.IndicateFocus = false;
            this.LogoutBtn.Location = new System.Drawing.Point(58, 147);
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
            this.LogoutBtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.OnIdleState.BorderRadius = 20;
            this.LogoutBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LogoutBtn.OnIdleState.BorderThickness = 1;
            this.LogoutBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
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
            this.SignUpBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.SignUpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpBtn.BackgroundImage")));
            this.SignUpBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SignUpBtn.ButtonText = "Sign Up";
            this.SignUpBtn.ButtonTextMarginLeft = 0;
            this.SignUpBtn.ColorContrastOnClick = 45;
            this.SignUpBtn.ColorContrastOnHover = 45;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.SignUpBtn.CustomizableEdges = borderEdges8;
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
            this.SignUpBtn.IdleBorderColor = System.Drawing.Color.Transparent;
            this.SignUpBtn.IdleBorderRadius = 20;
            this.SignUpBtn.IdleBorderThickness = 1;
            this.SignUpBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.SignUpBtn.IdleIconLeftImage = null;
            this.SignUpBtn.IdleIconRightImage = null;
            this.SignUpBtn.IndicateFocus = false;
            this.SignUpBtn.Location = new System.Drawing.Point(58, 88);
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
            this.SignUpBtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.SignUpBtn.OnIdleState.BorderRadius = 20;
            this.SignUpBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.SignUpBtn.OnIdleState.BorderThickness = 1;
            this.SignUpBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
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
            this.LoginBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LoginBtn.ButtonText = "Login";
            this.LoginBtn.ButtonTextMarginLeft = 0;
            this.LoginBtn.ColorContrastOnClick = 45;
            this.LoginBtn.ColorContrastOnHover = 45;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.LoginBtn.CustomizableEdges = borderEdges9;
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
            this.LoginBtn.IdleBorderColor = System.Drawing.Color.Transparent;
            this.LoginBtn.IdleBorderRadius = 20;
            this.LoginBtn.IdleBorderThickness = 1;
            this.LoginBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.LoginBtn.IdleIconLeftImage = null;
            this.LoginBtn.IdleIconRightImage = null;
            this.LoginBtn.IndicateFocus = false;
            this.LoginBtn.Location = new System.Drawing.Point(58, 29);
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
            this.LoginBtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.LoginBtn.OnIdleState.BorderRadius = 20;
            this.LoginBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LoginBtn.OnIdleState.BorderThickness = 1;
            this.LoginBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
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
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.userProfileBtn);
            this.bunifuPanel1.Controls.Add(this.searchBtn);
            this.bunifuPanel1.Controls.Add(this.pictureBox1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(144, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1188, 92);
            this.bunifuPanel1.TabIndex = 41;
            // 
            // userProfileBtn
            // 
            this.userProfileBtn.AllowAnimations = true;
            this.userProfileBtn.AllowMouseEffects = true;
            this.userProfileBtn.AllowToggling = false;
            this.userProfileBtn.AnimationSpeed = 200;
            this.userProfileBtn.AutoGenerateColors = false;
            this.userProfileBtn.AutoRoundBorders = false;
            this.userProfileBtn.AutoSizeLeftIcon = true;
            this.userProfileBtn.AutoSizeRightIcon = true;
            this.userProfileBtn.BackColor = System.Drawing.Color.Transparent;
            this.userProfileBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.userProfileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userProfileBtn.BackgroundImage")));
            this.userProfileBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.userProfileBtn.ButtonText = "JM";
            this.userProfileBtn.ButtonTextMarginLeft = 0;
            this.userProfileBtn.ColorContrastOnClick = 45;
            this.userProfileBtn.ColorContrastOnHover = 45;
            this.userProfileBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.userProfileBtn.CustomizableEdges = borderEdges10;
            this.userProfileBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.userProfileBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.userProfileBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.userProfileBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.userProfileBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.userProfileBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userProfileBtn.ForeColor = System.Drawing.Color.White;
            this.userProfileBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userProfileBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.userProfileBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.userProfileBtn.IconMarginLeft = 11;
            this.userProfileBtn.IconPadding = 10;
            this.userProfileBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userProfileBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.userProfileBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.userProfileBtn.IconSize = 25;
            this.userProfileBtn.IdleBorderColor = System.Drawing.Color.Transparent;
            this.userProfileBtn.IdleBorderRadius = 50;
            this.userProfileBtn.IdleBorderThickness = 1;
            this.userProfileBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.userProfileBtn.IdleIconLeftImage = null;
            this.userProfileBtn.IdleIconRightImage = null;
            this.userProfileBtn.IndicateFocus = false;
            this.userProfileBtn.Location = new System.Drawing.Point(1073, 12);
            this.userProfileBtn.Name = "userProfileBtn";
            this.userProfileBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.userProfileBtn.OnDisabledState.BorderRadius = 50;
            this.userProfileBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.userProfileBtn.OnDisabledState.BorderThickness = 1;
            this.userProfileBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.userProfileBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.userProfileBtn.OnDisabledState.IconLeftImage = null;
            this.userProfileBtn.OnDisabledState.IconRightImage = null;
            this.userProfileBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.userProfileBtn.onHoverState.BorderRadius = 50;
            this.userProfileBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.userProfileBtn.onHoverState.BorderThickness = 1;
            this.userProfileBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.userProfileBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.userProfileBtn.onHoverState.IconLeftImage = null;
            this.userProfileBtn.onHoverState.IconRightImage = null;
            this.userProfileBtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.userProfileBtn.OnIdleState.BorderRadius = 50;
            this.userProfileBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.userProfileBtn.OnIdleState.BorderThickness = 1;
            this.userProfileBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.userProfileBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.userProfileBtn.OnIdleState.IconLeftImage = null;
            this.userProfileBtn.OnIdleState.IconRightImage = null;
            this.userProfileBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.userProfileBtn.OnPressedState.BorderRadius = 50;
            this.userProfileBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.userProfileBtn.OnPressedState.BorderThickness = 1;
            this.userProfileBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.userProfileBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.userProfileBtn.OnPressedState.IconLeftImage = null;
            this.userProfileBtn.OnPressedState.IconRightImage = null;
            this.userProfileBtn.Size = new System.Drawing.Size(77, 65);
            this.userProfileBtn.TabIndex = 43;
            this.userProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userProfileBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.userProfileBtn.TextMarginLeft = 0;
            this.userProfileBtn.TextPadding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.userProfileBtn.UseDefaultRadiusAndThickness = true;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.searchBtn.BackgroundImage = global::MovieMunch.Properties.Resources.SearchBtn;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Location = new System.Drawing.Point(977, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(70, 62);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.searchBtn.TabIndex = 41;
            this.searchBtn.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MovieMunch.Properties.Resources.MovieM_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(762, -39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 183);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
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
            this.reserveSeatBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.reserveSeatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reserveSeatBtn.BackgroundImage")));
            this.reserveSeatBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.reserveSeatBtn.ButtonText = "RESEREVE SEAT";
            this.reserveSeatBtn.ButtonTextMarginLeft = 0;
            this.reserveSeatBtn.ColorContrastOnClick = 45;
            this.reserveSeatBtn.ColorContrastOnHover = 45;
            this.reserveSeatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.reserveSeatBtn.CustomizableEdges = borderEdges6;
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
            this.reserveSeatBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.reserveSeatBtn.IdleBorderRadius = 1;
            this.reserveSeatBtn.IdleBorderThickness = 1;
            this.reserveSeatBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.reserveSeatBtn.IdleIconLeftImage = null;
            this.reserveSeatBtn.IdleIconRightImage = null;
            this.reserveSeatBtn.IndicateFocus = false;
            this.reserveSeatBtn.Location = new System.Drawing.Point(626, 384);
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
            this.reserveSeatBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.reserveSeatBtn.OnIdleState.BorderRadius = 1;
            this.reserveSeatBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.reserveSeatBtn.OnIdleState.BorderThickness = 1;
            this.reserveSeatBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
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
            this.reserveSeatBtn.Size = new System.Drawing.Size(150, 39);
            this.reserveSeatBtn.TabIndex = 40;
            this.reserveSeatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reserveSeatBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.reserveSeatBtn.TextMarginLeft = 0;
            this.reserveSeatBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.reserveSeatBtn.UseDefaultRadiusAndThickness = true;
            this.reserveSeatBtn.Click += new System.EventHandler(this.reserveSeatBtn_Click);
            // 
            // rightTurnBtn
            // 
            this.rightTurnBtn.ActiveImage = null;
            this.rightTurnBtn.AllowAnimations = true;
            this.rightTurnBtn.AllowBuffering = false;
            this.rightTurnBtn.AllowToggling = false;
            this.rightTurnBtn.AllowZooming = true;
            this.rightTurnBtn.AllowZoomingOnFocus = true;
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
            this.rightTurnBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("rightTurnBtn.InitialImage")));
            this.rightTurnBtn.Location = new System.Drawing.Point(877, 255);
            this.rightTurnBtn.Name = "rightTurnBtn";
            this.rightTurnBtn.Rotation = 0;
            this.rightTurnBtn.ShowActiveImage = true;
            this.rightTurnBtn.ShowCursorChanges = true;
            this.rightTurnBtn.ShowImageBorders = true;
            this.rightTurnBtn.ShowSizeMarkers = false;
            this.rightTurnBtn.Size = new System.Drawing.Size(90, 90);
            this.rightTurnBtn.TabIndex = 38;
            this.rightTurnBtn.ToolTipText = "";
            this.rightTurnBtn.WaitOnLoad = false;
            this.rightTurnBtn.Zoom = 20;
            this.rightTurnBtn.ZoomSpeed = 10;
            this.rightTurnBtn.Click += new System.EventHandler(this.rightTurnBtn_Click);
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
            this.LeftTurnBtn.Location = new System.Drawing.Point(172, 255);
            this.LeftTurnBtn.Name = "LeftTurnBtn";
            this.LeftTurnBtn.Rotation = 0;
            this.LeftTurnBtn.ShowActiveImage = true;
            this.LeftTurnBtn.ShowCursorChanges = true;
            this.LeftTurnBtn.ShowImageBorders = true;
            this.LeftTurnBtn.ShowSizeMarkers = false;
            this.LeftTurnBtn.Size = new System.Drawing.Size(90, 90);
            this.LeftTurnBtn.TabIndex = 37;
            this.LeftTurnBtn.ToolTipText = "";
            this.LeftTurnBtn.WaitOnLoad = false;
            this.LeftTurnBtn.Zoom = 20;
            this.LeftTurnBtn.ZoomSpeed = 10;
            this.LeftTurnBtn.Click += new System.EventHandler(this.leftTurnBtn_Click);
            // 
            // fourthCircle
            // 
            this.fourthCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fourthCircle.Image = global::MovieMunch.Properties.Resources.UncolloredCircle;
            this.fourthCircle.Location = new System.Drawing.Point(630, 489);
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
            this.thirdCircle.Location = new System.Drawing.Point(579, 489);
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
            this.secondCircle.Location = new System.Drawing.Point(524, 489);
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
            this.firstCircle.Location = new System.Drawing.Point(468, 489);
            this.firstCircle.Name = "firstCircle";
            this.firstCircle.Size = new System.Drawing.Size(38, 35);
            this.firstCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.firstCircle.TabIndex = 26;
            this.firstCircle.TabStop = false;
            // 
            // films2
            // 
            this.films2.BackColor = System.Drawing.Color.Orange;
            this.films2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("films2.BackgroundImage")));
            this.films2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.films2.Location = new System.Drawing.Point(240, 25);
            this.films2.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.films2.MinimumSize = new System.Drawing.Size(150, 250);
            this.films2.Name = "films2";
            this.films2.Size = new System.Drawing.Size(200, 250);
            this.films2.TabIndex = 5;
            this.films2.Paint += new System.Windows.Forms.PaintEventHandler(this.films2_Paint);
            // 
            // films3
            // 
            this.films3.BackColor = System.Drawing.Color.Yellow;
            this.films3.BackgroundImage = global::MovieMunch.Properties.Resources.coming_soon;
            this.films3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.films3.Location = new System.Drawing.Point(460, 25);
            this.films3.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.films3.MinimumSize = new System.Drawing.Size(150, 250);
            this.films3.Name = "films3";
            this.films3.Size = new System.Drawing.Size(200, 250);
            this.films3.TabIndex = 6;
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.BackColor = System.Drawing.Color.Black;
            this.pictureBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRight.Location = new System.Drawing.Point(987, 92);
            this.pictureBoxRight.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(468, 376);
            this.pictureBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRight.TabIndex = 19;
            this.pictureBoxRight.TabStop = false;
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.BackColor = System.Drawing.Color.Black;
            this.pictureBoxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLeft.Location = new System.Drawing.Point(-328, 92);
            this.pictureBoxLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(476, 376);
            this.pictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeft.TabIndex = 18;
            this.pictureBoxLeft.TabStop = false;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxMain.Location = new System.Drawing.Point(282, 92);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(578, 376);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 12;
            this.pictureBoxMain.TabStop = false;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.HomeBtn.BackgroundImage = global::MovieMunch.Properties.Resources.Ellipse_7;
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = global::MovieMunch.Properties.Resources.homeIcon;
            this.HomeBtn.Location = new System.Drawing.Point(0, 49);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(0, 28, 1, 0);
            this.HomeBtn.Size = new System.Drawing.Size(144, 114);
            this.HomeBtn.TabIndex = 16;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // TicketBtn
            // 
            this.TicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.TicketBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TicketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TicketBtn.FlatAppearance.BorderSize = 0;
            this.TicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketBtn.ForeColor = System.Drawing.Color.White;
            this.TicketBtn.Image = global::MovieMunch.Properties.Resources.TicketIcon;
            this.TicketBtn.Location = new System.Drawing.Point(0, 213);
            this.TicketBtn.Name = "TicketBtn";
            this.TicketBtn.Size = new System.Drawing.Size(144, 114);
            this.TicketBtn.TabIndex = 15;
            this.TicketBtn.UseVisualStyleBackColor = false;
            this.TicketBtn.Click += new System.EventHandler(this.TicketBtn_Click);
            // 
            // FavBtn
            // 
            this.FavBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FavBtn.FlatAppearance.BorderSize = 0;
            this.FavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavBtn.Image = global::MovieMunch.Properties.Resources.FavIcon;
            this.FavBtn.Location = new System.Drawing.Point(0, 378);
            this.FavBtn.Name = "FavBtn";
            this.FavBtn.Padding = new System.Windows.Forms.Padding(38, 13, 0, 0);
            this.FavBtn.Size = new System.Drawing.Size(144, 114);
            this.FavBtn.TabIndex = 14;
            this.FavBtn.UseVisualStyleBackColor = true;
            this.FavBtn.Click += new System.EventHandler(this.FavBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.SettingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBtn.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.Image = global::MovieMunch.Properties.Resources.SettingIcon;
            this.SettingBtn.Location = new System.Drawing.Point(0, 541);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(144, 114);
            this.SettingBtn.TabIndex = 10;
            this.SettingBtn.UseVisualStyleBackColor = false;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 686);
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
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.FilmsInCinemaFlowLayout.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Panel panel2;
        private Button SettingBtn;
        private Button FavBtn;
        private PictureBox fourthCircle;
        private PictureBox thirdCircle;
        private PictureBox secondCircle;
        private PictureBox firstCircle;
        private Button HomeBtn;
        private Button TicketBtn;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private PictureBox searchBtn;
        private PictureBox pictureBox1;
        private Timer timer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel filmsInCinemaPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 reserveSeatBtn;
        private Bunifu.UI.WinForms.BunifuImageButton rightTurnBtn;
        private Bunifu.UI.WinForms.BunifuImageButton LeftTurnBtn;
        private Panel panel5;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 userProfileBtn;
        private Panel userPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 LoginBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 SignUpBtn;
        private Timer smothFromLeftToRightTransition;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 LogoutBtn;
    }
}

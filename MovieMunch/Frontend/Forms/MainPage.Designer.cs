
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.filmsInCinemaPanel = new System.Windows.Forms.Panel();
            this.rightTurnBtn = new System.Windows.Forms.Button();
            this.leftTurnBtn = new System.Windows.Forms.Button();
            this.FourthCircle = new System.Windows.Forms.PictureBox();
            this.ThirdCircle = new System.Windows.Forms.PictureBox();
            this.SecondCircle = new System.Windows.Forms.PictureBox();
            this.FirstCircle = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FilmsInCinemaFlowLayouPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.reservedBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            this.filmsInCinemaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FourthCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCircle)).BeginInit();
            this.panel5.SuspendLayout();
            this.FilmsInCinemaFlowLayouPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.SettingBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 719);
            this.panel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.filmsInCinemaPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(139, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1229, 666);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // searchBtn
            // 
            this.searchBtn.BackgroundImage = global::MovieMunch.Properties.Resources.SearchBtn;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Location = new System.Drawing.Point(1175, 10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(70, 62);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.searchBtn.TabIndex = 13;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.button3.BackgroundImage = global::MovieMunch.Properties.Resources.HomeIconCircle;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::MovieMunch.Properties.Resources.homeIcon;
            this.button3.Location = new System.Drawing.Point(0, 49);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 28, 1, 0);
            this.button3.Size = new System.Drawing.Size(144, 114);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.button1.BackgroundImage = global::MovieMunch.Properties.Resources.TicketIcon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 114);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::MovieMunch.Properties.Resources.FavIcon;
            this.button2.Location = new System.Drawing.Point(0, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 114);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.SettingBtn.BackgroundImage = global::MovieMunch.Properties.Resources.SettingIcon;
            this.SettingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBtn.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingBtn.Location = new System.Drawing.Point(0, 541);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(144, 114);
            this.SettingBtn.TabIndex = 10;
            this.SettingBtn.UseVisualStyleBackColor = false;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // filmsInCinemaPanel
            // 
            this.filmsInCinemaPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.filmsInCinemaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.filmsInCinemaPanel.BackgroundImage = global::MovieMunch.Properties.Resources.BG;
            this.filmsInCinemaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filmsInCinemaPanel.Controls.Add(this.rightTurnBtn);
            this.filmsInCinemaPanel.Controls.Add(this.leftTurnBtn);
            this.filmsInCinemaPanel.Controls.Add(this.FourthCircle);
            this.filmsInCinemaPanel.Controls.Add(this.ThirdCircle);
            this.filmsInCinemaPanel.Controls.Add(this.SecondCircle);
            this.filmsInCinemaPanel.Controls.Add(this.FirstCircle);
            this.filmsInCinemaPanel.Controls.Add(this.panel5);
            this.filmsInCinemaPanel.Controls.Add(this.FilmsInCinemaFlowLayouPanel);
            this.filmsInCinemaPanel.Controls.Add(this.reservedBtn);
            this.filmsInCinemaPanel.Controls.Add(this.panel4);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxRight);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxLeft);
            this.filmsInCinemaPanel.Controls.Add(this.panel3);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxMain);
            this.filmsInCinemaPanel.Location = new System.Drawing.Point(3, 3);
            this.filmsInCinemaPanel.Name = "filmsInCinemaPanel";
            this.filmsInCinemaPanel.Size = new System.Drawing.Size(1211, 1407);
            this.filmsInCinemaPanel.TabIndex = 0;
            // 
            // rightTurnBtn
            // 
            this.rightTurnBtn.BackColor = System.Drawing.Color.Transparent;
            this.rightTurnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightTurnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightTurnBtn.FlatAppearance.BorderSize = 0;
            this.rightTurnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(15)))), ((int)(((byte)(37)))));
            this.rightTurnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rightTurnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightTurnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightTurnBtn.ForeColor = System.Drawing.Color.White;
            this.rightTurnBtn.Image = global::MovieMunch.Properties.Resources.right;
            this.rightTurnBtn.Location = new System.Drawing.Point(892, 275);
            this.rightTurnBtn.Name = "rightTurnBtn";
            this.rightTurnBtn.Size = new System.Drawing.Size(118, 114);
            this.rightTurnBtn.TabIndex = 31;
            this.rightTurnBtn.UseVisualStyleBackColor = false;
            this.rightTurnBtn.Click += new System.EventHandler(this.rightTurnBtn_Click);
            // 
            // leftTurnBtn
            // 
            this.leftTurnBtn.BackColor = System.Drawing.Color.Transparent;
            this.leftTurnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftTurnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftTurnBtn.FlatAppearance.BorderSize = 0;
            this.leftTurnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(15)))), ((int)(((byte)(37)))));
            this.leftTurnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.leftTurnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftTurnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTurnBtn.ForeColor = System.Drawing.Color.White;
            this.leftTurnBtn.Image = global::MovieMunch.Properties.Resources.leftBtn;
            this.leftTurnBtn.Location = new System.Drawing.Point(181, 275);
            this.leftTurnBtn.Name = "leftTurnBtn";
            this.leftTurnBtn.Size = new System.Drawing.Size(118, 114);
            this.leftTurnBtn.TabIndex = 15;
            this.leftTurnBtn.UseVisualStyleBackColor = false;
            this.leftTurnBtn.Click += new System.EventHandler(this.leftTurnBtn_Click);
            // 
            // FourthCircle
            // 
            this.FourthCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FourthCircle.Image = ((System.Drawing.Image)(resources.GetObject("FourthCircle.Image")));
            this.FourthCircle.Location = new System.Drawing.Point(666, 559);
            this.FourthCircle.Name = "FourthCircle";
            this.FourthCircle.Size = new System.Drawing.Size(38, 35);
            this.FourthCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FourthCircle.TabIndex = 29;
            this.FourthCircle.TabStop = false;
            // 
            // ThirdCircle
            // 
            this.ThirdCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThirdCircle.Image = ((System.Drawing.Image)(resources.GetObject("ThirdCircle.Image")));
            this.ThirdCircle.Location = new System.Drawing.Point(615, 559);
            this.ThirdCircle.Name = "ThirdCircle";
            this.ThirdCircle.Size = new System.Drawing.Size(36, 35);
            this.ThirdCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ThirdCircle.TabIndex = 28;
            this.ThirdCircle.TabStop = false;
            // 
            // SecondCircle
            // 
            this.SecondCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SecondCircle.Image = ((System.Drawing.Image)(resources.GetObject("SecondCircle.Image")));
            this.SecondCircle.Location = new System.Drawing.Point(560, 559);
            this.SecondCircle.Name = "SecondCircle";
            this.SecondCircle.Size = new System.Drawing.Size(39, 35);
            this.SecondCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SecondCircle.TabIndex = 27;
            this.SecondCircle.TabStop = false;
            // 
            // FirstCircle
            // 
            this.FirstCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FirstCircle.Image = global::MovieMunch.Properties.Resources.UncolloredCircle;
            this.FirstCircle.Location = new System.Drawing.Point(504, 559);
            this.FirstCircle.Name = "FirstCircle";
            this.FirstCircle.Size = new System.Drawing.Size(38, 35);
            this.FirstCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FirstCircle.TabIndex = 26;
            this.FirstCircle.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(19)))), ((int)(((byte)(14)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 981);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1223, 71);
            this.panel5.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(546, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMING SOON";
            // 
            // FilmsInCinemaFlowLayouPanel
            // 
            this.FilmsInCinemaFlowLayouPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilmsInCinemaFlowLayouPanel.AutoScroll = true;
            this.FilmsInCinemaFlowLayouPanel.Controls.Add(this.panel1);
            this.FilmsInCinemaFlowLayouPanel.Controls.Add(this.panel6);
            this.FilmsInCinemaFlowLayouPanel.Controls.Add(this.panel7);
            this.FilmsInCinemaFlowLayouPanel.Controls.Add(this.panel8);
            this.FilmsInCinemaFlowLayouPanel.Controls.Add(this.panel9);
            this.FilmsInCinemaFlowLayouPanel.Controls.Add(this.panel12);
            this.FilmsInCinemaFlowLayouPanel.Controls.Add(this.panel11);
            this.FilmsInCinemaFlowLayouPanel.Controls.Add(this.panel10);
            this.FilmsInCinemaFlowLayouPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilmsInCinemaFlowLayouPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FilmsInCinemaFlowLayouPanel.Location = new System.Drawing.Point(3, 768);
            this.FilmsInCinemaFlowLayouPanel.Name = "FilmsInCinemaFlowLayouPanel";
            this.FilmsInCinemaFlowLayouPanel.Size = new System.Drawing.Size(1208, 257);
            this.FilmsInCinemaFlowLayouPanel.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(20, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 185);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Orange;
            this.panel6.Location = new System.Drawing.Point(240, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 185);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.Location = new System.Drawing.Point(460, 5);
            this.panel7.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 185);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Green;
            this.panel8.Location = new System.Drawing.Point(680, 5);
            this.panel8.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 185);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Blue;
            this.panel9.Location = new System.Drawing.Point(900, 5);
            this.panel9.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 185);
            this.panel9.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Indigo;
            this.panel12.Location = new System.Drawing.Point(1120, 5);
            this.panel12.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 185);
            this.panel12.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Violet;
            this.panel11.Location = new System.Drawing.Point(1340, 5);
            this.panel11.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 185);
            this.panel11.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(1560, 5);
            this.panel10.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 185);
            this.panel10.TabIndex = 3;
            // 
            // reservedBtn
            // 
            this.reservedBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reservedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.reservedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reservedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservedBtn.FlatAppearance.BorderSize = 0;
            this.reservedBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(33)))), ((int)(((byte)(57)))));
            this.reservedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(57)))));
            this.reservedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reservedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservedBtn.ForeColor = System.Drawing.Color.White;
            this.reservedBtn.Location = new System.Drawing.Point(623, 434);
            this.reservedBtn.Name = "reservedBtn";
            this.reservedBtn.Size = new System.Drawing.Size(217, 49);
            this.reservedBtn.TabIndex = 24;
            this.reservedBtn.Text = "RESERVED SEAT";
            this.reservedBtn.UseVisualStyleBackColor = false;
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
            this.label3.Location = new System.Drawing.Point(518, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "TRENDING";
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.BackColor = System.Drawing.Color.Black;
            this.pictureBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRight.Location = new System.Drawing.Point(1013, 135);
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
            this.pictureBoxLeft.Location = new System.Drawing.Point(-302, 135);
            this.pictureBoxLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(476, 376);
            this.pictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeft.TabIndex = 18;
            this.pictureBoxLeft.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AccessibleName = "";
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(19)))), ((int)(((byte)(14)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 666);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1213, 77);
            this.panel3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(533, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "FILMS IN CINEMA";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxMain.Location = new System.Drawing.Point(305, 135);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(578, 376);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 12;
            this.pictureBoxMain.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MovieMunch.Properties.Resources.lg2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1247, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1369, 719);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            this.filmsInCinemaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FourthCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCircle)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.FilmsInCinemaFlowLayouPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Panel panel2;
        private Button SettingBtn;
        private Panel filmsInCinemaPanel;
        private PictureBox FourthCircle;
        private PictureBox ThirdCircle;
        private PictureBox SecondCircle;
        private PictureBox FirstCircle;
        private Panel panel5;
        private Label label1;
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
        private Panel panel4;
        private Label label3;
        private PictureBox pictureBoxRight;
        private PictureBox pictureBoxLeft;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBoxMain;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button rightTurnBtn;
        private Button leftTurnBtn;
        private Button button3;
        private Button button1;
        private PictureBox searchBtn;
        private PictureBox pictureBox1;
    }
}

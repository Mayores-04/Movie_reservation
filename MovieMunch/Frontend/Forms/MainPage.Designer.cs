
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
            this.HomeBtn = new System.Windows.Forms.Button();
            this.TicketBtn = new System.Windows.Forms.Button();
            this.FavBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
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
            this.rightTurnBtn = new System.Windows.Forms.Button();
            this.leftTurnBtn = new System.Windows.Forms.Button();
            this.FourthCircle = new System.Windows.Forms.PictureBox();
            this.ThirdCircle = new System.Windows.Forms.PictureBox();
            this.SecondCircle = new System.Windows.Forms.PictureBox();
            this.FirstCircle = new System.Windows.Forms.PictureBox();
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
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.filmsInCinemaPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FourthCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCircle)).BeginInit();
            this.FilmsInCinemaFlowLayouPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(144, 718);
            this.panel2.TabIndex = 7;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = global::MovieMunch.Properties.Resources.home_down_1;
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
            this.FavBtn.Padding = new System.Windows.Forms.Padding(35, 13, 0, 0);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.filmsInCinemaPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(139, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1229, 666);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // filmsInCinemaPanel
            // 
            this.filmsInCinemaPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.filmsInCinemaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.filmsInCinemaPanel.BackgroundImage = global::MovieMunch.Properties.Resources.BG;
            this.filmsInCinemaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filmsInCinemaPanel.Controls.Add(this.panel5);
            this.filmsInCinemaPanel.Controls.Add(this.flowLayoutPanel2);
            this.filmsInCinemaPanel.Controls.Add(this.panel3);
            this.filmsInCinemaPanel.Controls.Add(this.panel13);
            this.filmsInCinemaPanel.Controls.Add(this.rightTurnBtn);
            this.filmsInCinemaPanel.Controls.Add(this.leftTurnBtn);
            this.filmsInCinemaPanel.Controls.Add(this.FourthCircle);
            this.filmsInCinemaPanel.Controls.Add(this.ThirdCircle);
            this.filmsInCinemaPanel.Controls.Add(this.SecondCircle);
            this.filmsInCinemaPanel.Controls.Add(this.FirstCircle);
            this.filmsInCinemaPanel.Controls.Add(this.FilmsInCinemaFlowLayouPanel);
            this.filmsInCinemaPanel.Controls.Add(this.reservedBtn);
            this.filmsInCinemaPanel.Controls.Add(this.panel4);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxRight);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxLeft);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxMain);
            this.filmsInCinemaPanel.Location = new System.Drawing.Point(3, 3);
            this.filmsInCinemaPanel.Name = "filmsInCinemaPanel";
            this.filmsInCinemaPanel.Size = new System.Drawing.Size(1211, 1598);
            this.filmsInCinemaPanel.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(-9, 1238);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1221, 53);
            this.panel5.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(518, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRENDING";
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
            this.flowLayoutPanel2.Location = new System.Drawing.Point(-3, 965);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(150, 250);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1218, 297);
            this.flowLayoutPanel2.TabIndex = 34;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Red;
            this.panel15.Location = new System.Drawing.Point(20, 5);
            this.panel15.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.panel15.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(200, 250);
            this.panel15.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Orange;
            this.panel16.Location = new System.Drawing.Point(240, 5);
            this.panel16.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel16.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(200, 250);
            this.panel16.TabIndex = 1;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Yellow;
            this.panel17.Location = new System.Drawing.Point(460, 5);
            this.panel17.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel17.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(200, 250);
            this.panel17.TabIndex = 2;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Green;
            this.panel18.Location = new System.Drawing.Point(680, 5);
            this.panel18.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel18.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(200, 250);
            this.panel18.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Blue;
            this.panel19.Location = new System.Drawing.Point(900, 5);
            this.panel19.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel19.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(200, 250);
            this.panel19.TabIndex = 3;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Indigo;
            this.panel20.Location = new System.Drawing.Point(1120, 5);
            this.panel20.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel20.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(200, 250);
            this.panel20.TabIndex = 3;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Violet;
            this.panel21.Location = new System.Drawing.Point(1340, 5);
            this.panel21.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel21.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(200, 250);
            this.panel21.TabIndex = 3;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.White;
            this.panel22.Location = new System.Drawing.Point(1560, 5);
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
            this.panel3.Location = new System.Drawing.Point(-3, 898);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1211, 53);
            this.panel3.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(518, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "TRENDING";
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
            this.label4.Location = new System.Drawing.Point(518, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "TRENDING";
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
            this.rightTurnBtn.Location = new System.Drawing.Point(892, 234);
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
            this.leftTurnBtn.Location = new System.Drawing.Point(181, 234);
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
            this.FourthCircle.Location = new System.Drawing.Point(671, 489);
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
            this.ThirdCircle.Location = new System.Drawing.Point(620, 489);
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
            this.SecondCircle.Location = new System.Drawing.Point(565, 489);
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
            this.FirstCircle.Location = new System.Drawing.Point(509, 489);
            this.FirstCircle.Name = "FirstCircle";
            this.FirstCircle.Size = new System.Drawing.Size(38, 35);
            this.FirstCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FirstCircle.TabIndex = 26;
            this.FirstCircle.TabStop = false;
            // 
            // FilmsInCinemaFlowLayouPanel
            // 
            this.FilmsInCinemaFlowLayouPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilmsInCinemaFlowLayouPanel.AutoScroll = true;
            this.FilmsInCinemaFlowLayouPanel.BackColor = System.Drawing.Color.Transparent;
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
            this.FilmsInCinemaFlowLayouPanel.Location = new System.Drawing.Point(3, 625);
            this.FilmsInCinemaFlowLayouPanel.MinimumSize = new System.Drawing.Size(150, 250);
            this.FilmsInCinemaFlowLayouPanel.Name = "FilmsInCinemaFlowLayouPanel";
            this.FilmsInCinemaFlowLayouPanel.Size = new System.Drawing.Size(1208, 305);
            this.FilmsInCinemaFlowLayouPanel.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(20, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.panel1.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 250);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Orange;
            this.panel6.Location = new System.Drawing.Point(240, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel6.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 250);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.Location = new System.Drawing.Point(460, 5);
            this.panel7.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel7.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 250);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Green;
            this.panel8.Location = new System.Drawing.Point(680, 5);
            this.panel8.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel8.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 250);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Blue;
            this.panel9.Location = new System.Drawing.Point(900, 5);
            this.panel9.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel9.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 250);
            this.panel9.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Indigo;
            this.panel12.Location = new System.Drawing.Point(1120, 5);
            this.panel12.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel12.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 250);
            this.panel12.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Violet;
            this.panel11.Location = new System.Drawing.Point(1340, 5);
            this.panel11.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel11.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 250);
            this.panel11.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(1560, 5);
            this.panel10.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.panel10.MinimumSize = new System.Drawing.Size(150, 250);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 250);
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
            this.reservedBtn.Location = new System.Drawing.Point(620, 389);
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
            this.pictureBoxRight.Location = new System.Drawing.Point(1013, 94);
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
            this.pictureBoxLeft.Location = new System.Drawing.Point(-302, 94);
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
            this.pictureBoxMain.Location = new System.Drawing.Point(305, 94);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(578, 376);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 12;
            this.pictureBoxMain.TabStop = false;
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
            this.ClientSize = new System.Drawing.Size(1369, 718);
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
            this.filmsInCinemaPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FourthCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCircle)).EndInit();
            this.FilmsInCinemaFlowLayouPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
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
        private PictureBox pictureBoxMain;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button FavBtn;
        private Button rightTurnBtn;
        private Button leftTurnBtn;
        private Button HomeBtn;
        private Button TicketBtn;
        private PictureBox searchBtn;
        private PictureBox pictureBox1;
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
    }
}

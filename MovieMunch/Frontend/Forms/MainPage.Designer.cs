
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
            this.SettingBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.filmsInCinemaPanel = new System.Windows.Forms.Panel();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.reservedBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.rightTurnBtn = new System.Windows.Forms.Label();
            this.FourthCircle = new System.Windows.Forms.PictureBox();
            this.ThirdCircle = new System.Windows.Forms.PictureBox();
            this.SecondCircle = new System.Windows.Forms.PictureBox();
            this.FirstCircle = new System.Windows.Forms.PictureBox();
            this.leftTurnBtn = new System.Windows.Forms.Label();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.filmsInCinemaPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.FilmsInCinemaFlowLayouPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(183)))), ((int)(((byte)(9)))));
            this.panel2.Controls.Add(this.SettingBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 697);
            this.panel2.TabIndex = 7;
            // 
            // SettingBtn
            // 
            this.SettingBtn.Location = new System.Drawing.Point(10, 627);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(94, 39);
            this.SettingBtn.TabIndex = 10;
            this.SettingBtn.Text = "Settings";
            this.SettingBtn.UseVisualStyleBackColor = true;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.filmsInCinemaPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(110, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1243, 627);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // filmsInCinemaPanel
            // 
            this.filmsInCinemaPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.filmsInCinemaPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filmsInCinemaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.filmsInCinemaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.filmsInCinemaPanel.Controls.Add(this.rightTurnBtn);
            this.filmsInCinemaPanel.Controls.Add(this.FourthCircle);
            this.filmsInCinemaPanel.Controls.Add(this.ThirdCircle);
            this.filmsInCinemaPanel.Controls.Add(this.SecondCircle);
            this.filmsInCinemaPanel.Controls.Add(this.FirstCircle);
            this.filmsInCinemaPanel.Controls.Add(this.panel5);
            this.filmsInCinemaPanel.Controls.Add(this.FilmsInCinemaFlowLayouPanel);
            this.filmsInCinemaPanel.Controls.Add(this.reservedBtn);
            this.filmsInCinemaPanel.Controls.Add(this.leftTurnBtn);
            this.filmsInCinemaPanel.Controls.Add(this.panel4);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxRight);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxLeft);
            this.filmsInCinemaPanel.Controls.Add(this.panel3);
            this.filmsInCinemaPanel.Controls.Add(this.pictureBoxMain);
            this.filmsInCinemaPanel.Location = new System.Drawing.Point(3, 3);
            this.filmsInCinemaPanel.Name = "filmsInCinemaPanel";
            this.filmsInCinemaPanel.Size = new System.Drawing.Size(1196, 1384);
            this.filmsInCinemaPanel.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(19)))), ((int)(((byte)(14)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 976);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1193, 76);
            this.panel5.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(569, 30);
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
            this.FilmsInCinemaFlowLayouPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FilmsInCinemaFlowLayouPanel.Location = new System.Drawing.Point(3, 768);
            this.FilmsInCinemaFlowLayouPanel.Name = "FilmsInCinemaFlowLayouPanel";
            this.FilmsInCinemaFlowLayouPanel.Size = new System.Drawing.Size(1193, 234);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(19)))), ((int)(((byte)(14)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1193, 77);
            this.panel4.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(590, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "TRENDING";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(19)))), ((int)(((byte)(14)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 666);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1193, 77);
            this.panel3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(569, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "FILMS IN CINEMA";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(4)))), ((int)(((byte)(15)))));
            this.panel13.Location = new System.Drawing.Point(989, 7);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(124, 60);
            this.panel13.TabIndex = 10;
            // 
            // reservedBtn
            // 
            this.reservedBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reservedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.reservedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reservedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservedBtn.FlatAppearance.BorderSize = 0;
            this.reservedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reservedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservedBtn.ForeColor = System.Drawing.Color.White;
            this.reservedBtn.Location = new System.Drawing.Point(616, 423);
            this.reservedBtn.Name = "reservedBtn";
            this.reservedBtn.Size = new System.Drawing.Size(217, 49);
            this.reservedBtn.TabIndex = 24;
            this.reservedBtn.Text = "RESERVED SEAT";
            this.reservedBtn.UseVisualStyleBackColor = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackgroundImage = global::MovieMunch.Properties.Resources.SearchBtn;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.Location = new System.Drawing.Point(1130, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(59, 50);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.searchBtn.TabIndex = 9;
            this.searchBtn.TabStop = false;
            // 
            // rightTurnBtn
            // 
            this.rightTurnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightTurnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightTurnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightTurnBtn.Image = global::MovieMunch.Properties.Resources.right;
            this.rightTurnBtn.Location = new System.Drawing.Point(889, 270);
            this.rightTurnBtn.Name = "rightTurnBtn";
            this.rightTurnBtn.Padding = new System.Windows.Forms.Padding(40, 30, 40, 30);
            this.rightTurnBtn.Size = new System.Drawing.Size(114, 108);
            this.rightTurnBtn.TabIndex = 30;
            this.rightTurnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightTurnBtn.Click += new System.EventHandler(this.rightTurnBtn_Click);
            // 
            // FourthCircle
            // 
            this.FourthCircle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FourthCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FourthCircle.Image = ((System.Drawing.Image)(resources.GetObject("FourthCircle.Image")));
            this.FourthCircle.Location = new System.Drawing.Point(702, 554);
            this.FourthCircle.Name = "FourthCircle";
            this.FourthCircle.Size = new System.Drawing.Size(38, 35);
            this.FourthCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FourthCircle.TabIndex = 29;
            this.FourthCircle.TabStop = false;
            // 
            // ThirdCircle
            // 
            this.ThirdCircle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThirdCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThirdCircle.Image = ((System.Drawing.Image)(resources.GetObject("ThirdCircle.Image")));
            this.ThirdCircle.Location = new System.Drawing.Point(651, 554);
            this.ThirdCircle.Name = "ThirdCircle";
            this.ThirdCircle.Size = new System.Drawing.Size(36, 35);
            this.ThirdCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ThirdCircle.TabIndex = 28;
            this.ThirdCircle.TabStop = false;
            // 
            // SecondCircle
            // 
            this.SecondCircle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecondCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SecondCircle.Image = ((System.Drawing.Image)(resources.GetObject("SecondCircle.Image")));
            this.SecondCircle.Location = new System.Drawing.Point(596, 554);
            this.SecondCircle.Name = "SecondCircle";
            this.SecondCircle.Size = new System.Drawing.Size(39, 35);
            this.SecondCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SecondCircle.TabIndex = 27;
            this.SecondCircle.TabStop = false;
            // 
            // FirstCircle
            // 
            this.FirstCircle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FirstCircle.Image = global::MovieMunch.Properties.Resources.UncolloredCircle;
            this.FirstCircle.Location = new System.Drawing.Point(540, 554);
            this.FirstCircle.Name = "FirstCircle";
            this.FirstCircle.Size = new System.Drawing.Size(38, 35);
            this.FirstCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FirstCircle.TabIndex = 26;
            this.FirstCircle.TabStop = false;
            // 
            // leftTurnBtn
            // 
            this.leftTurnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftTurnBtn.BackColor = System.Drawing.Color.Transparent;
            this.leftTurnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftTurnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftTurnBtn.Image = global::MovieMunch.Properties.Resources.leftBtn;
            this.leftTurnBtn.Location = new System.Drawing.Point(185, 270);
            this.leftTurnBtn.Name = "leftTurnBtn";
            this.leftTurnBtn.Padding = new System.Windows.Forms.Padding(40, 30, 40, 30);
            this.leftTurnBtn.Size = new System.Drawing.Size(114, 108);
            this.leftTurnBtn.TabIndex = 23;
            this.leftTurnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.leftTurnBtn.Click += new System.EventHandler(this.leftTurnBtn_Click);
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.BackColor = System.Drawing.Color.Black;
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
            this.pictureBoxLeft.Location = new System.Drawing.Point(-302, 135);
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
            this.pictureBoxMain.Location = new System.Drawing.Point(305, 135);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(578, 376);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 12;
            this.pictureBoxMain.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1393, 697);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.filmsInCinemaPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.FilmsInCinemaFlowLayouPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Panel panel2;
        private Panel filmsInCinemaPanel;
        private PictureBox pictureBoxMain;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBoxRight;
        private PictureBox pictureBoxLeft;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label label3;
        private Button SettingBtn;
        private FlowLayoutPanel FilmsInCinemaFlowLayouPanel;
        private Panel panel1;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel5;
        private Label label1;
        private PictureBox FirstCircle;
        private PictureBox FourthCircle;
        private PictureBox ThirdCircle;
        private PictureBox SecondCircle;
        private PictureBox searchBtn;
        private Label leftTurnBtn;
        private Label rightTurnBtn;
        private Panel panel13;
        private Button reservedBtn;
    }
}

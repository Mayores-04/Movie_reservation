using System;

namespace MovieMunch
{
    partial class LoadingForm 
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer timer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lastLogo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.firstCircle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.seventhCircle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.fifthCircle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.fourthCircle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.thirdCircle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.secondCircle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.sixthCircle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // lastLogo
            // 
            this.lastLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.lastLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lastLogo.BorderColor = System.Drawing.Color.Transparent;
            this.lastLogo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lastLogo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lastLogo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lastLogo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lastLogo.FillColor = System.Drawing.Color.Empty;
            this.lastLogo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastLogo.ForeColor = System.Drawing.Color.White;
            this.lastLogo.Image = global::MovieMunch.Properties.Resources.MovieM_removebg_preview;
            this.lastLogo.ImageSize = new System.Drawing.Size(600, 500);
            this.lastLogo.Location = new System.Drawing.Point(-8, -8);
            this.lastLogo.Name = "lastLogo";
            this.lastLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.lastLogo.Size = new System.Drawing.Size(1235, 670);
            this.lastLogo.TabIndex = 15;
            this.lastLogo.Visible = false;
            // 
            // firstCircle
            // 
            this.firstCircle.BackColor = System.Drawing.Color.Transparent;
            this.firstCircle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.firstCircle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.firstCircle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.firstCircle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.firstCircle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.firstCircle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstCircle.ForeColor = System.Drawing.Color.White;
            this.firstCircle.Location = new System.Drawing.Point(449, 196);
            this.firstCircle.Name = "firstCircle";
            this.firstCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.firstCircle.Size = new System.Drawing.Size(300, 300);
            this.firstCircle.TabIndex = 8;
            this.firstCircle.Visible = false;
            // 
            // seventhCircle
            // 
            this.seventhCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seventhCircle.BackgroundImage")));
            this.seventhCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seventhCircle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.seventhCircle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.seventhCircle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.seventhCircle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.seventhCircle.FillColor = System.Drawing.Color.Empty;
            this.seventhCircle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.seventhCircle.ForeColor = System.Drawing.Color.White;
            this.seventhCircle.Location = new System.Drawing.Point(-8, -266);
            this.seventhCircle.Name = "seventhCircle";
            this.seventhCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.seventhCircle.Size = new System.Drawing.Size(1217, 1200);
            this.seventhCircle.TabIndex = 14;
            this.seventhCircle.Visible = false;
            // 
            // fifthCircle
            // 
            this.fifthCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fifthCircle.BackgroundImage")));
            this.fifthCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fifthCircle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fifthCircle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fifthCircle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fifthCircle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fifthCircle.FillColor = System.Drawing.Color.Empty;
            this.fifthCircle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fifthCircle.ForeColor = System.Drawing.Color.White;
            this.fifthCircle.Location = new System.Drawing.Point(244, -24);
            this.fifthCircle.Name = "fifthCircle";
            this.fifthCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.fifthCircle.Size = new System.Drawing.Size(700, 700);
            this.fifthCircle.TabIndex = 12;
            this.fifthCircle.Visible = false;
            // 
            // fourthCircle
            // 
            this.fourthCircle.BackColor = System.Drawing.Color.Transparent;
            this.fourthCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fourthCircle.BackgroundImage")));
            this.fourthCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fourthCircle.BorderColor = System.Drawing.Color.Empty;
            this.fourthCircle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fourthCircle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fourthCircle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fourthCircle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fourthCircle.FillColor = System.Drawing.Color.Empty;
            this.fourthCircle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fourthCircle.ForeColor = System.Drawing.Color.White;
            this.fourthCircle.Location = new System.Drawing.Point(290, 25);
            this.fourthCircle.Name = "fourthCircle";
            this.fourthCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.fourthCircle.Size = new System.Drawing.Size(600, 600);
            this.fourthCircle.TabIndex = 11;
            this.fourthCircle.Visible = false;
            // 
            // thirdCircle
            // 
            this.thirdCircle.BackColor = System.Drawing.Color.Transparent;
            this.thirdCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thirdCircle.BackgroundImage")));
            this.thirdCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thirdCircle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.thirdCircle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.thirdCircle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.thirdCircle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.thirdCircle.FillColor = System.Drawing.Color.Empty;
            this.thirdCircle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.thirdCircle.ForeColor = System.Drawing.Color.White;
            this.thirdCircle.Location = new System.Drawing.Point(345, 80);
            this.thirdCircle.Name = "thirdCircle";
            this.thirdCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.thirdCircle.Size = new System.Drawing.Size(500, 500);
            this.thirdCircle.TabIndex = 10;
            this.thirdCircle.Visible = false;
            // 
            // secondCircle
            // 
            this.secondCircle.BackColor = System.Drawing.Color.Transparent;
            this.secondCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secondCircle.BackgroundImage")));
            this.secondCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondCircle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.secondCircle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.secondCircle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.secondCircle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.secondCircle.FillColor = System.Drawing.Color.Empty;
            this.secondCircle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.secondCircle.ForeColor = System.Drawing.Color.White;
            this.secondCircle.Location = new System.Drawing.Point(394, 137);
            this.secondCircle.Name = "secondCircle";
            this.secondCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.secondCircle.Size = new System.Drawing.Size(400, 400);
            this.secondCircle.TabIndex = 9;
            this.secondCircle.Visible = false;
            // 
            // sixthCircle
            // 
            this.sixthCircle.BackColor = System.Drawing.Color.Transparent;
            this.sixthCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sixthCircle.BackgroundImage")));
            this.sixthCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sixthCircle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sixthCircle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sixthCircle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sixthCircle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sixthCircle.FillColor = System.Drawing.Color.Empty;
            this.sixthCircle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sixthCircle.ForeColor = System.Drawing.Color.White;
            this.sixthCircle.Location = new System.Drawing.Point(144, -123);
            this.sixthCircle.Name = "sixthCircle";
            this.sixthCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.sixthCircle.Size = new System.Drawing.Size(900, 900);
            this.sixthCircle.TabIndex = 13;
            this.sixthCircle.Visible = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.fifthCircle);
            this.Controls.Add(this.fourthCircle);
            this.Controls.Add(this.lastLogo);
            this.Controls.Add(this.thirdCircle);
            this.Controls.Add(this.secondCircle);
            this.Controls.Add(this.sixthCircle);
            this.Controls.Add(this.firstCircle);
            this.Controls.Add(this.seventhCircle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton lastLogo;
        private Guna.UI2.WinForms.Guna2CircleButton firstCircle;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleButton seventhCircle;
        private Guna.UI2.WinForms.Guna2CircleButton fifthCircle;
        private Guna.UI2.WinForms.Guna2CircleButton fourthCircle;
        private Guna.UI2.WinForms.Guna2CircleButton thirdCircle;
        private Guna.UI2.WinForms.Guna2CircleButton secondCircle;
        private Guna.UI2.WinForms.Guna2CircleButton sixthCircle;
    }
}

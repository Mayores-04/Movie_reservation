namespace MovieMunch.Frontend.Forms
{
    partial class TicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.logoBefore = new System.Windows.Forms.PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.LogoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.gotoWatchListBtn = new Guna.UI2.WinForms.Guna2Button();
            this.gotoTicketFormBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userNameHolder = new Guna.UI2.WinForms.Guna2TextBox();
            this.userProfileBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.HomeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ticketsListWholeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBefore)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
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
            this.bunifuPanel1.Location = new System.Drawing.Point(-5, -3);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1216, 80);
            this.bunifuPanel1.TabIndex = 686;
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
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(29)))));
            this.guna2Panel3.BorderThickness = 3;
            this.guna2Panel3.Controls.Add(this.LogoutBtn);
            this.guna2Panel3.Controls.Add(this.gotoWatchListBtn);
            this.guna2Panel3.Controls.Add(this.gotoTicketFormBtn);
            this.guna2Panel3.Controls.Add(this.userNameHolder);
            this.guna2Panel3.Controls.Add(this.userProfileBtn);
            this.guna2Panel3.Controls.Add(this.HomeBtn);
            this.guna2Panel3.Location = new System.Drawing.Point(-5, 69);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(170, 591);
            this.guna2Panel3.TabIndex = 687;
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
            this.gotoTicketFormBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
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
            // userProfileBtn
            // 
            this.userProfileBtn.BackColor = System.Drawing.Color.Transparent;
            this.userProfileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userProfileBtn.BackgroundImage")));
            this.userProfileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userProfileBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.userProfileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userProfileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userProfileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userProfileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userProfileBtn.FillColor = System.Drawing.Color.Empty;
            this.userProfileBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userProfileBtn.ForeColor = System.Drawing.Color.White;
            this.userProfileBtn.Location = new System.Drawing.Point(41, 45);
            this.userProfileBtn.Name = "userProfileBtn";
            this.userProfileBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userProfileBtn.Size = new System.Drawing.Size(100, 100);
            this.userProfileBtn.TabIndex = 44;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BorderRadius = 10;
            this.HomeBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.HomeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeBtn.ImageSize = new System.Drawing.Size(30, 25);
            this.HomeBtn.IndicateFocus = true;
            this.HomeBtn.Location = new System.Drawing.Point(17, 283);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(144, 35);
            this.HomeBtn.TabIndex = 43;
            this.HomeBtn.Text = "HOME";
            this.HomeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ticketsListWholeFlowLayoutPanel
            // 
            this.ticketsListWholeFlowLayoutPanel.AutoScroll = true;
            this.ticketsListWholeFlowLayoutPanel.Location = new System.Drawing.Point(162, 72);
            this.ticketsListWholeFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.ticketsListWholeFlowLayoutPanel.Name = "ticketsListWholeFlowLayoutPanel";
            this.ticketsListWholeFlowLayoutPanel.Size = new System.Drawing.Size(1069, 578);
            this.ticketsListWholeFlowLayoutPanel.TabIndex = 688;
            this.ticketsListWholeFlowLayoutPanel.WrapContents = false;
            // 
            // TicketForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.ticketsListWholeFlowLayoutPanel);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketForm";
            this.bunifuPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBefore)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.PictureBox logoBefore;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button LogoutBtn;
        private Guna.UI2.WinForms.Guna2Button gotoWatchListBtn;
        private Guna.UI2.WinForms.Guna2Button gotoTicketFormBtn;
        private Guna.UI2.WinForms.Guna2TextBox userNameHolder;
        private Guna.UI2.WinForms.Guna2CircleButton userProfileBtn;
        private Guna.UI2.WinForms.Guna2Button HomeBtn;
        private System.Windows.Forms.FlowLayoutPanel ticketsListWholeFlowLayoutPanel;
    }
}
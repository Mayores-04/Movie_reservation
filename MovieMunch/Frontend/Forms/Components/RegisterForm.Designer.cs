using System.Windows.Forms;

namespace MovieMunch
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.LoginBtnLinked = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.regEmailInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.regNameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.regPasswordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.regConfirmPasswordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RegisterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.termsAndRegistrationCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.regFormClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.termsAndRegMessage = new System.Windows.Forms.Label();
            this.termsAndConditionPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.closeTermsAndConditionPanel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.successRegisterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.termsAndConditionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.label5.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(177)))), ((int)(((byte)(155)))));
            this.label5.Location = new System.Drawing.Point(614, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 38);
            this.label5.TabIndex = 34;
            this.label5.Text = "SIGN UP TO MOVIEMUNCH";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(29)))));
            this.guna2Panel3.BorderThickness = 3;
            this.guna2Panel3.Controls.Add(this.LoginBtnLinked);
            this.guna2Panel3.Controls.Add(this.pictureBox2);
            this.guna2Panel3.Location = new System.Drawing.Point(-4, -5);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(405, 659);
            this.guna2Panel3.TabIndex = 686;
            // 
            // LoginBtnLinked
            // 
            this.LoginBtnLinked.BorderColor = System.Drawing.Color.White;
            this.LoginBtnLinked.BorderRadius = 15;
            this.LoginBtnLinked.BorderThickness = 1;
            this.LoginBtnLinked.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtnLinked.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtnLinked.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtnLinked.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtnLinked.FillColor = System.Drawing.Color.Empty;
            this.LoginBtnLinked.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtnLinked.ForeColor = System.Drawing.Color.White;
            this.LoginBtnLinked.Location = new System.Drawing.Point(91, 434);
            this.LoginBtnLinked.Name = "LoginBtnLinked";
            this.LoginBtnLinked.Size = new System.Drawing.Size(225, 38);
            this.LoginBtnLinked.TabIndex = 699;
            this.LoginBtnLinked.Text = "SIGN IN";
            this.LoginBtnLinked.Click += new System.EventHandler(this.LoginBtnLinked_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MovieMunch.Properties.Resources.moviemunchBlack;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-10, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(457, 420);
            this.pictureBox2.TabIndex = 699;
            this.pictureBox2.TabStop = false;
            // 
            // regEmailInput
            // 
            this.regEmailInput.BorderRadius = 7;
            this.regEmailInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regEmailInput.DefaultText = "";
            this.regEmailInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regEmailInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regEmailInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regEmailInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regEmailInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regEmailInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regEmailInput.ForeColor = System.Drawing.Color.Black;
            this.regEmailInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regEmailInput.IconLeft = ((System.Drawing.Image)(resources.GetObject("regEmailInput.IconLeft")));
            this.regEmailInput.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.regEmailInput.IconLeftSize = new System.Drawing.Size(30, 30);
            this.regEmailInput.Location = new System.Drawing.Point(616, 358);
            this.regEmailInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.regEmailInput.Name = "regEmailInput";
            this.regEmailInput.PasswordChar = '\0';
            this.regEmailInput.PlaceholderForeColor = System.Drawing.Color.Black;
            this.regEmailInput.PlaceholderText = "Email";
            this.regEmailInput.SelectedText = "";
            this.regEmailInput.Size = new System.Drawing.Size(390, 51);
            this.regEmailInput.TabIndex = 2;
            this.regEmailInput.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // regNameInput
            // 
            this.regNameInput.BorderRadius = 7;
            this.regNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regNameInput.DefaultText = "";
            this.regNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regNameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regNameInput.ForeColor = System.Drawing.Color.Black;
            this.regNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regNameInput.IconLeft = ((System.Drawing.Image)(resources.GetObject("regNameInput.IconLeft")));
            this.regNameInput.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.regNameInput.IconLeftSize = new System.Drawing.Size(30, 30);
            this.regNameInput.Location = new System.Drawing.Point(616, 299);
            this.regNameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.regNameInput.Name = "regNameInput";
            this.regNameInput.PasswordChar = '\0';
            this.regNameInput.PlaceholderForeColor = System.Drawing.Color.Black;
            this.regNameInput.PlaceholderText = "Username";
            this.regNameInput.SelectedText = "";
            this.regNameInput.Size = new System.Drawing.Size(390, 51);
            this.regNameInput.TabIndex = 1;
            this.regNameInput.TextOffset = new System.Drawing.Point(4, 0);
            // 
            // regPasswordInput
            // 
            this.regPasswordInput.BorderRadius = 7;
            this.regPasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regPasswordInput.DefaultText = "";
            this.regPasswordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regPasswordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regPasswordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regPasswordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regPasswordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regPasswordInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regPasswordInput.ForeColor = System.Drawing.Color.Black;
            this.regPasswordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regPasswordInput.IconLeft = ((System.Drawing.Image)(resources.GetObject("regPasswordInput.IconLeft")));
            this.regPasswordInput.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.regPasswordInput.IconLeftSize = new System.Drawing.Size(30, 30);
            this.regPasswordInput.Location = new System.Drawing.Point(616, 417);
            this.regPasswordInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.regPasswordInput.Name = "regPasswordInput";
            this.regPasswordInput.PasswordChar = '●';
            this.regPasswordInput.PlaceholderForeColor = System.Drawing.Color.Black;
            this.regPasswordInput.PlaceholderText = "Password";
            this.regPasswordInput.SelectedText = "";
            this.regPasswordInput.Size = new System.Drawing.Size(390, 51);
            this.regPasswordInput.TabIndex = 3;
            this.regPasswordInput.TextOffset = new System.Drawing.Point(5, 0);
            this.regPasswordInput.UseSystemPasswordChar = true;
            // 
            // regConfirmPasswordInput
            // 
            this.regConfirmPasswordInput.BorderRadius = 7;
            this.regConfirmPasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regConfirmPasswordInput.DefaultText = "";
            this.regConfirmPasswordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regConfirmPasswordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regConfirmPasswordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regConfirmPasswordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regConfirmPasswordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regConfirmPasswordInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regConfirmPasswordInput.ForeColor = System.Drawing.Color.Black;
            this.regConfirmPasswordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regConfirmPasswordInput.IconLeft = ((System.Drawing.Image)(resources.GetObject("regConfirmPasswordInput.IconLeft")));
            this.regConfirmPasswordInput.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.regConfirmPasswordInput.IconLeftSize = new System.Drawing.Size(35, 35);
            this.regConfirmPasswordInput.Location = new System.Drawing.Point(616, 476);
            this.regConfirmPasswordInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.regConfirmPasswordInput.Name = "regConfirmPasswordInput";
            this.regConfirmPasswordInput.PasswordChar = '●';
            this.regConfirmPasswordInput.PlaceholderForeColor = System.Drawing.Color.Black;
            this.regConfirmPasswordInput.PlaceholderText = "Confirm Password";
            this.regConfirmPasswordInput.SelectedText = "";
            this.regConfirmPasswordInput.Size = new System.Drawing.Size(390, 51);
            this.regConfirmPasswordInput.TabIndex = 4;
            this.regConfirmPasswordInput.UseSystemPasswordChar = true;
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(177)))), ((int)(((byte)(155)))));
            this.guna2CircleButton3.BorderThickness = 2;
            this.guna2CircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton3.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.Image = global::MovieMunch.Properties.Resources.microsoft_logo;
            this.guna2CircleButton3.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2CircleButton3.Location = new System.Drawing.Point(844, 201);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.Size = new System.Drawing.Size(60, 60);
            this.guna2CircleButton3.TabIndex = 698;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(177)))), ((int)(((byte)(155)))));
            this.guna2CircleButton2.BorderThickness = 2;
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Image = global::MovieMunch.Properties.Resources.google;
            this.guna2CircleButton2.ImageOffset = new System.Drawing.Point(1, 1);
            this.guna2CircleButton2.ImageSize = new System.Drawing.Size(43, 43);
            this.guna2CircleButton2.Location = new System.Drawing.Point(778, 201);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(60, 60);
            this.guna2CircleButton2.TabIndex = 697;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(177)))), ((int)(((byte)(155)))));
            this.guna2CircleButton1.BorderThickness = 2;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = global::MovieMunch.Properties.Resources.facebook;
            this.guna2CircleButton1.ImageOffset = new System.Drawing.Point(0, 1);
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2CircleButton1.Location = new System.Drawing.Point(712, 201);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(60, 60);
            this.guna2CircleButton1.TabIndex = 696;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MovieMunch.Properties.Resources.MovieM_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(593, -96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 388);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.Transparent;
            this.RegisterBtn.BorderColor = System.Drawing.Color.Transparent;
            this.RegisterBtn.BorderRadius = 15;
            this.RegisterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(159)))));
            this.RegisterBtn.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.Black;
            this.RegisterBtn.Location = new System.Drawing.Point(698, 586);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(225, 38);
            this.RegisterBtn.TabIndex = 6;
            this.RegisterBtn.Text = "SIGN UP";
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(177)))), ((int)(((byte)(155)))));
            this.label6.Location = new System.Drawing.Point(674, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 27);
            this.label6.TabIndex = 701;
            this.label6.Text = "OR USE YOUR EMAIL ACCOUNT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // termsAndRegistrationCheckBox
            // 
            this.termsAndRegistrationCheckBox.AutoSize = true;
            this.termsAndRegistrationCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.termsAndRegistrationCheckBox.CheckedState.BorderRadius = 0;
            this.termsAndRegistrationCheckBox.CheckedState.BorderThickness = 0;
            this.termsAndRegistrationCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.termsAndRegistrationCheckBox.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.termsAndRegistrationCheckBox.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termsAndRegistrationCheckBox.ForeColor = System.Drawing.Color.White;
            this.termsAndRegistrationCheckBox.Location = new System.Drawing.Point(224, 543);
            this.termsAndRegistrationCheckBox.Name = "termsAndRegistrationCheckBox";
            this.termsAndRegistrationCheckBox.Size = new System.Drawing.Size(212, 25);
            this.termsAndRegistrationCheckBox.TabIndex = 5;
            this.termsAndRegistrationCheckBox.Text = "Terms and conditions";
            this.termsAndRegistrationCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.termsAndRegistrationCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.termsAndRegistrationCheckBox.UncheckedState.BorderRadius = 0;
            this.termsAndRegistrationCheckBox.UncheckedState.BorderThickness = 0;
            this.termsAndRegistrationCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // regFormClose
            // 
            this.regFormClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(177)))), ((int)(((byte)(155)))));
            this.regFormClose.BorderThickness = 2;
            this.regFormClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.regFormClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.regFormClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.regFormClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.regFormClose.FillColor = System.Drawing.Color.Transparent;
            this.regFormClose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regFormClose.ForeColor = System.Drawing.Color.White;
            this.regFormClose.ImageSize = new System.Drawing.Size(50, 50);
            this.regFormClose.Location = new System.Drawing.Point(1138, 12);
            this.regFormClose.Name = "regFormClose";
            this.regFormClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.regFormClose.Size = new System.Drawing.Size(50, 50);
            this.regFormClose.TabIndex = 704;
            this.regFormClose.Text = "x";
            this.regFormClose.TextOffset = new System.Drawing.Point(1, -3);
            this.regFormClose.Click += new System.EventHandler(this.regFormClose_Click);
            // 
            // termsAndRegMessage
            // 
            this.termsAndRegMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.termsAndRegMessage.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termsAndRegMessage.ForeColor = System.Drawing.Color.Red;
            this.termsAndRegMessage.Location = new System.Drawing.Point(640, 556);
            this.termsAndRegMessage.Name = "termsAndRegMessage";
            this.termsAndRegMessage.Size = new System.Drawing.Size(335, 27);
            this.termsAndRegMessage.TabIndex = 705;
            this.termsAndRegMessage.Text = "Accept the terms and Agreement to Sign Up";
            this.termsAndRegMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.termsAndRegMessage.Visible = false;
            // 
            // termsAndConditionPanel
            // 
            this.termsAndConditionPanel.BackColor = System.Drawing.Color.Transparent;
            this.termsAndConditionPanel.BorderRadius = 30;
            this.termsAndConditionPanel.Controls.Add(this.successRegisterBtn);
            this.termsAndConditionPanel.Controls.Add(this.closeTermsAndConditionPanel);
            this.termsAndConditionPanel.Controls.Add(this.termsAndRegistrationCheckBox);
            this.termsAndConditionPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(29)))));
            this.termsAndConditionPanel.Location = new System.Drawing.Point(487, 12);
            this.termsAndConditionPanel.Name = "termsAndConditionPanel";
            this.termsAndConditionPanel.Size = new System.Drawing.Size(631, 626);
            this.termsAndConditionPanel.TabIndex = 706;
            this.termsAndConditionPanel.Visible = false;
            // 
            // closeTermsAndConditionPanel
            // 
            this.closeTermsAndConditionPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(177)))), ((int)(((byte)(155)))));
            this.closeTermsAndConditionPanel.BorderThickness = 2;
            this.closeTermsAndConditionPanel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeTermsAndConditionPanel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeTermsAndConditionPanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeTermsAndConditionPanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeTermsAndConditionPanel.FillColor = System.Drawing.Color.Transparent;
            this.closeTermsAndConditionPanel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeTermsAndConditionPanel.ForeColor = System.Drawing.Color.White;
            this.closeTermsAndConditionPanel.ImageSize = new System.Drawing.Size(50, 50);
            this.closeTermsAndConditionPanel.Location = new System.Drawing.Point(559, 12);
            this.closeTermsAndConditionPanel.Name = "closeTermsAndConditionPanel";
            this.closeTermsAndConditionPanel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeTermsAndConditionPanel.Size = new System.Drawing.Size(50, 50);
            this.closeTermsAndConditionPanel.TabIndex = 705;
            this.closeTermsAndConditionPanel.Text = "x";
            this.closeTermsAndConditionPanel.TextOffset = new System.Drawing.Point(1, -3);
            this.closeTermsAndConditionPanel.Click += new System.EventHandler(this.closeTermsAndConditionPanel_Click);
            // 
            // successRegisterBtn
            // 
            this.successRegisterBtn.BackColor = System.Drawing.Color.Transparent;
            this.successRegisterBtn.BorderColor = System.Drawing.Color.Transparent;
            this.successRegisterBtn.BorderRadius = 15;
            this.successRegisterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.successRegisterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.successRegisterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.successRegisterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.successRegisterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(159)))));
            this.successRegisterBtn.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successRegisterBtn.ForeColor = System.Drawing.Color.Black;
            this.successRegisterBtn.Location = new System.Drawing.Point(225, 574);
            this.successRegisterBtn.Name = "successRegisterBtn";
            this.successRegisterBtn.Size = new System.Drawing.Size(198, 38);
            this.successRegisterBtn.TabIndex = 706;
            this.successRegisterBtn.Text = "PROCEED";
            this.successRegisterBtn.Click += new System.EventHandler(this.successRegisterBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.termsAndConditionPanel);
            this.Controls.Add(this.termsAndRegMessage);
            this.Controls.Add(this.regFormClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2CircleButton3);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.regPasswordInput);
            this.Controls.Add(this.regConfirmPasswordInput);
            this.Controls.Add(this.regNameInput);
            this.Controls.Add(this.regEmailInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Form";
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.termsAndConditionPanel.ResumeLayout(false);
            this.termsAndConditionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TextBox regEmailInput;
        private Guna.UI2.WinForms.Guna2TextBox regNameInput;
        private Guna.UI2.WinForms.Guna2TextBox regPasswordInput;
        private Guna.UI2.WinForms.Guna2TextBox regConfirmPasswordInput;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button LoginBtnLinked;
        private Guna.UI2.WinForms.Guna2Button RegisterBtn;
        private Label label6;
        private Guna.UI2.WinForms.Guna2CheckBox termsAndRegistrationCheckBox;
        private Guna.UI2.WinForms.Guna2CircleButton regFormClose;
        private Label termsAndRegMessage;
        private Guna.UI2.WinForms.Guna2Panel termsAndConditionPanel;
        private Guna.UI2.WinForms.Guna2CircleButton closeTermsAndConditionPanel;
        private Guna.UI2.WinForms.Guna2Button successRegisterBtn;
    }
}

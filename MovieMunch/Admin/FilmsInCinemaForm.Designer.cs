namespace MovieMunch.Admin.FilmsInCinema
{
    partial class FilmsInCinemaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmsInCinemaForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewFilmPanel = new System.Windows.Forms.Panel();
            this.closeShowingImageBtn = new Guna.UI2.WinForms.Guna2Button();
            this.viewFilmBox = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.settingBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.backFilmBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.logoBefore = new System.Windows.Forms.PictureBox();
            this.formOptionsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.foodsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.employeesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.comingSoonBtn = new Guna.UI2.WinForms.Guna2Button();
            this.showingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddMoviesButton = new Guna.UI2.WinForms.Guna2Button();
            this.directoryInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.filmsPriceInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.descriptionInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.titleInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.MoviesTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewFilmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFilmBox)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBefore)).BeginInit();
            this.formOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // viewFilmPanel
            // 
            this.viewFilmPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.viewFilmPanel.Controls.Add(this.closeShowingImageBtn);
            this.viewFilmPanel.Controls.Add(this.viewFilmBox);
            this.viewFilmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewFilmPanel.Location = new System.Drawing.Point(0, 0);
            this.viewFilmPanel.Name = "viewFilmPanel";
            this.viewFilmPanel.Size = new System.Drawing.Size(1200, 650);
            this.viewFilmPanel.TabIndex = 32;
            this.viewFilmPanel.Visible = false;
            // 
            // closeShowingImageBtn
            // 
            this.closeShowingImageBtn.BorderRadius = 10;
            this.closeShowingImageBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.closeShowingImageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeShowingImageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeShowingImageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeShowingImageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeShowingImageBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.closeShowingImageBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeShowingImageBtn.ForeColor = System.Drawing.Color.White;
            this.closeShowingImageBtn.IndicateFocus = true;
            this.closeShowingImageBtn.Location = new System.Drawing.Point(534, 574);
            this.closeShowingImageBtn.Name = "closeShowingImageBtn";
            this.closeShowingImageBtn.Size = new System.Drawing.Size(194, 34);
            this.closeShowingImageBtn.TabIndex = 58;
            this.closeShowingImageBtn.Text = "CLOSE";
            this.closeShowingImageBtn.Click += new System.EventHandler(this.closeShowingImageBtn_Click);
            // 
            // viewFilmBox
            // 
            this.viewFilmBox.Location = new System.Drawing.Point(438, 56);
            this.viewFilmBox.Name = "viewFilmBox";
            this.viewFilmBox.Size = new System.Drawing.Size(384, 512);
            this.viewFilmBox.TabIndex = 0;
            this.viewFilmBox.TabStop = false;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(29)))));
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 2;
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.settingBtn);
            this.bunifuPanel1.Controls.Add(this.backFilmBtn);
            this.bunifuPanel1.Controls.Add(this.logoBefore);
            this.bunifuPanel1.Location = new System.Drawing.Point(-5, -3);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1215, 80);
            this.bunifuPanel1.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(702, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 51);
            this.label1.TabIndex = 56;
            this.label1.Text = "FILMS IN CINEMA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingBtn
            // 
            this.settingBtn.AllowAnimations = true;
            this.settingBtn.AllowBorderColorChanges = true;
            this.settingBtn.AllowMouseEffects = true;
            this.settingBtn.AnimationSpeed = 200;
            this.settingBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.settingBtn.BackgroundImage = global::MovieMunch.Properties.Resources.SettingIcon;
            this.settingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingBtn.BorderColor = System.Drawing.Color.Transparent;
            this.settingBtn.BorderRadius = 1;
            this.settingBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.settingBtn.BorderThickness = 1;
            this.settingBtn.ColorContrastOnClick = 30;
            this.settingBtn.ColorContrastOnHover = 30;
            this.settingBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.settingBtn.CustomizableEdges = borderEdges2;
            this.settingBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.settingBtn.Image = null;
            this.settingBtn.ImageMargin = new System.Windows.Forms.Padding(0);
            this.settingBtn.Location = new System.Drawing.Point(1143, 15);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.RoundBorders = true;
            this.settingBtn.ShowBorders = true;
            this.settingBtn.Size = new System.Drawing.Size(50, 50);
            this.settingBtn.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.settingBtn.TabIndex = 44;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // backFilmBtn
            // 
            this.backFilmBtn.BackColor = System.Drawing.Color.Transparent;
            this.backFilmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backFilmBtn.BackgroundImage")));
            this.backFilmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backFilmBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.backFilmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backFilmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backFilmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backFilmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backFilmBtn.FillColor = System.Drawing.Color.Empty;
            this.backFilmBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backFilmBtn.ForeColor = System.Drawing.Color.White;
            this.backFilmBtn.Location = new System.Drawing.Point(168, 15);
            this.backFilmBtn.Name = "backFilmBtn";
            this.backFilmBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.backFilmBtn.Size = new System.Drawing.Size(67, 54);
            this.backFilmBtn.TabIndex = 55;
            this.backFilmBtn.Click += new System.EventHandler(this.backFilmBtn_Click_1);
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
            // formOptionsPanel
            // 
            this.formOptionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.formOptionsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.formOptionsPanel.BorderRadius = 3;
            this.formOptionsPanel.BorderThickness = 3;
            this.formOptionsPanel.Controls.Add(this.foodsBtn);
            this.formOptionsPanel.Controls.Add(this.employeesBtn);
            this.formOptionsPanel.Controls.Add(this.comingSoonBtn);
            this.formOptionsPanel.Controls.Add(this.showingBtn);
            this.formOptionsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.formOptionsPanel.Location = new System.Drawing.Point(987, 75);
            this.formOptionsPanel.Name = "formOptionsPanel";
            this.formOptionsPanel.Size = new System.Drawing.Size(201, 215);
            this.formOptionsPanel.TabIndex = 65;
            this.formOptionsPanel.Visible = false;
            // 
            // foodsBtn
            // 
            this.foodsBtn.BorderRadius = 10;
            this.foodsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.foodsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.foodsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.foodsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.foodsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.foodsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.foodsBtn.ForeColor = System.Drawing.Color.White;
            this.foodsBtn.Location = new System.Drawing.Point(11, 161);
            this.foodsBtn.Name = "foodsBtn";
            this.foodsBtn.Size = new System.Drawing.Size(180, 45);
            this.foodsBtn.TabIndex = 4;
            this.foodsBtn.Text = "FOODS";
            this.foodsBtn.Click += new System.EventHandler(this.foodsBtn_Click);
            // 
            // employeesBtn
            // 
            this.employeesBtn.BorderRadius = 10;
            this.employeesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.employeesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.employeesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.employeesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.employeesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.employeesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.employeesBtn.ForeColor = System.Drawing.Color.White;
            this.employeesBtn.Location = new System.Drawing.Point(11, 110);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(180, 45);
            this.employeesBtn.TabIndex = 3;
            this.employeesBtn.Text = "EMPLOYEES";
            this.employeesBtn.Click += new System.EventHandler(this.employeesBtn_Click);
            // 
            // comingSoonBtn
            // 
            this.comingSoonBtn.BorderRadius = 10;
            this.comingSoonBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.comingSoonBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.comingSoonBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.comingSoonBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.comingSoonBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.comingSoonBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comingSoonBtn.ForeColor = System.Drawing.Color.White;
            this.comingSoonBtn.Location = new System.Drawing.Point(11, 59);
            this.comingSoonBtn.Name = "comingSoonBtn";
            this.comingSoonBtn.Size = new System.Drawing.Size(180, 45);
            this.comingSoonBtn.TabIndex = 2;
            this.comingSoonBtn.Text = "COMING SOON";
            this.comingSoonBtn.Click += new System.EventHandler(this.comingSoonBtn_Click);
            // 
            // showingBtn
            // 
            this.showingBtn.BorderRadius = 10;
            this.showingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showingBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.showingBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showingBtn.ForeColor = System.Drawing.Color.White;
            this.showingBtn.Location = new System.Drawing.Point(11, 8);
            this.showingBtn.Name = "showingBtn";
            this.showingBtn.Size = new System.Drawing.Size(180, 45);
            this.showingBtn.TabIndex = 0;
            this.showingBtn.Text = "SHOWING";
            this.showingBtn.Click += new System.EventHandler(this.showingBtn_Click);
            // 
            // AddMoviesButton
            // 
            this.AddMoviesButton.BorderRadius = 10;
            this.AddMoviesButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.AddMoviesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddMoviesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddMoviesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddMoviesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddMoviesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.AddMoviesButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMoviesButton.ForeColor = System.Drawing.Color.White;
            this.AddMoviesButton.IndicateFocus = true;
            this.AddMoviesButton.Location = new System.Drawing.Point(13, 95);
            this.AddMoviesButton.Name = "AddMoviesButton";
            this.AddMoviesButton.Size = new System.Drawing.Size(136, 34);
            this.AddMoviesButton.TabIndex = 66;
            this.AddMoviesButton.Text = "ADD";
            this.AddMoviesButton.Click += new System.EventHandler(this.AddFilm_Click);
            // 
            // directoryInput
            // 
            this.directoryInput.BackColor = System.Drawing.Color.Transparent;
            this.directoryInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.directoryInput.BorderRadius = 10;
            this.directoryInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.directoryInput.DefaultText = "";
            this.directoryInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.directoryInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.directoryInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.directoryInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.directoryInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.directoryInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoryInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.directoryInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.directoryInput.Location = new System.Drawing.Point(1017, 95);
            this.directoryInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.directoryInput.Name = "directoryInput";
            this.directoryInput.PasswordChar = '\0';
            this.directoryInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.directoryInput.PlaceholderText = "DIRECTORY";
            this.directoryInput.SelectedText = "";
            this.directoryInput.Size = new System.Drawing.Size(170, 34);
            this.directoryInput.TabIndex = 70;
            // 
            // filmsPriceInput
            // 
            this.filmsPriceInput.BackColor = System.Drawing.Color.Transparent;
            this.filmsPriceInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.filmsPriceInput.BorderRadius = 10;
            this.filmsPriceInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filmsPriceInput.DefaultText = "";
            this.filmsPriceInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.filmsPriceInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.filmsPriceInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filmsPriceInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filmsPriceInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filmsPriceInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmsPriceInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.filmsPriceInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.filmsPriceInput.Location = new System.Drawing.Point(782, 94);
            this.filmsPriceInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.filmsPriceInput.Name = "filmsPriceInput";
            this.filmsPriceInput.PasswordChar = '\0';
            this.filmsPriceInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.filmsPriceInput.PlaceholderText = "ENTER PRICE";
            this.filmsPriceInput.SelectedText = "";
            this.filmsPriceInput.Size = new System.Drawing.Size(228, 34);
            this.filmsPriceInput.TabIndex = 69;
            // 
            // descriptionInput
            // 
            this.descriptionInput.BackColor = System.Drawing.Color.Transparent;
            this.descriptionInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.descriptionInput.BorderRadius = 10;
            this.descriptionInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionInput.DefaultText = "";
            this.descriptionInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.descriptionInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.descriptionInput.Location = new System.Drawing.Point(439, 95);
            this.descriptionInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.PasswordChar = '\0';
            this.descriptionInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.descriptionInput.PlaceholderText = "ENTER DESCRIPTION";
            this.descriptionInput.SelectedText = "";
            this.descriptionInput.Size = new System.Drawing.Size(335, 34);
            this.descriptionInput.TabIndex = 68;
            // 
            // titleInput
            // 
            this.titleInput.BackColor = System.Drawing.Color.Transparent;
            this.titleInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.titleInput.BorderRadius = 10;
            this.titleInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleInput.DefaultText = "";
            this.titleInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.titleInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.titleInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titleInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.titleInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.titleInput.Location = new System.Drawing.Point(156, 95);
            this.titleInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.titleInput.Name = "titleInput";
            this.titleInput.PasswordChar = '\0';
            this.titleInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.titleInput.PlaceholderText = "ENTER TITLE";
            this.titleInput.SelectedText = "";
            this.titleInput.Size = new System.Drawing.Size(275, 34);
            this.titleInput.TabIndex = 67;
            // 
            // MoviesTable
            // 
            this.MoviesTable.AllowUserToAddRows = false;
            this.MoviesTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.MoviesTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.MoviesTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MoviesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.MoviesTable.ColumnHeadersHeight = 27;
            this.MoviesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MoviesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Title,
            this.Description,
            this.filmPrice,
            this.imagePath,
            this.DaysCB,
            this.StartTimeCB,
            this.EndTimeCB});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MoviesTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.MoviesTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.MoviesTable.Location = new System.Drawing.Point(13, 154);
            this.MoviesTable.Name = "MoviesTable";
            this.MoviesTable.RowHeadersVisible = false;
            this.MoviesTable.RowHeadersWidth = 51;
            this.MoviesTable.RowTemplate.Height = 24;
            this.MoviesTable.Size = new System.Drawing.Size(1175, 484);
            this.MoviesTable.TabIndex = 72;
            this.MoviesTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MoviesTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MoviesTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MoviesTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MoviesTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MoviesTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.MoviesTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.MoviesTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MoviesTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MoviesTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MoviesTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MoviesTable.ThemeStyle.HeaderStyle.Height = 27;
            this.MoviesTable.ThemeStyle.ReadOnly = false;
            this.MoviesTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MoviesTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MoviesTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MoviesTable.ThemeStyle.RowsStyle.Height = 24;
            this.MoviesTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MoviesTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // filmPrice
            // 
            this.filmPrice.HeaderText = "Price";
            this.filmPrice.MinimumWidth = 6;
            this.filmPrice.Name = "filmPrice";
            // 
            // imagePath
            // 
            this.imagePath.HeaderText = "Directory";
            this.imagePath.MinimumWidth = 6;
            this.imagePath.Name = "imagePath";
            // 
            // DaysCB
            // 
            this.DaysCB.HeaderText = "Days";
            this.DaysCB.MinimumWidth = 6;
            this.DaysCB.Name = "DaysCB";
            // 
            // StartTimeCB
            // 
            this.StartTimeCB.HeaderText = "Start Time";
            this.StartTimeCB.MinimumWidth = 6;
            this.StartTimeCB.Name = "StartTimeCB";
            // 
            // EndTimeCB
            // 
            this.EndTimeCB.HeaderText = "End Time";
            this.EndTimeCB.MinimumWidth = 6;
            this.EndTimeCB.Name = "EndTimeCB";
            // 
            // FilmsInCinemaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.viewFilmPanel);
            this.Controls.Add(this.MoviesTable);
            this.Controls.Add(this.AddMoviesButton);
            this.Controls.Add(this.directoryInput);
            this.Controls.Add(this.filmsPriceInput);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.formOptionsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilmsInCinemaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmsInCinema";
            this.viewFilmPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewFilmBox)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBefore)).EndInit();
            this.formOptionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoviesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel viewFilmPanel;
        private System.Windows.Forms.PictureBox viewFilmBox;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton settingBtn;
        private Guna.UI2.WinForms.Guna2CircleButton backFilmBtn;
        private System.Windows.Forms.PictureBox logoBefore;
        private Guna.UI2.WinForms.Guna2Panel formOptionsPanel;
        private Guna.UI2.WinForms.Guna2Button foodsBtn;
        private Guna.UI2.WinForms.Guna2Button employeesBtn;
        private Guna.UI2.WinForms.Guna2Button comingSoonBtn;
        private Guna.UI2.WinForms.Guna2Button showingBtn;
        private Guna.UI2.WinForms.Guna2Button AddMoviesButton;
        private Guna.UI2.WinForms.Guna2TextBox directoryInput;
        private Guna.UI2.WinForms.Guna2TextBox filmsPriceInput;
        private Guna.UI2.WinForms.Guna2TextBox descriptionInput;
        private Guna.UI2.WinForms.Guna2TextBox titleInput;
        private Guna.UI2.WinForms.Guna2DataGridView MoviesTable;
        private Guna.UI2.WinForms.Guna2Button closeShowingImageBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeCB;
    }
}
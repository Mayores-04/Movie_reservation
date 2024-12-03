namespace MovieMunch.Admin
{
    partial class EmployeesManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesManagementForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formOptionsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.foodsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.comingSoonBtn = new Guna.UI2.WinForms.Guna2Button();
            this.filmsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.showingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.settingBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.backCsoonBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.logoBefore = new System.Windows.Forms.PictureBox();
            this.EmployeeListTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addEmployeeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.employeeImagePathInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.employeePasswordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.employeeEmailInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.employeeNameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.viewEmployeePanel = new System.Windows.Forms.Panel();
            this.closeShowingImageBtn = new Guna.UI2.WinForms.Guna2Button();
            this.viewEmployeeBox = new System.Windows.Forms.PictureBox();
            this.formOptionsPanel.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeListTable)).BeginInit();
            this.viewEmployeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployeeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // formOptionsPanel
            // 
            this.formOptionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.formOptionsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.formOptionsPanel.BorderRadius = 3;
            this.formOptionsPanel.BorderThickness = 3;
            this.formOptionsPanel.Controls.Add(this.foodsBtn);
            this.formOptionsPanel.Controls.Add(this.comingSoonBtn);
            this.formOptionsPanel.Controls.Add(this.filmsBtn);
            this.formOptionsPanel.Controls.Add(this.showingBtn);
            this.formOptionsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.formOptionsPanel.Location = new System.Drawing.Point(987, 75);
            this.formOptionsPanel.Name = "formOptionsPanel";
            this.formOptionsPanel.Size = new System.Drawing.Size(201, 216);
            this.formOptionsPanel.TabIndex = 71;
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
            this.foodsBtn.Click += new System.EventHandler(this.foodsBtn_Click_1);
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
            this.comingSoonBtn.Location = new System.Drawing.Point(11, 110);
            this.comingSoonBtn.Name = "comingSoonBtn";
            this.comingSoonBtn.Size = new System.Drawing.Size(180, 45);
            this.comingSoonBtn.TabIndex = 3;
            this.comingSoonBtn.Text = "COMING SOON";
            this.comingSoonBtn.Click += new System.EventHandler(this.comingSoonBtn_Click_1);
            // 
            // filmsBtn
            // 
            this.filmsBtn.BorderRadius = 10;
            this.filmsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.filmsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.filmsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.filmsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.filmsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.filmsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filmsBtn.ForeColor = System.Drawing.Color.White;
            this.filmsBtn.Location = new System.Drawing.Point(11, 59);
            this.filmsBtn.Name = "filmsBtn";
            this.filmsBtn.Size = new System.Drawing.Size(180, 45);
            this.filmsBtn.TabIndex = 1;
            this.filmsBtn.Text = "FILMS";
            this.filmsBtn.Click += new System.EventHandler(this.filmsBtn_Click_1);
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
            this.showingBtn.Click += new System.EventHandler(this.showingBtn_Click_1);
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
            this.bunifuPanel1.Controls.Add(this.backCsoonBtn);
            this.bunifuPanel1.Controls.Add(this.logoBefore);
            this.bunifuPanel1.Location = new System.Drawing.Point(-5, -3);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1215, 80);
            this.bunifuPanel1.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(821, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 51);
            this.label1.TabIndex = 56;
            this.label1.Text = "EMPLOYEES";
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.settingBtn.CustomizableEdges = borderEdges1;
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
            // backCsoonBtn
            // 
            this.backCsoonBtn.BackColor = System.Drawing.Color.Transparent;
            this.backCsoonBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backCsoonBtn.BackgroundImage")));
            this.backCsoonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backCsoonBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.backCsoonBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backCsoonBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backCsoonBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backCsoonBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backCsoonBtn.FillColor = System.Drawing.Color.Empty;
            this.backCsoonBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backCsoonBtn.ForeColor = System.Drawing.Color.White;
            this.backCsoonBtn.Location = new System.Drawing.Point(168, 15);
            this.backCsoonBtn.Name = "backCsoonBtn";
            this.backCsoonBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.backCsoonBtn.Size = new System.Drawing.Size(67, 54);
            this.backCsoonBtn.TabIndex = 55;
            this.backCsoonBtn.Click += new System.EventHandler(this.backCsoonBtn_Click);
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
            // EmployeeListTable
            // 
            this.EmployeeListTable.AllowUserToAddRows = false;
            this.EmployeeListTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmployeeListTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeListTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeListTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeListTable.ColumnHeadersHeight = 27;
            this.EmployeeListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeId,
            this.employeeName,
            this.employeeEmail,
            this.employeePassword,
            this.employeeProfile});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeListTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeListTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.EmployeeListTable.Location = new System.Drawing.Point(13, 154);
            this.EmployeeListTable.Name = "EmployeeListTable";
            this.EmployeeListTable.RowHeadersVisible = false;
            this.EmployeeListTable.RowHeadersWidth = 51;
            this.EmployeeListTable.RowTemplate.Height = 24;
            this.EmployeeListTable.Size = new System.Drawing.Size(1175, 484);
            this.EmployeeListTable.TabIndex = 82;
            this.EmployeeListTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeListTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeListTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeListTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeListTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeListTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.EmployeeListTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.EmployeeListTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmployeeListTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeListTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeListTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeListTable.ThemeStyle.HeaderStyle.Height = 27;
            this.EmployeeListTable.ThemeStyle.ReadOnly = false;
            this.EmployeeListTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeListTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeListTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeListTable.ThemeStyle.RowsStyle.Height = 24;
            this.EmployeeListTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeListTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // employeeId
            // 
            this.employeeId.HeaderText = "ID";
            this.employeeId.MinimumWidth = 6;
            this.employeeId.Name = "employeeId";
            // 
            // employeeName
            // 
            this.employeeName.HeaderText = "NAME";
            this.employeeName.MinimumWidth = 6;
            this.employeeName.Name = "employeeName";
            // 
            // employeeEmail
            // 
            this.employeeEmail.HeaderText = "EMAIL";
            this.employeeEmail.MinimumWidth = 6;
            this.employeeEmail.Name = "employeeEmail";
            // 
            // employeePassword
            // 
            this.employeePassword.HeaderText = "PASSWORD";
            this.employeePassword.MinimumWidth = 6;
            this.employeePassword.Name = "employeePassword";
            // 
            // employeeProfile
            // 
            this.employeeProfile.HeaderText = "PIC DIRECTORY";
            this.employeeProfile.MinimumWidth = 6;
            this.employeeProfile.Name = "employeeProfile";
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.BorderRadius = 10;
            this.addEmployeeBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(8)))));
            this.addEmployeeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addEmployeeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addEmployeeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addEmployeeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addEmployeeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.addEmployeeBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployeeBtn.IndicateFocus = true;
            this.addEmployeeBtn.Location = new System.Drawing.Point(13, 95);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(136, 34);
            this.addEmployeeBtn.TabIndex = 83;
            this.addEmployeeBtn.Text = "ADD";
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click_1);
            // 
            // employeeImagePathInput
            // 
            this.employeeImagePathInput.BackColor = System.Drawing.Color.Transparent;
            this.employeeImagePathInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.employeeImagePathInput.BorderRadius = 10;
            this.employeeImagePathInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeeImagePathInput.DefaultText = "";
            this.employeeImagePathInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.employeeImagePathInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.employeeImagePathInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeeImagePathInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeeImagePathInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeeImagePathInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeImagePathInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.employeeImagePathInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.employeeImagePathInput.Location = new System.Drawing.Point(1017, 95);
            this.employeeImagePathInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.employeeImagePathInput.Name = "employeeImagePathInput";
            this.employeeImagePathInput.PasswordChar = '\0';
            this.employeeImagePathInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.employeeImagePathInput.PlaceholderText = "PIC DIRECTORY";
            this.employeeImagePathInput.SelectedText = "";
            this.employeeImagePathInput.Size = new System.Drawing.Size(170, 34);
            this.employeeImagePathInput.TabIndex = 87;
            // 
            // employeePasswordInput
            // 
            this.employeePasswordInput.BackColor = System.Drawing.Color.Transparent;
            this.employeePasswordInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.employeePasswordInput.BorderRadius = 10;
            this.employeePasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeePasswordInput.DefaultText = "";
            this.employeePasswordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.employeePasswordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.employeePasswordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeePasswordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeePasswordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeePasswordInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePasswordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.employeePasswordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.employeePasswordInput.Location = new System.Drawing.Point(782, 94);
            this.employeePasswordInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.employeePasswordInput.Name = "employeePasswordInput";
            this.employeePasswordInput.PasswordChar = '\0';
            this.employeePasswordInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.employeePasswordInput.PlaceholderText = "ENTER PASSWORD";
            this.employeePasswordInput.SelectedText = "";
            this.employeePasswordInput.Size = new System.Drawing.Size(228, 34);
            this.employeePasswordInput.TabIndex = 86;
            // 
            // employeeEmailInput
            // 
            this.employeeEmailInput.BackColor = System.Drawing.Color.Transparent;
            this.employeeEmailInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.employeeEmailInput.BorderRadius = 10;
            this.employeeEmailInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeeEmailInput.DefaultText = "";
            this.employeeEmailInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.employeeEmailInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.employeeEmailInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeeEmailInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeeEmailInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeeEmailInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeEmailInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.employeeEmailInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.employeeEmailInput.Location = new System.Drawing.Point(439, 95);
            this.employeeEmailInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.employeeEmailInput.Name = "employeeEmailInput";
            this.employeeEmailInput.PasswordChar = '\0';
            this.employeeEmailInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.employeeEmailInput.PlaceholderText = "ENTER EMAIL";
            this.employeeEmailInput.SelectedText = "";
            this.employeeEmailInput.Size = new System.Drawing.Size(335, 34);
            this.employeeEmailInput.TabIndex = 85;
            // 
            // employeeNameInput
            // 
            this.employeeNameInput.BackColor = System.Drawing.Color.Transparent;
            this.employeeNameInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.employeeNameInput.BorderRadius = 10;
            this.employeeNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeeNameInput.DefaultText = "";
            this.employeeNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.employeeNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.employeeNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeeNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeeNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeeNameInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.employeeNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.employeeNameInput.Location = new System.Drawing.Point(156, 95);
            this.employeeNameInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.employeeNameInput.Name = "employeeNameInput";
            this.employeeNameInput.PasswordChar = '\0';
            this.employeeNameInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.employeeNameInput.PlaceholderText = "ENTER NAME";
            this.employeeNameInput.SelectedText = "";
            this.employeeNameInput.Size = new System.Drawing.Size(275, 34);
            this.employeeNameInput.TabIndex = 84;
            // 
            // viewEmployeePanel
            // 
            this.viewEmployeePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.viewEmployeePanel.Controls.Add(this.closeShowingImageBtn);
            this.viewEmployeePanel.Controls.Add(this.viewEmployeeBox);
            this.viewEmployeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewEmployeePanel.Location = new System.Drawing.Point(0, 0);
            this.viewEmployeePanel.Name = "viewEmployeePanel";
            this.viewEmployeePanel.Size = new System.Drawing.Size(1200, 650);
            this.viewEmployeePanel.TabIndex = 88;
            this.viewEmployeePanel.Visible = false;
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
            this.closeShowingImageBtn.Location = new System.Drawing.Point(536, 574);
            this.closeShowingImageBtn.Name = "closeShowingImageBtn";
            this.closeShowingImageBtn.Size = new System.Drawing.Size(194, 34);
            this.closeShowingImageBtn.TabIndex = 60;
            this.closeShowingImageBtn.Text = "CLOSE";
            this.closeShowingImageBtn.Click += new System.EventHandler(this.closeShowingImageBtn_Click);
            // 
            // viewEmployeeBox
            // 
            this.viewEmployeeBox.Location = new System.Drawing.Point(438, 56);
            this.viewEmployeeBox.Name = "viewEmployeeBox";
            this.viewEmployeeBox.Size = new System.Drawing.Size(384, 512);
            this.viewEmployeeBox.TabIndex = 0;
            this.viewEmployeeBox.TabStop = false;
            // 
            // EmployeesManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.viewEmployeePanel);
            this.Controls.Add(this.addEmployeeBtn);
            this.Controls.Add(this.employeeImagePathInput);
            this.Controls.Add(this.employeePasswordInput);
            this.Controls.Add(this.employeeEmailInput);
            this.Controls.Add(this.employeeNameInput);
            this.Controls.Add(this.EmployeeListTable);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.formOptionsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeesManagementForm";
            this.formOptionsPanel.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeListTable)).EndInit();
            this.viewEmployeePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployeeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton settingBtn;
        private Guna.UI2.WinForms.Guna2CircleButton backCsoonBtn;
        private System.Windows.Forms.PictureBox logoBefore;
        private Guna.UI2.WinForms.Guna2Panel formOptionsPanel;
        private Guna.UI2.WinForms.Guna2Button foodsBtn;
        private Guna.UI2.WinForms.Guna2Button comingSoonBtn;
        private Guna.UI2.WinForms.Guna2Button filmsBtn;
        private Guna.UI2.WinForms.Guna2Button showingBtn;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeListTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeProfile;
        private Guna.UI2.WinForms.Guna2Button addEmployeeBtn;
        private Guna.UI2.WinForms.Guna2TextBox employeeImagePathInput;
        private Guna.UI2.WinForms.Guna2TextBox employeePasswordInput;
        private Guna.UI2.WinForms.Guna2TextBox employeeEmailInput;
        private Guna.UI2.WinForms.Guna2TextBox employeeNameInput;
        private System.Windows.Forms.Panel viewEmployeePanel;
        private Guna.UI2.WinForms.Guna2Button closeShowingImageBtn;
        private System.Windows.Forms.PictureBox viewEmployeeBox;
    }
}
namespace MovieMunch
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.LoginContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.LinkLabel();
            this.bunifuFormCaptionButton1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.LoginBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.passwordInput = new Bunifu.UI.WinForms.BunifuTextBox();
            this.emailInput = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LoginContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginContainer
            // 
            this.LoginContainer.BackgroundColor = System.Drawing.Color.White;
            this.LoginContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginContainer.BackgroundImage")));
            this.LoginContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginContainer.BorderColor = System.Drawing.Color.Transparent;
            this.LoginContainer.BorderRadius = 30;
            this.LoginContainer.BorderThickness = 1;
            this.LoginContainer.Controls.Add(this.pictureBox2);
            this.LoginContainer.Controls.Add(this.label5);
            this.LoginContainer.Controls.Add(this.SignUpBtn);
            this.LoginContainer.Controls.Add(this.bunifuFormCaptionButton1);
            this.LoginContainer.Controls.Add(this.LoginBtn);
            this.LoginContainer.Controls.Add(this.passwordInput);
            this.LoginContainer.Controls.Add(this.emailInput);
            this.LoginContainer.Location = new System.Drawing.Point(473, 110);
            this.LoginContainer.Name = "LoginContainer";
            this.LoginContainer.ShowBorders = true;
            this.LoginContainer.Size = new System.Drawing.Size(397, 467);
            this.LoginContainer.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MovieMunch.Properties.Resources.MovieMunchLogo_removebg_preview;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(81, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 124);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Don\'t have an account?";
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.AutoSize = true;
            this.SignUpBtn.BackColor = System.Drawing.Color.White;
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignUpBtn.LinkColor = System.Drawing.Color.Black;
            this.SignUpBtn.Location = new System.Drawing.Point(263, 434);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(60, 18);
            this.SignUpBtn.TabIndex = 4;
            this.SignUpBtn.TabStop = true;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpBtn_LinkClicked);
            // 
            // bunifuFormCaptionButton1
            // 
            this.bunifuFormCaptionButton1.AllowAnimations = true;
            this.bunifuFormCaptionButton1.AllowBorderColorChanges = true;
            this.bunifuFormCaptionButton1.AllowDefaults = true;
            this.bunifuFormCaptionButton1.AllowMouseEffects = true;
            this.bunifuFormCaptionButton1.AnimationSpeed = 200;
            this.bunifuFormCaptionButton1.AutoSizeCaptions = true;
            this.bunifuFormCaptionButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.bunifuFormCaptionButton1.BackHoverColor = System.Drawing.Color.LightGray;
            this.bunifuFormCaptionButton1.BackPressedColor = System.Drawing.Color.Silver;
            this.bunifuFormCaptionButton1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuFormCaptionButton1.BorderHoverColor = System.Drawing.Color.DarkGray;
            this.bunifuFormCaptionButton1.BorderPressedColor = System.Drawing.Color.DarkGray;
            this.bunifuFormCaptionButton1.BorderRadius = 25;
            this.bunifuFormCaptionButton1.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.bunifuFormCaptionButton1.BorderThickness = 1;
            this.bunifuFormCaptionButton1.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            this.bunifuFormCaptionButton1.ColorContrastOnClick = 30;
            this.bunifuFormCaptionButton1.ColorContrastOnHover = 30;
            this.bunifuFormCaptionButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuFormCaptionButton1.CustomizableEdges = borderEdges1;
            this.bunifuFormCaptionButton1.DefaultBorderColor = System.Drawing.Color.Silver;
            this.bunifuFormCaptionButton1.DefaultColor = System.Drawing.Color.Gainsboro;
            this.bunifuFormCaptionButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuFormCaptionButton1.IconColor = System.Drawing.Color.Black;
            this.bunifuFormCaptionButton1.IconHoverColor = System.Drawing.Color.Black;
            this.bunifuFormCaptionButton1.IconPressedColor = System.Drawing.Color.Black;
            this.bunifuFormCaptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuFormCaptionButton1.Image")));
            this.bunifuFormCaptionButton1.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.bunifuFormCaptionButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.bunifuFormCaptionButton1.Location = new System.Drawing.Point(356, 6);
            this.bunifuFormCaptionButton1.Name = "bunifuFormCaptionButton1";
            this.bunifuFormCaptionButton1.ShowBorders = true;
            this.bunifuFormCaptionButton1.Size = new System.Drawing.Size(34, 30);
            this.bunifuFormCaptionButton1.TabIndex = 3;
            this.bunifuFormCaptionButton1.Click += new System.EventHandler(this.CloseButton);
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
            this.LoginBtn.ButtonText = "LOGIN";
            this.LoginBtn.ButtonTextMarginLeft = 0;
            this.LoginBtn.ColorContrastOnClick = 45;
            this.LoginBtn.ColorContrastOnHover = 45;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.LoginBtn.CustomizableEdges = borderEdges2;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoginBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoginBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LoginBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.LoginBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.LoginBtn.IdleBorderRadius = 35;
            this.LoginBtn.IdleBorderThickness = 1;
            this.LoginBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.LoginBtn.IdleIconLeftImage = null;
            this.LoginBtn.IdleIconRightImage = null;
            this.LoginBtn.IndicateFocus = false;
            this.LoginBtn.Location = new System.Drawing.Point(98, 314);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoginBtn.OnDisabledState.BorderRadius = 35;
            this.LoginBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LoginBtn.OnDisabledState.BorderThickness = 1;
            this.LoginBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoginBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LoginBtn.OnDisabledState.IconLeftImage = null;
            this.LoginBtn.OnDisabledState.IconRightImage = null;
            this.LoginBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LoginBtn.onHoverState.BorderRadius = 35;
            this.LoginBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LoginBtn.onHoverState.BorderThickness = 1;
            this.LoginBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LoginBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.onHoverState.IconLeftImage = null;
            this.LoginBtn.onHoverState.IconRightImage = null;
            this.LoginBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.LoginBtn.OnIdleState.BorderRadius = 35;
            this.LoginBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LoginBtn.OnIdleState.BorderThickness = 1;
            this.LoginBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.LoginBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnIdleState.IconLeftImage = null;
            this.LoginBtn.OnIdleState.IconRightImage = null;
            this.LoginBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LoginBtn.OnPressedState.BorderRadius = 35;
            this.LoginBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.LoginBtn.OnPressedState.BorderThickness = 1;
            this.LoginBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LoginBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnPressedState.IconLeftImage = null;
            this.LoginBtn.OnPressedState.IconRightImage = null;
            this.LoginBtn.Size = new System.Drawing.Size(201, 39);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBtn.TextMarginLeft = 0;
            this.LoginBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.LoginBtn.UseDefaultRadiusAndThickness = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.AcceptsReturn = false;
            this.passwordInput.AcceptsTab = false;
            this.passwordInput.AnimationSpeed = 200;
            this.passwordInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordInput.AutoSizeHeight = true;
            this.passwordInput.BackColor = System.Drawing.Color.Transparent;
            this.passwordInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordInput.BackgroundImage")));
            this.passwordInput.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.passwordInput.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordInput.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.passwordInput.BorderColorIdle = System.Drawing.Color.Silver;
            this.passwordInput.BorderRadius = 1;
            this.passwordInput.BorderThickness = 1;
            this.passwordInput.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.passwordInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.DefaultText = "";
            this.passwordInput.FillColor = System.Drawing.Color.White;
            this.passwordInput.HideSelection = true;
            this.passwordInput.IconLeft = null;
            this.passwordInput.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.IconPadding = 10;
            this.passwordInput.IconRight = null;
            this.passwordInput.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.Lines = new string[0];
            this.passwordInput.Location = new System.Drawing.Point(59, 246);
            this.passwordInput.MaxLength = 32767;
            this.passwordInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwordInput.Modified = false;
            this.passwordInput.Multiline = false;
            this.passwordInput.Name = "passwordInput";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordInput.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passwordInput.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordInput.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordInput.OnIdleState = stateProperties4;
            this.passwordInput.Padding = new System.Windows.Forms.Padding(3);
            this.passwordInput.PasswordChar = '\0';
            this.passwordInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordInput.PlaceholderText = "Password";
            this.passwordInput.ReadOnly = false;
            this.passwordInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordInput.SelectedText = "";
            this.passwordInput.SelectionLength = 0;
            this.passwordInput.SelectionStart = 0;
            this.passwordInput.ShortcutsEnabled = true;
            this.passwordInput.Size = new System.Drawing.Size(272, 49);
            this.passwordInput.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.passwordInput.TabIndex = 1;
            this.passwordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordInput.TextMarginBottom = 0;
            this.passwordInput.TextMarginLeft = 3;
            this.passwordInput.TextMarginTop = 1;
            this.passwordInput.TextPlaceholder = "Password";
            this.passwordInput.UseSystemPasswordChar = true;
            this.passwordInput.WordWrap = true;
            // 
            // emailInput
            // 
            this.emailInput.AcceptsReturn = false;
            this.emailInput.AcceptsTab = false;
            this.emailInput.AnimationSpeed = 200;
            this.emailInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.emailInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.emailInput.AutoSizeHeight = true;
            this.emailInput.BackColor = System.Drawing.Color.Transparent;
            this.emailInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emailInput.BackgroundImage")));
            this.emailInput.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.emailInput.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.emailInput.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.emailInput.BorderColorIdle = System.Drawing.Color.Silver;
            this.emailInput.BorderRadius = 1;
            this.emailInput.BorderThickness = 1;
            this.emailInput.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.emailInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailInput.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.DefaultText = "";
            this.emailInput.FillColor = System.Drawing.Color.White;
            this.emailInput.HideSelection = true;
            this.emailInput.IconLeft = null;
            this.emailInput.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.emailInput.IconPadding = 10;
            this.emailInput.IconRight = null;
            this.emailInput.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.emailInput.Lines = new string[0];
            this.emailInput.Location = new System.Drawing.Point(59, 191);
            this.emailInput.MaxLength = 32767;
            this.emailInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.emailInput.Modified = false;
            this.emailInput.Multiline = false;
            this.emailInput.Name = "emailInput";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.emailInput.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.emailInput.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.emailInput.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.emailInput.OnIdleState = stateProperties8;
            this.emailInput.Padding = new System.Windows.Forms.Padding(3);
            this.emailInput.PasswordChar = '\0';
            this.emailInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.emailInput.PlaceholderText = "Email";
            this.emailInput.ReadOnly = false;
            this.emailInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailInput.SelectedText = "";
            this.emailInput.SelectionLength = 0;
            this.emailInput.SelectionStart = 0;
            this.emailInput.ShortcutsEnabled = true;
            this.emailInput.Size = new System.Drawing.Size(272, 49);
            this.emailInput.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.emailInput.TabIndex = 0;
            this.emailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailInput.TextMarginBottom = 0;
            this.emailInput.TextMarginLeft = 3;
            this.emailInput.TextMarginTop = 1;
            this.emailInput.TextPlaceholder = "Email";
            this.emailInput.UseSystemPasswordChar = false;
            this.emailInput.WordWrap = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1343, 687);
            this.Controls.Add(this.LoginContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.LoginContainer.ResumeLayout(false);
            this.LoginContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Bunifu.UI.WinForms.BunifuPanel LoginContainer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel SignUpBtn;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton bunifuFormCaptionButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 LoginBtn;
        private Bunifu.UI.WinForms.BunifuTextBox passwordInput;
        private Bunifu.UI.WinForms.BunifuTextBox emailInput;
    }
}

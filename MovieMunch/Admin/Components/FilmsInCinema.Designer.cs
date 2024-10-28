﻿namespace MovieMunch.Admin.Components
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmsInCinemaForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.MoviesTable = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.SaveMoviesButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.directoryInput = new Bunifu.UI.WinForms.BunifuTextBox();
            this.descriptionInput = new Bunifu.UI.WinForms.BunifuTextBox();
            this.titleInput = new Bunifu.UI.WinForms.BunifuTextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviesTable
            // 
            this.MoviesTable.AllowCustomTheming = false;
            this.MoviesTable.AllowUserToAddRows = false;
            this.MoviesTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.MoviesTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.MoviesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MoviesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoviesTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MoviesTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MoviesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.MoviesTable.ColumnHeadersHeight = 40;
            this.MoviesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Title,
            this.Description,
            this.imagePath});
            this.MoviesTable.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.MoviesTable.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.MoviesTable.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MoviesTable.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.MoviesTable.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.MoviesTable.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.MoviesTable.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.MoviesTable.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.MoviesTable.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.MoviesTable.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MoviesTable.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.MoviesTable.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MoviesTable.CurrentTheme.Name = null;
            this.MoviesTable.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MoviesTable.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.MoviesTable.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MoviesTable.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.MoviesTable.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MoviesTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.MoviesTable.EnableHeadersVisualStyles = false;
            this.MoviesTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.MoviesTable.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.MoviesTable.HeaderBgColor = System.Drawing.Color.Empty;
            this.MoviesTable.HeaderForeColor = System.Drawing.Color.White;
            this.MoviesTable.Location = new System.Drawing.Point(357, 220);
            this.MoviesTable.Name = "MoviesTable";
            this.MoviesTable.RowHeadersVisible = false;
            this.MoviesTable.RowHeadersWidth = 51;
            this.MoviesTable.RowTemplate.Height = 40;
            this.MoviesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MoviesTable.Size = new System.Drawing.Size(963, 454);
            this.MoviesTable.TabIndex = 4;
            this.MoviesTable.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // SaveMoviesButton
            // 
            this.SaveMoviesButton.AllowAnimations = true;
            this.SaveMoviesButton.AllowMouseEffects = true;
            this.SaveMoviesButton.AllowToggling = false;
            this.SaveMoviesButton.AnimationSpeed = 200;
            this.SaveMoviesButton.AutoGenerateColors = false;
            this.SaveMoviesButton.AutoRoundBorders = false;
            this.SaveMoviesButton.AutoSizeLeftIcon = true;
            this.SaveMoviesButton.AutoSizeRightIcon = true;
            this.SaveMoviesButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveMoviesButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.SaveMoviesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveMoviesButton.BackgroundImage")));
            this.SaveMoviesButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveMoviesButton.ButtonText = "Add";
            this.SaveMoviesButton.ButtonTextMarginLeft = 0;
            this.SaveMoviesButton.ColorContrastOnClick = 45;
            this.SaveMoviesButton.ColorContrastOnHover = 45;
            this.SaveMoviesButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.SaveMoviesButton.CustomizableEdges = borderEdges2;
            this.SaveMoviesButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveMoviesButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveMoviesButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.SaveMoviesButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.SaveMoviesButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SaveMoviesButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveMoviesButton.ForeColor = System.Drawing.Color.White;
            this.SaveMoviesButton.IconLeft = null;
            this.SaveMoviesButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveMoviesButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SaveMoviesButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SaveMoviesButton.IconMarginLeft = 11;
            this.SaveMoviesButton.IconPadding = 10;
            this.SaveMoviesButton.IconRight = null;
            this.SaveMoviesButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveMoviesButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SaveMoviesButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SaveMoviesButton.IconSize = 25;
            this.SaveMoviesButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.SaveMoviesButton.IdleBorderRadius = 0;
            this.SaveMoviesButton.IdleBorderThickness = 0;
            this.SaveMoviesButton.IdleFillColor = System.Drawing.Color.Empty;
            this.SaveMoviesButton.IdleIconLeftImage = null;
            this.SaveMoviesButton.IdleIconRightImage = null;
            this.SaveMoviesButton.IndicateFocus = false;
            this.SaveMoviesButton.Location = new System.Drawing.Point(357, 173);
            this.SaveMoviesButton.Name = "SaveMoviesButton";
            this.SaveMoviesButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveMoviesButton.OnDisabledState.BorderRadius = 1;
            this.SaveMoviesButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveMoviesButton.OnDisabledState.BorderThickness = 1;
            this.SaveMoviesButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveMoviesButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveMoviesButton.OnDisabledState.IconLeftImage = null;
            this.SaveMoviesButton.OnDisabledState.IconRightImage = null;
            this.SaveMoviesButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.SaveMoviesButton.onHoverState.BorderRadius = 1;
            this.SaveMoviesButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveMoviesButton.onHoverState.BorderThickness = 1;
            this.SaveMoviesButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.SaveMoviesButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SaveMoviesButton.onHoverState.IconLeftImage = null;
            this.SaveMoviesButton.onHoverState.IconRightImage = null;
            this.SaveMoviesButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SaveMoviesButton.OnIdleState.BorderRadius = 1;
            this.SaveMoviesButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveMoviesButton.OnIdleState.BorderThickness = 1;
            this.SaveMoviesButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SaveMoviesButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SaveMoviesButton.OnIdleState.IconLeftImage = null;
            this.SaveMoviesButton.OnIdleState.IconRightImage = null;
            this.SaveMoviesButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveMoviesButton.OnPressedState.BorderRadius = 1;
            this.SaveMoviesButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveMoviesButton.OnPressedState.BorderThickness = 1;
            this.SaveMoviesButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveMoviesButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SaveMoviesButton.OnPressedState.IconLeftImage = null;
            this.SaveMoviesButton.OnPressedState.IconRightImage = null;
            this.SaveMoviesButton.Size = new System.Drawing.Size(117, 41);
            this.SaveMoviesButton.TabIndex = 3;
            this.SaveMoviesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveMoviesButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveMoviesButton.TextMarginLeft = 0;
            this.SaveMoviesButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SaveMoviesButton.UseDefaultRadiusAndThickness = true;
            this.SaveMoviesButton.Click += new System.EventHandler(this.AddMoviesButton_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(357, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(344, 62);
            this.bunifuLabel1.TabIndex = 11;
            this.bunifuLabel1.Text = "Films in Cinema";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // directoryInput
            // 
            this.directoryInput.AcceptsReturn = false;
            this.directoryInput.AcceptsTab = false;
            this.directoryInput.AnimationSpeed = 200;
            this.directoryInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.directoryInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.directoryInput.AutoSizeHeight = true;
            this.directoryInput.BackColor = System.Drawing.Color.Transparent;
            this.directoryInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("directoryInput.BackgroundImage")));
            this.directoryInput.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.directoryInput.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.directoryInput.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.directoryInput.BorderColorIdle = System.Drawing.Color.Silver;
            this.directoryInput.BorderRadius = 1;
            this.directoryInput.BorderThickness = 1;
            this.directoryInput.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.directoryInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.directoryInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.directoryInput.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.directoryInput.DefaultText = "";
            this.directoryInput.FillColor = System.Drawing.Color.White;
            this.directoryInput.HideSelection = true;
            this.directoryInput.IconLeft = null;
            this.directoryInput.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.directoryInput.IconPadding = 10;
            this.directoryInput.IconRight = null;
            this.directoryInput.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.directoryInput.Lines = new string[0];
            this.directoryInput.Location = new System.Drawing.Point(1044, 171);
            this.directoryInput.MaxLength = 32767;
            this.directoryInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.directoryInput.Modified = false;
            this.directoryInput.Multiline = false;
            this.directoryInput.Name = "directoryInput";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.directoryInput.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.directoryInput.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.directoryInput.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.directoryInput.OnIdleState = stateProperties16;
            this.directoryInput.Padding = new System.Windows.Forms.Padding(3);
            this.directoryInput.PasswordChar = '\0';
            this.directoryInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.directoryInput.PlaceholderText = "Directory";
            this.directoryInput.ReadOnly = false;
            this.directoryInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.directoryInput.SelectedText = "";
            this.directoryInput.SelectionLength = 0;
            this.directoryInput.SelectionStart = 0;
            this.directoryInput.ShortcutsEnabled = true;
            this.directoryInput.Size = new System.Drawing.Size(276, 43);
            this.directoryInput.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.directoryInput.TabIndex = 7;
            this.directoryInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.directoryInput.TextMarginBottom = 0;
            this.directoryInput.TextMarginLeft = 3;
            this.directoryInput.TextMarginTop = 1;
            this.directoryInput.TextPlaceholder = "Directory";
            this.directoryInput.UseSystemPasswordChar = false;
            this.directoryInput.WordWrap = true;
            // 
            // descriptionInput
            // 
            this.descriptionInput.AcceptsReturn = false;
            this.descriptionInput.AcceptsTab = false;
            this.descriptionInput.AnimationSpeed = 200;
            this.descriptionInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.descriptionInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.descriptionInput.AutoSizeHeight = true;
            this.descriptionInput.BackColor = System.Drawing.Color.Transparent;
            this.descriptionInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("descriptionInput.BackgroundImage")));
            this.descriptionInput.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.descriptionInput.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.descriptionInput.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.descriptionInput.BorderColorIdle = System.Drawing.Color.Silver;
            this.descriptionInput.BorderRadius = 1;
            this.descriptionInput.BorderThickness = 1;
            this.descriptionInput.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.descriptionInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.descriptionInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionInput.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.descriptionInput.DefaultText = "";
            this.descriptionInput.FillColor = System.Drawing.Color.White;
            this.descriptionInput.HideSelection = true;
            this.descriptionInput.IconLeft = null;
            this.descriptionInput.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionInput.IconPadding = 10;
            this.descriptionInput.IconRight = null;
            this.descriptionInput.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionInput.Lines = new string[0];
            this.descriptionInput.Location = new System.Drawing.Point(762, 171);
            this.descriptionInput.MaxLength = 32767;
            this.descriptionInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.descriptionInput.Modified = false;
            this.descriptionInput.Multiline = false;
            this.descriptionInput.Name = "descriptionInput";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.descriptionInput.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.descriptionInput.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.descriptionInput.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.descriptionInput.OnIdleState = stateProperties20;
            this.descriptionInput.Padding = new System.Windows.Forms.Padding(3);
            this.descriptionInput.PasswordChar = '\0';
            this.descriptionInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.descriptionInput.PlaceholderText = "Description";
            this.descriptionInput.ReadOnly = false;
            this.descriptionInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionInput.SelectedText = "";
            this.descriptionInput.SelectionLength = 0;
            this.descriptionInput.SelectionStart = 0;
            this.descriptionInput.ShortcutsEnabled = true;
            this.descriptionInput.Size = new System.Drawing.Size(276, 43);
            this.descriptionInput.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.descriptionInput.TabIndex = 6;
            this.descriptionInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.descriptionInput.TextMarginBottom = 0;
            this.descriptionInput.TextMarginLeft = 3;
            this.descriptionInput.TextMarginTop = 1;
            this.descriptionInput.TextPlaceholder = "Description";
            this.descriptionInput.UseSystemPasswordChar = false;
            this.descriptionInput.WordWrap = true;
            // 
            // titleInput
            // 
            this.titleInput.AcceptsReturn = false;
            this.titleInput.AcceptsTab = false;
            this.titleInput.AnimationSpeed = 200;
            this.titleInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.titleInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.titleInput.AutoSizeHeight = true;
            this.titleInput.BackColor = System.Drawing.Color.Transparent;
            this.titleInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleInput.BackgroundImage")));
            this.titleInput.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.titleInput.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.titleInput.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.titleInput.BorderColorIdle = System.Drawing.Color.Silver;
            this.titleInput.BorderRadius = 1;
            this.titleInput.BorderThickness = 1;
            this.titleInput.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.titleInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.titleInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleInput.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.titleInput.DefaultText = "";
            this.titleInput.FillColor = System.Drawing.Color.White;
            this.titleInput.HideSelection = true;
            this.titleInput.IconLeft = null;
            this.titleInput.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.titleInput.IconPadding = 10;
            this.titleInput.IconRight = null;
            this.titleInput.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.titleInput.Lines = new string[0];
            this.titleInput.Location = new System.Drawing.Point(480, 171);
            this.titleInput.MaxLength = 32767;
            this.titleInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.titleInput.Modified = false;
            this.titleInput.Multiline = false;
            this.titleInput.Name = "titleInput";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.titleInput.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.titleInput.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.titleInput.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.titleInput.OnIdleState = stateProperties24;
            this.titleInput.Padding = new System.Windows.Forms.Padding(3);
            this.titleInput.PasswordChar = '\0';
            this.titleInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.titleInput.PlaceholderText = "Title";
            this.titleInput.ReadOnly = false;
            this.titleInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.titleInput.SelectedText = "";
            this.titleInput.SelectionLength = 0;
            this.titleInput.SelectionStart = 0;
            this.titleInput.ShortcutsEnabled = true;
            this.titleInput.Size = new System.Drawing.Size(276, 43);
            this.titleInput.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.titleInput.TabIndex = 5;
            this.titleInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.titleInput.TextMarginBottom = 0;
            this.titleInput.TextMarginLeft = 3;
            this.titleInput.TextMarginTop = 1;
            this.titleInput.TextPlaceholder = "Title";
            this.titleInput.UseSystemPasswordChar = false;
            this.titleInput.WordWrap = true;
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
            // imagePath
            // 
            this.imagePath.HeaderText = "Image Path";
            this.imagePath.MinimumWidth = 6;
            this.imagePath.Name = "imagePath";
            // 
            // FilmsInCinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 686);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.directoryInput);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.MoviesTable);
            this.Controls.Add(this.SaveMoviesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilmsInCinemaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmsInCinema";
            ((System.ComponentModel.ISupportInitialize)(this.MoviesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SaveMoviesButton;
        private Bunifu.UI.WinForms.BunifuDataGridView MoviesTable;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox directoryInput;
        private Bunifu.UI.WinForms.BunifuTextBox descriptionInput;
        private Bunifu.UI.WinForms.BunifuTextBox titleInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagePath;
    }
}
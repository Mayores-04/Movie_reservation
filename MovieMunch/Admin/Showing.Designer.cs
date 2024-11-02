﻿namespace MovieMunch.Admin
{
    partial class Showing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Showing));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            this.MoviesToShowTable = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.movieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddMoviesToShowButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.movieDirectoryInput = new Bunifu.UI.WinForms.BunifuTextBox();
            this.movieDescriptionInput = new Bunifu.UI.WinForms.BunifuTextBox();
            this.movieTitleInput = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SaveMoviesButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.viewShowingImagePanel = new System.Windows.Forms.Panel();
            this.closeShowingImageBtn = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.viewShowingImageBox = new System.Windows.Forms.PictureBox();
            this.backBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesToShowTable)).BeginInit();
            this.viewShowingImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewShowingImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviesToShowTable
            // 
            this.MoviesToShowTable.AllowCustomTheming = false;
            this.MoviesToShowTable.AllowUserToAddRows = false;
            this.MoviesToShowTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.MoviesToShowTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.MoviesToShowTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MoviesToShowTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoviesToShowTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MoviesToShowTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MoviesToShowTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.MoviesToShowTable.ColumnHeadersHeight = 40;
            this.MoviesToShowTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieId,
            this.moviesTitle,
            this.moviesDescription,
            this.moviesImagePath});
            this.MoviesToShowTable.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.MoviesToShowTable.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.MoviesToShowTable.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MoviesToShowTable.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.MoviesToShowTable.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.MoviesToShowTable.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.MoviesToShowTable.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.MoviesToShowTable.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.MoviesToShowTable.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.MoviesToShowTable.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MoviesToShowTable.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.MoviesToShowTable.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MoviesToShowTable.CurrentTheme.Name = null;
            this.MoviesToShowTable.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MoviesToShowTable.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.MoviesToShowTable.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MoviesToShowTable.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.MoviesToShowTable.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MoviesToShowTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.MoviesToShowTable.EnableHeadersVisualStyles = false;
            this.MoviesToShowTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.MoviesToShowTable.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.MoviesToShowTable.HeaderBgColor = System.Drawing.Color.Empty;
            this.MoviesToShowTable.HeaderForeColor = System.Drawing.Color.White;
            this.MoviesToShowTable.Location = new System.Drawing.Point(131, 146);
            this.MoviesToShowTable.Name = "MoviesToShowTable";
            this.MoviesToShowTable.RowHeadersVisible = false;
            this.MoviesToShowTable.RowHeadersWidth = 51;
            this.MoviesToShowTable.RowTemplate.Height = 40;
            this.MoviesToShowTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MoviesToShowTable.Size = new System.Drawing.Size(963, 454);
            this.MoviesToShowTable.TabIndex = 5;
            this.MoviesToShowTable.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // movieId
            // 
            this.movieId.HeaderText = "ID";
            this.movieId.MinimumWidth = 6;
            this.movieId.Name = "movieId";
            // 
            // moviesTitle
            // 
            this.moviesTitle.HeaderText = "Title";
            this.moviesTitle.MinimumWidth = 6;
            this.moviesTitle.Name = "moviesTitle";
            // 
            // moviesDescription
            // 
            this.moviesDescription.HeaderText = "Description";
            this.moviesDescription.MinimumWidth = 6;
            this.moviesDescription.Name = "moviesDescription";
            // 
            // moviesImagePath
            // 
            this.moviesImagePath.HeaderText = "Image Path";
            this.moviesImagePath.MinimumWidth = 6;
            this.moviesImagePath.Name = "moviesImagePath";
            // 
            // AddMoviesToShowButton
            // 
            this.AddMoviesToShowButton.AllowAnimations = true;
            this.AddMoviesToShowButton.AllowMouseEffects = true;
            this.AddMoviesToShowButton.AllowToggling = false;
            this.AddMoviesToShowButton.AnimationSpeed = 200;
            this.AddMoviesToShowButton.AutoGenerateColors = false;
            this.AddMoviesToShowButton.AutoRoundBorders = false;
            this.AddMoviesToShowButton.AutoSizeLeftIcon = true;
            this.AddMoviesToShowButton.AutoSizeRightIcon = true;
            this.AddMoviesToShowButton.BackColor = System.Drawing.Color.Transparent;
            this.AddMoviesToShowButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.AddMoviesToShowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddMoviesToShowButton.BackgroundImage")));
            this.AddMoviesToShowButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMoviesToShowButton.ButtonText = "Add";
            this.AddMoviesToShowButton.ButtonTextMarginLeft = 0;
            this.AddMoviesToShowButton.ColorContrastOnClick = 45;
            this.AddMoviesToShowButton.ColorContrastOnHover = 45;
            this.AddMoviesToShowButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.AddMoviesToShowButton.CustomizableEdges = borderEdges4;
            this.AddMoviesToShowButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddMoviesToShowButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddMoviesToShowButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.AddMoviesToShowButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.AddMoviesToShowButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AddMoviesToShowButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddMoviesToShowButton.ForeColor = System.Drawing.Color.White;
            this.AddMoviesToShowButton.IconLeft = null;
            this.AddMoviesToShowButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMoviesToShowButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddMoviesToShowButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AddMoviesToShowButton.IconMarginLeft = 11;
            this.AddMoviesToShowButton.IconPadding = 10;
            this.AddMoviesToShowButton.IconRight = null;
            this.AddMoviesToShowButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddMoviesToShowButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddMoviesToShowButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AddMoviesToShowButton.IconSize = 25;
            this.AddMoviesToShowButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.AddMoviesToShowButton.IdleBorderRadius = 0;
            this.AddMoviesToShowButton.IdleBorderThickness = 0;
            this.AddMoviesToShowButton.IdleFillColor = System.Drawing.Color.Empty;
            this.AddMoviesToShowButton.IdleIconLeftImage = null;
            this.AddMoviesToShowButton.IdleIconRightImage = null;
            this.AddMoviesToShowButton.IndicateFocus = false;
            this.AddMoviesToShowButton.Location = new System.Drawing.Point(130, 99);
            this.AddMoviesToShowButton.Name = "AddMoviesToShowButton";
            this.AddMoviesToShowButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddMoviesToShowButton.OnDisabledState.BorderRadius = 1;
            this.AddMoviesToShowButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMoviesToShowButton.OnDisabledState.BorderThickness = 1;
            this.AddMoviesToShowButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddMoviesToShowButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddMoviesToShowButton.OnDisabledState.IconLeftImage = null;
            this.AddMoviesToShowButton.OnDisabledState.IconRightImage = null;
            this.AddMoviesToShowButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.AddMoviesToShowButton.onHoverState.BorderRadius = 1;
            this.AddMoviesToShowButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMoviesToShowButton.onHoverState.BorderThickness = 1;
            this.AddMoviesToShowButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.AddMoviesToShowButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AddMoviesToShowButton.onHoverState.IconLeftImage = null;
            this.AddMoviesToShowButton.onHoverState.IconRightImage = null;
            this.AddMoviesToShowButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.AddMoviesToShowButton.OnIdleState.BorderRadius = 1;
            this.AddMoviesToShowButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMoviesToShowButton.OnIdleState.BorderThickness = 1;
            this.AddMoviesToShowButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.AddMoviesToShowButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AddMoviesToShowButton.OnIdleState.IconLeftImage = null;
            this.AddMoviesToShowButton.OnIdleState.IconRightImage = null;
            this.AddMoviesToShowButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddMoviesToShowButton.OnPressedState.BorderRadius = 1;
            this.AddMoviesToShowButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMoviesToShowButton.OnPressedState.BorderThickness = 1;
            this.AddMoviesToShowButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddMoviesToShowButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddMoviesToShowButton.OnPressedState.IconLeftImage = null;
            this.AddMoviesToShowButton.OnPressedState.IconRightImage = null;
            this.AddMoviesToShowButton.Size = new System.Drawing.Size(117, 41);
            this.AddMoviesToShowButton.TabIndex = 20;
            this.AddMoviesToShowButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddMoviesToShowButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddMoviesToShowButton.TextMarginLeft = 0;
            this.AddMoviesToShowButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.AddMoviesToShowButton.UseDefaultRadiusAndThickness = true;
            this.AddMoviesToShowButton.Click += new System.EventHandler(this.AddMoviesToShowButton_Click);
            // 
            // movieDirectoryInput
            // 
            this.movieDirectoryInput.AcceptsReturn = false;
            this.movieDirectoryInput.AcceptsTab = false;
            this.movieDirectoryInput.AnimationSpeed = 200;
            this.movieDirectoryInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.movieDirectoryInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.movieDirectoryInput.AutoSizeHeight = true;
            this.movieDirectoryInput.BackColor = System.Drawing.Color.Transparent;
            this.movieDirectoryInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movieDirectoryInput.BackgroundImage")));
            this.movieDirectoryInput.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.movieDirectoryInput.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.movieDirectoryInput.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.movieDirectoryInput.BorderColorIdle = System.Drawing.Color.Silver;
            this.movieDirectoryInput.BorderRadius = 1;
            this.movieDirectoryInput.BorderThickness = 1;
            this.movieDirectoryInput.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.movieDirectoryInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.movieDirectoryInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.movieDirectoryInput.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.movieDirectoryInput.DefaultText = "";
            this.movieDirectoryInput.FillColor = System.Drawing.Color.White;
            this.movieDirectoryInput.HideSelection = true;
            this.movieDirectoryInput.IconLeft = null;
            this.movieDirectoryInput.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.movieDirectoryInput.IconPadding = 10;
            this.movieDirectoryInput.IconRight = null;
            this.movieDirectoryInput.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.movieDirectoryInput.Lines = new string[0];
            this.movieDirectoryInput.Location = new System.Drawing.Point(817, 97);
            this.movieDirectoryInput.MaxLength = 32767;
            this.movieDirectoryInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.movieDirectoryInput.Modified = false;
            this.movieDirectoryInput.Multiline = false;
            this.movieDirectoryInput.Name = "movieDirectoryInput";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.movieDirectoryInput.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.movieDirectoryInput.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.movieDirectoryInput.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.movieDirectoryInput.OnIdleState = stateProperties16;
            this.movieDirectoryInput.Padding = new System.Windows.Forms.Padding(3);
            this.movieDirectoryInput.PasswordChar = '\0';
            this.movieDirectoryInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.movieDirectoryInput.PlaceholderText = "Directory";
            this.movieDirectoryInput.ReadOnly = false;
            this.movieDirectoryInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.movieDirectoryInput.SelectedText = "";
            this.movieDirectoryInput.SelectionLength = 0;
            this.movieDirectoryInput.SelectionStart = 0;
            this.movieDirectoryInput.ShortcutsEnabled = true;
            this.movieDirectoryInput.Size = new System.Drawing.Size(276, 43);
            this.movieDirectoryInput.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.movieDirectoryInput.TabIndex = 19;
            this.movieDirectoryInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.movieDirectoryInput.TextMarginBottom = 0;
            this.movieDirectoryInput.TextMarginLeft = 3;
            this.movieDirectoryInput.TextMarginTop = 1;
            this.movieDirectoryInput.TextPlaceholder = "Directory";
            this.movieDirectoryInput.UseSystemPasswordChar = false;
            this.movieDirectoryInput.WordWrap = true;
            // 
            // movieDescriptionInput
            // 
            this.movieDescriptionInput.AcceptsReturn = false;
            this.movieDescriptionInput.AcceptsTab = false;
            this.movieDescriptionInput.AnimationSpeed = 200;
            this.movieDescriptionInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.movieDescriptionInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.movieDescriptionInput.AutoSizeHeight = true;
            this.movieDescriptionInput.BackColor = System.Drawing.Color.Transparent;
            this.movieDescriptionInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movieDescriptionInput.BackgroundImage")));
            this.movieDescriptionInput.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.movieDescriptionInput.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.movieDescriptionInput.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.movieDescriptionInput.BorderColorIdle = System.Drawing.Color.Silver;
            this.movieDescriptionInput.BorderRadius = 1;
            this.movieDescriptionInput.BorderThickness = 1;
            this.movieDescriptionInput.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.movieDescriptionInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.movieDescriptionInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.movieDescriptionInput.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.movieDescriptionInput.DefaultText = "";
            this.movieDescriptionInput.FillColor = System.Drawing.Color.White;
            this.movieDescriptionInput.HideSelection = true;
            this.movieDescriptionInput.IconLeft = null;
            this.movieDescriptionInput.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.movieDescriptionInput.IconPadding = 10;
            this.movieDescriptionInput.IconRight = null;
            this.movieDescriptionInput.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.movieDescriptionInput.Lines = new string[0];
            this.movieDescriptionInput.Location = new System.Drawing.Point(535, 97);
            this.movieDescriptionInput.MaxLength = 32767;
            this.movieDescriptionInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.movieDescriptionInput.Modified = false;
            this.movieDescriptionInput.Multiline = false;
            this.movieDescriptionInput.Name = "movieDescriptionInput";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.movieDescriptionInput.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.movieDescriptionInput.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.movieDescriptionInput.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.movieDescriptionInput.OnIdleState = stateProperties20;
            this.movieDescriptionInput.Padding = new System.Windows.Forms.Padding(3);
            this.movieDescriptionInput.PasswordChar = '\0';
            this.movieDescriptionInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.movieDescriptionInput.PlaceholderText = "Description";
            this.movieDescriptionInput.ReadOnly = false;
            this.movieDescriptionInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.movieDescriptionInput.SelectedText = "";
            this.movieDescriptionInput.SelectionLength = 0;
            this.movieDescriptionInput.SelectionStart = 0;
            this.movieDescriptionInput.ShortcutsEnabled = true;
            this.movieDescriptionInput.Size = new System.Drawing.Size(276, 43);
            this.movieDescriptionInput.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.movieDescriptionInput.TabIndex = 18;
            this.movieDescriptionInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.movieDescriptionInput.TextMarginBottom = 0;
            this.movieDescriptionInput.TextMarginLeft = 3;
            this.movieDescriptionInput.TextMarginTop = 1;
            this.movieDescriptionInput.TextPlaceholder = "Description";
            this.movieDescriptionInput.UseSystemPasswordChar = false;
            this.movieDescriptionInput.WordWrap = true;
            // 
            // movieTitleInput
            // 
            this.movieTitleInput.AcceptsReturn = false;
            this.movieTitleInput.AcceptsTab = false;
            this.movieTitleInput.AnimationSpeed = 200;
            this.movieTitleInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.movieTitleInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.movieTitleInput.AutoSizeHeight = true;
            this.movieTitleInput.BackColor = System.Drawing.Color.Transparent;
            this.movieTitleInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movieTitleInput.BackgroundImage")));
            this.movieTitleInput.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.movieTitleInput.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.movieTitleInput.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.movieTitleInput.BorderColorIdle = System.Drawing.Color.Silver;
            this.movieTitleInput.BorderRadius = 1;
            this.movieTitleInput.BorderThickness = 1;
            this.movieTitleInput.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.movieTitleInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.movieTitleInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.movieTitleInput.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.movieTitleInput.DefaultText = "";
            this.movieTitleInput.FillColor = System.Drawing.Color.White;
            this.movieTitleInput.HideSelection = true;
            this.movieTitleInput.IconLeft = null;
            this.movieTitleInput.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.movieTitleInput.IconPadding = 10;
            this.movieTitleInput.IconRight = null;
            this.movieTitleInput.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.movieTitleInput.Lines = new string[0];
            this.movieTitleInput.Location = new System.Drawing.Point(253, 97);
            this.movieTitleInput.MaxLength = 32767;
            this.movieTitleInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.movieTitleInput.Modified = false;
            this.movieTitleInput.Multiline = false;
            this.movieTitleInput.Name = "movieTitleInput";
            stateProperties21.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.movieTitleInput.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.movieTitleInput.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.movieTitleInput.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.Silver;
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.Empty;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.movieTitleInput.OnIdleState = stateProperties24;
            this.movieTitleInput.Padding = new System.Windows.Forms.Padding(3);
            this.movieTitleInput.PasswordChar = '\0';
            this.movieTitleInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.movieTitleInput.PlaceholderText = "Title";
            this.movieTitleInput.ReadOnly = false;
            this.movieTitleInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.movieTitleInput.SelectedText = "";
            this.movieTitleInput.SelectionLength = 0;
            this.movieTitleInput.SelectionStart = 0;
            this.movieTitleInput.ShortcutsEnabled = true;
            this.movieTitleInput.Size = new System.Drawing.Size(276, 43);
            this.movieTitleInput.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.movieTitleInput.TabIndex = 17;
            this.movieTitleInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.movieTitleInput.TextMarginBottom = 0;
            this.movieTitleInput.TextMarginLeft = 3;
            this.movieTitleInput.TextMarginTop = 1;
            this.movieTitleInput.TextPlaceholder = "Title";
            this.movieTitleInput.UseSystemPasswordChar = false;
            this.movieTitleInput.WordWrap = true;
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
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.SaveMoviesButton.CustomizableEdges = borderEdges5;
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
            this.SaveMoviesButton.Location = new System.Drawing.Point(130, 99);
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
            this.SaveMoviesButton.TabIndex = 16;
            this.SaveMoviesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveMoviesButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveMoviesButton.TextMarginLeft = 0;
            this.SaveMoviesButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SaveMoviesButton.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(131, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(190, 62);
            this.bunifuLabel1.TabIndex = 21;
            this.bunifuLabel1.Text = "Showing";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // viewShowingImagePanel
            // 
            this.viewShowingImagePanel.Controls.Add(this.closeShowingImageBtn);
            this.viewShowingImagePanel.Controls.Add(this.viewShowingImageBox);
            this.viewShowingImagePanel.Location = new System.Drawing.Point(-3, 0);
            this.viewShowingImagePanel.Name = "viewShowingImagePanel";
            this.viewShowingImagePanel.Size = new System.Drawing.Size(1214, 658);
            this.viewShowingImagePanel.TabIndex = 33;
            this.viewShowingImagePanel.Visible = false;
            // 
            // closeShowingImageBtn
            // 
            this.closeShowingImageBtn.AllowAnimations = true;
            this.closeShowingImageBtn.AllowBorderColorChanges = true;
            this.closeShowingImageBtn.AllowDefaults = true;
            this.closeShowingImageBtn.AllowMouseEffects = true;
            this.closeShowingImageBtn.AnimationSpeed = 200;
            this.closeShowingImageBtn.AutoSizeCaptions = true;
            this.closeShowingImageBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeShowingImageBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.closeShowingImageBtn.BackHoverColor = System.Drawing.Color.LightGray;
            this.closeShowingImageBtn.BackPressedColor = System.Drawing.Color.Silver;
            this.closeShowingImageBtn.BorderColor = System.Drawing.Color.LightGray;
            this.closeShowingImageBtn.BorderHoverColor = System.Drawing.Color.DarkGray;
            this.closeShowingImageBtn.BorderPressedColor = System.Drawing.Color.DarkGray;
            this.closeShowingImageBtn.BorderRadius = 15;
            this.closeShowingImageBtn.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.closeShowingImageBtn.BorderThickness = 1;
            this.closeShowingImageBtn.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Close;
            this.closeShowingImageBtn.ColorContrastOnClick = 30;
            this.closeShowingImageBtn.ColorContrastOnHover = 30;
            this.closeShowingImageBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.closeShowingImageBtn.CustomizableEdges = borderEdges6;
            this.closeShowingImageBtn.DefaultBorderColor = System.Drawing.Color.Silver;
            this.closeShowingImageBtn.DefaultColor = System.Drawing.Color.Gainsboro;
            this.closeShowingImageBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeShowingImageBtn.IconColor = System.Drawing.Color.Black;
            this.closeShowingImageBtn.IconHoverColor = System.Drawing.Color.Black;
            this.closeShowingImageBtn.IconPressedColor = System.Drawing.Color.Black;
            this.closeShowingImageBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeShowingImageBtn.Image")));
            this.closeShowingImageBtn.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.closeShowingImageBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.closeShowingImageBtn.Location = new System.Drawing.Point(982, 115);
            this.closeShowingImageBtn.Name = "closeShowingImageBtn";
            this.closeShowingImageBtn.ShowBorders = true;
            this.closeShowingImageBtn.Size = new System.Drawing.Size(38, 33);
            this.closeShowingImageBtn.TabIndex = 4;
            this.closeShowingImageBtn.Click += new System.EventHandler(this.closeShowingImageBtn_Click);
            // 
            // viewShowingImageBox
            // 
            this.viewShowingImageBox.Location = new System.Drawing.Point(356, 167);
            this.viewShowingImageBox.Name = "viewShowingImageBox";
            this.viewShowingImageBox.Size = new System.Drawing.Size(598, 399);
            this.viewShowingImageBox.TabIndex = 0;
            this.viewShowingImageBox.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.backBtn.IconColor = System.Drawing.Color.Black;
            this.backBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backBtn.Location = new System.Drawing.Point(1113, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 51);
            this.backBtn.TabIndex = 34;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Showing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.viewShowingImagePanel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.AddMoviesToShowButton);
            this.Controls.Add(this.movieDirectoryInput);
            this.Controls.Add(this.movieDescriptionInput);
            this.Controls.Add(this.movieTitleInput);
            this.Controls.Add(this.SaveMoviesButton);
            this.Controls.Add(this.MoviesToShowTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Showing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f";
            ((System.ComponentModel.ISupportInitialize)(this.MoviesToShowTable)).EndInit();
            this.viewShowingImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewShowingImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView MoviesToShowTable;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddMoviesToShowButton;
        private Bunifu.UI.WinForms.BunifuTextBox movieDirectoryInput;
        private Bunifu.UI.WinForms.BunifuTextBox movieDescriptionInput;
        private Bunifu.UI.WinForms.BunifuTextBox movieTitleInput;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SaveMoviesButton;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn moviesTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn moviesDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn moviesImagePath;
        private System.Windows.Forms.Panel viewShowingImagePanel;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton closeShowingImageBtn;
        private System.Windows.Forms.PictureBox viewShowingImageBox;
        private FontAwesome.Sharp.IconButton backBtn;
    }
}
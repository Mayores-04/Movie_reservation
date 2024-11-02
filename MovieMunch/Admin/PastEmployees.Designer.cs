namespace MovieMunch.Admin
{
    partial class PastEmployees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmployeeListTable = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pastEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pastEmployeeProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeListTable
            // 
            this.EmployeeListTable.AllowCustomTheming = false;
            this.EmployeeListTable.AllowUserToAddRows = false;
            this.EmployeeListTable.AllowUserToOrderColumns = true;
            this.EmployeeListTable.AllowUserToResizeColumns = false;
            this.EmployeeListTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.EmployeeListTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeListTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeListTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EmployeeListTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeListTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EmployeeListTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeListTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeListTable.ColumnHeadersHeight = 40;
            this.EmployeeListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeId,
            this.pastEmployeeName,
            this.pastEmployeeProfile});
            this.EmployeeListTable.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.EmployeeListTable.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.EmployeeListTable.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.EmployeeListTable.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.EmployeeListTable.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmployeeListTable.CurrentTheme.BackColor = System.Drawing.Color.DodgerBlue;
            this.EmployeeListTable.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.EmployeeListTable.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.EmployeeListTable.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.EmployeeListTable.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeListTable.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.EmployeeListTable.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmployeeListTable.CurrentTheme.Name = null;
            this.EmployeeListTable.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.EmployeeListTable.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.EmployeeListTable.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.EmployeeListTable.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.EmployeeListTable.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeListTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeListTable.EnableHeadersVisualStyles = false;
            this.EmployeeListTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.EmployeeListTable.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.EmployeeListTable.HeaderBgColor = System.Drawing.Color.Empty;
            this.EmployeeListTable.HeaderForeColor = System.Drawing.Color.White;
            this.EmployeeListTable.Location = new System.Drawing.Point(344, 175);
            this.EmployeeListTable.Name = "EmployeeListTable";
            this.EmployeeListTable.RowHeadersVisible = false;
            this.EmployeeListTable.RowHeadersWidth = 48;
            this.EmployeeListTable.RowTemplate.Height = 40;
            this.EmployeeListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeListTable.Size = new System.Drawing.Size(728, 422);
            this.EmployeeListTable.TabIndex = 26;
            this.EmployeeListTable.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DodgerBlue;
            // 
            // employeeId
            // 
            this.employeeId.HeaderText = "ID";
            this.employeeId.MaxInputLength = 247;
            this.employeeId.MinimumWidth = 6;
            this.employeeId.Name = "employeeId";
            // 
            // pastEmployeeName
            // 
            this.pastEmployeeName.HeaderText = "Name";
            this.pastEmployeeName.MaxInputLength = 247;
            this.pastEmployeeName.MinimumWidth = 6;
            this.pastEmployeeName.Name = "pastEmployeeName";
            // 
            // pastEmployeeProfile
            // 
            this.pastEmployeeProfile.HeaderText = "Profile";
            this.pastEmployeeProfile.MaxInputLength = 247;
            this.pastEmployeeProfile.MinimumWidth = 6;
            this.pastEmployeeProfile.Name = "pastEmployeeProfile";
            // 
            // PastEmployees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.EmployeeListTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PastEmployees";
            this.Text = "PastEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeListTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView EmployeeListTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn pastEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pastEmployeeProfile;
    }
}
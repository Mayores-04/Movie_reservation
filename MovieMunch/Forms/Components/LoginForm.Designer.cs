namespace MovieMunch
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MaskedTextBox email_input;
        private System.Windows.Forms.MaskedTextBox password_input;
        private System.Windows.Forms.Button LoginBtn;

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
            this.email_input = new System.Windows.Forms.MaskedTextBox();
            this.password_input = new System.Windows.Forms.MaskedTextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(97, 110);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(254, 22);
            this.email_input.TabIndex = 0;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(97, 157);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(254, 22);
            this.password_input.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(187, 214);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(448, 364);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.email_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}

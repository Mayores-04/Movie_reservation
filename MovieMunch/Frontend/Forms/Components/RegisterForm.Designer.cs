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
            this.email_input = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(151, 86);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(200, 22);
            this.email_input.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(51, 136);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 16);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(151, 136);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(200, 22);
            this.password_input.TabIndex = 3;
            this.password_input.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(207, 185);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(51, 86);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 16);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email:";
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(364, 9);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(24, 29);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "x";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.registerButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox email_input;
        private Label passwordLabel;
        private TextBox password_input;
        private Button registerButton;
        private Label emailLabel;
        private Label CloseBtn;
    }
}

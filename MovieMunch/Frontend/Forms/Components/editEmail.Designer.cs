namespace MovieMunch.Forms.Components
{
    partial class editEmail
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
            this.prevEmail_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prevPassword_input = new System.Windows.Forms.TextBox();
            this.save_new_account = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassword_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // prevEmail_input
            // 
            this.prevEmail_input.Location = new System.Drawing.Point(149, 57);
            this.prevEmail_input.Name = "prevEmail_input";
            this.prevEmail_input.Size = new System.Drawing.Size(307, 22);
            this.prevEmail_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // prevPassword_input
            // 
            this.prevPassword_input.Location = new System.Drawing.Point(149, 129);
            this.prevPassword_input.Name = "prevPassword_input";
            this.prevPassword_input.Size = new System.Drawing.Size(307, 22);
            this.prevPassword_input.TabIndex = 2;
            // 
            // save_new_account
            // 
            this.save_new_account.Location = new System.Drawing.Point(252, 232);
            this.save_new_account.Name = "save_new_account";
            this.save_new_account.Size = new System.Drawing.Size(60, 37);
            this.save_new_account.TabIndex = 4;
            this.save_new_account.Text = "Save";
            this.save_new_account.UseVisualStyleBackColor = true;
            this.save_new_account.Click += new System.EventHandler(this.save_new_account_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "new password";
            // 
            // newPassword_input
            // 
            this.newPassword_input.Location = new System.Drawing.Point(149, 178);
            this.newPassword_input.Name = "newPassword_input";
            this.newPassword_input.Size = new System.Drawing.Size(307, 22);
            this.newPassword_input.TabIndex = 5;
            // 
            // editEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 303);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPassword_input);
            this.Controls.Add(this.save_new_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prevPassword_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prevEmail_input);
            this.Name = "editEmail";
            this.Text = "editEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prevEmail_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prevPassword_input;
        private System.Windows.Forms.Button save_new_account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPassword_input;
    }
}
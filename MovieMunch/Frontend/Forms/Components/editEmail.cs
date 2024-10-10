
using System;
using System.Windows.Forms;

namespace MovieMunch.Forms.Components
{
    public partial class editEmail : Form
    {
        public editEmail()
        {
            InitializeComponent();
        }

        private void save_new_account_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            // Get the email and new password input values
            string email = prevEmail_input.Text.Trim();
            string password = prevPassword_input.Text.Trim();

            //Get also the new password input values 
            string newPassword = newPassword_input.Text.Trim();

            // Ensure the email and password fields are not empty before proceeding.
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Email and password cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Attempt to update the existing account with the new password.
            bool prevAccount = userService.new_edited_account(email, newPassword);

            // If the account was successfully updated, display a success message.
            if (prevAccount)
            {
                MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the input fields after a successful update.
                prevEmail_input.Clear();
                prevPassword_input.Clear();
            }
            else
            {
                // If there was an issue updating the account, show an error message.
                MessageBox.Show("Failed to update the account. Please check the email and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

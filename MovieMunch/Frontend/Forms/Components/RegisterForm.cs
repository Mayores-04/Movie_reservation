using System;
using System.Windows.Forms;

namespace MovieMunch
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void LoginBtnLinked_Click(object sender, EventArgs e)
        {
            
            LoginForm logForm = new LoginForm();
            logForm.Show();
            this.Close();
        }

        private void regFormClose_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            string name = regNameInput.Text.Trim();
            string email = regEmailInput.Text.Trim();
            string password = regPasswordInput.Text;
            string confirmPassword = regConfirmPasswordInput.Text;

            if (!termsAndRegistrationCheckBox.Checked)
            {
                termsAndRegMessage.Visible = true;
                termsAndRegMessage.Text = "You must accept the terms and conditions.";
                return; 
            }

            termsAndRegMessage.Visible = false;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                termsAndRegMessage.Visible = true;
                termsAndRegMessage.Text = "Email, password, and confirm password are required!";
                return;  
            }

            if (password != confirmPassword)
            {
                termsAndRegMessage.Visible = true;
                termsAndRegMessage.Text = "Passwords do not match.";
                return;  
            }

            bool isRegistered = userService.RegisterUser(name, email, password, confirmPassword);

            if (isRegistered)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

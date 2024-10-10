using MovieMunch.Admin;
using System;
using System.Windows.Forms;

namespace MovieMunch
{
    public partial class LoginForm : Form
    {
        private MainPage mainPage;
        private MainAdminForm mainAdminForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            string email = email_input.Text;
            string password = password_input.Text;

            // First, check if it's an admin login
            bool isAdminLogin = userService.AdminLogin(email, password);

            if (isAdminLogin)
            {
                // Show dialog to choose between Admin and User interface
                DialogResult result = MessageBox.Show(
                    "Login successful as Admin. Do you want to open the Admin interface?",
                    "Admin Login",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Open Admin interface and ensure MainPage is closed
                    OpenAdminInterface();
                }
                else
                {
                    // Open regular user interface
                    OpenUserInterface();
                }
            }
            else
            {
                // Check for regular user login
                bool isLogin = userService.LoginUser(email, password);

                if (isLogin)
                {
                    OpenUserInterface();
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    MessageBox.Show("Login failed. Please check your credentials.");
                }
            }
        }

        private void OpenAdminInterface()
        {
            // Check if MainPage is open and close it if necessary
            if (mainPage != null && !mainPage.IsDisposed)
            {
                mainPage.Close(); // Close MainPage if open
                mainPage.Dispose();
                mainPage = null;
            }

            // Hide the login form and open the admin interface
            this.Hide();
            mainAdminForm = new MainAdminForm();
            mainAdminForm.Show();
        }

        private void OpenUserInterface()
        {
            // Close and dispose of the MainAdminForm if it's open
            if (mainAdminForm != null && !mainAdminForm.IsDisposed)
            {
                mainAdminForm.Close();
                mainAdminForm.Dispose();
                mainAdminForm = null;
            }

            // Close and dispose of the current MainPage instance if it's open
            if (mainPage != null && !mainPage.IsDisposed)
            {
                mainPage.Close();
                mainPage.Dispose();
                mainPage = null;
            }

            // Hide the login form and open a new instance of MainPage
            this.Hide();
            mainPage = new MainPage();
            mainPage.Show();
        }
        private void CloseButton(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

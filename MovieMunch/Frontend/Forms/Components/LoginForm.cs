using MovieMunch.Admin;
using System;
using System.Windows.Forms;
using System.Windows.Media;

namespace MovieMunch
{
    public partial class LoginForm : Form
    {
        private MainPage mainPage;
        private MainAdmin mainAdminForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            string email = emailInput.Text;
            string password = passwordInput.Text;

            bool isAdminLogin = userService.AdminLogin(email, password);

            if (isAdminLogin)
            {
                DialogResult result = MessageBox.Show(
                    "Login successful as Admin. Do you want to open the Admin interface?",
                    "Admin Login",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    this.Close();
                    MainPage mainPage = new MainPage();
                    mainPage.Visible = false;
                    
                    MainAdmin mainAdmin = new MainAdmin();
                    mainAdmin.Show();
                    
                }
            }
            else
            {
                bool isLogin = userService.LoginUser(email, password);

                if (isLogin)
                {
                    this.Close();
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    MessageBox.Show("Login failed. Please check your credentials.");
                }
            }
        }


        //private void OpenAdminInterface()
        //{
        //    // Ensure MainPage is closed if it is open
        //    if (mainPage != null && !mainPage.IsDisposed)
        //    {
        //        mainPage.Close();
        //        mainPage.Dispose();
        //        mainPage = null;
        //    }

        //    // Close the login form and open the admin interface
        //    this.Close();
        //    if (mainAdminForm == null || mainAdminForm.IsDisposed)
        //    {
        //        mainAdminForm = new MainAddmin();
        //    }
        //    mainAdminForm.Show();
        //}

        //private void OpenUserInterface()
        //{
        //    // Ensure MainAdminForm is closed if it is open
        //    if (mainAdminForm != null && !mainAdminForm.IsDisposed)
        //    {
        //        mainAdminForm.Close();
        //        mainAdminForm.Dispose();
        //        mainAdminForm = null;
        //    }

        //    // Close the login form and open the user interface
        //    this.Close();
        //    if (mainPage == null || mainPage.IsDisposed)
        //    {
        //        mainPage = new MainPage();
        //    }
        //    mainPage.Show();
        //}

        private void CloseButton(object sender, EventArgs e)
        {
            this.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void SignUpBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}

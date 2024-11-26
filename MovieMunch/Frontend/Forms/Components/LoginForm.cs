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

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            string email = emailInput.Text;
            string password = passwordInput.Text;

            bool isAdminLogin = userService.AdminLogin(email, password);

            if (!rememberMeCheckBox.Checked)
            {
                termsAndRegMessage.Visible = true;
                termsAndRegMessage.Text = "You must accept the terms and conditions.";
                return;
            }

            termsAndRegMessage.Visible = false;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) )
            {
                termsAndRegMessage.Visible = true;
                termsAndRegMessage.Text = "Email and password are required.";
                return;
            }


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
                }
                else
                {
                    termsAndRegMessage.Visible = true;
                    termsAndRegMessage.Text = "Login failed. Please check your credentials.";
                }
            }
        }


        private void SignUpBtn_Click(object sender, EventArgs e)
        {

            this.Close();
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }

        private void loginFormClose_Click(object sender, EventArgs e)
        {

            this.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }
    }
}

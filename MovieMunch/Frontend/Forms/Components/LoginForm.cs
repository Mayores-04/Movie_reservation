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

        private string _userName;

        public void GetUsers(string userName)
        {
            _userName = userName;
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            string email = emailInput.Text;
            string password = passwordInput.Text;

            bool isAdminLogin = userService.AdminLogin(email, password);

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
                    MainPage mainPage = new MainPage();
                    mainPage.Visible = false;

                    MainAdmin mainAdmin = new MainAdmin();
                    mainAdmin.Show();
                    this.Close();
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

                    foreach (Form openForm in Application.OpenForms)
                    {
                        if (openForm is MainPage)
                        {
                            openForm.Close();
                            break;
                        }
                    }
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
            mainPage.SetUserInfo(_userName);
            mainPage.Show();
        }
    }
}

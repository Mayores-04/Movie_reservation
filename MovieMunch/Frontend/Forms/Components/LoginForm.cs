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
            
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is RegisterForm)
                {
                    openForm.Close();
                    break;
                }
            }
        }

        private string _userName;
        private string _profilePic;

        public void GetUsers(string userName, string profilePic)
        {
            _userName = userName;
            _profilePic = profilePic;
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            string email = emailInput.Text.Trim();
            string password = passwordInput.Text.Trim();

            termsAndRegMessage.Visible = false;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                termsAndRegMessage.Visible = true;
                termsAndRegMessage.Text = "Email and password are required.";
                return;
            }

            AdminAccount admin = userService.AdminLogin(email, password);

            if (admin != null)  
            {
                AdminLoadingForm adminLoginForm = new AdminLoadingForm();
                adminLoginForm.setUserNamme(admin.employeeName, admin.employeeProfilePic);
                adminLoginForm.Show();
                this.Close();
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
            regForm.GetUsers(_userName, _profilePic);
            regForm.ShowDialog();
        }

        private void loginFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mainPage = new MainPage();
            if(_userName == null)
            {
                mainPage.SetUserInfo("USERNAME", _profilePic);
            }
            else
            {
                mainPage.SetUserInfo(_userName, _profilePic);
            }
            mainPage.Show();
        }
    }
}

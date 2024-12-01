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
            string email = emailInput.Text.Trim();
            string password = passwordInput.Text.Trim();

            termsAndRegMessage.Visible = false;

            // Check if email or password fields are empty
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                termsAndRegMessage.Visible = true;
                termsAndRegMessage.Text = "Email and password are required.";
                return;
            }

            // Attempt admin login
            AdminAccount admin = userService.AdminLogin(email, password);

            if (admin != null) // Admin login successful
            {
                DialogResult result = MessageBox.Show(
                    $"Login successful as Admin ({admin.employeeName}). Do you want to open the Admin interface?",
                    "Admin Login",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Open Admin interface
                    MainAdmin mainAdmin = new MainAdmin();
                    mainAdmin.SetUserNamme(admin.employeeName, admin.employeeProfilePic);
                    mainAdmin.Show();
                    this.Close();
                }
                else
                {
                    // Stay on the current page
                    return;
                }
            }
            else
            {
                // Attempt regular user login
                bool isLogin = userService.LoginUser(email, password);

                if (isLogin)
                {
                    // User login successful
                    this.Close();
                }
                else
                {
                    // User login failed
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
            mainPage.SetUserInfo(_userName);
            mainPage.Show();
        }
    }
}

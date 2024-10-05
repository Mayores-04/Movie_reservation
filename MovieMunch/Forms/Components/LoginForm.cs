using System;
using System.Windows.Forms;

namespace MovieMunch
{
    public partial class LoginForm : Form
    {
        private MainPage mainPage; 

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            string email = email_input.Text;    
            string password = password_input.Text;

            bool isLogin = userService.LoginUser(email, password);

            if (isLogin)
            {
                this.Hide(); // Hide the LoginForm after a successful login

                // Close the previous instance of MainPage if it's open
                if (mainPage != null && !mainPage.IsDisposed)
                {
                    mainPage.Close();
                }

                // Create and open a new instance of MainPage
                mainPage = new MainPage();
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        
        }
    }
}

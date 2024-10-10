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

        private void registerButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            string email = email_input.Text;
            string password = password_input.Text;

            bool isRegistered = userService.RegisterUser(email, password);
            if (isRegistered)
            {
                MessageBox.Show("Successful Register");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

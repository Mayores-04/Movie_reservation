using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace MovieMunch
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            termsAndConditionPanel.BringToFront();

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is LoginForm)
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

        private void LoginBtnLinked_Click(object sender, EventArgs e)
        {
            LoginForm logForm = new LoginForm();
            logForm.GetUsers(_userName, _profilePic);
            logForm.Show();
            this.Close();
        }

        private void regFormClose_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            if(_userName == null)
            {
                _userName = "USERNAME";
                mainPage.SetUserInfo(_userName, _profilePic);
            }
            else
            {
                mainPage.SetUserInfo(_userName, _profilePic);
            }
            mainPage.Show();
            this.Close();
        }

        private void closeTermsAndConditionPanel_Click(object sender, EventArgs e)
        {
            termsAndConditionPanel.Visible = false;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            string name = regNameInput.Text.Trim();
            string email = regEmailInput.Text.Trim();
            string password = regPasswordInput.Text;
            string confirmPassword = regConfirmPasswordInput.Text;

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
            else
            {
                termsAndConditionPanel.Visible = true;
            }
        }

        private void successRegisterBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            string name = regNameInput.Text.Trim();
            string email = regEmailInput.Text.Trim();
            string password = regPasswordInput.Text;
            string confirmPassword = regConfirmPasswordInput.Text;

            if (termsAndRegistrationCheckBox.Checked)
            {
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

                bool isGood = userService.RegisterUser(name, email, password, confirmPassword);
                if (isGood)
                {
                    LoginForm loginForm = new LoginForm();
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginForm.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("An error occurred during registration. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                termsAndConditionPanel.Visible = false;
                MessageBox.Show("You must agree to the terms and conditions to register.", "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //private void RegisterBtn_Click(object sender, EventArgs e)
        //{
        //    UserService userService = new UserService();

        //    string name = regNameInput.Text.Trim();
        //    string email = regEmailInput.Text.Trim();
        //    string password = regPasswordInput.Text;
        //    string confirmPassword = regConfirmPasswordInput.Text;



        //    if (!termsAndRegistrationCheckBox.Checked)
        //    {
        //        termsAndRegMessage.Visible = true;
        //        termsAndRegMessage.Text = "You must accept the terms and conditions.";
        //        return;
        //    }
        //    termsAndRegMessage.Visible = false;

        //    if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
        //    {
        //        termsAndRegMessage.Visible = true;
        //        termsAndRegMessage.Text = "Email, password, and confirm password are required!";
        //        return;
        //    }

        //    if (password != confirmPassword)
        //    {
        //        termsAndRegMessage.Visible = true;
        //        termsAndRegMessage.Text = "Passwords do not match.";
        //        return;
        //    }

        //    bool isGood = userService.RegisterUser(name, email, password, confirmPassword);
        //    if (isGood)
        //    {
        //        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.Hide();
        //        LoginForm loginForm = new LoginForm();
        //        loginForm.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("pakyu");
        //    }
        //}
    }
}

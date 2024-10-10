using MovieMunch.Forms.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMunch.Frontend.Forms
{
    public partial class SettingsForm : Form
    {
        //Instances
        private LoginForm _loginFormInstance;
        private RegisterForm _registerFormInstance;
        private editEmail _editAccount;


        public SettingsForm()
        {
            InitializeComponent();
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Open Login Form
            if (_loginFormInstance != null && !_loginFormInstance.IsDisposed)
            {
                _loginFormInstance.Close();  // Close the previous instance if it's still open
            }

            _loginFormInstance = new LoginForm();  // Create a new instance
            _loginFormInstance.Show(); //Display loginForm
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            // Open Register Form
            if (_registerFormInstance != null && !_registerFormInstance.IsDisposed)
            {
                _registerFormInstance.Close();  // Close the previous instance if it's still open
            }

            _registerFormInstance = new RegisterForm(); // Create a new instance
            _registerFormInstance.Show(); //Display registerForm
        }

        private void edit_emailBtn_Click(object sender, EventArgs e)
        {
            if (_editAccount != null && !_editAccount.IsDisposed)
            {
                _editAccount.Close();
            }

            _editAccount = new editEmail();
            _editAccount.Show();
        }
    }
}

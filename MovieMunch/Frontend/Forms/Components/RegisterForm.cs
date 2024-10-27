﻿using System;
using System.Windows.Forms;

namespace MovieMunch
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void LoginBtnLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LoginForm logForm = new LoginForm();
            logForm.ShowDialog();
        }

        private void regCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            string email = regEmailInput.Text;
            string password = regPasswordInput.Text;

            bool isRegistered = userService.RegisterUser(email, password);
            if (isRegistered)
            {
                MessageBox.Show("Successful Register");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
        }
    }
}

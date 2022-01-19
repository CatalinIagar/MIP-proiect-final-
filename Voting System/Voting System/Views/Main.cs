﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voting_System.Views;
using Voting_System.Controllers;

using System.Threading;
using System.Configuration;

namespace Voting_System
{
    public partial class Main : Form
    {

        private int adminPass = "admin".GetHashCode();
        public Main()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            SignUpForm signupForm = new SignUpForm();
            signupForm.Show();
        }

        private void adminBtn_Click(object sender, EventArgs e) {
            if (adminPassTxt.Text.GetHashCode() == adminPass)
            {
                Thread newThread = new Thread(() =>
                {
                    Application.Run(new Admin());
                });
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
                this.Close();
            }
            else
            {
                var language = ConfigurationManager.AppSettings["language"];

                if (language == "ro") MessageBox.Show("Parola incorecta");
                if (language == "en") MessageBox.Show("Incorrect password");
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool result = UserController.UserExists(this.usernameTxtBox.Text, this.passwordTextBox.Text.GetHashCode());

            if (result == true)
            {
                int id = UserController.GetUserID(usernameTxtBox.Text);
                Thread newThread = new Thread(() =>
                {
                    Application.Run(new UserForm(id));
                });
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "en");
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "ro");
            Application.Restart();
        }
    }
}

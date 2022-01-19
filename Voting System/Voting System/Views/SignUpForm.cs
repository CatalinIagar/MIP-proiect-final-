using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voting_System.Models;
using Voting_System.Controllers;
using System.Configuration;

namespace Voting_System.Views
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            signupBtn.Enabled = false;
            Task.Run(() => createUser(this, signupBtn));
        }

        public delegate void CloseFormDelegate(SignUpForm signUp);

        public void CloseForm(SignUpForm signUp)
        {
            if (signUp != null)
            {
                signUp.Close();
            }
        }

        public delegate void enableSignUpButtonDelegate(Button button);

        public void enableSignUpButton(Button button)
        {

            button.Enabled = true;

        }

        private async Task createUser(SignUpForm signUp, Button signUpButton)
        {
            await Task.Run(() =>
            {
                
                string Username = this.usernameTxt.Text;
                string Password = this.passwordTxt.Text;
                string FirstName = this.firstTxt.Text;
                string LastName = this.lastTxt.Text;
                string CNP = this.cnpTxt.Text;
                DateTime DateOfBirth = this.dateTimePicker1.Value;

                int rezultat = UserController.NewUser(Username, Password, FirstName, LastName, DateOfBirth, CNP);

                var language = ConfigurationManager.AppSettings["language"];

                if (rezultat == ErrorCodes.UsernameExistent)
                {
                    if (language == "ro") MessageBox.Show("Numele de utilizator exista deja");
                    if (language == "en") MessageBox.Show("Username already exists");
                }
                if (rezultat == ErrorCodes.UsernameNull)
                {
                    if (language == "ro") MessageBox.Show("Va rugam completati numele de utilizator");
                    if (language == "en") MessageBox.Show("Please complete username field");
                }
                if (rezultat == ErrorCodes.PasswordNull)
                {
                    if (language == "ro") MessageBox.Show("Va rugam completati parola");
                    if (language == "en") MessageBox.Show("Please complete password field");
                }
                if (rezultat == ErrorCodes.FirstNameNull)
                {
                    if (language == "ro") MessageBox.Show("Va rugam completati numele");
                    if (language == "en") MessageBox.Show("Please complete first name field");
                }
                if (rezultat == ErrorCodes.LastPassNull)
                {
                    if (language == "ro") MessageBox.Show("Va rugam completati prenumele");
                    if (language == "en") MessageBox.Show("Please complete last name field");
                }
                if (rezultat == ErrorCodes.DOBNull)
                {
                    if (language == "ro") MessageBox.Show("Va rugam completati data de nastere");
                    if (language == "en") MessageBox.Show("Please complete Date of bith field");
                }
                if (rezultat == ErrorCodes.CNPNULL)
                {
                    if (language == "ro") MessageBox.Show("Va rugam completati CNP-ul");
                    if (language == "en") MessageBox.Show("Please complete CNP field");
                }
                if (rezultat == ErrorCodes.CNPLengthError)
                {
                    if (language == "ro") MessageBox.Show("Numarul de cifre din CNP gresit");
                    if (language == "en") MessageBox.Show("CNP does not meet the required length");
                }
                if (rezultat == ErrorCodes.InvalidCNP)
                {
                    if (language == "ro") MessageBox.Show("CNP invalid");
                    if (language == "en") MessageBox.Show("CNP invalid");
                }
                if (rezultat == ErrorCodes.Succes)
                {
                    if (language == "ro") MessageBox.Show("Cont creat cu succes");
                    if (language == "en") MessageBox.Show("Account succesfully created");
                    if (signUp.InvokeRequired)
                    {
                        object[] f = new object[1];
                        f[0] = signUp;
                        signUp.BeginInvoke(new CloseFormDelegate(CloseForm), f);
                    }
                    else
                    {
                        CloseForm(signUp);
                    }
                }


                if (signUpButton.InvokeRequired)
                {
                    object[] b = new object[1];
                    b[0] = signUpButton;
                    signUpButton.BeginInvoke(new enableSignUpButtonDelegate(enableSignUpButton), b);
                }
                else
                {
                    enableSignUpButton(signUpButton);
                }
                
            });
        }
    }
}


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

                if(rezultat == ErrorCodes.UsernameExistent)
                {
                    MessageBox.Show("Username already exists");
                }
                if (rezultat == ErrorCodes.UsernameNull)
                {
                    MessageBox.Show("Please complete username field");
                }
                if (rezultat == ErrorCodes.PasswordNull)
                {
                    MessageBox.Show("Please complete password field");
                }
                if (rezultat == ErrorCodes.FirstNameNull)
                {
                    MessageBox.Show("Please complete first name field");
                }
                if (rezultat == ErrorCodes.LastPassNull)
                {
                    MessageBox.Show("Please complete last name field");
                }
                if (rezultat == ErrorCodes.DOBNull)
                {
                    MessageBox.Show("Please complete Date of bith field");
                }
                if (rezultat == ErrorCodes.CNPNULL)
                {
                    MessageBox.Show("Please complete CNP field");
                }
                if (rezultat == ErrorCodes.CNPLengthError)
                {
                    MessageBox.Show("CNP does not meet the required length");
                }
                if (rezultat == ErrorCodes.InvalidCNP)
                {
                    MessageBox.Show("CNP invalid");
                }
                if (rezultat == ErrorCodes.Succes)
                {
                    MessageBox.Show("Account succesfully created");
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


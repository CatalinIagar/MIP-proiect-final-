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
                }
            });
        }
    }
}


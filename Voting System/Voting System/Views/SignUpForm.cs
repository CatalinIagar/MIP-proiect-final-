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
                using (UserDbContext context = new UserDbContext())
                {
                    UserModel utilizator = new UserModel();
                    utilizator.Username = this.usernameTxt.Text;
                    utilizator.Password = this.passwordTxt.Text.GetHashCode();
                    utilizator.FirstName = this.firstTxt.Text;
                    utilizator.LastName = this.lastTxt.Text;
                    utilizator.CNP = this.cnpTxt.Text;
                    utilizator.DateOfBirth = this.dateTimePicker1.Value;

                    int query = (from u in context.Users
                                 where u.Username == usernameTxt.Text
                                 select u).Count();
                    if (query == 0)
                    {
                        try
                        {
                            context.Users.Add(utilizator);
                            context.SaveChanges();
                            MessageBox.Show("Cont creat cu succes");

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
                        catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                        {
                            MessageBox.Show("Nu ati complet toate campurile");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username existent");
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
                }
            });
        }
    }
}


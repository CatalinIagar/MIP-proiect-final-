using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voting_System.Views;

namespace Voting_System
{
    public partial class Main : Form
    {
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
    }
}

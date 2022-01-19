using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Voting_System.Controllers;

namespace Voting_System.Views
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void addCandidateBtn_Click(object sender, EventArgs e)
        {
            AddCandidate addCandidate = new AddCandidate();
            addCandidate.Show();
        }

        private void resultsBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}

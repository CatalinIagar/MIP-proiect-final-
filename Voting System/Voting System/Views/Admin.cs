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
using Voting_System.Models;

namespace Voting_System.Views
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadData();
        }

        private void addCandidateBtn_Click(object sender, EventArgs e)
        {
            AddCandidate addCandidate = new AddCandidate();
            addCandidate.Show();
        }

        private void resultsBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            Task<List<CandidateModel>> task = new Task<List<CandidateModel>>(() => CandidateController.GetAllCandidates());
            task.Start();
            List<CandidateModel> candidates = await task; // get all candidates from db

            var res = (from c in candidates
                       select new
                       {
                           c.ID,
                           c.FirstName,
                           c.LastName,
                           c.NrOfVotes
                       }).ToList();

            this.dgv.DataSource = res;
        }
    }
}

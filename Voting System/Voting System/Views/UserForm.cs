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

namespace Voting_System.Views {
    public partial class UserForm : Form {

        private int userId;
        public UserForm(int userId) {
            InitializeComponent();
            this.userId = userId;
        }

        public async void LoadData () {
            Task<List<CandidateModel>> task = new Task<List<CandidateModel>>(() => CandidateController.GetAllCandidates());
            task.Start();
            List<CandidateModel> candidates = await task; // get all candidates from db

            var res = (from c in candidates
                       select new {
                           c.ID,
                           c.FirstName,
                           c.LastName,
                       }).ToList();

            this.dgv.DataSource = res;
        }

        private void refreshButton_Click(object sender, EventArgs e) {
            LoadData();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
           int candidateId = int.Parse(dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString());

          VoteForm form = new VoteForm(candidateId, userId);
            if (form.ShowDialog() == DialogResult.OK) {
                Console.WriteLine("Votat");
            }
        }
    }
}

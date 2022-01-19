using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Voting_System.Controllers;

namespace Voting_System.Views {
    public partial class VoteForm : Form {

        private int candidateId;
        private int userId;
        public VoteForm(int candidateId, int userId) {

            InitializeComponent();

            bool hasVoted = UserController.GetVoteState(userId);
            if (hasVoted == true) Votebtn.Enabled = false;
            else Votebtn.Enabled = true;

            this.candidateId = candidateId;
            this.userId = userId;
         
            descriptionrichTextBox.Text = XmlController.getDescriptionXml(@"data\candidati.xml", candidateId);
            name.Text = CandidateController.GetFullName(candidateId);
            string imageName = XmlController.getImageXml(@"data\candidati.xml", candidateId);

            if(imageName != "")
            {
                string basePath = Environment.CurrentDirectory;
                string relativePath = "data";
                string fullPath = Path.Combine(basePath, relativePath);
                fullPath = Path.Combine(fullPath, imageName);

                Size size = new Size(220, 220);
                Bitmap bitmap = new Bitmap(fullPath);
                Bitmap bitmap1 = new Bitmap(bitmap, new Size(220, 220));

                pictureBox.Image = bitmap1;
            }
        }

        private void Votebtn_Click(object sender, EventArgs e) {
            CandidateController.IncermentCandidateVotes(candidateId);
            UserController.ChangeVoteState(userId, candidateId);
            this.Close();
        }
    }
}

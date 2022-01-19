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

        public VoteForm(int id) {

            InitializeComponent();
         
            descriptionrichTextBox.Text = XmlController.getDescriptionXml(@"data\candidati.xml", id);
            name.Text = CandidateController.GetFullName(id);
            string imageName = XmlController.getImageXml(@"data\candidati.xml", id);

            string basePath = Environment.CurrentDirectory;
            string relativePath = "data";
            string fullPath = Path.Combine(basePath, relativePath);
            fullPath = Path.Combine(fullPath,imageName);
            Console.WriteLine(fullPath);

            Size size = new Size(220, 220);
            Bitmap bitmap = new Bitmap(fullPath);
            Bitmap bitmap1 = new Bitmap(bitmap, new Size(220,220));
           
            pictureBox.Image = bitmap1;

          // pictureBox.ClientSize = new Size(220, 220); //220,220
         
        
            /*
            descriptionrichTextBox.Text = "Sunt Razavan si sunt un bombardier.CHeck.Chec";
            string basePath = Environment.CurrentDirectory;
            string relativePath = @"data\person.png";
            string fullPath = Path.Combine(basePath, relativePath);
          
            Bitmap bitmap = new Bitmap(fullPath);
            pictureBox.Image = bitmap;
            pictureBox.ClientSize = new Size(220, 220); //220,220
            Console.WriteLine(bitmap.Width+ " " + bitmap.Height);
            name.Text = "aLEXANDRU cRACIUN";
            */
        }

        private void Votebtn_Click(object sender, EventArgs e) {

        }
    }
}

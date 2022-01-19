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

namespace Voting_System.Views {
    public partial class VoteForm : Form {
        public VoteForm() {
            InitializeComponent();
            descriptionrichTextBox.Text = "Sunt Razavan si sunt un bombardier.CHeck.Chec";
            string basePath = Environment.CurrentDirectory;
            string relativePath = @"data\person.png";
            string fullPath = Path.Combine(basePath, relativePath);
          
            Bitmap bitmap = new Bitmap(fullPath);
            pictureBox.Image = bitmap;
            pictureBox.ClientSize = new Size(220, 220); //220,220
            Console.WriteLine(bitmap.Width+ " " + bitmap.Height);
            name.Text = "aLEXANDRU cRACIUN";
        }
    }
}

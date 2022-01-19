using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Voting_System.Controllers;

namespace Voting_System.Views
{
    
    public partial class AddCandidate : Form
    {
        private string fileName;

        private TraceController tracecontroller = TraceController.getInstance();
        public AddCandidate()
        {
            InitializeComponent();
            fileName = "";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            addBtn.Enabled = false;
            Task.Run(() => addCandidate(this, addBtn));
        }

        public delegate void CloseFormDelegate(AddCandidate addCandidate);

        public void CloseForm(AddCandidate addCandidate)
        {
            if (addCandidate != null)
            {
                addCandidate.Close();
            }
        }

        public delegate void enableAddButtonDelegate(Button button);

        public void enableAddButton(Button button)
        {

            button.Enabled = true;

        }

        private async Task addCandidate(AddCandidate signUp, Button addCandidate)
        {
            await Task.Run(() =>
            {
                string FirstName = this.firstTxt.Text;
                string LastName = this.lastTxt.Text;
                string Description = this.description.Text;


                int rezultat = CandidateController.NewCandidate(FirstName, LastName, Description);

                if (rezultat == ErrorCodes.FirstNameNull)
                {
                    MessageBox.Show("Please complete first name field");
                }
                if (rezultat == ErrorCodes.LastPassNull)
                {
                    MessageBox.Show("Please complete last name field");
                }
                if (rezultat == ErrorCodes.DescriptionNull)
                {
                    MessageBox.Show("Please complete description field");
                }
                if (rezultat == ErrorCodes.DescriptionLessThan50)
                {
                    MessageBox.Show("Description too short");
                }
                if (rezultat == ErrorCodes.DescriptionMoreThan200)
                {
                    MessageBox.Show("Description too long");
                }
                if (rezultat == ErrorCodes.Succes)
                {
                    MessageBox.Show("Candidate added succesfully");
                    //xml
                    XmlController.InsertXml(@"data\candidati.xml", 2, FirstName, LastName,Description, fileName);

                    //
                    tracecontroller.logMessage("Candidate added succesfully");
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


                if (addBtn.InvokeRequired)
                {
                    object[] b = new object[1];
                    b[0] = addBtn;
                    addBtn.BeginInvoke(new enableAddButtonDelegate(enableAddButton), b);
                }
                else
                {
                    enableAddButton(addBtn);
                }
            });
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addBtn.Enabled = false;
            Task.Run(() => addCandidate(this, addBtn));
        }

        private void button1_Click(object sender, EventArgs e) {
            string basePath = Environment.CurrentDirectory;
            string relativePath = "data";
            string fullPath = Path.Combine(basePath, relativePath);

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {

                FileInfo fi = new FileInfo(ofd.FileName);
                File.Move(ofd.FileName, Path.Combine(fullPath,fi.Name));
                fileName = fi.Name;
                // Console.WriteLine(fileName);
            }
        }
    }
}

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

using System.IO;
using System.Reflection;

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

        private void adminBtn_Click(object sender, EventArgs e) {
          /*
            string basePath = Environment.CurrentDirectory;
            string relativePath = @"data/XMLLibrary.dll";
            string fullPath = Path.Combine(basePath, relativePath);

            Assembly reflDLL = Assembly.LoadFile(fullPath);

            if (reflDLL == null) {
                Console.WriteLine("Assambley negasit!");
            }
            else {
                Console.WriteLine("Assambley gasit!");
                dynamic d = reflDLL.CreateInstance("XMLLibrary.XmlHandler");
                */
                // d.insertXml(@"data/out.xml", 127, "Vlad", "Valentin", "Este bun la orice vrea si nu numai");
                /*
                try {
                    d.deleteCandidatXml(@"data/out.xml", 27);
                }
                catch(System.NullReferenceException eeeee) {
                    Console.WriteLine(eeeee.Message);
                }
                */
                // Console.WriteLine(d.getDescription(@"data/out.xml", 17));
                //d.modifyDescription(@"data/out.xml", 17, "hahahhahahhah");
                
           // }




        }
    }
}

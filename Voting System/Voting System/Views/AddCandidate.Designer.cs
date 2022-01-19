namespace Voting_System.Views
{
    partial class AddCandidate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCandidate));
            this.lastTxt = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstTxt = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.labelImage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lastTxt
            // 
            resources.ApplyResources(this.lastTxt, "lastTxt");
            this.lastTxt.Name = "lastTxt";
            // 
            // lastNameLbl
            // 
            resources.ApplyResources(this.lastNameLbl, "lastNameLbl");
            this.lastNameLbl.Name = "lastNameLbl";
            // 
            // firstTxt
            // 
            resources.ApplyResources(this.firstTxt, "firstTxt");
            this.firstTxt.Name = "firstTxt";
            // 
            // firstNameLbl
            // 
            resources.ApplyResources(this.firstNameLbl, "firstNameLbl");
            this.firstNameLbl.Name = "firstNameLbl";
            // 
            // descLbl
            // 
            resources.ApplyResources(this.descLbl, "descLbl");
            this.descLbl.Name = "descLbl";
            // 
            // closeBtn
            // 
            resources.ApplyResources(this.closeBtn, "closeBtn");
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // addBtn
            // 
            resources.ApplyResources(this.addBtn, "addBtn");
            this.addBtn.Name = "addBtn";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // labelImage
            // 
            resources.ApplyResources(this.labelImage, "labelImage");
            this.labelImage.Name = "labelImage";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // description
            // 
            resources.ApplyResources(this.description, "description");
            this.description.Name = "description";
            // 
            // AddCandidate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.description);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.lastTxt);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstTxt);
            this.Controls.Add(this.firstNameLbl);
            this.Name = "AddCandidate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastTxt;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox firstTxt;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox description;
    }
}
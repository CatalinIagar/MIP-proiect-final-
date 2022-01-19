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
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.descLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastTxt
            // 
            this.lastTxt.Location = new System.Drawing.Point(12, 70);
            this.lastTxt.Name = "lastTxt";
            this.lastTxt.Size = new System.Drawing.Size(200, 20);
            this.lastTxt.TabIndex = 15;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(9, 53);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.lastNameLbl.TabIndex = 14;
            this.lastNameLbl.Text = "Last Name";
            // 
            // firstTxt
            // 
            this.firstTxt.Location = new System.Drawing.Point(12, 30);
            this.firstTxt.Name = "firstTxt";
            this.firstTxt.Size = new System.Drawing.Size(200, 20);
            this.firstTxt.TabIndex = 13;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(9, 13);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.firstNameLbl.TabIndex = 12;
            this.firstNameLbl.Text = "First Name";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(12, 112);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(200, 20);
            this.descriptionTxt.TabIndex = 17;
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(9, 95);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(60, 13);
            this.descLbl.TabIndex = 16;
            this.descLbl.Text = "Description";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(125, 156);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(87, 36);
            this.closeBtn.TabIndex = 19;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 156);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(87, 36);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 208);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.lastTxt);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstTxt);
            this.Controls.Add(this.firstNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCandidate";
            this.Text = "AddCandidate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastTxt;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox firstTxt;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button addBtn;
    }
}
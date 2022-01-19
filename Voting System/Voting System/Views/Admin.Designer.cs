namespace Voting_System.Views
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resultsBtn = new System.Windows.Forms.Button();
            this.addCandidateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // resultsBtn
            // 
            this.resultsBtn.Location = new System.Drawing.Point(337, 13);
            this.resultsBtn.Name = "resultsBtn";
            this.resultsBtn.Size = new System.Drawing.Size(117, 35);
            this.resultsBtn.TabIndex = 1;
            this.resultsBtn.Text = "Show Results";
            this.resultsBtn.UseVisualStyleBackColor = true;
            this.resultsBtn.Click += new System.EventHandler(this.resultsBtn_Click);
            // 
            // addCandidateBtn
            // 
            this.addCandidateBtn.Location = new System.Drawing.Point(13, 13);
            this.addCandidateBtn.Name = "addCandidateBtn";
            this.addCandidateBtn.Size = new System.Drawing.Size(117, 35);
            this.addCandidateBtn.TabIndex = 2;
            this.addCandidateBtn.Text = "Add candidate";
            this.addCandidateBtn.UseVisualStyleBackColor = true;
            this.addCandidateBtn.Click += new System.EventHandler(this.addCandidateBtn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 365);
            this.Controls.Add(this.addCandidateBtn);
            this.Controls.Add(this.resultsBtn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button resultsBtn;
        private System.Windows.Forms.Button addCandidateBtn;
    }
}
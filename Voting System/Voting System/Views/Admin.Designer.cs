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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.resultsBtn = new System.Windows.Forms.Button();
            this.addCandidateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            resources.ApplyResources(this.dgv, "dgv");
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Name = "dgv";
            // 
            // resultsBtn
            // 
            resources.ApplyResources(this.resultsBtn, "resultsBtn");
            this.resultsBtn.Name = "resultsBtn";
            this.resultsBtn.UseVisualStyleBackColor = true;
            this.resultsBtn.Click += new System.EventHandler(this.resultsBtn_Click);
            // 
            // addCandidateBtn
            // 
            resources.ApplyResources(this.addCandidateBtn, "addCandidateBtn");
            this.addCandidateBtn.Name = "addCandidateBtn";
            this.addCandidateBtn.UseVisualStyleBackColor = true;
            this.addCandidateBtn.Click += new System.EventHandler(this.addCandidateBtn_Click);
            // 
            // Admin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addCandidateBtn);
            this.Controls.Add(this.resultsBtn);
            this.Controls.Add(this.dgv);
            this.Name = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button resultsBtn;
        private System.Windows.Forms.Button addCandidateBtn;
    }
}
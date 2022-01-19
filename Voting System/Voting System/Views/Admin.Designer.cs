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
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(17, 85);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(588, 346);
            this.dgv.TabIndex = 0;
            // 
            // resultsBtn
            // 
            this.resultsBtn.Location = new System.Drawing.Point(449, 16);
            this.resultsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultsBtn.Name = "resultsBtn";
            this.resultsBtn.Size = new System.Drawing.Size(156, 43);
            this.resultsBtn.TabIndex = 1;
            this.resultsBtn.Text = "Show Results";
            this.resultsBtn.UseVisualStyleBackColor = true;
            this.resultsBtn.Click += new System.EventHandler(this.resultsBtn_Click);
            // 
            // addCandidateBtn
            // 
            this.addCandidateBtn.Location = new System.Drawing.Point(17, 16);
            this.addCandidateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCandidateBtn.Name = "addCandidateBtn";
            this.addCandidateBtn.Size = new System.Drawing.Size(156, 43);
            this.addCandidateBtn.TabIndex = 2;
            this.addCandidateBtn.Text = "Add candidate";
            this.addCandidateBtn.UseVisualStyleBackColor = true;
            this.addCandidateBtn.Click += new System.EventHandler(this.addCandidateBtn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 449);
            this.Controls.Add(this.addCandidateBtn);
            this.Controls.Add(this.resultsBtn);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button resultsBtn;
        private System.Windows.Forms.Button addCandidateBtn;
    }
}
namespace Voting_System.Views {
    partial class VoteForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoteForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.Label();
            this.Votebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // descriptionrichTextBox
            // 
            resources.ApplyResources(this.descriptionrichTextBox, "descriptionrichTextBox");
            this.descriptionrichTextBox.Name = "descriptionrichTextBox";
            this.descriptionrichTextBox.ReadOnly = true;
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            // 
            // Votebtn
            // 
            resources.ApplyResources(this.Votebtn, "Votebtn");
            this.Votebtn.Name = "Votebtn";
            this.Votebtn.UseVisualStyleBackColor = true;
            this.Votebtn.Click += new System.EventHandler(this.Votebtn_Click);
            // 
            // VoteForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Votebtn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.descriptionrichTextBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "VoteForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox descriptionrichTextBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button Votebtn;
    }
}
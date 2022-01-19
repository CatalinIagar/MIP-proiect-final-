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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.Label();
            this.Votebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(19, 17);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(306, 273);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // descriptionrichTextBox
            // 
            this.descriptionrichTextBox.Location = new System.Drawing.Point(343, 12);
            this.descriptionrichTextBox.Name = "descriptionrichTextBox";
            this.descriptionrichTextBox.ReadOnly = true;
            this.descriptionrichTextBox.Size = new System.Drawing.Size(445, 426);
            this.descriptionrichTextBox.TabIndex = 1;
            this.descriptionrichTextBox.Text = "";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(51, 302);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 16);
            this.name.TabIndex = 2;
            this.name.Text = "label1";
            // 
            // Votebtn
            // 
            this.Votebtn.Location = new System.Drawing.Point(42, 358);
            this.Votebtn.Name = "Votebtn";
            this.Votebtn.Size = new System.Drawing.Size(270, 65);
            this.Votebtn.TabIndex = 3;
            this.Votebtn.Text = "Vote";
            this.Votebtn.UseVisualStyleBackColor = true;
            this.Votebtn.Click += new System.EventHandler(this.Votebtn_Click);
            // 
            // VoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Votebtn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.descriptionrichTextBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "VoteForm";
            this.Text = "VoteForm";
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
namespace Voting_System
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(371, 85);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(67, 16);
            this.passwordLbl.TabIndex = 0;
            this.passwordLbl.Text = "Password";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(375, 105);
            this.usernameTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.PasswordChar = '*';
            this.usernameTxtBox.Size = new System.Drawing.Size(249, 22);
            this.usernameTxtBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 315);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(375, 156);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(116, 44);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Log in";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(509, 156);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(116, 44);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.Location = new System.Drawing.Point(439, 208);
            this.signupBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(116, 32);
            this.signupBtn.TabIndex = 7;
            this.signupBtn.Text = "Sign up";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(509, 283);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(116, 44);
            this.adminBtn.TabIndex = 8;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 342);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.passwordLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Voting System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Button adminBtn;
    }
}


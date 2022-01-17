namespace Voting_System.Views
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.lastTxt = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstTxt = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.cnpTxt = new System.Windows.Forms.TextBox();
            this.cdnpLbl = new System.Windows.Forms.Label();
            this.dobLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.closeBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(15, 36);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(200, 20);
            this.usernameTxt.TabIndex = 5;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(12, 19);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameLbl.TabIndex = 4;
            this.usernameLbl.Text = "Username";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(15, 76);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(200, 20);
            this.passwordTxt.TabIndex = 7;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(12, 59);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "Password";
            // 
            // lastTxt
            // 
            this.lastTxt.Location = new System.Drawing.Point(15, 156);
            this.lastTxt.Name = "lastTxt";
            this.lastTxt.Size = new System.Drawing.Size(200, 20);
            this.lastTxt.TabIndex = 11;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(12, 139);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.lastNameLbl.TabIndex = 10;
            this.lastNameLbl.Text = "Last Name";
            // 
            // firstTxt
            // 
            this.firstTxt.Location = new System.Drawing.Point(15, 116);
            this.firstTxt.Name = "firstTxt";
            this.firstTxt.Size = new System.Drawing.Size(200, 20);
            this.firstTxt.TabIndex = 9;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(12, 99);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.firstNameLbl.TabIndex = 8;
            this.firstNameLbl.Text = "First Name";
            // 
            // cnpTxt
            // 
            this.cnpTxt.Location = new System.Drawing.Point(15, 196);
            this.cnpTxt.Name = "cnpTxt";
            this.cnpTxt.Size = new System.Drawing.Size(200, 20);
            this.cnpTxt.TabIndex = 13;
            // 
            // cdnpLbl
            // 
            this.cdnpLbl.AutoSize = true;
            this.cdnpLbl.Location = new System.Drawing.Point(12, 179);
            this.cdnpLbl.Name = "cdnpLbl";
            this.cdnpLbl.Size = new System.Drawing.Size(29, 13);
            this.cdnpLbl.TabIndex = 12;
            this.cdnpLbl.Text = "CNP";
            // 
            // dobLbl
            // 
            this.dobLbl.AutoSize = true;
            this.dobLbl.Location = new System.Drawing.Point(12, 219);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(66, 13);
            this.dobLbl.TabIndex = 14;
            this.dobLbl.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(128, 272);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(87, 36);
            this.closeBtn.TabIndex = 17;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.Location = new System.Drawing.Point(15, 272);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(87, 36);
            this.signupBtn.TabIndex = 16;
            this.signupBtn.Text = "Sign up";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 318);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dobLbl);
            this.Controls.Add(this.cnpTxt);
            this.Controls.Add(this.cdnpLbl);
            this.Controls.Add(this.lastTxt);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstTxt);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.usernameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox lastTxt;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox firstTxt;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox cnpTxt;
        private System.Windows.Forms.Label cdnpLbl;
        private System.Windows.Forms.Label dobLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button signupBtn;
    }
}
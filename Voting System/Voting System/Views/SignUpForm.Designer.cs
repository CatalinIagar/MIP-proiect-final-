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
            resources.ApplyResources(this.usernameTxt, "usernameTxt");
            this.usernameTxt.Name = "usernameTxt";
            // 
            // usernameLbl
            // 
            resources.ApplyResources(this.usernameLbl, "usernameLbl");
            this.usernameLbl.Name = "usernameLbl";
            // 
            // passwordTxt
            // 
            resources.ApplyResources(this.passwordTxt, "passwordTxt");
            this.passwordTxt.Name = "passwordTxt";
            // 
            // passwordLbl
            // 
            resources.ApplyResources(this.passwordLbl, "passwordLbl");
            this.passwordLbl.Name = "passwordLbl";
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
            // cnpTxt
            // 
            resources.ApplyResources(this.cnpTxt, "cnpTxt");
            this.cnpTxt.Name = "cnpTxt";
            // 
            // cdnpLbl
            // 
            resources.ApplyResources(this.cdnpLbl, "cdnpLbl");
            this.cdnpLbl.Name = "cdnpLbl";
            // 
            // dobLbl
            // 
            resources.ApplyResources(this.dobLbl, "dobLbl");
            this.dobLbl.Name = "dobLbl";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // closeBtn
            // 
            resources.ApplyResources(this.closeBtn, "closeBtn");
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // signupBtn
            // 
            resources.ApplyResources(this.signupBtn, "signupBtn");
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // SignUpForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "SignUpForm";
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
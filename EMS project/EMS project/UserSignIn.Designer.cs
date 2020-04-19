namespace EMS_project
{
    partial class UserSignIn
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
            this.SignInUserNameLebel = new System.Windows.Forms.Label();
            this.SignInUserNameTextbox = new System.Windows.Forms.TextBox();
            this.SignInPasswordLebel = new System.Windows.Forms.Label();
            this.SignInPasswordtextBox = new System.Windows.Forms.TextBox();
            this.SignInEmaillabel = new System.Windows.Forms.Label();
            this.SignInEmailtextBox = new System.Windows.Forms.TextBox();
            this.UserSignInIdlabel = new System.Windows.Forms.Label();
            this.UserSignIntextBox = new System.Windows.Forms.TextBox();
            this.CreateAccountbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignInUserNameLebel
            // 
            this.SignInUserNameLebel.AutoSize = true;
            this.SignInUserNameLebel.Location = new System.Drawing.Point(43, 181);
            this.SignInUserNameLebel.Name = "SignInUserNameLebel";
            this.SignInUserNameLebel.Size = new System.Drawing.Size(88, 13);
            this.SignInUserNameLebel.TabIndex = 5;
            this.SignInUserNameLebel.Text = " Enter UserName";
            // 
            // SignInUserNameTextbox
            // 
            this.SignInUserNameTextbox.Location = new System.Drawing.Point(163, 178);
            this.SignInUserNameTextbox.Name = "SignInUserNameTextbox";
            this.SignInUserNameTextbox.Size = new System.Drawing.Size(204, 20);
            this.SignInUserNameTextbox.TabIndex = 6;
            // 
            // SignInPasswordLebel
            // 
            this.SignInPasswordLebel.AutoSize = true;
            this.SignInPasswordLebel.Location = new System.Drawing.Point(43, 108);
            this.SignInPasswordLebel.Name = "SignInPasswordLebel";
            this.SignInPasswordLebel.Size = new System.Drawing.Size(81, 13);
            this.SignInPasswordLebel.TabIndex = 7;
            this.SignInPasswordLebel.Text = "Enter Password";
            this.SignInPasswordLebel.Click += new System.EventHandler(this.SignInPasswordLebel_Click);
            // 
            // SignInPasswordtextBox
            // 
            this.SignInPasswordtextBox.Location = new System.Drawing.Point(163, 108);
            this.SignInPasswordtextBox.Name = "SignInPasswordtextBox";
            this.SignInPasswordtextBox.Size = new System.Drawing.Size(204, 20);
            this.SignInPasswordtextBox.TabIndex = 8;
            // 
            // SignInEmaillabel
            // 
            this.SignInEmaillabel.AutoSize = true;
            this.SignInEmaillabel.Location = new System.Drawing.Point(43, 143);
            this.SignInEmaillabel.Name = "SignInEmaillabel";
            this.SignInEmaillabel.Size = new System.Drawing.Size(63, 13);
            this.SignInEmaillabel.TabIndex = 9;
            this.SignInEmaillabel.Text = " Enter Email";
            // 
            // SignInEmailtextBox
            // 
            this.SignInEmailtextBox.Location = new System.Drawing.Point(163, 143);
            this.SignInEmailtextBox.Name = "SignInEmailtextBox";
            this.SignInEmailtextBox.Size = new System.Drawing.Size(204, 20);
            this.SignInEmailtextBox.TabIndex = 10;
            // 
            // UserSignInIdlabel
            // 
            this.UserSignInIdlabel.AutoSize = true;
            this.UserSignInIdlabel.Location = new System.Drawing.Point(43, 76);
            this.UserSignInIdlabel.Name = "UserSignInIdlabel";
            this.UserSignInIdlabel.Size = new System.Drawing.Size(47, 13);
            this.UserSignInIdlabel.TabIndex = 11;
            this.UserSignInIdlabel.Text = " Enter Id";
            // 
            // UserSignIntextBox
            // 
            this.UserSignIntextBox.Location = new System.Drawing.Point(163, 69);
            this.UserSignIntextBox.Name = "UserSignIntextBox";
            this.UserSignIntextBox.Size = new System.Drawing.Size(204, 20);
            this.UserSignIntextBox.TabIndex = 12;
            // 
            // CreateAccountbutton
            // 
            this.CreateAccountbutton.Location = new System.Drawing.Point(163, 229);
            this.CreateAccountbutton.Name = "CreateAccountbutton";
            this.CreateAccountbutton.Size = new System.Drawing.Size(132, 39);
            this.CreateAccountbutton.TabIndex = 13;
            this.CreateAccountbutton.Text = "Create Account";
            this.CreateAccountbutton.UseVisualStyleBackColor = true;
            this.CreateAccountbutton.Click += new System.EventHandler(this.CreateAccountbutton_Click);
            // 
            // UserSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 304);
            this.Controls.Add(this.CreateAccountbutton);
            this.Controls.Add(this.UserSignIntextBox);
            this.Controls.Add(this.UserSignInIdlabel);
            this.Controls.Add(this.SignInEmailtextBox);
            this.Controls.Add(this.SignInEmaillabel);
            this.Controls.Add(this.SignInPasswordtextBox);
            this.Controls.Add(this.SignInPasswordLebel);
            this.Controls.Add(this.SignInUserNameTextbox);
            this.Controls.Add(this.SignInUserNameLebel);
            this.Name = "UserSignIn";
            this.Text = "UserSignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignInUserNameLebel;
        private System.Windows.Forms.TextBox SignInUserNameTextbox;
        private System.Windows.Forms.Label SignInPasswordLebel;
        private System.Windows.Forms.TextBox SignInPasswordtextBox;
        private System.Windows.Forms.Label SignInEmaillabel;
        private System.Windows.Forms.TextBox SignInEmailtextBox;
        private System.Windows.Forms.Label UserSignInIdlabel;
        private System.Windows.Forms.TextBox UserSignIntextBox;
        private System.Windows.Forms.Button CreateAccountbutton;
    }
}
namespace EMS_project
{
    partial class LoginForm
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
            this.SignInButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.UserNameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UserNameLebel = new System.Windows.Forms.Label();
            this.PasswordLebel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(71, 226);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(110, 45);
            this.SignInButton.TabIndex = 0;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(200, 226);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(110, 45);
            this.LogInButton.TabIndex = 1;
            this.LogInButton.Text = "Login";
            this.LogInButton.UseVisualStyleBackColor = true;
            // 
            // UserNameTextbox
            // 
            this.UserNameTextbox.Location = new System.Drawing.Point(158, 100);
            this.UserNameTextbox.Name = "UserNameTextbox";
            this.UserNameTextbox.Size = new System.Drawing.Size(204, 20);
            this.UserNameTextbox.TabIndex = 2;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(158, 146);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(204, 20);
            this.PasswordTextbox.TabIndex = 3;
            // 
            // UserNameLebel
            // 
            this.UserNameLebel.AutoSize = true;
            this.UserNameLebel.Location = new System.Drawing.Point(68, 103);
            this.UserNameLebel.Name = "UserNameLebel";
            this.UserNameLebel.Size = new System.Drawing.Size(57, 13);
            this.UserNameLebel.TabIndex = 4;
            this.UserNameLebel.Text = "UserName";
            // 
            // PasswordLebel
            // 
            this.PasswordLebel.AutoSize = true;
            this.PasswordLebel.Location = new System.Drawing.Point(68, 149);
            this.PasswordLebel.Name = "PasswordLebel";
            this.PasswordLebel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLebel.TabIndex = 5;
            this.PasswordLebel.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 309);
            this.Controls.Add(this.PasswordLebel);
            this.Controls.Add(this.UserNameLebel);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UserNameTextbox);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.SignInButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.TextBox UserNameTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label UserNameLebel;
        private System.Windows.Forms.Label PasswordLebel;
    }
}


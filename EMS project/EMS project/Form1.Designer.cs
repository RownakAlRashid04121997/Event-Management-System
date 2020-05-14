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
            this.EMSlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(95, 278);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(147, 55);
            this.SignInButton.TabIndex = 0;
            this.SignInButton.Text = "Sign Up";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(267, 278);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(147, 55);
            this.LogInButton.TabIndex = 1;
            this.LogInButton.Text = "Login";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // UserNameTextbox
            // 
            this.UserNameTextbox.Location = new System.Drawing.Point(211, 123);
            this.UserNameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserNameTextbox.Name = "UserNameTextbox";
            this.UserNameTextbox.Size = new System.Drawing.Size(271, 22);
            this.UserNameTextbox.TabIndex = 2;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(211, 180);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(271, 22);
            this.PasswordTextbox.TabIndex = 3;
            // 
            // UserNameLebel
            // 
            this.UserNameLebel.AutoSize = true;
            this.UserNameLebel.Location = new System.Drawing.Point(91, 127);
            this.UserNameLebel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLebel.Name = "UserNameLebel";
            this.UserNameLebel.Size = new System.Drawing.Size(75, 17);
            this.UserNameLebel.TabIndex = 4;
            this.UserNameLebel.Text = "UserName";
            // 
            // PasswordLebel
            // 
            this.PasswordLebel.AutoSize = true;
            this.PasswordLebel.Location = new System.Drawing.Point(91, 183);
            this.PasswordLebel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLebel.Name = "PasswordLebel";
            this.PasswordLebel.Size = new System.Drawing.Size(69, 17);
            this.PasswordLebel.TabIndex = 5;
            this.PasswordLebel.Text = "Password";
            // 
            // EMSlabel
            // 
            this.EMSlabel.AutoSize = true;
            this.EMSlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMSlabel.Location = new System.Drawing.Point(138, 54);
            this.EMSlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EMSlabel.Name = "EMSlabel";
            this.EMSlabel.Size = new System.Drawing.Size(276, 25);
            this.EMSlabel.TabIndex = 6;
            this.EMSlabel.Text = "Event Management System";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 380);
            this.Controls.Add(this.EMSlabel);
            this.Controls.Add(this.PasswordLebel);
            this.Controls.Add(this.UserNameLebel);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UserNameTextbox);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.SignInButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
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
        private System.Windows.Forms.Label EMSlabel;
    }
}


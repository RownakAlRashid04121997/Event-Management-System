namespace EMS_project
{
    partial class AdminPage
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
            this.AdminPageBackbutton = new System.Windows.Forms.Button();
            this.WelcomeAdminlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminPageBackbutton
            // 
            this.AdminPageBackbutton.Location = new System.Drawing.Point(394, 293);
            this.AdminPageBackbutton.Name = "AdminPageBackbutton";
            this.AdminPageBackbutton.Size = new System.Drawing.Size(75, 23);
            this.AdminPageBackbutton.TabIndex = 1;
            this.AdminPageBackbutton.Text = "Back";
            this.AdminPageBackbutton.UseVisualStyleBackColor = true;
            this.AdminPageBackbutton.Click += new System.EventHandler(this.AdminPageBackbutton_Click);
            // 
            // WelcomeAdminlabel
            // 
            this.WelcomeAdminlabel.AutoSize = true;
            this.WelcomeAdminlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeAdminlabel.Location = new System.Drawing.Point(28, 41);
            this.WelcomeAdminlabel.Name = "WelcomeAdminlabel";
            this.WelcomeAdminlabel.Size = new System.Drawing.Size(122, 17);
            this.WelcomeAdminlabel.TabIndex = 2;
            this.WelcomeAdminlabel.Text = "Welcome Admin";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 328);
            this.Controls.Add(this.WelcomeAdminlabel);
            this.Controls.Add(this.AdminPageBackbutton);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminPageBackbutton;
        private System.Windows.Forms.Label WelcomeAdminlabel;
    }
}
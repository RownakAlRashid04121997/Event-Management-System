namespace EMS_project
{
    partial class UserPage
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
            this.UserPageBackbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserPageBackbutton
            // 
            this.UserPageBackbutton.Location = new System.Drawing.Point(387, 288);
            this.UserPageBackbutton.Name = "UserPageBackbutton";
            this.UserPageBackbutton.Size = new System.Drawing.Size(75, 23);
            this.UserPageBackbutton.TabIndex = 0;
            this.UserPageBackbutton.Text = "Back";
            this.UserPageBackbutton.UseVisualStyleBackColor = true;
            this.UserPageBackbutton.Click += new System.EventHandler(this.UserPageBackbutton_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 332);
            this.Controls.Add(this.UserPageBackbutton);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserPageBackbutton;
    }
}
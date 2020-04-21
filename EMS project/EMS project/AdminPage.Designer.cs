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
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 328);
            this.Controls.Add(this.AdminPageBackbutton);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminPageBackbutton;
    }
}
namespace EMS_project
{
    partial class OrderTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderTableBackbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // OrderTableBackbutton
            // 
            this.OrderTableBackbutton.Location = new System.Drawing.Point(738, 250);
            this.OrderTableBackbutton.Name = "OrderTableBackbutton";
            this.OrderTableBackbutton.Size = new System.Drawing.Size(75, 23);
            this.OrderTableBackbutton.TabIndex = 1;
            this.OrderTableBackbutton.Text = "Back";
            this.OrderTableBackbutton.UseVisualStyleBackColor = true;
            this.OrderTableBackbutton.Click += new System.EventHandler(this.OrderTableBackbutton_Click);
            // 
            // OrderTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 285);
            this.Controls.Add(this.OrderTableBackbutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderTable";
            this.Text = "OrderTable";
            this.Load += new System.EventHandler(this.OrderTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button OrderTableBackbutton;
    }
}
﻿namespace EMS_project
{
    partial class EmployeePage
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
            this.components = new System.ComponentModel.Container();
            this.EmployeeNamelabel = new System.Windows.Forms.Label();
            this.EmployeeNametextBox = new System.Windows.Forms.TextBox();
            this.EmployeeEmaillabel = new System.Windows.Forms.Label();
            this.EmployeeEmailtextBox = new System.Windows.Forms.TextBox();
            this.EmployeeDOBlabel = new System.Windows.Forms.Label();
            this.EmployeeDOBtextBox = new System.Windows.Forms.TextBox();
            this.EmployeePosttextBox = new System.Windows.Forms.TextBox();
            this.EmployeePostlabel = new System.Windows.Forms.Label();
            this.EmployeeSalarytextBox = new System.Windows.Forms.TextBox();
            this.EmployeeSalarylabel = new System.Windows.Forms.Label();
            this.AddEmployeebutton = new System.Windows.Forms.Button();
            this.EmployeePageNextbutton = new System.Windows.Forms.Button();
            this.EmployeePageBackbutton = new System.Windows.Forms.Button();
            this.eMSdbDataSet = new EMS_project.EMSdbDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new EMS_project.EMSdbDataSetTableAdapters.EmployeeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.eMSdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeNamelabel
            // 
            this.EmployeeNamelabel.AutoSize = true;
            this.EmployeeNamelabel.Location = new System.Drawing.Point(88, 24);
            this.EmployeeNamelabel.Name = "EmployeeNamelabel";
            this.EmployeeNamelabel.Size = new System.Drawing.Size(35, 13);
            this.EmployeeNamelabel.TabIndex = 0;
            this.EmployeeNamelabel.Text = "Name";
            // 
            // EmployeeNametextBox
            // 
            this.EmployeeNametextBox.Location = new System.Drawing.Point(156, 24);
            this.EmployeeNametextBox.Name = "EmployeeNametextBox";
            this.EmployeeNametextBox.Size = new System.Drawing.Size(218, 20);
            this.EmployeeNametextBox.TabIndex = 1;
            // 
            // EmployeeEmaillabel
            // 
            this.EmployeeEmaillabel.AutoSize = true;
            this.EmployeeEmaillabel.Location = new System.Drawing.Point(88, 74);
            this.EmployeeEmaillabel.Name = "EmployeeEmaillabel";
            this.EmployeeEmaillabel.Size = new System.Drawing.Size(32, 13);
            this.EmployeeEmaillabel.TabIndex = 2;
            this.EmployeeEmaillabel.Text = "Email";
            // 
            // EmployeeEmailtextBox
            // 
            this.EmployeeEmailtextBox.Location = new System.Drawing.Point(156, 74);
            this.EmployeeEmailtextBox.Name = "EmployeeEmailtextBox";
            this.EmployeeEmailtextBox.Size = new System.Drawing.Size(218, 20);
            this.EmployeeEmailtextBox.TabIndex = 3;
            // 
            // EmployeeDOBlabel
            // 
            this.EmployeeDOBlabel.AutoSize = true;
            this.EmployeeDOBlabel.Location = new System.Drawing.Point(74, 124);
            this.EmployeeDOBlabel.Name = "EmployeeDOBlabel";
            this.EmployeeDOBlabel.Size = new System.Drawing.Size(66, 13);
            this.EmployeeDOBlabel.TabIndex = 4;
            this.EmployeeDOBlabel.Text = "Date of Birth";
            // 
            // EmployeeDOBtextBox
            // 
            this.EmployeeDOBtextBox.Location = new System.Drawing.Point(156, 124);
            this.EmployeeDOBtextBox.Name = "EmployeeDOBtextBox";
            this.EmployeeDOBtextBox.Size = new System.Drawing.Size(218, 20);
            this.EmployeeDOBtextBox.TabIndex = 5;
            // 
            // EmployeePosttextBox
            // 
            this.EmployeePosttextBox.Location = new System.Drawing.Point(156, 173);
            this.EmployeePosttextBox.Name = "EmployeePosttextBox";
            this.EmployeePosttextBox.Size = new System.Drawing.Size(218, 20);
            this.EmployeePosttextBox.TabIndex = 6;
            // 
            // EmployeePostlabel
            // 
            this.EmployeePostlabel.AutoSize = true;
            this.EmployeePostlabel.Location = new System.Drawing.Point(92, 173);
            this.EmployeePostlabel.Name = "EmployeePostlabel";
            this.EmployeePostlabel.Size = new System.Drawing.Size(28, 13);
            this.EmployeePostlabel.TabIndex = 7;
            this.EmployeePostlabel.Text = "Post";
            // 
            // EmployeeSalarytextBox
            // 
            this.EmployeeSalarytextBox.Location = new System.Drawing.Point(156, 217);
            this.EmployeeSalarytextBox.Name = "EmployeeSalarytextBox";
            this.EmployeeSalarytextBox.Size = new System.Drawing.Size(218, 20);
            this.EmployeeSalarytextBox.TabIndex = 8;
            // 
            // EmployeeSalarylabel
            // 
            this.EmployeeSalarylabel.AutoSize = true;
            this.EmployeeSalarylabel.Location = new System.Drawing.Point(88, 217);
            this.EmployeeSalarylabel.Name = "EmployeeSalarylabel";
            this.EmployeeSalarylabel.Size = new System.Drawing.Size(36, 13);
            this.EmployeeSalarylabel.TabIndex = 9;
            this.EmployeeSalarylabel.Text = "Salary";
            // 
            // AddEmployeebutton
            // 
            this.AddEmployeebutton.Location = new System.Drawing.Point(68, 262);
            this.AddEmployeebutton.Name = "AddEmployeebutton";
            this.AddEmployeebutton.Size = new System.Drawing.Size(117, 30);
            this.AddEmployeebutton.TabIndex = 10;
            this.AddEmployeebutton.Text = "Add Employee";
            this.AddEmployeebutton.UseVisualStyleBackColor = true;
            this.AddEmployeebutton.Click += new System.EventHandler(this.AddEmployeebutton_Click);
            // 
            // EmployeePageNextbutton
            // 
            this.EmployeePageNextbutton.Location = new System.Drawing.Point(200, 262);
            this.EmployeePageNextbutton.Name = "EmployeePageNextbutton";
            this.EmployeePageNextbutton.Size = new System.Drawing.Size(117, 30);
            this.EmployeePageNextbutton.TabIndex = 11;
            this.EmployeePageNextbutton.Text = "Next";
            this.EmployeePageNextbutton.UseVisualStyleBackColor = true;
            // 
            // EmployeePageBackbutton
            // 
            this.EmployeePageBackbutton.Location = new System.Drawing.Point(337, 262);
            this.EmployeePageBackbutton.Name = "EmployeePageBackbutton";
            this.EmployeePageBackbutton.Size = new System.Drawing.Size(117, 30);
            this.EmployeePageBackbutton.TabIndex = 12;
            this.EmployeePageBackbutton.Text = "Back";
            this.EmployeePageBackbutton.UseVisualStyleBackColor = true;
            this.EmployeePageBackbutton.Click += new System.EventHandler(this.EmployeePageBackbutton_Click);
            // 
            // eMSdbDataSet
            // 
            this.eMSdbDataSet.DataSetName = "EMSdbDataSet";
            this.eMSdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.eMSdbDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(440, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 213);
            this.dataGridView1.TabIndex = 13;
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 314);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EmployeePageBackbutton);
            this.Controls.Add(this.EmployeePageNextbutton);
            this.Controls.Add(this.AddEmployeebutton);
            this.Controls.Add(this.EmployeeSalarylabel);
            this.Controls.Add(this.EmployeeSalarytextBox);
            this.Controls.Add(this.EmployeePostlabel);
            this.Controls.Add(this.EmployeePosttextBox);
            this.Controls.Add(this.EmployeeDOBtextBox);
            this.Controls.Add(this.EmployeeDOBlabel);
            this.Controls.Add(this.EmployeeEmailtextBox);
            this.Controls.Add(this.EmployeeEmaillabel);
            this.Controls.Add(this.EmployeeNametextBox);
            this.Controls.Add(this.EmployeeNamelabel);
            this.Name = "EmployeePage";
            this.Text = "EmployeePage";
            this.Load += new System.EventHandler(this.EmployeePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMSdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeNamelabel;
        private System.Windows.Forms.TextBox EmployeeNametextBox;
        private System.Windows.Forms.Label EmployeeEmaillabel;
        private System.Windows.Forms.TextBox EmployeeEmailtextBox;
        private System.Windows.Forms.Label EmployeeDOBlabel;
        private System.Windows.Forms.TextBox EmployeeDOBtextBox;
        private System.Windows.Forms.TextBox EmployeePosttextBox;
        private System.Windows.Forms.Label EmployeePostlabel;
        private System.Windows.Forms.TextBox EmployeeSalarytextBox;
        private System.Windows.Forms.Label EmployeeSalarylabel;
        private System.Windows.Forms.Button AddEmployeebutton;
        private System.Windows.Forms.Button EmployeePageNextbutton;
        private System.Windows.Forms.Button EmployeePageBackbutton;
        private EMSdbDataSet eMSdbDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EMSdbDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
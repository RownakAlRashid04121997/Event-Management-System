﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EMS_project
{
    public partial class EmployeePage : Form
    {
        string _connectionString;
     
         public EmployeePage()
        {
            InitializeComponent();
            _connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Sunan\c#\EMS\Project-101\EMS project\EMS project\EMSdb.mdf;Integrated Security=True;Connect Timeout=30 ";


        }

        private void EmployeePageBackbutton_Click(object sender, EventArgs e)
        {
            AdminPage BackToAdminpage = new AdminPage();
            BackToAdminpage.Show();
            this.Hide();

        }

        private void AddEmployeebutton_Click(object sender, EventArgs e)
        {

            string AddEmployeesql = string.Format("insert into [Employee] ([EmployeeName],[EmployeeEmail],[EmployeeDOB],[EmployeePost],[EmployeeSalary]) Values('{0}','{1}','{2}','{3}','{4}')", EmployeeNametextBox.Text, EmployeeEmailtextBox.Text, EmployeeDOBtextBox.Text, EmployeePosttextBox.Text, EmployeeSalarytextBox.Text);
            SqlConnection AddEmployeecon = new SqlConnection(_connectionString);
            SqlCommand AddEmployeecmd = new SqlCommand(AddEmployeesql, AddEmployeecon);
            DataTable AddEmployeedt = new DataTable();
            AddEmployeecmd.Connection.Open();
            AddEmployeecmd.ExecuteNonQuery();
            MessageBox.Show("Employee added");
            AddEmployeecmd.Connection.Close();
            LoadUserGridData();
   }


        private void EmployeePage_Load(object sender, EventArgs e)
        {
            LoadUserGridData();

        }


        void LoadUserGridData()
        {
            string ConnectionString = _connectionString;
            string sql = string.Format("select * from Employee");
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            DataTable dt = new DataTable();

            sqlCmd.Connection.Open();
            dt.Load(sqlCmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            sqlCmd.Connection.Close();

          }

        private void UpdateEmployeebutton_Click(object sender, EventArgs e)
        {
            string AddEmployeesql = "update Employee set EmployeeEmail='"+EmployeeEmailtextBox.Text+"',EmployeeDOB='"+ EmployeeDOBtextBox.Text+"',EmployeePost='"+EmployeePosttextBox.Text+"',EmployeeSalary='"+EmployeeSalarytextBox.Text+"' where EmployeeName='"+EmployeeNametextBox.Text+"'" ;
            SqlConnection AddEmployeecon = new SqlConnection(_connectionString);
            SqlCommand AddEmployeecmd = new SqlCommand(AddEmployeesql, AddEmployeecon);

            DataTable AddEmployeedt = new DataTable();
            AddEmployeecmd.Connection.Open();
            AddEmployeecmd.ExecuteNonQuery();
            MessageBox.Show("Row updated");
            AddEmployeecmd.Connection.Close();
            LoadUserGridData();

        }

        private void DeleteEmployeebutton_Click(object sender, EventArgs e)
        {
            string AddEmployeesql = "Delete from Employee where EmployeeName='"+EmployeeNametextBox.Text+"'";
            SqlConnection AddEmployeecon = new SqlConnection(_connectionString);
            SqlCommand AddEmployeecmd = new SqlCommand(AddEmployeesql, AddEmployeecon);

            DataTable AddEmployeedt = new DataTable();
            AddEmployeecmd.Connection.Open();
            AddEmployeecmd.ExecuteNonQuery();
            MessageBox.Show("Row deleted");
            AddEmployeecmd.Connection.Close();
            LoadUserGridData();

        }

        private void EmployeePageNextbutton_Click(object sender, EventArgs e)
        {
            NewPage n1 = new NewPage();
            n1.Show();
            this.Hide();
        }

   

    }
}

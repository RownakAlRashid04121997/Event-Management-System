using System;
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
            _connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Sunan\c#\EMS\Project-101\EMS project\EMS project\EMSdb.mdf;Integrated Security=True;Connect Timeout=30";


        }

         DataTable dt;

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
            EmployeecomboBox.Items.Add("EmployeeId");
            EmployeecomboBox.Items.Add("EmployeeName");
            EmployeecomboBox.Items.Add("EmployeeEmail");
            EmployeecomboBox.Items.Add("EmployeeDOB");
            EmployeecomboBox.Items.Add("EmployeePost");
            EmployeecomboBox.Items.Add("EmployeeSalary");

            LoadUserGridData();
            LoadUserGridData1();
            LoadUserGridData2();
            LoadUserGridData3();
            LoadUserGridData4();
            LoadUserGridData5();
            LoadUserGridData6();
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





        void LoadUserGridData1()   
        {
            string ConnectionString = _connectionString;
            string sql = string.Format("Select *from Employee where EmployeeId like '" + EmployeeSearchtextBox.Text + "%'");
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            DataTable dt = new DataTable();

            sqlCmd.Connection.Open();
            dt.Load(sqlCmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            sqlCmd.Connection.Close();

        }



        void LoadUserGridData2()
        {
            string ConnectionString = _connectionString;
            string sql = string.Format("Select *from Employee where EmployeeName like '" + EmployeeSearchtextBox.Text + "%'");
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            DataTable dt = new DataTable();

            sqlCmd.Connection.Open();
            dt.Load(sqlCmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            sqlCmd.Connection.Close();

        }



        void LoadUserGridData3()
        {
            string ConnectionString = _connectionString;
            string sql = string.Format("Select *from Employee where EmployeeEmail like '" + EmployeeSearchtextBox.Text + "%'");
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            DataTable dt = new DataTable();

            sqlCmd.Connection.Open();
            dt.Load(sqlCmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            sqlCmd.Connection.Close();

        }


        void LoadUserGridData4()
        {
            string ConnectionString = _connectionString;
            string sql = string.Format("Select *from Employee where EmployeeDOB like '" + EmployeeSearchtextBox.Text + "%'");
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            DataTable dt = new DataTable();

            sqlCmd.Connection.Open();
            dt.Load(sqlCmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            sqlCmd.Connection.Close();

        }




        void LoadUserGridData5()
        {
            string ConnectionString = _connectionString;
            string sql = string.Format("Select *from Employee where EmployeePost like '" + EmployeeSearchtextBox.Text + "%'");
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            DataTable dt = new DataTable();

            sqlCmd.Connection.Open();
            dt.Load(sqlCmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            sqlCmd.Connection.Close();

        }


        void LoadUserGridData6()
        {
            string ConnectionString = _connectionString;
            string sql = string.Format("Select *from Employee where EmployeeSalary like '" + EmployeeSearchtextBox.Text + "%'");
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

        private void EmployeeSearchtextBox_TextChanged(object sender, EventArgs e)
        {
          
           if (EmployeecomboBox.Text == "EmployeeId")
            {
              
               LoadUserGridData1();
             
             }
            else if (EmployeecomboBox.Text == "EmployeeName")
            {
                LoadUserGridData2();
            }
           else if (EmployeecomboBox.Text == "EmployeeEmail")
           {
               LoadUserGridData3();
           }
           else if (EmployeecomboBox.Text == "EmployeeDOB")
           {
               LoadUserGridData4();
           }
           else if (EmployeecomboBox.Text == "EmployeePost")
           {
               LoadUserGridData5();
           }
           else if (EmployeecomboBox.Text == "EmployeeSalary")
           {
               LoadUserGridData6();
           }


      
        }

        private void EmployeeSearchbutton_Click(object sender, EventArgs e)
        {
            /*if (EmployeecomboBox.Text == "EmployeeName")
            {
                string AddEmployeesql = string.Format("Select * from Employee where EmployeeName like '" + EmployeeSearchtextBox.Text + "%'");
                SqlConnection AddEmployeecon = new SqlConnection(_connectionString);
                SqlCommand AddEmployeecmd = new SqlCommand(AddEmployeesql, AddEmployeecon);
               // DataTable AddEmployeedt = new DataTable();
                AddEmployeecmd.Connection.Open();
                AddEmployeecmd.ExecuteNonQuery();
                // MessageBox.Show("Employee added");
               AddEmployeecmd.Connection.Close();
               dataGridView1.DataSource = dt;
              // LoadUserGridData();

            }*/
        }

   

    }
}

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
    public partial class OrderTable : Form
    {
        string _connectionString;
        

        public OrderTable()
        {
            InitializeComponent();
            _connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Sunan\c#\EMS\Project-101\EMS project\EMS project\EMSdb.mdf;Integrated Security=True;Connect Timeout=30";
        }
        DataTable dt;

        private void OrderTableBackbutton_Click(object sender, EventArgs e)
        {
            AdminPage a1 = new AdminPage();
            a1.Show();
            this.Hide();
        }

          private void OrderTable_Load(object sender, EventArgs e)
        {
           // LoadUserGridData();
          /*  try
            {
                string ConnectionString = _connectionString;
                // string sql = string.Format("SELECT * FROM  Order");
                string sql = string.Format(" SELECT *FROM ORDER");
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlCmd = new SqlCommand(sql, conn);

                DataTable dt = new DataTable();

                sqlCmd.Connection.Open();
                dt.Load(sqlCmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                sqlCmd.Connection.Close();
            }
            catch (Exception E) { }*/
        }
          /*void LoadUserGridData()
          {
              try
              {
                  string ConnectionString = _connectionString;
                  // string sql = string.Format("SELECT * FROM  Order");
                  string sql = string.Format("Select *from Order");
                  SqlConnection conn = new SqlConnection(ConnectionString);
                  SqlCommand sqlCmd = new SqlCommand(sql, conn);

                  DataTable dt = new DataTable();

                  sqlCmd.Connection.Open();
                  dt.Load(sqlCmd.ExecuteReader());
                  dataGridView1.DataSource = dt;
                  sqlCmd.Connection.Close();
              }
              catch (Exception E) { }
             

          }*/

    }
}

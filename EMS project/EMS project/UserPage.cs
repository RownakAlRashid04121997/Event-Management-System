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
    public partial class UserPage : Form
    {
        public string UserId;
        public string USERNAME1= UserClass.UserName;
        LoginForm Userpage;
      // string _connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Sunan\c#\EMS\Project-101\EMS project\EMS project\EMSdb.mdf;Integrated Security=True;Connect Timeout=30";

        public UserPage(string UserId,string USERNAME1,LoginForm Userpage)
        {
            InitializeComponent();
            this.UserId = UserId;
            this.USERNAME1 =USERNAME1 ;
            this.Userpage = Userpage;
        }




        private void UserPageBackbutton_Click(object sender, EventArgs e)
        {
            LoginForm UserBack = new LoginForm();
            UserBack.Show();
            this.Close();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
           WelcomeUserlabel.Text = UserClass.UserName ;


           comboBox1.Items.Add("Birthday");
           comboBox1.Items.Add("Wedding");
           comboBox1.Items.Add("Reception");
           comboBox1.Items.Add("Engagement");
           comboBox1.Items.Add("Party");



            Instrument1ElementcomboBox.Items.Add("1");
            Instrument1ElementcomboBox.Items.Add("2");
            Instrument1ElementcomboBox.Items.Add("3");
            Instrument1ElementcomboBox.Items.Add("4");
            Instrument1ElementcomboBox.Items.Add("5");
            Instrument1ElementcomboBox.Items.Add("6");



            Instrument2ElementcomboBox.Items.Add("1");
            Instrument2ElementcomboBox.Items.Add("2");
            Instrument2ElementcomboBox.Items.Add("3");
            Instrument2ElementcomboBox.Items.Add("4");
            Instrument2ElementcomboBox.Items.Add("5");
            Instrument2ElementcomboBox.Items.Add("6");



            Instrument3ElementcomboBox.Items.Add("1");
            Instrument3ElementcomboBox.Items.Add("2");
            Instrument3ElementcomboBox.Items.Add("3");
            Instrument3ElementcomboBox.Items.Add("4");
            Instrument3ElementcomboBox.Items.Add("5");
            Instrument3ElementcomboBox.Items.Add("6");



            Instrument4ElementcomboBox.Items.Add("1");
            Instrument4ElementcomboBox.Items.Add("2");
            Instrument4ElementcomboBox.Items.Add("3");
            Instrument4ElementcomboBox.Items.Add("4");
            Instrument4ElementcomboBox.Items.Add("5");
            Instrument4ElementcomboBox.Items.Add("6");


            Instrument5ElementcomboBox.Items.Add("1");
            Instrument5ElementcomboBox.Items.Add("2");
            Instrument5ElementcomboBox.Items.Add("3");
            Instrument5ElementcomboBox.Items.Add("4");
            Instrument5ElementcomboBox.Items.Add("5");
            Instrument5ElementcomboBox.Items.Add("6");





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlaceOrderbutton_Click(object sender, EventArgs e)
        {

            OrderUserIdtextBox.Text = UserId;
           string Connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Sunan\c#\EMS\Project-101\EMS project\EMS project\EMSdb.mdf;Integrated Security=True;Connect Timeout=30";
           string sql1 = string.Format("insert into [Order] ([OrderUserId],[EventType],[EventName],[EventDate],[Instrument1 ammount],[Instrument2 ammount],[Instrument3 ammount],[Instrument4 ammount],[Instrument5 ammount],[UserVenue]) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", OrderUserIdtextBox.Text, comboBox1.Text, EventNametextBox.Text, EventDatetextBox.Text, Instrument1ElementcomboBox.Text, Instrument2ElementcomboBox.Text, Instrument3ElementcomboBox.Text, Instrument4ElementcomboBox.Text, Instrument5ElementcomboBox.Text, VenuetextBox.Text);
            SqlConnection con1 = new SqlConnection(Connection);
            SqlCommand cmd1 = new SqlCommand(sql1, con1);

            DataTable dt2 = new DataTable();
            cmd1.Connection.Open();
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Ordered Successfully");

            cmd1.Connection.Close();
        }

        private void UpdateOrderbutton_Click(object sender, EventArgs e)
        {

         //  OrderUserIdtextBox.Text = UserId;
         //  string Connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Sunan\c#\EMS\Project-101\EMS project\EMS project\EMSdb.mdf;Integrated Security=True;Connect Timeout=30";
          // string _connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Sunan\c#\EMS\Project-101\EMS project\EMS project\EMSdb.mdf;Integrated Security=True;Connect Timeout=30";
        //   string sql1 = "update table Order  set EventType='" + comboBox1.Text + "',EventName='" + EventNametextBox.Text + "',EventDate='" + EventDatetextBox.Text + "',Instrument1 ammount='" + Instrument1ElementcomboBox.Text + "',Instrument2 ammount='" + Instrument2ElementcomboBox.Text + "',Instrument3 ammount='" + Instrument3ElementcomboBox.Text + "',Instrument4 ammount='" + Instrument4ElementcomboBox.Text + "',Instrument5 ammount='" + Instrument5ElementcomboBox.Text + "',UserVenue='" + VenuetextBox.Text + "' where OrderUserId='" + OrderUserIdtextBox.Text + "'";
           // string AddEmployeesql="UPDATE Order set EventType=comboBox1.Text"
           //SqlConnection UpdateOrdercon = new SqlConnection(_connectionString);
           //SqlCommand UpdateOrdercmd = new SqlCommand(UpdateOrdersql, UpdateOrdercon);

          // DataTable UpdateOrderdt = new DataTable();
          // UpdateOrdercmd.Connection.Open();
          // UpdateOrdercmd.ExecuteNonQuery();
          // MessageBox.Show("Order updated");
          // UpdateOrdercmd.Connection.Close();
           //LoadUserGridData();


        /*   SqlConnection con1 = new SqlConnection(Connection);
           SqlCommand cmd1 = new SqlCommand(sql1, con1);

           DataTable dt2 = new DataTable();
           cmd1.Connection.Open();
           cmd1.ExecuteNonQuery();
           MessageBox.Show("Updated Successfully");

           cmd1.Connection.Close();*/
            try
            {
                OrderUserIdtextBox.Text = UserId;
                string Connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Sunan\c#\EMS\Project-101\EMS project\EMS project\EMSdb.mdf;Integrated Security=True;Connect Timeout=30";
                string sql1 = "Update [dbo].[Order] set EventType='" + this.comboBox1.Text + "',EventName='" + this.EventNametextBox.Text + "',EventDate='" + this.EventDatetextBox.Text + "',Instrument1 ammount='" + this.Instrument1ElementcomboBox.Text + "',Instrument2 ammount='" + this.Instrument2ElementcomboBox.Text + "',Instrument3 ammount='" + this.Instrument3ElementcomboBox.Text + "',Instrument4 ammount='" + this.Instrument4ElementcomboBox.Text + "',Instrument5 ammount='" + this.Instrument5ElementcomboBox.Text + "',UserVenue='" + this.VenuetextBox.Text + "' where OrderUserId='" + this.OrderUserIdtextBox.Text + "'";
                SqlConnection con1 = new SqlConnection(Connection);
                SqlCommand cmd1 = new SqlCommand(sql1, con1);

                DataTable dt2 = new DataTable();
                cmd1.Connection.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");

                cmd1.Connection.Close();
            }
            catch (Exception E) { MessageBox.Show(E.Message); }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string _connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Sunan\c#\EMS\Project-101\EMS project\EMS project\EMSdb.mdf;Integrated Security=True;Connect Timeout=30";
                string AddEmployeesql = "Delete * from  [dbo].[Order] where OrderUserId='" + OrderUserIdtextBox.Text + "'";
                SqlConnection AddEmployeecon = new SqlConnection(_connectionString);
                SqlCommand AddEmployeecmd = new SqlCommand(AddEmployeesql, AddEmployeecon);

                DataTable AddEmployeedt = new DataTable();
                AddEmployeecmd.Connection.Open();
                AddEmployeecmd.ExecuteNonQuery();
                MessageBox.Show("Order deleted");
                AddEmployeecmd.Connection.Close();
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
            
        }
    }
}

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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            UserSignIn u1 = new UserSignIn();
            u1.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string LogInConnection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Chowdhury\Documents\GitHub\Project-101\EMS project\EMS project\EMSdb.mdf;Integrated Security=True;Connect Timeout=30";
            string LogInsql = "select Id,Username,Password " + " from LoginForm where UserName = '" + UserNameTextbox.Text + "' and Password = '" + PasswordTextbox.Text + "'";
            SqlConnection LogInconn = new SqlConnection(LogInConnection);
            SqlCommand LogIncmd = new SqlCommand(LogInsql, LogInconn);
            DataTable dt2 = new DataTable();
            LogIncmd.Connection.Open();
            dt2.Load(LogIncmd.ExecuteReader());

            if (dt2.Rows.Count > 0)
            {
                MessageBox.Show("logged successful");

                if (dt2.Rows[0][0].ToString() == 1.ToString())
                {
                    MessageBox.Show("Logged in as admin");
                    AdminPage a1 = new AdminPage(dt2.Rows[0][0].ToString(), UserNameTextbox.Text,this);
                    AdminClass.AdminName = UserNameTextbox.Text;
                    a1.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Logged in as user");
                    UserPage u1 = new UserPage(dt2.Rows[0][0].ToString(), UserNameTextbox.Text,this);
                    UserClass.UserName = UserNameTextbox.Text;
                    u1.Show();
                    this.Hide();

                }
           

            }
            else
            {
                MessageBox.Show("Please check connection");
            }

            LogIncmd.Connection.Close();


        }
    }
}

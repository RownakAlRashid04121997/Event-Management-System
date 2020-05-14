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
    public partial class UserSignIn : Form
    {
        public UserSignIn()
        {
            InitializeComponent();
        }

        private void SignInPasswordLebel_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccountbutton_Click(object sender, EventArgs e)
        {
            string SignInConnection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Chowdhury\Documents\GitHub\Project-101\EMS project\EMS project\EMSdb.mdf;Integrated Security=True;Connect Timeout=30";
            string LogInsql = string.Format("insert into [LoginForm] ([Password],[Email],[Username]) Values('{0}','{1}','{2}')", SignInPasswordtextBox.Text, SignInEmailtextBox.Text, SignInUserNameTextbox.Text) ;
            SqlConnection SignIncon = new SqlConnection(SignInConnection);
            SqlCommand SignIncmd = new SqlCommand(LogInsql, SignIncon) ;

            DataTable dt1 = new DataTable();
            SignIncmd.Connection.Open();
            SignIncmd.ExecuteNonQuery();
            MessageBox.Show("Account created");

            LoginForm l1 = new LoginForm();
            l1.Show();
            SignIncmd.Connection.Close();
            this.Hide();
        }
    }
}

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
        string SignInConnection1 = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Sunan\c#\EMS\Project-101\EMS project\EMS project\EMSdb.mdfIntegrated Security=True;Connect Timeout=30";
        public UserSignIn()
        {
            InitializeComponent();
         }

        private void SignInPasswordLebel_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccountbutton_Click(object sender, EventArgs e)
        {
            //string SignInConnection1 = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Sunan\c#\EMS\Project-101\EMS project\EMS project\EMSdb.mdfIntegrated Security=True;Connect Timeout=30";
            //string LogInsql1 = string.Format("insert into [LoginForm] ([Password],[Email],[Username]) Values('{0}','{1}','{2}')", SignInPasswordtextBox.Text, SignInEmailtextBox.Text, SignInUserNameTextbox.Text) ;

            //string LogInsql1 = string.Format("insert into [LoginForm] ([Password],[Email],[Username]) Values('{0}','{1}','{2}')", SignInPasswordtextBox.Text, SignInEmailtextBox.Text, SignInUserNameTextbox.Text);

            string LogInsql1 = string.Format("insert into LoginForm (Password,Email,Username) Values('{0}','{1}','{2}')", SignInPasswordtextBox.Text, SignInEmailtextBox.Text, SignInUserNameTextbox.Text);
            SqlConnection SignIncon1 = new SqlConnection(SignInConnection1);
            SqlCommand SignIncmd1 = new SqlCommand(LogInsql1, SignIncon1) ;

            DataTable dt1 = new DataTable();

            SignIncmd1.Connection.Open();
            SignIncmd1.ExecuteNonQuery();
            MessageBox.Show("Account created");

            LoginForm l1 = new LoginForm();
            l1.Show();
            SignIncmd1.Connection.Close();
            this.Hide();
        }
    }
}

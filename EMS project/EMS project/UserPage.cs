using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_project
{
    public partial class UserPage : Form
    {
        public string UserId;
        public string USERNAME1= UserClass.UserName;
        LoginForm Userpage;

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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

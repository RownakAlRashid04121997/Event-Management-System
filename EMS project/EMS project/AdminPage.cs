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
    public partial class AdminPage : Form
    {
        public string AdminId;
        public string ADMINNAME1 = AdminClass.AdminName;
        LoginForm Adminpage;

        public AdminPage(string AdminId,string ADMINNAME1,LoginForm Adminpage)
        {
            InitializeComponent();

            this.AdminId = AdminId;
            this.ADMINNAME1 = ADMINNAME1;
            this.Adminpage = Adminpage;
        
        }




        private void AdminPageBackbutton_Click(object sender, EventArgs e)
        {
            LoginForm AdminBack = new LoginForm();
            AdminBack.Show();
            this.Close();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            WelcomeAdminlabel.Text = AdminClass.AdminName;
        }
        }
    }


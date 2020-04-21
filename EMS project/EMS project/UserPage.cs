﻿using System;
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
        LoginForm Userpage;

        public UserPage(string UserId,LoginForm Userpage)
        {
            InitializeComponent();
            this.UserId = UserId;
            this.Userpage = Userpage;
        }




        private void UserPageBackbutton_Click(object sender, EventArgs e)
        {
            LoginForm UserBack = new LoginForm();
            UserBack.Show();
            this.Close();
        }
    }
}

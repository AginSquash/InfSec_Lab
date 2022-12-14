﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfSec_Lab
{
    public partial class UsersList : Form
    {
        public List<UserJSON> Users = new List<UserJSON>();
        public UsersList()
        {
            InitializeComponent();
            Users = IODriver.ReadUsersData();
            updateUserList();
        }

        public void updateUserList()
        {
            foreach (var user in Users)
            {
                usersListBox.Items.Add(user.Login);
            }
        }

        private void openUserProfile_Click(object sender, EventArgs e)
        {

        }
    }
}

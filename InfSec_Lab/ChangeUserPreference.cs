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
    public partial class ChangeUserPreference : Form
    {
        UserJSON Users = new UserJSON();
        public ChangeUserPreference(UserJSON user)
        {
            InitializeComponent();
            username.Text = user.Login;
            passwordRestriction.Checked = user.passwordRestriction;
            isBlocked.Checked = user.isBlocked;
        }

        private void SaveUserPrefButton_Click(object sender, EventArgs e)
        {

        }
    }
}

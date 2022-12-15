using System;
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
        UserJSON currentUser = new UserJSON();
        public ChangeUserPreference(UserJSON user)
        {
            InitializeComponent();
            username.Text = user.Login;
            passwordRestriction.Checked = user.passwordRestriction;
            isBlocked.Checked = user.isBlocked;
            currentUser = user;
        }

        private void SaveUserPrefButton_Click(object sender, EventArgs e)
        {
            List<UserJSON> Users = IODriver.ReadUsersData();
            int index = Users.FindIndex(item => (item.Login == currentUser.Login));
            Users[index].Login = username.Text; // ?
            Users[index].passwordRestriction = passwordRestriction.Checked;
            Users[index].isBlocked = isBlocked.Checked;
            IODriver.WriteUsersData(Users);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordRestriction_CheckedChanged(object sender, EventArgs e)
        {
            fillPassRestBox(passwordRestriction.Checked);
        }

        private void fillPassRestBox(bool isCheked)
        {
            String text = "Ограничение на пароль:\n";
            if (isCheked)
            {
                passRestBox.Text = text + "Наличие букв и знаков препинания.";
            }
            else
            {
                passRestBox.Text = text + "не заданны.";
            }
        }
    }
}

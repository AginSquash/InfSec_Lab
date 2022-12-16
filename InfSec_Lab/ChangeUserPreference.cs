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

            MessageBox.Show("Настройки сохранены", "Ok");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

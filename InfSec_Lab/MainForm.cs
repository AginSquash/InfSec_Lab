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
    public partial class MainForm : Form
    {
        public UserJSON currentUser = new UserJSON();

        public MainForm(List<UserJSON> UsersAll, UserJSON CurrentUser)
        {
            InitializeComponent();
            currentUser = CurrentUser;
            if (currentUser.Login != "ADMIN")
            {
                UsersToolStripMenuItem.DropDownItems[1].Enabled = false;
                UsersToolStripMenuItem.DropDownItems[2].Enabled = false;
            }
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void changePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassForm cpf = new ChangePassForm(currentUser); //this is the change, code for redirect  
            cpf.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersList usersList = new UsersList();
            usersList.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }
    }
}

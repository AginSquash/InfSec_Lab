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

        public MainForm()
        {
            InitializeComponent();
            if (currentUser.Login != "ADMIN")
            {
                UsersToolStripMenuItem.DropDownItems[1].Enabled = false;
                UsersToolStripMenuItem.DropDownItems[2].Enabled = false;
            }

            if (currentUser.Login == "")
            {
                UsersToolStripMenuItem.DropDownItems[0].Enabled = false;
                UsersToolStripMenuItem.DropDownItems[1].Enabled = false;
                UsersToolStripMenuItem.DropDownItems[2].Enabled = false;
                UsersToolStripMenuItem.DropDownItems[3].Enabled = false;
            }
        }

        public void updateUserToolStrip()
        {
            if (currentUser.Login == "ADMIN")
            {
                UsersToolStripMenuItem.DropDownItems[0].Enabled = true;
                UsersToolStripMenuItem.DropDownItems[1].Enabled = true;
                UsersToolStripMenuItem.DropDownItems[2].Enabled = true;
                UsersToolStripMenuItem.DropDownItems[3].Enabled = true;

                return;
            }

            UsersToolStripMenuItem.DropDownItems[1].Enabled = false;
            UsersToolStripMenuItem.DropDownItems[2].Enabled = false;

            if (currentUser.Login == "")
            {
                UsersToolStripMenuItem.DropDownItems[0].Enabled = false;
                UsersToolStripMenuItem.DropDownItems[3].Enabled = false;
            } else
            {
                UsersToolStripMenuItem.DropDownItems[0].Enabled = true;
                UsersToolStripMenuItem.DropDownItems[3].Enabled = true;
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
            currentUser = new UserJSON();
            logonButton.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            if (currentUser.Login != "ADMIN")
            {
                UsersToolStripMenuItem.DropDownItems[1].Enabled = false;
                UsersToolStripMenuItem.DropDownItems[2].Enabled = false;
            }
            af.ShowDialog();
        }

        private void logonButton_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Owner = this;
            lf.ShowDialog();

            if (currentUser.Login != "")
            {
                logonButton.Hide();
            }
        }
    }
}

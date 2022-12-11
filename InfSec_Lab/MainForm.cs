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
        public List<UserJSON> Users = new List<UserJSON>();
        public UserJSON currentUser = new UserJSON();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void changePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassForm cpf = new ChangePassForm(); //this is the change, code for redirect  
            cpf.user = currentUser;
            cpf.allusersjson = Users;
            cpf.ShowDialog();
        }
    }
}

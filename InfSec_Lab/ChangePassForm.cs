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
    public partial class ChangePassForm : Form
    {
        public UserJSON user = new UserJSON();
        public List<UserJSON> Users = new List<UserJSON>();
        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
             if (user.Password == oldPass.Text)
            {
                if (newPass.Text == newPass2.Text)
                {
                    Users.Remove(user);
                    user.Password = newPass.Text;
                    Users.Add(user);


                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InfSec_Lab
{
    public partial class PassEnterForm : Form
    {
        public static String pass = "";
        public PassEnterForm()
        {
            InitializeComponent();

        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string curFile = "users.json";
            string pass = passTextBox.Text;
            PassEnterForm.pass = pass;
            if (!File.Exists(curFile))
            {
                Console.WriteLine("Cannot found users.json. Creating...");
                UserJSON admin = new UserJSON("ADMIN");
                List<UserJSON> Users = new List<UserJSON>();
                Users.Add(admin);
                IODriver.WriteUsersData(Users);

                MainForm mf = new MainForm();
                this.Hide();
                mf.ShowDialog();
                
            }
            else
            {
                Console.WriteLine("users.json founded");
                List<UserJSON> Users = IODriver.ReadUsersData();
                if (Users.Count > 0) 
                {
                    MainForm mf = new MainForm();
                    this.Hide();
                    mf.ShowDialog();
                } else
                {
                    MessageBox.Show("Неверный пароль", "login error");
                }
                
            }
        }

        private void PassEnterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

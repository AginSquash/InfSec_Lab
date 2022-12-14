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
using Newtonsoft.Json;

namespace InfSec_Lab
{
    public partial class LoginForm : Form
    {

        List<UserJSON> Users = new List<UserJSON>();

        public LoginForm()
        {
            InitializeComponent();

            string curFile = "users.json";
            if (!File.Exists(curFile))
            {
                Console.WriteLine("Cannot found users.json. Creating...");
                UserJSON admin = new UserJSON("ADMIN");
                Users.Add(admin);
                IODriver.WriteUsersData(Users);
            } else
            {
                Console.WriteLine("users.json founded");
                Users = IODriver.ReadUsersData();
            }
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string pass = passwordTextBox.Text;

            UserJSON entered = new UserJSON(login, pass);
            if (Users.Exists( item => (item.Login == login) && (item.Password == pass)))
            {
                Console.WriteLine("Successful");

                MainForm ms = new MainForm(); //this is the change, code for redirect  
                ms.Users = this.Users;
                ms.currentUser = new UserJSON(login, pass);
                this.Hide();
                ms.ShowDialog();
                this.Close();

            } else
            {
                Console.WriteLine("Error");
                MessageBox.Show("Duplicate username and password", "login page");
            }
      
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

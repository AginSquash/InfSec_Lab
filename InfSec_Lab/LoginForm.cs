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
                AllUsersJson users = new AllUsersJson(admin);
                string json = JsonConvert.SerializeObject(users);
                using (StreamWriter writer = new StreamWriter(curFile, false))
                {
                    writer.WriteLineAsync(json);
                }

                Users.Add(admin);
            } else
            {
                Console.WriteLine("users.json founded");
                using (StreamReader reader = new StreamReader(curFile))
                {
                    string json = reader.ReadToEnd();
                    Console.WriteLine(json);
                    AllUsersJson restoredAllUsers = JsonConvert.DeserializeObject<AllUsersJson>(json);
                    Users = restoredAllUsers.UsersData;
                }
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

                //this.Close();
                MainForm ms = new MainForm(); //this is the change, code for redirect  
                ms.Users = this.Users;
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

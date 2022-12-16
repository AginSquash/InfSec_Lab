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
        public PassEnterForm()
        {
            InitializeComponent();

        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string curFile = "users.json";
            string pass = passTextBox.Text;
            if (!File.Exists(curFile))
            {
                Console.WriteLine("Cannot found users.json. Creating...");
                UserJSON admin = new UserJSON("ADMIN");
                List<UserJSON> Users = new List<UserJSON>();
                Users.Add(admin);
                IODriver.WriteUsersData(Users, pass);

               // LoginForm lf = new LoginForm();
                
            }
            else
            {
                Console.WriteLine("users.json founded");
                List<UserJSON> Users = IODriver.ReadUsersData(pass);
                if (Users.Count > 0) 
                {

                }
                //Users = IODriver.ReadUsersData();
            }
        }
    }
}

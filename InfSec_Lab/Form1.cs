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
using System.Text.Json;

namespace InfSec_Lab
{
    public partial class Form1 : Form
    {

        List<UserJSON> Users = new List<UserJSON>();

        public Form1()
        {
            InitializeComponent();

            string curFile = "users.txt";
            if (!File.Exists(curFile))
            {
                UserJSON admin = new UserJSON("ADMIN");
                AllUsersJson users = new AllUsersJson(admin);
                string json = JsonSerializer.Serialize(users);
                Console.WriteLine("Cannot found users.json. Creating...");
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
                    AllUsersJson? restoredAllUsers = JsonSerializer.Deserialize<AllUsersJson>(json);
                    Users = restoredAllUsers.UserData;
                }
            }
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string curFile = "users.txt";
            if (!File.Exists(curFile))
            {
                UserJSON admin = new UserJSON("ADMIN");
                AllUsersJson users = new AllUsersJson(admin);
                string json = JsonSerializer.Serialize(users);
                Console.WriteLine(json);
                using (StreamWriter writer = new StreamWriter(curFile, false))
                {
                    writer.WriteLineAsync(json);
                }
            } else
            {
                Console.WriteLine("Exist");
            }
        }
    }
}

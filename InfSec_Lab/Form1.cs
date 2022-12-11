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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace InfSec_Lab
{
    public partial class Form1 : Form
    {

        List<UserJSON> Users = new List<UserJSON>();

        public Form1()
        {
            InitializeComponent();

            string curFile = "users.json";
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(AllUsersJson));
            if (!File.Exists(curFile))
            {
                Console.WriteLine("Cannot found users.json. Creating...");
                UserJSON admin = new UserJSON("ADMIN");
                AllUsersJson users = new AllUsersJson(admin);
                using (FileStream fs = new FileStream(curFile, FileMode.OpenOrCreate))
                {
                    // сериализация (сохранение объекта в поток) 
                    formatter.WriteObject(fs, users);
                }

                Users.Add(admin);
            } else
            {
                Console.WriteLine("users.json founded");
                using (FileStream fs = new FileStream(curFile, FileMode.OpenOrCreate))
                {
                    // десериализация (создание объекта из потока) 
                    AllUsersJson allUsersJson = (AllUsersJson)formatter.ReadObject(fs);
                    Users = allUsersJson.UserData;
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

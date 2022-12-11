using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace InfSec_Lab
{
    class IODriver
    {
        static string curFile = "users.json";
        static public void WriteUsersData(List<UserJSON> users)
        {
            AllUsersJson allUsersJson = new AllUsersJson(users);
            string json = JsonConvert.SerializeObject(users);
            using (StreamWriter writer = new StreamWriter(curFile, false))
            {
                writer.WriteLineAsync(json);
            }
        }

        static public List<UserJSON> ReadUsersData()
        {
            using (StreamReader reader = new StreamReader(curFile))
            {
                string json = reader.ReadToEnd();
                Console.WriteLine(json);
                AllUsersJson restoredAllUsers = JsonConvert.DeserializeObject<AllUsersJson>(json);
                List<UserJSON> Users = restoredAllUsers.UsersData;
                return Users;
            }
        }
    }
}

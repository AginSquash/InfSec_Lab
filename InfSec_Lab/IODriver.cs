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
            users.Sort();
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
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
                List<UserJSON> Users = JsonConvert.DeserializeObject<List<UserJSON>>(json);
                return Users;
            }
        }
    }
}

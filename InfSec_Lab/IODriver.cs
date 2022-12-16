using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;
using SpritzDotNet;
using System.Globalization;

namespace InfSec_Lab
{
    class IODriver
    {
        static string curFile = "users.json";
        static public void WriteUsersData(List<UserJSON> users)
        {
            users.Sort();
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            byte[] plaintext = Encoding.ASCII.GetBytes(json);
            byte[] key = Encoding.ASCII.GetBytes(PassEnterForm.pass);
            byte[] ciphertext = Spritz.Encrypt(plaintext, key);
            try
            {
                using (var fs = new FileStream(curFile, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(ciphertext, 0, ciphertext.Length);
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return;
            }
        }

        static public List<UserJSON> ReadUsersData()
        {
            using (StreamReader reader = new StreamReader(curFile))
            {
                byte[] json = File.ReadAllBytes(curFile); 
                byte[] key = Encoding.ASCII.GetBytes(PassEnterForm.pass);
                byte[] cleartext = Spritz.Decrypt(json, key);
                String decoded = Encoding.ASCII.GetString(cleartext); 
                Console.WriteLine(decoded);
                try
                {
                    List<UserJSON> Users = JsonConvert.DeserializeObject<List<UserJSON>>(decoded);
                    return Users;
                } catch
                {
                    List<UserJSON> Users = new List<UserJSON>();
                    return Users;
                }
            }
        }

        private static string ReadAllBytes()
        {
            throw new NotImplementedException();
        }


    }
}

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
            byte[] key = Encoding.ASCII.GetBytes("secret key");
            byte[] ciphertext = Spritz.Encrypt(plaintext, key);
            String encoded = Bin2Hex(ciphertext);
            using (StreamWriter writer = new StreamWriter(curFile, false))
            {
                writer.WriteLineAsync(encoded);
            }
        }

        static public List<UserJSON> ReadUsersData()
        {
            using (StreamReader reader = new StreamReader(curFile))
            {
                string json = reader.ReadToEnd();
                Console.WriteLine(json);

                byte[] encoded = Hex2Bin(json);
                byte[] key = Encoding.ASCII.GetBytes("secret key");
                byte[] cleartext = Spritz.Decrypt(encoded, key);
                String decoded = Encoding.ASCII.GetString(cleartext); 
                Console.WriteLine(decoded);
                List<UserJSON> Users = JsonConvert.DeserializeObject<List<UserJSON>>(decoded);
                return Users;
            }
        }

        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            // Create an Rijndael object
            // with the specified key and IV.
            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Rijndael object
            // with the specified key and IV.
            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        private static byte[] Hex2Bin(string hex)
        {
            if ((hex == null) || (hex.Length < 1))
            {
                return new byte[0];
            }
            int num = hex.Length / 2;
            byte[] buffer = new byte[num];
            num *= 2;
            for (int i = 0; i < num; i++)
            {
                int num3 = int.Parse(hex.Substring(i, 2), NumberStyles.HexNumber);
                buffer[i / 2] = (byte)num3;
                i++;
            }
            return buffer;
        }

        private static string Bin2Hex(byte[] binary)
        {
            StringBuilder builder = new StringBuilder();
            foreach (byte num in binary)
            {
                if (num > 15)
                {
                    builder.AppendFormat("{0:X}", num);
                }
                else
                {
                    builder.AppendFormat("0{0:X}", num); 
                }
            }
            return builder.ToString();
        }
    }
}

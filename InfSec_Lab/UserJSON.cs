using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InfSec_Lab
{

    public class UserJSON
    {
        public string Login { get; set; }
        public string Password { get; set; }

        [JsonConstructor]
        public UserJSON(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public UserJSON(string login)
        {
            Login = login;
            Password = "";
        }

        public UserJSON()
        {
            Login = "";
            Password = "";
        }
    }


    public class AllUsersJson
    {
        public List<UserJSON> UsersData { get; set; }

        public AllUsersJson(UserJSON userJSON)
        {
            UsersData = new List<UserJSON>();
            UsersData.Add(userJSON);
        }

        public AllUsersJson(List<UserJSON> usersJSON)
        {
            UsersData = usersJSON;
        }

        public AllUsersJson()
        {
            UsersData = new List<UserJSON>();
        }
    }
}

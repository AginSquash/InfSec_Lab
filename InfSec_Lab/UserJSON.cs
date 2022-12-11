using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace InfSec_Lab
{
    public class UserJSON
    {
        public string Login { get; set; }
        public string Password { get; set; }

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
    }

    public class AllUsersJson
    {
        public List<UserJSON> UserData { get; set; }

        public AllUsersJson(UserJSON userJSON)
        {
            UserData = new List<UserJSON>();
            UserData.Add(userJSON);
        }

        public AllUsersJson(List<UserJSON> usersJSON)
        {
            UserData = usersJSON;
        }
    }
}

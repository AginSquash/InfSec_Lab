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
        public bool passwordRestriction { get; set; }
        public bool isLocked { get; set; }


        [JsonConstructor]
        public UserJSON(string login, string password, bool passRestriction = false)
        {
            Login = login;
            Password = password;
            passwordRestriction = passRestriction;
            isLocked = false;
        }

        public UserJSON(string login, bool passRestriction)
        {
            Login = login;
            Password = "";
            passwordRestriction = passRestriction;
            isLocked = false;
        }

        public UserJSON(string login)
        {
            Login = login;
            Password = "";
            passwordRestriction = false;
            isLocked = false;
        }

        public UserJSON()
        {
            Login = "";
            Password = "";
            passwordRestriction = false;
            isLocked = false;
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

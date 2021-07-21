using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._5___Zadanie
{
    class User
    {
        public static List<User> users = new List<User>();
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string Name, string Password)
        {
            this.Login = Name;
            this.Password = Password;
        }

        public static void AddUser(User user)
        {
            users.Add(user);
        }
    }
}

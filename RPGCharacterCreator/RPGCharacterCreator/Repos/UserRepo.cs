using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGCharacterCreator.Models;

namespace RPGCharacterCreator.Repos
{
    public class UserRepo : IUserRepo
    {
        private static List<User> users = new List<User>();

        public List<User> Users => users;

        public void AddUser(User user) => users.Add(user);

        public bool CheckForUserByUserName(string userName)
        {
            if (users.Contains(GetUserByUserName(userName)))
            {
                return true;
            }
            else
                return false;
        }

        public User GetUSerByEmail(string email)
        {
            User user = users.Find(u => u.Email == email);
            return user;
        }

        public User GetUserByName(string name)
        {
            User user = users.Find(u => u.Name == name);
            return user;
        }

        public User GetUserByUserName(string userName)
        {
            User user = users.Find(u => u.UserName == userName);
            return user;
        }

        public void AddTestData()
        {
            User user = new User()
            {
                Email = "Sandra.Heart@gmail.com",
                Name = "Sandra Heart",
                UserName = "SheartsJ",
                Password = "thisisaBADpassword"
            };
            users.Add(user);

            user = new User()
            {
                Email = "P.Andrew.Grey@yahoo.com",
                Name = "Phillip Grey",
                UserName = "philgrey",
                Password = "lifeisPrettyGrey"
            };
            users.Add(user);
        }
    }
}

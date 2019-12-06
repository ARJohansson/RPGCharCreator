using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGCharacterCreator.Models;

namespace RPGCharacterCreator.Repos
{
    public interface IUserRepo
    {
        List<User> Users { get; }
        void AddUser(User user);
        bool CheckForUserByUserName(string userName);
        User GetUserByName(string name);
        User GetUserByUserName(string userName);
        User GetUSerByEmail(string email);
        void AddTestData();
    }
}

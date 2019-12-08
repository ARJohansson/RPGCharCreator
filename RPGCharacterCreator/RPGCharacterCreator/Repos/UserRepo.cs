using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGCharacterCreator.Models;
using Microsoft.EntityFrameworkCore;

namespace RPGCharacterCreator.Repos
{
    public class UserRepo : IUserRepo
    {
        private AppDbContext context;
        public List<User> Users { get { return context.Users.Include("Characters").ToList(); } }
        
        public UserRepo(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void AddCharacter(User user, Character c)
        {
            user.Characters.Add(c);
            context.Users.Update(user);
            context.SaveChanges();
        }

        public bool CheckForUserByUserName(string userName)
        {
            for (int i = 0; i < context.Users.Count(); i++)
            {
                if (Users[i].UserName == userName)
                {
                    return true;
                }
            }
            return false;
        }

        public User GetUserByEmail(string email)
        {
            User user;
            user = context.Users.First(u => u.Email == email);
            return user;
        }

        public User GetUserByName(string name)
        {
            User user;
            user = context.Users.First(u => u.Name == name);
            return user;
        }

        public User GetUserByUserName(string userName)
        {
            User user;
            user = context.Users.First(u => u.UserName == userName);
            return user;
        }        
    }
}

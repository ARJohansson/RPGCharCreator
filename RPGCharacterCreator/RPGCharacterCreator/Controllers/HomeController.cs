using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using RPGCharacterCreator.Models;
using RPGCharacterCreator.Repos;

namespace RPGCharacterCreator.Controllers
{
    public class HomeController : Controller
    {
        IUserRepo uRepo;
        ICharacterRepo cRepo;
        IAbilityRepo aRepo;
        Ability ability;

        public HomeController(IUserRepo uR, ICharacterRepo cR)
        {
            uRepo = uR;
            cRepo = cR;
        }

        // Returns the view from the Index page
        [HttpGet]
        public ViewResult Index()
        {
            return View("Index");
        }
        // Returns a view containing a username/user value
        [HttpPost]
        public IActionResult Index(string searchText)
        {
            var possibleUsers = (from User u in uRepo.Users
                         where u.UserName.Contains(searchText)
                         select u).ToList();
            return View("Users", possibleUsers);
        }

        [HttpGet]
        public IActionResult Users(string possibleUsers)
        {
            IEnumerable<User> users = (from User u in uRepo.Users
                                       where u.UserName == possibleUsers
                                       select u).ToList();
            return View(users);
        }
        
        // Returns the view from the Sign Up page
        public IActionResult SignUp()
        {
            return View("SignUp");
        }

        // Sends the User from the SignIn/SignUp page to their User Page
        [HttpPost]
        public RedirectToActionResult SignUp(string email, string userName, 
                                                string password, string name)
        {
            User user;
            if (!uRepo.CheckForUserByUserName(userName))
            {
                user = new User()
                {
                    Email = email,
                    Name = name,
                    UserName = userName,
                    Password = password
                };
                uRepo.AddUser(user);
            }
            else
            {
                user = uRepo.GetUserByUserName(userName);
            }

            return RedirectToAction("Member", new { userName = user.UserName });
        }

        // Returns the view from the User page
        [HttpGet]
        public IActionResult Member(string userName)
        {
            List<User> users = uRepo.Users;
            List<Character> characters = cRepo.Characters;
            //List<Ability> abilities = aRepo.Abilities;

            User user = uRepo.GetUserByUserName(userName);
            return View("Member", user);
        }

        // Returns the view from the Character Creator page
        public IActionResult CharacterCreator(string userName)
        {
            return View("CharacterCreator", HttpUtility.HtmlDecode(userName));
        }

        [HttpPost]
        public RedirectToActionResult CharacterCreator(string userName, string name, string species, string gender,
                                                 string description, string ability1, string ability2,
                                                 string ability3, string ability4, string ability5)
        {
            User user = uRepo.GetUserByUserName(userName);
            Character character;
            if (!cRepo.CheckForCharacterByName(name))
            {
                ability = new Ability()
                {
                    Ability1 = ability1,
                    Ability2 = ability2,
                    Ability3 = ability3,
                    Ability4 = ability4,
                    Ability5 = ability5
                };
                character = new Character(name, gender, species, description)
                {
                    IsPlayer = true,
                    IsMonster = false,
                    IsNPC = false
                };

                cRepo.AddCharacter(character);
                cRepo.AddAbility(character, ability);
                uRepo.AddCharacter(user, character);
            } else
            {
                character = cRepo.GetCharacterByName(name);
                cRepo.UpdateCharacter(name, gender, species, description,
                                        "player", ability);
            }

            return RedirectToAction("Member", new { userName = user.UserName });
        }

        // Returns the view from the Non-playing Character page
        public IActionResult NpcCreator(string userName)
        {
            return View("NpcCreator", HttpUtility.HtmlDecode(userName));
        }

        [HttpPost]
        public RedirectToActionResult NpcCreator(string userName, string name, string species, string gender,
                                                 string description, string ability1, string ability2,
                                                 string ability3, string ability4, string ability5)
        {
            User user = uRepo.GetUserByUserName(userName);
            Character character;
            if (!cRepo.CheckForCharacterByName(name))
            {
                ability = new Ability()
                {
                    Ability1 = ability1,
                    Ability2 = ability2,
                    Ability3 = ability3,
                    Ability4 = ability4,
                    Ability5 = ability5
                };
                character = new Character(name, gender, species, description)
                {
                    IsPlayer = true,
                    IsMonster = false,
                    IsNPC = false
                };

                cRepo.AddCharacter(character);
                cRepo.AddAbility(character, ability);
                uRepo.AddCharacter(user, character);
            }
            else
            {
                character = cRepo.GetCharacterByName(name);
                cRepo.UpdateCharacter(name, gender, species, description,
                                        "npc", ability);
            }
            
            return RedirectToAction("Member", new { userName = user.UserName });
        }

        // Returns the view from the Monster Creator page
        public IActionResult MonsterCreator(string userName)
        {
            return View("MonsterCreator", HttpUtility.HtmlDecode(userName));
        }

        [HttpPost]
        public RedirectToActionResult MonsterCreator(string userName, string name, string species, string gender,
                                                 string description, string ability1, string ability2,
                                                 string ability3, string ability4, string ability5)
        {
            User user = uRepo.GetUserByUserName(userName);
            Character character;
            if (!cRepo.CheckForCharacterByName(name))
            {
                ability = new Ability()
                {
                    Ability1 = ability1,
                    Ability2 = ability2,
                    Ability3 = ability3,
                    Ability4 = ability4,
                    Ability5 = ability5
                };
                character = new Character(name, gender, species, description)
                {
                    IsPlayer = true,
                    IsMonster = false,
                    IsNPC = false
                };

                cRepo.AddCharacter(character);
                cRepo.AddAbility(character, ability);
                uRepo.AddCharacter(user, character);
            }
            else
            {
                character = cRepo.GetCharacterByName(name);
                cRepo.UpdateCharacter(name, gender, species, description,
                                        "monster", ability);
            }

            return RedirectToAction("Member", new { userName = user.UserName });
        }

    }
}
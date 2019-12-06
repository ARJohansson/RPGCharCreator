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

        public HomeController(IUserRepo uR, ICharacterRepo cR)
        {
            uRepo = uR;
            cRepo = cR;
            if(uRepo.Users.Count == 0)
            {
                User user = new User()
                {
                    Email = "Sandra.Heart@gmail.com",
                    Name = "Sandra Heart",
                    UserName = "SheartsJ",
                    Password = "thisisaBADpassword"
                };
                uRepo.AddUser(user);

                user = new User()
                {
                    Email = "P.Andrew.Grey@yahoo.com",
                    Name = "Phillip Grey",
                    UserName = "philgrey",
                    Password = "lifeisPrettyGrey"
                };
                uRepo.AddUser(user);
            }

            if(cRepo.Characters.Count == 0)
            {
                User user = uRepo.GetUserByName("Phillip Grey");
                Character character = new Character()
                {
                    Name = "Alphie, Terror of the Night",
                    IsMonster = true,
                    IsNPC = false,
                    IsPlayer = false,
                    Species = "Pig Monster",
                    Gender = "male",
                    Description = "Orange, short, fat, large fangs."
                };
                character.Abilities.Add("Sharp claws and fangs that can kill and maim.");
                character.Abilities.Add("Piercing red eyes for hypnotizing prey.");
                character.Abilities.Add("A cruel laugh that paralyzes all who hear it.");
                cRepo.AddCharacter(character);
                user.Characters.Add(character);
                

                character = new Character()
                {
                    Name = "Cleo SharpTongue",
                    IsMonster = false,
                    IsNPC = true,
                    IsPlayer = false,
                    Species = "Halfling",
                    Gender = "female",
                    Description = "Small, but tough bartender. Spends her days adventuring" +
                        "and her nights busting heads at her tavern. She has brown hair and" +
                        "brown eyes, and if you don't try to mess with her, her smile will " +
                        "melt your heart."
                };
                character.Abilities.Add("Handy with a sword.");
                character.Abilities.Add("Makes a mean ale.");
                character.Abilities.Add("A killer stare that makes grown men run to their mamas.");
                cRepo.AddCharacter(character);
                user.Characters.Add(character);
            }
        }

        // Returns the view from the Index page
        public ViewResult Index()
        {
            return View("Index");
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
            return View("User", HttpUtility.HtmlDecode(userName));
        }

        // Returns the view from the Character Creator page
        public IActionResult CharacterCreator()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult CharacterCreator(string userName, string name, string species, string gender,
                                                 string description, string ability1, string ability2,
                                                 string ability3, string ability4, string ability5)
        {
            Character character = new Character(name, gender, species, description)
            {
                IsPlayer = true,
                IsMonster = false,
                IsNPC = false
            };
            character.Abilities.Add(ability1);
            character.Abilities.Add(ability2);
            character.Abilities.Add(ability3);
            character.Abilities.Add(ability4);
            character.Abilities.Add(ability5);
            cRepo.AddCharacter(character);


            User user;
            if (!uRepo.CheckForUserByUserName(userName))
            {
                user = new User();
                user.UserName = userName;
                uRepo.AddUser(user);
            }
            else
            {
                user = uRepo.GetUserByUserName(userName);
            }

            user.Characters.Add(character);

            return RedirectToAction("Member", new { userName = user.UserName });
        }

        // Returns the view from the Non-playing Character page
        public IActionResult NpcCreator()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult NpcCreator(string userName, string name, string species, string gender,
                                                 string description, string ability1, string ability2,
                                                 string ability3, string ability4, string ability5)
        {
            Character character = new Character(name, species, gender, description)
            {
                IsPlayer = false,
                IsMonster = false,
                IsNPC = true
            };
            character.Abilities.Add(ability1);
            character.Abilities.Add(ability2);
            character.Abilities.Add(ability3);
            character.Abilities.Add(ability4);
            character.Abilities.Add(ability5);
            cRepo.AddCharacter(character);


            User user;
            if (!uRepo.CheckForUserByUserName(userName))
            {
                user = new User();
                user.UserName = userName;
                uRepo.AddUser(user);
            }
            else
            {
                user = uRepo.GetUserByUserName(userName);
            }

            user.Characters.Add(character);

            return RedirectToAction("Member", new { userName = user.UserName });
        }

        // Returns the view from the Monster Creator page
        public IActionResult MonsterCreator()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult MonsterCreator(string userName, string name, string species, string gender,
                                                 string description, string ability1, string ability2,
                                                 string ability3, string ability4, string ability5)
        {
            Character character = new Character(name, gender, species, description)
            {
                IsPlayer = false,
                IsMonster = true,
                IsNPC = false
            };
            character.Abilities.Add(ability1);
            character.Abilities.Add(ability2);
            character.Abilities.Add(ability3);
            character.Abilities.Add(ability4);
            character.Abilities.Add(ability5);
            cRepo.AddCharacter(character);


            User user;
            if (!uRepo.CheckForUserByUserName(userName))
            {
                user = new User();
                user.UserName = userName;
                uRepo.AddUser(user);
            }
            else
            {
                user = uRepo.GetUserByUserName(userName);
            }

            user.Characters.Add(character);

            return RedirectToAction("Member", new { userName = user.UserName });
        }

    }
}
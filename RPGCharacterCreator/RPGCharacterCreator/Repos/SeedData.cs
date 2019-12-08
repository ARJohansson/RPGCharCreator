using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGCharacterCreator.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace RPGCharacterCreator.Repos
{
    public class SeedData
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Users.Any())
            {
                Character alphie = new Character()
                {
                    Name = "Alphie, Terror of the Night",
                    IsMonster = true,
                    IsNPC = false,
                    IsPlayer = false,
                    Species = "Pig Monster",
                    Gender = "male",
                    Description = "Orange, short, fat, large fangs."
                };
                Ability ability = new Ability
                {
                    Ability1 = "Sharp claws and fangs that can kill and maim.",
                    Ability2 = "Piercing red eyes for hypnotizing prey.",
                    Ability3 = "A cruel laugh that paralyzes all who hear it."
                };
                alphie.Abilities.Add(ability);
                context.Characters.Add(alphie);

                Character cleo = new Character()
                {
                    Name = "Cleo SharpTongue",
                    IsMonster = false,
                    IsNPC = true,
                    IsPlayer = false,
                    Species = "Halfling",
                    Gender = "female",
                    Description = "Small, but tough bartender. Spends her days adventuring " +
                        "and her nights busting heads at her tavern. She has brown hair and " +
                        "brown eyes, and if you don't try to mess with her, her smile will " +
                        "melt your heart."
                };
                ability = new Ability
                {
                    Ability1 = "Handy with a sword.",
                    Ability2 = "Makes a mean ale.",
                    Ability3 = "A killer stare that makes grown men run to their mamas."
                };
                cleo.Abilities.Add(ability);
                context.Characters.Add(cleo);

                User user1 = new User()
                {
                    Email = "Sandra.Heart@gmail.com",
                    Name = "Sandra Heart",
                    UserName = "SheartsJ",
                    Password = "thisisaBADpassword"
                };
                context.Users.Add(user1);

                User user = new User()
                {
                    Email = "P.Andrew.Grey@yahoo.com",
                    Name = "Phillip Grey",
                    UserName = "philgrey",
                    Password = "lifeisPrettyGrey"
                };
                user.Characters.Add(alphie);
                user.Characters.Add(cleo);
                context.Users.Add(user);

                context.SaveChanges(); // Save all the data
            }
        }
    }
}

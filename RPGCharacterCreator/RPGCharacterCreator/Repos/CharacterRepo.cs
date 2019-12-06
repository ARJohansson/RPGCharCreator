using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGCharacterCreator.Models;

namespace RPGCharacterCreator.Repos
{
    public class CharacterRepo : ICharacterRepo
    {
        private static List<Character> characters = new List<Character>();

        public List<Character> Characters { get { return characters;  } }

        public void AddCharacter(Character c)
        {
            characters.Add(c);
        }

        public Character GetCharacterByName(string name)
        {
            Character character = characters.Find(c => c.Name == name);
            return character;
        }

        public void AddTestData()
        {
            User user = new FakeUserRepo().GetUserByName("Phillip Grey");
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
            characters.Add(character);
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
            characters.Add(character);
            user.Characters.Add(character);
        }
    }
}

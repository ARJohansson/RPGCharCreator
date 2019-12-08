using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGCharacterCreator.Models;

namespace RPGCharacterCreator.Repos
{
    public class FakeCharacterRepo : ICharacterRepo
    {
        private static List<Character> characters = new List<Character>();

        public List<Character> Characters => characters;
        
        public void AddCharacter(Character c)
        {
            characters.Add(c);
        }
        public void AddAbility(Character c, Ability a)
        {
            c.Abilities.Add(a);
        }

        public Character GetCharacterByName(string name)
        {
            Character character = characters.Find(c => c.Name == name);
            return character;
        }

        public bool CheckForCharacterByName(string name)
        {
            for (int i = 0; i < Characters.Count(); i++)
            {
                if (Characters[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void UpdateCharacter(string name, string gender, string species,
                        string description, string type, Ability a)
        {
            Character character = GetCharacterByName(name);
            character.Gender = gender;
            character.Species = species;
            character.Description = description;
            character.Abilities.Add(a);
            if (type == "player")
            {
                character.IsPlayer = true;
                character.IsNPC = false;
                character.IsMonster = false;
            }
            else if (type == "npc")
            {
                character.IsPlayer = false;
                character.IsNPC = true;
                character.IsMonster = false;
            }
            else
            {
                character.IsPlayer = false;
                character.IsNPC = false;
                character.IsMonster = true;
            }
        }

        public void AddTestData()
        {
            FakeUserRepo fakeRepo = new FakeUserRepo();
            fakeRepo.AddTestData();
            User user = fakeRepo.GetUserByName("Phillip Grey");
            Character character = new Character() {
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
            character.Abilities.Add(ability);
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
            ability = new Ability
            {
                Ability1 = "Handy with a sword.",
                Ability2 = "Makes a mean ale.",
                Ability3 = "A killer stare that makes grown men run to their mamas."
            };
            character.Abilities.Add(ability);
            characters.Add(character);
            user.Characters.Add(character);
        }
    }
}

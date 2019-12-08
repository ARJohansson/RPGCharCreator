using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGCharacterCreator.Models;
using Microsoft.EntityFrameworkCore;

namespace RPGCharacterCreator.Repos
{
    public class CharacterRepo : ICharacterRepo
    {
        private AppDbContext context;
        private static List<Character> characters = new List<Character>();

        public List<Character> Characters { get { return context.Characters.Include("Abilities").ToList();  } }

        public CharacterRepo(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddCharacter(Character c)
        {
            context.Characters.Add(c);
            context.SaveChanges();
        }

        public void AddAbility(Character c, Ability a)
        {
            c.Abilities.Add(a);
            context.Characters.Update(c);
            context.SaveChanges();
        }

        public Character GetCharacterByName(string name)
        {
            Character character;
            character = context.Characters.First(c => c.Name == name);
            return character;
        }

        public bool CheckForCharacterByName(string name)
        {
            for (int i = 0; i < context.Characters.Count(); i++)
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

            context.Characters.Update(character);
            context.SaveChanges();
        }
    }
}

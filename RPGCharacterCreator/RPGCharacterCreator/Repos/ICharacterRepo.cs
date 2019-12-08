using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGCharacterCreator.Models;

namespace RPGCharacterCreator.Repos
{
    public interface ICharacterRepo
    {
        List<Character> Characters { get; }
        void AddCharacter(Character c);
        void AddAbility(Character c, Ability a);
        bool CheckForCharacterByName(string name);
        Character GetCharacterByName(string name);
        void UpdateCharacter(string name, string gender, string species,
                                string description, string type, Ability a);
    }
}

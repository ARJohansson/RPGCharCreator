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
        Character GetCharacterByName(string name);
        void AddTestData();
    }
}

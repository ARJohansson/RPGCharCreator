using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGCharacterCreator.Models;

namespace RPGCharacterCreator.Repos
{
    public class AbilityRepo : IAbilityRepo
    {
        private List<Ability> abilities = new List<Ability>();
        public List<Ability> Abilities => abilities;

        public void AddAbility(Ability a)
        {
            Abilities.Add(a);
        }
    }
}

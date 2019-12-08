using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGCharacterCreator.Models;

namespace RPGCharacterCreator.Repos
{
    public interface IAbilityRepo
    {
        List<Ability> Abilities { get; }
        void AddAbility(Ability a);
    }
}

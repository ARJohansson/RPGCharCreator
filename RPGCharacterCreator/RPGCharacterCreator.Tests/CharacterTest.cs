using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using RPGCharacterCreator.Repos;
using RPGCharacterCreator.Models;
using RPGCharacterCreator.Controllers;

namespace RPGCharacterCreator.Tests
{
    public class CharacterTest
    {
        // Tests Character get abilities
        [Fact]
        public void TestCharacterAbilities()
        {
            // Arrange
            var repo = new FakeCharacterRepo();
            repo.AddTestData();
            var abilityRepo = new AbilityRepo();
            Character character = repo.GetCharacterByName("Alphie, Terror of the Night");

            // Act
            abilityRepo.AddAbility(repo.Characters[0].Abilities[0]);

            // Assert
            Assert.Equal(character.Abilities[0].Ability1, abilityRepo.Abilities[0].Ability1);
        }
    }
}

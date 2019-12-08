using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using RPGCharacterCreator.Repos;
using RPGCharacterCreator.Models;
using RPGCharacterCreator.Controllers;

namespace RPGCharacterCreator.Tests
{
    public class AbilityTest
    {
        // Tests AddAbility
        [Fact]
        public void TestAddAbility()
        {
            // Arrange
            var repo = new AbilityRepo();
            var ability = new Ability()
            {
                Ability1 = "fights like a cat",
                Ability2 = "will kill a man",
                Ability3 = "runs super fast",
                Ability4 = "sweet eyes that trick you into serenity"
            };

            //Act
            repo.AddAbility(ability);

            //Assert
            Assert.Equal("fights like a cat",
                repo.Abilities[0].Ability1);
        }
        
        //Test getting Abilities from a character known to have abilities
        [Fact]
        public void TestGetAbilities()
        {
            // Arrange
            var repo = new FakeCharacterRepo();
            repo.AddTestData();
            var abilityRepo = new AbilityRepo();

            // Act
            abilityRepo.AddAbility(repo.Characters[0].Abilities[0]);

            // Assert
            Assert.Single(abilityRepo.Abilities);
            Assert.Equal("Sharp claws and fangs that can kill and maim.",
                abilityRepo.Abilities[0].Ability1);
        }
    }
}

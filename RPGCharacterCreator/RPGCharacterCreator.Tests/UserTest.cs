using System;
using Xunit;
using RPGCharacterCreator.Repos;
using RPGCharacterCreator.Models;
using RPGCharacterCreator.Controllers;

namespace RPGCharacterCreator.Tests
{
    public class UserTest
    {
        // Tests AddUser
        [Fact]
        public void TestAddUser()
        {

            // Arrange 
            var repo = new FakeUserRepo();
            repo.AddTestData();
            var user = new User()
            {
                Name = "Johnny Bill",
                Email = "johnnywho@gmail.com",
                UserName = "here'sjohnnybill",
                Password = "this is a password."
            };

            // Act
            repo.AddUser(user);

            // Assert
            Assert.Equal("Johnny Bill",
                repo.Users[repo.Users.Count - 1].Name);
            Assert.Equal("Phillip Grey",
                repo.Users[repo.Users.Count - 2].Name);

        }

        // Tests the User repository's get user by name method
        [Fact]
        public void GetUserByNameTest()
        {
            // Arange
            var repo = new FakeUserRepo();
            repo.AddTestData();
            var user = new User();

            // Act
            user = repo.GetUserByName("Phillip Grey");

            // Assert
            Assert.Equal(user.Name, repo.Users[1].Name);
        }

        // Tests the User repository's get user by email method
        [Fact]
        public void TestGetUserByEmail()
        {
            // Arange
            var repo = new FakeUserRepo();
            repo.AddTestData();
            var user = new User();

            // Act
            user = repo.GetUserByEmail("Sandra.Heart@gmail.com");

            // Assert
            Assert.Equal(user.Email, repo.Users[0].Email);

        }

        // Tests the User repository's get user by username method
        [Fact]
        public void TestGetUserByUserName()
        {
            // Arange
            var repo = new FakeUserRepo();
            repo.AddTestData();
            var user = new User();

            // Act
            user = repo.GetUserByUserName("philgrey");

            // Assert
            Assert.Equal(user.UserName, repo.Users[1].UserName);
        }

        // Tests the User repository's check for user by username method
        [Fact]
        public void TestCheckForUserByUserName()
        {
            // Arrange
            var repo = new FakeUserRepo();
            repo.AddTestData();
            var user = new User();
            bool truefalse = new bool();
            user.UserName = "philgrey";

            // Act
            truefalse = repo.CheckForUserByUserName(user.UserName);

            // Assert
            Assert.True(truefalse);

        }

        // Tests whether SignUp View creates a new User
        [Fact]
        public void TestNewUserSignUpView()
        {
            // Arrange
            var repo = new FakeUserRepo();
            repo.AddTestData();
            Assert.Equal(2, repo.Users.Count);
            var controller = new HomeController(repo, new FakeCharacterRepo());

            // Act
            controller.SignUp("thisisanemail", "heresjohnny",
                                "pass1234", "Johnny Billings");

            // Assert
            Assert.Equal("heresjohnny",
                repo.Users[2].UserName);
            Assert.Equal(3, repo.Users.Count);
        }

        // Tests wheteher SignUp View finds an existing User
        [Fact]
        public void TestFindUserSignUpView()
        {
            // Arrange
            var repo = new FakeUserRepo();
            repo.AddTestData();
            Assert.Equal(2, repo.Users.Count);
            var controller = new HomeController(repo, new FakeCharacterRepo());

            // Act
            controller.SignUp("P.Andrew.Grey@yahoo.com", "philgrey",
                                "lifeisPrettyGrey", "Phillip Grey");

            // Assert
            Assert.Equal("philgrey",
                repo.Users[1].UserName);
            Assert.Equal(2, repo.Users.Count);
        }

        // Tests whether the Member View contains a user
        [Fact]
        public void TestMemberView()
        {
            // Arrange
            var repo = new FakeUserRepo();
            repo.AddTestData();
            Assert.Equal(2, repo.Users.Count);
            var controller = new HomeController(repo, new FakeCharacterRepo());

            // Act
            controller.Member("philgrey");

            // Assert
            Assert.Equal("philgrey",
                repo.Users[1].UserName);
            Assert.Equal(2, repo.Users.Count);
        }
    }
}

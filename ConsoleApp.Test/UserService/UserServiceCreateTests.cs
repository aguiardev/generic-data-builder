using ConsoleApp.Models;
using ConsoleApp.Services;
using System;
using Xunit;

namespace ConsoleApp.Test
{
    public class UserServiceCreateTests
    {
        private readonly UserService _userService;

        public UserServiceCreateTests()
            => _userService = new UserService();

        [Theory(DisplayName = "Given user without name, when creating should be fail")]
        [InlineData("")]
        [InlineData(null)]
        public void GivenUserWithoutNameWhenCreatingShouldBeFail(string name)
        {
            // Arrange
            var userModel = new DataBuilder<UserModel>()
                .Set(x =>
                {
                    x.Name = name;
                    x.Birth = new DateTime(1989, 05, 13);
                })
                .Build();

            // Act
            var created = _userService.CreateUser(userModel);

            // Assert
            Assert.False(created);
        }

        [Fact(DisplayName = "Given user underage, when creating should be fail")]
        public void GivenUserUnderageWhenCreatingShouldBeFail()
        {
            // Arrange
            var userModel = new DataBuilder<UserModel>()
                .Set(x =>
                {
                    x.Name = "Bruce";
                    x.Birth = new DateTime(DateTime.Now.Year - 15, 01, 01);
                })
                .Build();

            // Act
            var created = _userService.CreateUser(userModel);

            // Assert
            Assert.False(created);
        }
    }
}
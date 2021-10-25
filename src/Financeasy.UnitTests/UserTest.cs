using Financeasy.Business.Core;
using Financeasy.Business.Entities;
using Financeasy.Business.Enumerators;
using Xunit;

namespace Financeasy.UnitTests
{
    public class UserTest
    {
        [Fact]
        public void Block_SetStatusBlockedToUser()
        {
            //Arrange
            var user = new User("Maicon", "teste@teste", "123456");

            //Act
            user.Block();

            //Assert
            var result = user.IsBlocked();
            Assert.True(result);
        }

        [Fact]
        public void IsBlocked_CheckIfUserIsBlocked_ReturnTrue()
        {
            //Arrange
            var user = new User("Maicon", "teste@teste", "123456");
            user.Block();

            //Act
            var result = user.IsBlocked();

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsBlocked_CheckIfUserIsBlocked_ReturnFalse()
        {
            //Arrange
            var user = new User("Maicon", "teste@teste", "123456");

            //Act
            var result = user.IsBlocked();

            //Assert
            Assert.False(result);
        }
    }
}
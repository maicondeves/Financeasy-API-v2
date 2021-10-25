using Financeasy.Business.Entities;
using Xunit;

namespace Financeasy.UnitTests
{
    public class RevenueTest
    {
        [Fact]
        public void Receive_SetReceivedAmount_PopulateReceivedAmoutAndReceivedDate()
        {
            //Arrange
            var revenue = new Revenue();

            //Act
            revenue.Receive(10);

            //Assert
            Assert.True(revenue.ReceivedAmount == 10 && revenue.ReceivedDate.HasValue);
        }
    }
}
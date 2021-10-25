using Financeasy.Business.Entities;
using Xunit;

namespace Financeasy.UnitTests
{
    public class ExpenseTest
    {
        [Fact]
        public void Pay_SetPaymentAmout_PopulatePaymentAmoutAndPaymentDate()
        {
            //Arrange
            var expense = new Expense();

            //Act
            expense.Pay(10);

            //Assert
            Assert.True(expense.PaymentAmount == 10 && expense.PaymentDate.HasValue);
        }
    }
}
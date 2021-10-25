using Financeasy.Business.Entities;
using System;
using Xunit;

namespace Financeasy.UnitTests
{
    public class ProjectTest
    {
        [Fact]
        public void AddRevenue_AddRevenueToList_ListOfRevenuesWithRevenueAdded()
        {
            //Arrange
            var project = new Project("teste", "teste", Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());
            var revenue = new Revenue();

            //Act
            project.AddRevenue(revenue);

            //Assert
            var result = project.Revenues.Contains(revenue);
            Assert.True(result);
        }

        [Fact]
        public void AddExpense_AddExpenseToList_ListOfExpensesWithExpenseAdded()
        {
            //Arrange
            var project = new Project("teste", "teste", Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());
            var expense = new Expense();

            //Act
            project.AddExpense(expense);

            //Assert
            var result = project.Expenses.Contains(expense);
            Assert.True(result);
        }

        [Fact]
        public void RemoveRevenue_RemoveRevenueToList_ListOfRevenuesWithRevenueRemoved()
        {
            //Arrange
            var project = new Project("teste", "teste", Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());
            var revenue = new Revenue();
            project.AddRevenue(revenue);

            //Act
            project.RemoveRevenue(revenue);

            //Assert
            var result = project.Revenues.Contains(revenue);
            Assert.False(result);
        }

        [Fact]
        public void RemoveExpense_RemoveExpenseFromList_ListOfExpensesWithExpenseRemoved()
        {
            //Arrange
            var project = new Project("teste", "teste", Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());
            var expense = new Expense();
            project.AddExpense(expense);

            //Act
            project.RemoveExpense(expense);

            //Assert
            var result = project.Expenses.Contains(expense);
            Assert.False(result);
        }
    }
}
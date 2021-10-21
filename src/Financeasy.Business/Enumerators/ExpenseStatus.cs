using System.ComponentModel;

namespace Financeasy.Business.Enumerators
{
    public enum ExpenseStatus : short
    {
        [Description("Project")]
        Project = 1,

        [Description("Revenue")]
        Revenue = 2,

        [Description("Expense")]
        Expense = 3
    }
}
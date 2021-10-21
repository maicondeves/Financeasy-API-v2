using System.ComponentModel;

namespace Financeasy.Business.Enumerators
{
    public enum Month : short
    {
        [Description("Project")]
        Project = 1,

        [Description("Revenue")]
        Revenue = 2,

        [Description("Expense")]
        Expense = 3
    }
}
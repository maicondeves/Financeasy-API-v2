using System.ComponentModel;

namespace Financeasy.Business.Enumerators
{
    public enum UserStatus
    {
        [Description("Ativo")]
        Active = 1,

        [Description("Inativo")]
        Inactive = 2,

        [Description("Bloqueado")]
        Blocked = 3,
    }
}
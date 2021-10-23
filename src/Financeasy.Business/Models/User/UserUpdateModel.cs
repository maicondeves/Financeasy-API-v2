using System;

namespace Financeasy.Business.Models
{
    public class UserUpdateModel
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
using Financeasy.Business.Core;
using Financeasy.Business.Enumerators;
using System;

namespace Financeasy.Business.Entities
{
    public class User : Entity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public UserStatus Status { get; private set; }

        public User()
        {
        }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            Status = UserStatus.Active;
        }

        public void Block() =>
            Status = UserStatus.Blocked;

        public bool IsBlocked() =>
            Status == UserStatus.Blocked;

        public void Update(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
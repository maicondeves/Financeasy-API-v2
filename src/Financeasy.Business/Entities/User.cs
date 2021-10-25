using Financeasy.Business.Enumerators;
using Financeasy.Business.Validations;
using Financeasy.Core;

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

            ValidateBase();
        }

        protected override void ValidateBase() => Validate(new UserValidation(), this);

        public void Block()
            => Status = UserStatus.Blocked;

        public bool IsBlocked()
            => Status == UserStatus.Blocked;

        public void ChangeEmail(string email)
        {
            Email = email;
            ValidateBase();
        }

        public void ChangePassword(string password)
        {
            Password = password;
            ValidateBase();
        }
    }
}
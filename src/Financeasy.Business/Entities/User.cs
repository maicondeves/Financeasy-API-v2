using Financeasy.Business.Core;
using Financeasy.Business.Enumerators;
using Financeasy.Business.Validations;

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

            Validate();
        }

        protected override void Validate() => Validate(new UserValidation(), this);

        public void Block()
            => Status = UserStatus.Blocked;

        public bool IsBlocked()
            => Status == UserStatus.Blocked;

        public void ChangeEmail(string email)
        {
            Email = email;
            Validate();
        }

        public void ChangePassword(string password)
        {
            Password = password;
            Validate();
        }
    }
}
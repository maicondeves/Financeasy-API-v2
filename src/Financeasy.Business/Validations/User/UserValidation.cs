using Financeasy.Business.Entities;
using FluentValidation;

namespace Financeasy.Business.Validations
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            ValidatorOptions.Global.CascadeMode = CascadeMode.Stop;

            RuleFor(e => e.Name)
                .NotEmpty()
                .WithMessage("Name is required");

            RuleFor(e => e.Email)
                .NotEmpty()
                    .WithMessage("Email is required")
                .EmailAddress()
                    .WithMessage("Email is invalid");

            RuleFor(e => e.Password)
                .NotEmpty()
                .WithMessage("Password is required");

            RuleFor(e => e.Status)
                .NotEmpty()
                    .WithMessage("Status is required")
                .IsInEnum()
                    .WithMessage("Status is invalid");
        }
    }
}
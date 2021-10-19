using Financeasy.Business.Core;
using Financeasy.Business.Interfaces.Core;
using Financeasy.Business.Interfaces.Repositories.Common;
using FluentValidation;
using FluentValidation.Results;

namespace Financeasy.Business.Services.Common
{
    public class Service
    {
        private readonly INotifier _notifier;
        private readonly IUnitOfWork _unitOfWork;

        protected Service(INotifier notifier, IUnitOfWork unitOfWork)
        {
            _notifier = notifier;
            _unitOfWork = unitOfWork;
        }

        protected void Commit()
        {
            if (_unitOfWork.Commit().Equals(0))
                Notify("Error saving information on database");
        }

        protected void Notify(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
                Notify(error.ErrorMessage);
        }

        protected void Notify(string mensagem)
            => _notifier.Notify(new Notification(mensagem));

        protected bool EntityIsValid<TV, TE>(TV validation, TE entity)
            where TV : AbstractValidator<TE>
            where TE : Entity
        {
            var validator = validation.Validate(entity);
            if (validator.IsValid)
                return true;

            Notify(validator);

            return false;
        }
    }
}
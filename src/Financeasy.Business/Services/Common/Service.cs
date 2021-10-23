using Financeasy.Business.Interfaces.Core;
using Financeasy.Business.Interfaces.Repositories.Common;

namespace Financeasy.Business.Services.Common
{
    public abstract class Service
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

        protected void Notify(string message)
            => _notifier.Notify(message);
    }
}
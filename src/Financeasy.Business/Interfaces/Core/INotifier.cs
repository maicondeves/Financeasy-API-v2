using Financeasy.Business.Core;
using System.Collections.Generic;

namespace Financeasy.Business.Interfaces.Core
{
    public interface INotifier
    {
        bool HasNotifications();

        List<Notification> GetNotifications();

        void Notify(Notification notification);

        void Notify(string message);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducaFacil.Domain.Notifications;

namespace EducaFacil.Domain.Interfaces
{
    public interface INotificator
    {
        bool HasNotification();
        List<Notification> ObtainNotifications();
        void Handle(Notification notificacao);
    }
}

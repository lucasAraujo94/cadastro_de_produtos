using System;
using System.Collections.Generic;
using System.Text;
using Cadastro_De_Produtos.Business.Notifications;

namespace Cadastro_De_Produtos.Business.Interfaces
{
    public interface INotificator
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cadastro_De_Produtos.Business.Interfaces;

namespace Cadastro_De_Produtos.Business.Notifications
{
    public class Notificator : INotificator
    {
        private List<Notification> _notification;
        public Notificator()
        {
            _notification = new List<Notification>();
        }

        public List<Notification> GetNotifications()
        {
            return _notification;
        }

        public void Handle(Notification notification)
        {            
            _notification.Add(notification);
        }

        public bool HasNotification()
        {
            return _notification.Any();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.App;

namespace ObserverDesignPatternConsole.App
{
    internal class NotificationService : IUserSubject
    {
        public void Send(string phone)
        {
            Console.WriteLine("Notification Gönderildi");
        }

        public void Send(UserCreatedEvent userCreatedEvent)
        {
            Console.WriteLine($"Notification({userCreatedEvent.Phone}) Gönderildi");
        }
    }
}
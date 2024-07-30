using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.App;

namespace ObserverDesignPatternConsole.App
{
    internal class EmailService : IUserSubject
    {
        public void Send(string email)
        {
            Console.WriteLine("Email Gönderildi");
        }

        public void Send(UserCreatedEvent userCreatedEvent)
        {
            Console.WriteLine($"Email({userCreatedEvent.Email}) Gönderildi");
        }
    }
}
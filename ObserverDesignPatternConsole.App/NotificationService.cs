using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPatternConsole.App
{
    internal class NotificationService
    {
        public void Send()
        {
            Console.WriteLine("Notification Gönderildi");
        }
    }
}
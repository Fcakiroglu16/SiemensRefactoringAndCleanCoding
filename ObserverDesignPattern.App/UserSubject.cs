using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.App
{
    internal class UserSubject
    {
        private List<IUserSubject> ModuleList = new();

        public void Register(IUserSubject userSubject)
        {
            ModuleList.Add(userSubject);
        }


        public void Notify(UserCreatedEvent userCreatedEvent)
        {
            foreach (var module in ModuleList)
            {
                module.Send(userCreatedEvent);
            }
        }
    }
}
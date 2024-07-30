using ObserverDesignPattern.App;

namespace ObserverDesignPatternConsole.App
{
    internal class SmsService : IUserSubject
    {
        public void Send(string phone)
        {
            Console.WriteLine("Sms Gönderildi");
        }

        public void Send(UserCreatedEvent userCreatedEvent)
        {
            Console.WriteLine($"Sms({userCreatedEvent.Phone}) Gönderildi");
        }
    }
}
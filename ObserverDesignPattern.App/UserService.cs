using ObserverDesignPattern.App;

namespace ObserverDesignPatternConsole.App
{
    internal class UserService(UserSubject userSubject)
    {
        public void Create()
        {
            // database operation
            Console.WriteLine("Kullanıcı oluştur");

            userSubject.Notify(new UserCreatedEvent("555 555 55 55", "ahmet@outlook.com"));
            //emailService.Send();
            //notificationService.Send();
            //smsService.Send();
        }
    }
}
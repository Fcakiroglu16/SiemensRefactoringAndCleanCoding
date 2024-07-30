// See https://aka.ms/new-console-template for more information

using ObserverDesignPattern.App;
using ObserverDesignPatternConsole.App;

Console.WriteLine("Hello, World!");

var userSubject = new UserSubject();

userSubject.Register(new EmailService());
userSubject.Register(new NotificationService());
userSubject.Register(new SmsService());


var userService = new UserService(userSubject);
userService.Create();
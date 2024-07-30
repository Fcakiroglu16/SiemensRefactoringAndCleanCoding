namespace ObserverDesignPatternConsole.App
{
    internal class UserService(
        EmailService emailService,
        NotificationService notificationService,
        SmsService smsService)
    {
        public void Create()
        {
            // database operation

            emailService.Send();
            notificationService.Send();
            smsService.Send();
        }
    }
}
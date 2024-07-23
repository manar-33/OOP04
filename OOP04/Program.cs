namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            //1. a) To provide a way to implement multiple inheritance
            //2.c) internal
            //3.c) Only if they are static
            //4.b) Yes, interfaces can inherit from multiple interfaces
            //5.d) implements
            //6.a) Yes
            //7.a) Yes, for all members
            //8.c) To allow multiple classes to implement the same interface
            //9.b) No, interfaces cannot have constructors
            //10.c) By separating interface names with commas
            #endregion
            #region Part02
            #region Question 01:
            //Circle circle = new Circle();

            //circle.Radius = 10;
            //Rectangle rectangle = new Rectangle();
            //rectangle.Length = 4;
            //rectangle.Width = 5;
            //rectangle.DisplayShapeInfo();
            //circle.DisplayShapeInfo();
            #endregion
            #region Question02:
            //IAuthenticationService authService;
            //authService = new BasicAuthenticationService();
            //Console.WriteLine(authService.AuthenticateUser("Manar", 1234));
            //Console.WriteLine(authService.AuthorizeUser("Manar", "Dev"));

            #endregion
            #region Ouestion03
            //INotificationService notification01 = new EmailNotificationService();
            //INotificationService notification02 = new PushNotificationService();
            //INotificationService notification03 = new SmsNotificationService();
            //notification01.SendNotification("Manar", "Message");
            //notification02.SendNotification("Manar", "Message");
            //notification03.SendNotification("Manar", "Message");
            #endregion
            #endregion
        }
    }
}

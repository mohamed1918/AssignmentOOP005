
namespace AssignmentOOP005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Q1");
            //IShape circle = new Circle(5);

            //IShape rectagle = new Rectangle(10,5);

            //circle.DisplayShapeInfo();
            //rectagle.DisplayShapeInfo();
            #endregion

            #region Q2
            //IAuthenticationService authService = new BasicAuthenticationService();
            //string username = "admin", password = "1234";
            //if (authService.AuthenticateUser(username, password))
            //{
            //    Console.WriteLine("User authenticated successfully.");
            //    Console.WriteLine(authService.AuthorizeUser(username, "Admin") ? "User is authorized as Admin." : "User is not authorized.");
            //}
            //else
            //{
            //    Console.WriteLine("Authentication failed.");
            //}
            #endregion

            #region Q3
            INotificationService email = new EmailNotificationService();
            INotificationService sms = new SmsNotificationService();
            INotificationService push = new PushNotificationService();

            email.SendNotification("ahmed@email.com", "Welcome!");
            sms.SendNotification("0100000000", "Your code is 1234.");
            push.SendNotification("Ahmed", "You have a new message.");
            #endregion
        }

    }
    
}

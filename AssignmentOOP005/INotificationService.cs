using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP005
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }


    class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Email sent to {recipient}: {message}");
        }
    }


    class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"SMS sent to {recipient}: {message}");
        }
    }


    class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Push Notification sent to {recipient}: {message}");
        }
    }
}

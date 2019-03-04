using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    public interface INotifications
    {
        //members
        void showNotification();
        string getDate();
    }
    public class Notification:INotifications
    {
        private string sender;
        private string message;
        private string date;

        //default constructor
        public Notification()
        {
            sender = "admin";
            message = "Hi";
            date = " ";
        }

        public Notification(string mySender, string myMessage, string myDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.date = myDate;
        }

        public void showNotification()
        {
            Console.WriteLine("Message: {0} - was sent by {1} on {2}", message, sender, date);
        }
        public string getDate()
        {
            return date;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notification n1 = new Notification("Ivan", "Hi", "04/03/2019");
            Notification n2 = new Notification("Frank", "ag fok", "04/03/2019");

            n1.showNotification();
            n2.showNotification();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Notification notifictaion = new Notification();

            for (int i = 0; i < notifictaion._IMessanger.Count; i++)
            {
                notifictaion._IMessanger[i].SendMessage();
            }

            Console.ReadKey();    
        }

        public interface IMessanger
        {
            void SendMessage();
        }

        public class Email : IMessanger
        {
            public void SendMessage()
            {
                Console.WriteLine("Email sent");
            }
        }

        public class SMS : IMessanger
        {
            public void SendMessage()
            {
                Console.WriteLine("SMS sent");
            }
        }

        public class Notification
        {
            private List<IMessanger> _iMessanger = new List<IMessanger>();
            public List<IMessanger> _IMessanger { get { return _iMessanger; } }

            public Notification()
            {
                _iMessanger.Add(new Email());
                _iMessanger.Add(new SMS());
            }
        }
    }
}

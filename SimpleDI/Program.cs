using SimpleDI.Interfaces;
using SimpleDI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestEmailService();
            IEmailService es = /*new EmailServiceSendGrid();*/ new EmailServiceGoogle();
            IUserService us = new UserService(es);
            var res = us.Register("gordon@gmail.com", "123456");
        }

        private static void TestEmailService()
        {
            using (IEmailService es = new EmailServiceGoogle())
            {
                string email, subject, body;
                Console.WriteLine("-----Відправика пошти--------");
                Console.WriteLine("Пошта:");
                Console.Write("->_");
                email = Console.ReadLine();
                Console.WriteLine("Тема листа:");
                Console.Write("->_");
                subject = Console.ReadLine();
                Console.WriteLine("Тіло листа листа:");
                Console.Write("->_");
                body = Console.ReadLine();
                //es.SendMessage("ddds","asdfasf",)
                var res = es.SendMessage(email, subject, body);
            }
        }
    }
}

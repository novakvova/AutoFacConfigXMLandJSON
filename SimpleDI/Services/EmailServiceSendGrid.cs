﻿using SimpleDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDI.Services
{
    public class EmailServiceSendGrid : IEmailService
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public bool SendMessage(string email, string subject, string body)
        {
            Console.WriteLine("Send message SENDGRID to {0}", email);
            return true;
        }

        public bool SendMessageAttachFile(string email, string subject, string body, string[] files)
        {
            var res = this.SendMessage(email, subject, body);
            foreach (var f in files)
            {
                Console.WriteLine("Send files {0}", f);
            }
            return res;
        }
    }
}

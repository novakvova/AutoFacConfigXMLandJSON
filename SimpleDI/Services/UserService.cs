﻿using SimpleDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDI.Services
{
    public class UserService : IUserService
    {
        private readonly IEmailService _emailService;
        public UserService(IEmailService emailService)
        {
            _emailService = emailService;
        }
        public bool Register(string email, string password)
        {
            Console.WriteLine("Create new User {0} --- {1}", email, password);
            //_emailService.SendMessage(email, "noreply", "Ваш акаунт створено. " +
            //    "Дякуємо за реєстрацію");
            _emailService.SendMessageAttachFile(email, 
                "noreply", 
                "Ваш акаунт створено. " +
                "Дякуємо за реєстрацію", new string[] { "Hello.jpg", "Oksana.jpg" });
            return true;
        }
    }
}

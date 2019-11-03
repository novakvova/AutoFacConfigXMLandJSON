using Autofac;
using SimpleDI.Entities;
using SimpleDI.Interfaces;
using SimpleDI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDI
{
    public class DataModule : Module
    {
        private string _connStr;

        public DataModule(string connString)
        {
            _connStr = connString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(ctx =>
            {
                return new EFContext(_connStr);
            });
            builder.RegisterType<EmailServiceGoogle>()
                .As<IEmailService>();
            builder.RegisterType<UserService>()
                .As<IUserService>();
            base.Load(builder);
        }
    }
}

using MyBook.Core.Interface.Managers;
using MyBook.Core.Managers;
using MyBook.Infrastructure.DataAccess;
using MyBook.Infrastructure.Entities;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyBook.Web.Modules
{
    public class MainModule: NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<DataContext>().InRequestScope();
            Bind<IAccountQueries>().To<IAccountQueries>();
            Bind<IAccountManager>().To<AccountManager>();
        }
    }
}
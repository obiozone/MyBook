using Microsoft.AspNet.Identity;
using MyBook.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBook.Web.Models
{
    public class User: UserModel, IUser<int>
    {
        public int Id
        {
            get { return UserID; }
            set { UserID = value; }
        }

        public string UserName
        {
            get { return Email; }
            set { Email = value; }
        } 
    }
}
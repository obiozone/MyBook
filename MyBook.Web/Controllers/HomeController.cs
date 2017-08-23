using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MyBook.Web.Models;

namespace MyBook.Web.Controllers
{    

    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int userID = User.Identity.GetUserId<int>();
            string email = User.Identity.GetUserName();

            var user = new User { UserID = userID, Email = email };
            return View();
        }

        [Authorize(Roles ="Admin")]
        public ActionResult Admin()
        {
            return View();
        }
    }
}
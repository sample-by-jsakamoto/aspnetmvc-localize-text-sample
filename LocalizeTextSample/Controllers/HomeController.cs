using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LocalizeTextSample.Models;

namespace LocalizeTextSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveUserProfile(UserProfile userProfile)
        {
            if (ModelState.IsValid == false)
            {
                return View("Index", userProfile);
            }
            return View(userProfile);
        }
    }
}
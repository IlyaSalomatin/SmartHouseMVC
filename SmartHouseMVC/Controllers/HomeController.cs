using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SmartHouseMVC.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            string us = User.Identity.Name;
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("IndexAUTH", "MyAuthentication");
            }            
        }
    }
}

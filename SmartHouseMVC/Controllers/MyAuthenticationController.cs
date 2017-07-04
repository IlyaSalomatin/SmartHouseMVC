using SmartHouseMVC.Models.Classes;
using SmartHouseMVC.Models.DbClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Security.Cryptography;
using System.Text;

namespace SmartHouseMVC.Controllers
{
    public class MyAuthenticationController : Controller
    {
        private DbRoomContext db = new DbRoomContext();


        public ActionResult IndexAUTH()
        {
            return View();
        }
      

        [HttpPost]
        public ActionResult AuthLogin(Login model)
        {
            string modelPass = "";
            using(MD5 md5Hash=MD5.Create())
            {
                modelPass += GetMd5Hash(md5Hash, model.Password);
            }
            
            if (model.Password == null && model.Name == null)
            {
                return RedirectToAction("IndexAUTH", "MyAuthentication"); 
            }
            else {}
           
            User user = db.Users.Where(u => u.Name == model.Name && u.Password == modelPass).FirstOrDefault();
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(model.Name, true);
                string us = User.Identity.Name;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("IndexAUTH", "MyAuthentication");
            }         
        }


        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return Redirect("IndexAUTH");
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {           
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));            
            StringBuilder sBuilder = new StringBuilder();            
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }            
            return sBuilder.ToString();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }


}
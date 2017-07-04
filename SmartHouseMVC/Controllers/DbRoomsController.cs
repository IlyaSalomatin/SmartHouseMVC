using SmartHouseMVC.Models.DbClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace SmartHouseMVC.Controllers
{
    public class DbRoomsController : Controller
    {
        private DbRoomContext db = new DbRoomContext();
        // GET: DbRooms
        public ActionResult Index()
        {
            int id = 7;
            DbRoom ri = db.DbRooms.Find(id);
            ViewBag.Entitys = ri.Name;
            return View();
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
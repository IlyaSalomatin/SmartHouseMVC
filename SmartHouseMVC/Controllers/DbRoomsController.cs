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

        [Authorize]
        public ActionResult Bedroom()
        {
            DbRoom r = db.DbRooms.Find(3);
            return View(r);
        }

        public void RoomAction(DbRoom room)
        {

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
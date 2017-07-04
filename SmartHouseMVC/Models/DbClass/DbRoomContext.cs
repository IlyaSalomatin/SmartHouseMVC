using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.DbClass
{
    public class DbRoomContext : DbContext

    {
        static DbRoomContext()
        {
            Database.SetInitializer<DbRoomContext>(new DbRoomContextInitializer());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<DbRoom> DbRooms { get; set; }      
    }
}
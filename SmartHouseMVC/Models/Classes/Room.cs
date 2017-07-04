using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Classes
{
    public abstract class Room
    {
        public string Name { get; set; }
        public Room(string name)
        {
            Name = name;
        }

    }
}
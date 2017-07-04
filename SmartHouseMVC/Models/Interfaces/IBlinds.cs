using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface IBlinds
    {
        string Blinds { get; }
        void GetLoweredBlinds();
        void GetRaisedBlinds();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface ISmartWindow
    {
        bool FrostedGlassState { get; }
        int DimmingGlass { get; }
        void FrostedGlassOnOff();
        void SetDimmingGlass(int p);
    }
}
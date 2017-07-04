using SmartHouseMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface IOzonation
    {
        TimerOzonation OzonationState { get; }
        void SetTimerOzonation(TimerOzonation v);
    }
}
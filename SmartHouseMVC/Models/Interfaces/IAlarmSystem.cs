using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface IAlarmSystem
    {
        string AlarmSystemState { get; }
        void ChangeAlarmSystemState();
    }
}
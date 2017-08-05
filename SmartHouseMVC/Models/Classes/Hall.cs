using SmartHouseMVC.Models.Enums;
using SmartHouseMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace SmartHouseMVC.Models.Classes
{
    public class Hall : Room, IOzonation, IFloorHeating
    {
        public Heating FloorHeating { get; set; }       
        public TimerOzonation OzonationState { get; set; }
        public Hall(string name): base(name)  { }
        
        public void SetTimerOzonation(TimerOzonation time)
        {
            OzonationState = time;
            Task t = new Task(TimerOzon);
            t.Start();
        }
        void TimerOzon()
        {
            int time = (int)OzonationState;
            Thread.Sleep(time);
            OzonationState = TimerOzonation.off;
        }
    }
}
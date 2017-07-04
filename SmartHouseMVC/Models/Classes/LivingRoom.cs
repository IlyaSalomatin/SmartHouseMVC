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
    public class LivingRoom : Room, IAirHumidification, IAirConditioning, ISmartWindow, IFloorHeating, IOzonation
    {
        public bool FrostedGlassState { get; set; }
        public int DimmingGlass { get; set; }
        public int TempConditioning { get; set; }
        public bool ConditioningState { get; set; }
        public Heating FloorHeating { get; set; }        
        public TimerOzonation OzonationState { get; set; }
        public TimerHumidification HumidificationState { get; set; }
        public LivingRoom(string name) : base(name) {}
       
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
            OzonationState = TimerOzonation.Off;
        }
        public void SetTimerHumidification(TimerHumidification time)
        {
            HumidificationState = time;
            Task t = new Task(TimerHum);
            t.Start();
        }
        void TimerHum()
        {
            int time = (int)HumidificationState;
            Thread.Sleep(time);
            HumidificationState = TimerHumidification.Off;
        }
        public void OnConditioning(int temp)
        {
            ConditioningState = true;
            TempConditioning = temp;

        }
        public void OffConditioning()
        {
            ConditioningState = false;
        }
        public void FrostedGlassOnOff()
        {
            FrostedGlassState = FrostedGlassState == true ? FrostedGlassState = false : FrostedGlassState = true;
        }
        public void SetDimmingGlass(int percent)
        {
            DimmingGlass = percent;
        }
    }
}
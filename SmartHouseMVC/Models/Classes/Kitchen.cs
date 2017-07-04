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
    public class Kitchen : Room, IBoiler, IFloorHeating, IOzonation, IAirConditioning, ISmartWindow
    {
        public bool FrostedGlassState { get; set; }
        public int DimmingGlass { get; set; }
        public int TempConditioning { get; set; }
        public bool ConditioningState { get; set; }
        public Heating Boiler { get; set; }
        public Heating FloorHeating { get; set; }        
        public TimerOzonation OzonationState { get; set; }
        public Kitchen(string name): base(name)   {}

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.ViewModels
{
    public class RoomModel
    {        
        public string Name { get; set; }
        public string FrostedGlassState { get; set; }
        public int? DimmingGlass { get; set; }
        public string FloorHeating { get; set; }
        public string Boiler { get; set; }
        public string OzonationState { get; set; }
        public int? TempConditioning { get; set; }
        public string ConditioningState { get; set; }
        public string HumidificationState { get; set; }
        public string PowerState { get; set; }
        public string LightinState { get; set; }
        public string BlindsState { get; set; }
    }
}
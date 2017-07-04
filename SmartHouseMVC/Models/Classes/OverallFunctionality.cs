using SmartHouseMVC.Models.Enums;
using SmartHouseMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace SmartHouseMVC.Models.Classes
{
    public class OverallFunctionality : Room, IBlinds, ILighting, IPower //IAlarmSystem
    {
        public Power PowerState { get; set; }
        public Lighting LightingState { get; set; }
        //public string AlarmSystemState { get; set; }
        public string Blinds { get; set; }
        public OverallFunctionality(string name): base(name){ }
       
        public void GetLoweredBlinds()
        {
            Blinds = "lowered";
        }
        public void GetRaisedBlinds()
        {
            Blinds = "raised";
        }
        //public void ChangeAlarmSystemState()
        //{
        //    string re = @"^0000$";
        //    while (true)
        //    {
        //        Console.WriteLine("Enter your password:");
        //        string password = Console.ReadLine();
        //        if (Regex.IsMatch(password, re, RegexOptions.IgnoreCase))
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("Wrong password!!!");
        //            Console.ResetColor();
        //        }
        //    }
        //    AlarmSystemState = AlarmSystemState == "On" ? AlarmSystemState = "Off" : AlarmSystemState = "On";

        //}
    }
}
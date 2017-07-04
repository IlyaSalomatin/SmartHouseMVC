using SmartHouseMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface ILighting
    {
        Lighting LightingState { get; set; }
    }
}
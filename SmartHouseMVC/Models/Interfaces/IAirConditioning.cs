using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.Interfaces
{
    public interface IAirConditioning
    {
        int TempConditioning { get; }
        bool ConditioningState { get; }
        void OnConditioning(int t);
        void OffConditioning();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavidPR_MVC_Tenta.Models
{
    public class CalculateModel
    {
        public decimal GetCurrentSpeed(string distance, string time)
        {
            if (distance == null || time == null || distance.Length == 0 || time.Length == 0)
                return -1.0M;

            decimal distanceDeci;
            decimal timeDecimal;
            if (decimal.TryParse(distance, out distanceDeci) && decimal.TryParse(time, out timeDecimal))
                return distanceDeci / timeDecimal;
            return -1.0M;
        }
    }
}
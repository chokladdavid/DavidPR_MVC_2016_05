using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace DavidPR_MVC_Tenta.Models
{
    public class PNumValidAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;
            int nr = new int();
            var toCheck = value.ToString().ToLower().Trim();
            return toCheck.StartsWith("p-") && int.TryParse(toCheck.Substring(2, toCheck.Length-2), out nr);
        }

        public override string FormatErrorMessage(string name)
        {
            return "Must be like p-(numbers)";
        }
    }
}
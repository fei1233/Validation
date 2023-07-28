using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.ComponentModel.DataAnnotations;
namespace ASS2._5final.Models
{


    public class NoNumbersAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return true;

            string input = value.ToString();

            // Check if the input contains any numeric characters
            return !input.Any(char.IsDigit);
        }
    }

}
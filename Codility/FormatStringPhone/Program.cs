using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FormatStringPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("8194524120"));
        }

        // Return formated phone
        static string solution(string unformatedPhone)
        {
            unformatedPhone = Regex.Replace(unformatedPhone, @"[^\w]", "");

            if (unformatedPhone.Length == 2)
            {
                return unformatedPhone;
            }

            int remainder = unformatedPhone.Length % 3;
            string formatedPhone = string.Join("-", Regex.Matches(unformatedPhone, @"\d{3}"));

            if (unformatedPhone.Length == 10)
            {
                formatedPhone = String.Format(@"{0:000-000-00-00}", Int64.Parse(unformatedPhone));
            }
            else if (remainder != 0)
            {
                formatedPhone += '-' + unformatedPhone.Substring(unformatedPhone.Length - remainder);
            }

            return formatedPhone;
        }
    }
}

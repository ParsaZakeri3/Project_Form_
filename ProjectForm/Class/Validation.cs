using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectForm.Class
{
    public static class Validation
    {
        public static bool CheckDate(this string[] SplitDate)
        {
            if (SplitDate.Length == 3)
            {
                //check Year
                bool resultYear = SplitDate[0].Length == 4 && int.TryParse(SplitDate[0], out int num_year) && num_year < DateTime.Now.Year ? true : false;
                //check Month
                bool resultmonth = SplitDate[1].Length == 2 && int.TryParse(SplitDate[1], out int num_month) && num_month >= 1 && num_month <= 12 ? true : false;
                if (!resultmonth) resultmonth = SplitDate[1].Length == 1 && int.TryParse(SplitDate[1], out int num) ? num >= 1 && num <= 12 : false;
                //check Day
                bool resultday = SplitDate[2].Length == 2 && int.TryParse(SplitDate[2], out int num_day) && num_day >= 1 && num_day <= 30 ? true : false;
                if (!resultday) resultday = SplitDate[1].Length == 1 && int.TryParse(SplitDate[2], out int num) ? num >= 1 && num <= 30 : false;
                //check Date
                return resultYear && resultmonth && resultday ? true : false;
            }
            return false;
        }

        public static bool CheckTryAgain(this string TryAgainForm)
        {
            return int.TryParse(TryAgainForm, out int numtryagainform) && numtryagainform >= 1 && numtryagainform <= 2 ? true : false;
        }

        public static bool validNumber(this string valid_Number)
        {
            bool result = valid_Number.Length == 11 ? true : false;
            return result;
        }
        public static string Checkphone(string check_number)
        {
            if (check_number.StartsWith("09")) return check_number;
            if (check_number.StartsWith("+989")) return check_number.Replace("+98", "0");
            if (check_number.StartsWith("9")) return "0" + check_number;
            return "false";
        }
        public static bool validgender(this string gender)
        {
            return gender == "Male" || gender == "Famle" || gender == "Other" || gender == "male" || gender == "famle" || gender == "other" ? true : false;
        }
        public static bool mustGoToMiliteryService(string gender, int age)
        {
            return (gender == "male" || gender == "Male") && age >= 18 && age <= 50 ? true : false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectForm.Class
{
    public static class Validation
    {
        public static bool CheckDate(this string[] SplitDate)
        {
            if (SplitDate.Length == 3)
            {
                return (CheckYear(SplitDate[0]) && CheckMonth(SplitDate[1]) && CheckDay(SplitDate[2]));
            }

            return false;
        }
        private static bool CheckYear(string year)
        {
            if (year.Length == 4)
            {
                if (int.TryParse(year, out int num_year) && num_year < DateTime.Now.Year)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        private static bool CheckMonth(string month)
        {
            if (month.Length == 2)
            {
                if (int.TryParse(month, out int num) && num >= 1 && num <= 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (int.TryParse(month, out int num))
                {
                    return num >= 1 && num <= 12;
                }
                else
                {
                    return false;
                }
            }
        }

        private static bool CheckDay(string day)
        {
            if (day.Length == 2)
            {
                if (int.TryParse(day, out int num) && num >= 1 && num <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (int.TryParse(day, out int num))
                {
                    return num >= 1 && num <= 30;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool CheckTryAgain(this string TryAgainForm)
        {
            if (int.TryParse(TryAgainForm, out int numtryagainform) && numtryagainform >= 1 && numtryagainform <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool validNumber(this string valid_Number)
        {
            if (valid_Number.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string Checkphone(string check_number)
        {
            if (check_number.StartsWith("09"))
            {
                return check_number;
            }
            else
            if (check_number.StartsWith("+989"))
            {
                check_number = check_number.Replace("+98", "0");
                return check_number;
            }
            else
            if (check_number.StartsWith("9"))
            {
                check_number = "0" + check_number;
                return check_number;
            }
            else
            {
                return "false";
            }
        }
        public static bool validgender(this string gender)
        {
            if (gender == "Male" || gender == "Famle" || gender == "Other")
            {
                return true;
            }
            if (gender == "male" || gender == "famle" || gender == "other")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool mustGoToMiliteryService(string gender, int age)
        {
            if ((gender == "male" || gender == "Male") && age >= 18 && age <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
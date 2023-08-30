using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProjectForm.Class
{
    public class MyCallender
    {
        public string GetGregorianMonthName(int monthNumber)
        {
            DateTimeFormatInfo dateTimeFormat = new DateTimeFormatInfo();
            return dateTimeFormat.GetMonthName(monthNumber);
        }

        public string GetPersianMonthName(int monthNumber)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            DateTime dateTime = new DateTime(2023, monthNumber, 1, persianCalendar);
            return dateTime.ToString("MMMM", new CultureInfo("fa-IR"));
        }
    }
}

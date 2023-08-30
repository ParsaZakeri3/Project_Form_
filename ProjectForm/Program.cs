using ProjectForm.Class;
using System;

namespace ProjectForm
{
    class Program
    {
        //create the object 
        public static string Fname;
        public static string Lname;
        public static string FatherName;
        public static string gregorianMonthName;
        public static string DateYear;
        public static string Number_ReadPhone;
        public static string NumberUser;
        public static string gender_valid;
        public static int Age;
        public static int MonthsYear;
        public static bool validDate = false;
        public static string[] SplitDate;
        public static int Try;
        public static string TryY;
        private static string Year;

        static void Main(string[] args)
        {

            while (true)
            {
                //welcom project
                Console.WriteLine("Welcom!");
                //Form 
                Console.Write("FistName :");
                Fname = Console.ReadLine();
                Console.Write("LastName :");
                Lname = Console.ReadLine();

                bool validDate = false;

                while (!validDate)
                {
                    Console.Write("Date Brthday: ");
                    DateYear = Console.ReadLine();
                    SplitDate = DateYear.Split('-');
                    validDate = Validation.CheckDate(SplitDate);

                    if (!validDate)
                    {
                        Console.WriteLine("Invalid date format. Please try again. example 2023-02-02");
                    }

                }

                Age = DateTime.Now.Year - int.Parse(SplitDate[0]);
                MonthsYear = int.Parse(SplitDate[1]);
                Console.WriteLine($"Age : {Age}");

                //Get Month Persian And Gregorian

                MyCallender Callender = new MyCallender();
                gregorianMonthName = Callender.GetGregorianMonthName(MonthsYear);
                //string persianMonthName = Callender.GetPersianMonthName(MonthsYear);
                Console.WriteLine($"Months : {gregorianMonthName}");

                bool validgender = false;

                while (!validgender)
                {
                    Console.Write("Gender(Male,Famle,Other) : ");
                    gender_valid = Console.ReadLine();
                    validgender = Validation.validgender(gender_valid);

                    if (!validgender)
                    {
                        Console.WriteLine("Invalid. Please try again. (male,famle,other)");
                    }

                }
                Console.WriteLine($"Gender : {gender_valid}");

                bool MiliteryService = Validation.mustGoToMiliteryService(gender_valid, Age);

                Console.Write("FatherName :");

                FatherName = Console.ReadLine();

                bool validNumber = false;

                while (!validNumber)
                {
                    Console.Write("Phone Number : ");
                    Number_ReadPhone = Console.ReadLine();
                    NumberUser = Validation.Checkphone(Number_ReadPhone);
                    if (NumberUser == "false")
                    {
                        validNumber = false;
                    }
                    validNumber = Validation.validNumber(NumberUser);

                    if (!validNumber)
                    {
                        Console.WriteLine("Invalid number format. Please try again. example 09120000000");
                    }

                }
                Console.WriteLine($"Phone Number : {NumberUser}");

                string Form = $"FistName : {Fname} ,LastName : {Lname} ,Year : {Year} ,Age: {Age} ,Gregorian Month: {gregorianMonthName} ,FatherName: {FatherName} , Phone Number : {NumberUser} , Gender: { gender_valid}";
                IFShowLog(Form);

                bool validTryAgain = false;

                while (!validTryAgain)
                {
                    Console.WriteLine("TryAgain?(1.Yes,2.No)");
                    TryY = Console.ReadLine();
                    validTryAgain = Validation.CheckTryAgain(TryY);

                    if (!validTryAgain)
                    {
                        Console.WriteLine("Invalid date format. Please try again.");
                    }

                }
                Try = int.Parse(TryY);
                if (Try == 1)
                {
                }
                else
                if (Try == 2)
                {

                    bool validCtext = false;

                    while (!validCtext)
                    {
                        Console.WriteLine("Do you want a text file output from the form?(1.Yes,2.No)");
                        TryY = Console.ReadLine();
                        validCtext = Validation.CheckTryAgain(TryY);

                        if (!validCtext)
                        {
                            Console.WriteLine("Invalid date format. Please try again.");
                        }

                    }
                    Try = int.Parse(TryY);
                    if (Try == 1)
                    {
                        TextValid Text = new TextValid();
                        Text.GetForm(Form);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("thank you");
                        break;
                    }
                }
            }
        }
        static void IFShowLog(string resultForm)
        {
            //if with form 1 and 2
            Console.WriteLine("-----------------------------------------------------");
            bool validCtext = false;
            while (!validCtext)
            {
                Console.WriteLine("Show (1.Detail Or 2.Summery)");
                TryY = Console.ReadLine();
                validCtext = Validation.CheckTryAgain(TryY);

                if (!validCtext)
                {
                    Console.WriteLine("Invalid date format. Please try again.");
                }

            }
            //result with 
            int result = int.Parse(TryY);
            if (result == 1)
            {
                Console.WriteLine(resultForm);
            }
            else if (result == 2)
            {
                string[] lst = resultForm.Split(",");
                Console.WriteLine(lst[0] + " ," + lst[1]);
            }
        }
    }
}

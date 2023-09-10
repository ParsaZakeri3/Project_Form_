using ProjectForm.Class;
using System;



namespace ProjectForm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //ObjectClass ObjectClass = new ObjectClass();
                //welcom project
                Console.WriteLine("Wellcom!");
                //Form 
                Console.Write("FistName :");
                ObjectClass.Fname = Console.ReadLine();
                Console.Write("LastName :");
                ObjectClass.Lname = Console.ReadLine();

                bool validDate = false;
                while (!validDate)
                {
                    try
                    {
                        Console.Write("Date Brthday: ");
                        ObjectClass.DateYear = Console.ReadLine();
                        ObjectClass.SplitDate = ObjectClass.DateYear.Split('-');
                        validDate = Validation.CheckDate(ObjectClass.SplitDate);

                        if (!validDate)
                            Console.WriteLine("Invalid date format. Please try again. example 2023-02-02");

                    }
                    catch (Exception ex)
                    {
                        ErrorLog log = new ErrorLog();
                        log.ErorrLogText(ex.Message, ex.Source);
                    }
                }

                ObjectClass.Age = DateTime.Now.Year - int.Parse(ObjectClass.SplitDate[0]);
                ObjectClass.MonthsYear = int.Parse(ObjectClass.SplitDate[1]);
                Console.WriteLine($"Age : {ObjectClass.Age}");

                //Get Month Persian And Gregorian
                MyCallender Callender = new MyCallender();
                ObjectClass.gregorianMonthName = Callender.GetGregorianMonthName(ObjectClass.MonthsYear);
                //string persianMonthName = Callender.GetPersianMonthName(MonthsYear);
                Console.WriteLine($"Months : {ObjectClass.gregorianMonthName}");

                bool validgender = false;
                while (!validgender)
                {
                    try
                    {
                        Console.Write("Gender(Male,Famle,Other) : ");
                        ObjectClass.gender_valid = Console.ReadLine();
                        validgender = Validation.validgender(ObjectClass.gender_valid);

                        if (!validgender)
                        {
                            Console.WriteLine("Invalid. Please try again. (male,famle,other)");
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorLog log = new ErrorLog();
                        log.ErorrLogText(ex.Message, ex.Source);
                    }

                }
                Console.WriteLine($"Gender : {ObjectClass.gender_valid}");

                //check the gender and age with if gender men and age 18 in 50 ok
                bool MiliteryService = Validation.mustGoToMiliteryService(ObjectClass.gender_valid, ObjectClass.Age);
                string MFO = MiliteryService ? "OK" : "NO";
                //Console.WriteLine(MFO);

                Console.Write("FatherName :");
                ObjectClass.FatherName = Console.ReadLine();

                bool validNumber = false;
                while (!validNumber)
                {
                    try
                    {
                        Console.Write("Phone Number : ");
                        ObjectClass.Number_ReadPhone = Console.ReadLine();
                        ObjectClass.NumberUser = Validation.Checkphone(ObjectClass.Number_ReadPhone);
                        if (ObjectClass.NumberUser == "false")
                        {
                            validNumber = false;
                        }
                        validNumber = Validation.validNumber(ObjectClass.NumberUser);

                        if (!validNumber)
                        {
                            Console.WriteLine("Invalid number format. Please try again. example 09120000000");
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorLog log = new ErrorLog();
                        log.ErorrLogText(ex.Message, ex.Source);
                    }

                }
                Console.WriteLine($"Phone Number : {ObjectClass.NumberUser}");

                string Form = $"FistName : {ObjectClass.Fname} ,LastName : {ObjectClass.Lname} ,Year : {ObjectClass.Year} ,Age: {ObjectClass.Age} ,Gregorian Month: {ObjectClass.gregorianMonthName} ,FatherName: {ObjectClass.FatherName} , Phone Number : {ObjectClass.NumberUser} , Gender: {ObjectClass.gender_valid}";
                IFShowLog(Form);

                bool validTryAgain = false;
                while (!validTryAgain)
                {
                    try
                    {
                        Console.WriteLine("TryAgain?(1.Yes,2.No)");
                        ObjectClass.TryY = Console.ReadLine();
                        validTryAgain = Validation.CheckTryAgain(ObjectClass.TryY);

                        if (!validTryAgain)
                        {
                            Console.WriteLine("Invalid date format. Please try again.");
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorLog log = new ErrorLog();
                        log.ErorrLogText(ex.Message, ex.Source);
                    }

                }
                ObjectClass.Try = int.Parse(ObjectClass.TryY);
                if (ObjectClass.Try == 1)
                {
                }
                else
                if (ObjectClass.Try == 2)
                {
                    bool validCtext = false;
                    while (!validCtext)
                    {
                        try
                        {
                            Console.WriteLine("Do you want a text file output from the form?(1.Yes,2.No)");
                            ObjectClass.TryY = Console.ReadLine();
                            validCtext = Validation.CheckTryAgain(ObjectClass.TryY);

                            if (!validCtext)
                            {
                                Console.WriteLine("Invalid date format. Please try again.");
                            }
                        }
                        catch (Exception ex)
                        {
                            ErrorLog log = new ErrorLog();
                            log.ErorrLogText(ex.Message, ex.Source);
                        }

                    }
                    ObjectClass.Try = int.Parse(ObjectClass.TryY);
                    if (ObjectClass.Try == 1)
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
                try
                {
                    Console.WriteLine("Show (1.Detail Or 2.Summery)");
                    ObjectClass.TryY = Console.ReadLine();
                    validCtext = Validation.CheckTryAgain(ObjectClass.TryY);

                    if (!validCtext)
                    {
                        Console.WriteLine("Invalid date format. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    ErrorLog log = new ErrorLog();
                    log.ErorrLogText(ex.Message, ex.Source);
                }
            }
            //result with 
            int result = int.Parse(ObjectClass.TryY);
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

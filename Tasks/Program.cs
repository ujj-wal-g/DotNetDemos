using System;
namespace DateComparisonTask
{
    public class DateComparisonTask
    {
        static bool flagToEnableCheckDate = true;


        public static void Main(string[] args)
        {

            string userInp1;
            string userInp2;

            do
            {
                Console.WriteLine("Please Enter first date in string format,Ex11042002");
                userInp1 = Console.ReadLine();
                Console.WriteLine("Please Enter second date in string format,Ex11042002");
                userInp2 = Console.ReadLine();


                try
                {
                    //Calling CheckDate method here with class name it could throw an error so i have bound it in try block
                    flagToEnableCheckDate = CheckDate(userInp1, userInp2);
                    if (flagToEnableCheckDate)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Input is not Valid");
                }

                //Taking again user input
                Console.WriteLine("Do you want to compare again y/n");
                string useroptn;
                useroptn = Console.ReadLine();
                if (useroptn == "y" || useroptn == "Y")
                {
                    flagToEnableCheckDate = true;
                }
                else
                {
                    flagToEnableCheckDate = false;
                }


            }
            while (flagToEnableCheckDate);
        }

        //Method that check(validate) a date is correct or not
        public static bool CheckDate(string userInp1, string userInp2)

        {
            int day1 = 0, month1 = 0, year1 = 0;
            int day2 = 0, month2 = 0, year2 = 0;
            try
            {
                day1 = int.Parse(userInp1.Substring(0, 2));
                month1 = int.Parse(userInp1.Substring(2, 2));
                year1 = int.Parse(userInp1.Substring(4, 4));


                day2 = int.Parse(userInp2.Substring(0, 2));
                month2 = int.Parse(userInp2.Substring(0, 2));
                year2 = int.Parse(userInp2.Substring(0, 2));
                if (DateTime.DaysInMonth(year1, month1) != day1 && DateTime.DaysInMonth(year2, month2) != day2)
                {
                    //Console.WriteLine("Days is not available!!");
                    return false;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Input is not valid!!");
                return false;
            }

            string mes1 = "Date1 is Earlier than date2";
            string mes2 = "Date2 is Earlier than date1";

            if (userInp1.Length > 8 && userInp1.Length < 8)
            {
                Console.WriteLine("Invalid Input,Please Enter date that has 8 character only!!");

                if (userInp2.Length > 8 && userInp2.Length < 8)
                {
                    Console.WriteLine("Invalid Input,Please Enter date that has 8 character only!!");
                }
            }
            else
            {

                if (day1 < 31 && day1 > 0 && month1 < 12 && month1 > 0)
                {

                    if (day2 < 31 && day2 > 0 && month2 < 12 && month2 > 0)
                    {


                        if (year1 < year2)
                        {
                            Console.WriteLine(mes1);
                        }
                        if (year1 > year2)
                        {
                            Console.WriteLine(mes2);
                        }
                        if (year1 == year2)
                        {
                            if (month1 < month2)
                            {
                                Console.WriteLine(mes1);
                            }
                            if (month1 > month2)
                            {
                                Console.WriteLine(mes2);
                            }
                            if (month1 == month2)
                            {
                                if (day1 < day2)
                                {
                                    Console.WriteLine(mes1);
                                }
                                if (day1 > day2)
                                {

                                    Console.WriteLine(mes2);

                                }

                            }
                            if (day1 == day2)
                            {
                                Console.WriteLine("Both dates are equal!!");

                            }
                        }

                    }

                    else
                    {
                        Console.WriteLine("Sorry your date is invalid enter a valid date!!");
                        return false;
                    }


                }
                else
                {
                    Console.WriteLine("Sorry your date is invalid enter a valid date!!");
                    return false;
                }
            }
            return true;
        }
    }
}

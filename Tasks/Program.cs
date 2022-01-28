using System;

namespace DateComparisonTask
{
    public class DateComparisonTask
    {
        static bool i = true;

        public static void Main(string[] args)
        {
           
            string userInp1;
            string userInp2;
            //DateComparisonTask dt = new DateComparisonTask();
            do
            {
                Console.WriteLine("Please Enter first date in string format ,Ex11042002");
                userInp1 = Console.ReadLine();
                Console.WriteLine("Please Enter second date in string format ,Ex11042002");
                userInp2 = Console.ReadLine();

                DateComparisonTask.checkDate(userInp1, userInp2);
                Console.WriteLine("Do you want to compare again y/n");
                string useroptn;
                useroptn = Console.ReadLine();
                if (useroptn == "y"|| useroptn == "Y")
                {
                    i = true;
                }
                else
                {
                    i = false;
                }


            }
            while (i);
        }


        //Method that check(validate) a date is correct or not
        public static void checkDate(string userInp1, string userInp2)

        {
            string day1, month1, year1;
            day1 = userInp1.Substring(0, 2);
            month1 = userInp1.Substring(2, 2);
            year1 = userInp1.Substring(4, 4);

            string day2, month2, year2;
            day2 = userInp2.Substring(0, 2);
            month2 = userInp2.Substring(2, 2);
            year2 = userInp2.Substring(4);

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

                if (int.Parse(day1) < 31 && int.Parse(day1) > 0 && int.Parse(month1) < 12 && int.Parse(month1) > 0 && int.Parse(year1) < 2022)
                {
                    
                    if (int.Parse(day2) < 31 && int.Parse(day2) > 0 && int.Parse(month2) < 12 && int.Parse(month2) > 0 && int.Parse(year2) < 2022)
                    {

                       
                         if(int.Parse(year1)<int.Parse(year2))
                         {
                              Console.WriteLine(mes1);
                         }
                         if(int.Parse(year1) > int.Parse(year2))
                         {
                            Console.WriteLine(mes2);
                         }
                         if(int.Parse(year1) == int.Parse(year2))
                         {
                            if(int.Parse(month1) < int.Parse(month2))
                            {
                                Console.WriteLine(mes1);
                            }
                            if(int.Parse(month1) > int.Parse(month2))
                            {
                                Console.WriteLine(mes2);
                            }
                            if(int.Parse(month1) == int.Parse(month2))
                            {
                                if(int.Parse(day1) < int.Parse(day2))
                                {
                                    Console.WriteLine(mes1);
                                }
                                if (int.Parse(day1) > int.Parse(day2))
                                {
                                    
                                    Console.WriteLine(mes2);
                                 
                                }

                            }
                            if(int.Parse(day1) == int.Parse(day2))
                            {
                                Console.WriteLine("Both dates are equal!!");
                            }
                         }
                             
                    }

                    else
                    {
                        Console.WriteLine("Sorry your date is invalid enter a valid date!!");
                    }


                }
                else
                {
                    Console.WriteLine("Sorry your date is invalid enter a valid date!!");
                }
            }
        }
    }
}
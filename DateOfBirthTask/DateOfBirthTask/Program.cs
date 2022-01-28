using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateOfBirthTask
{
    public class DateOfBirthTask
    {
        static void Main(string[] args)
        {

            
            bool flag = true ;
            string UserInp;
            do
            {
                Console.WriteLine("Enter your date of birth (Format ddmmyyyy Ex 01022001)");
                UserInp = Console.ReadLine();
                bool isValid = CheckValid(UserInp);
                Console.WriteLine("Do You Want To print Again- Y/N");
                UserInp = Console.ReadLine() ;
                if(UserInp == "Y"||UserInp=="y")
                {
                    flag = true ;
                }
                else
                {
                    flag = false ;
                }
            }
            while (flag);
         }

        static bool CheckValid(string str)
        {
            bool valid = false;
            try
            {
                int DateOfBirth;
                
                string dob;
                DateOfBirth = Convert.ToInt32(str);
                if (str.Substring(0,1) == "0") {
                   dob = "0"+DateOfBirth;
                }
                else
                {
                    dob = DateOfBirth.ToString();
                }
               
                
                string day, month, year;
                day = dob.Substring(0, 2);
                month = dob.Substring(2, 2);
                year = dob.Substring(4, 4);
                int tempMonth = Convert.ToInt32(month);

                if (dob.Length > 8 || dob.Length<8)
                {
                    Console.WriteLine("Invalid input");

                }
                else
                {
                    if (int.Parse(day) < 31 && int.Parse(day) > 0 && int.Parse(month) < 12 && int.Parse(month) > 0 && int.Parse(year) < 2022 && int.Parse(year)>1800)
                    {
                        string[] MonthsName = { "Jan", "Feb", "Mar", "Apr", "May", "June", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };
                        
                        Console.WriteLine("Your date of birth is " + day + "-" + MonthsName[tempMonth-1] + "-" + year);
                    }
                    else
                    {
                        Console.WriteLine("Your date of birth is invalid");
                    }
                }




            }
            catch (Exception ex)
            {

                return false;

            }
            return true;
        }
    }



}

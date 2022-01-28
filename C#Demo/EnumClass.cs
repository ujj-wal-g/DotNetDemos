using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
    //public enum days
    //{
    //   Monday=1,Tuesday=11,Wednesday=21,Thursday=31,Friday=41,Saturday=51



    //}

    public enum color
    {
        
        red=0,yellow=1,green=2
    }

    internal class EnumClass
    {

        public static color colorname
        {

            get;set;
        }=(color).1;
     
        //   public static days meetingDays
        //   {
        //      get; set;
        //   } = days.Monday;


        //   static void na()
        //{
        //     foreach(int i in Enum.GetValues(typeof(days)))
        //       {
        //          Console.WriteLine(i);
        //      }
        //       Console.WriteLine(meetingDays);

        // }
        static void Main()
        {
        foreach(int i in Enum.GetValues(typeof(color)))
                {
                Console.WriteLine(i);
            }
        Console.WriteLine(colorname);
        }
    }
}

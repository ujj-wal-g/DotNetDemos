using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
    public delegate double delegate1(int a, float b,double c);
    public delegate void delegate2(int a, float b,double c);
    public delegate bool delegate3(string std);

    class Delegates
    {
        public static double AddNums1(int n1,float n2,double n3)
        {
            return n1 + n2+n3;
        }
        public static void AddNums2(int n1,float n2,double n3)
        {
            Console.WriteLine(n1+n2+n3);
        }
        public static bool checkLength(string str)
        {
            if(str.Length>5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Func<int,float,double,double> obj1 = AddNums1;
            double result = obj1.Invoke(100, 1.5f, 3.33);
            Console.WriteLine(result);

           Action<int,float,double> obj2 = AddNums2;
            obj2.Invoke(100, 1.5f, 3.33);

            Predicate<string > obj3 = checkLength;

            //Pradicateobj3 = checkLength;
            bool status = obj3.Invoke("Hello world");
            Console.WriteLine(status);
        }
    }
}

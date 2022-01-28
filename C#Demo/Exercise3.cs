using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
    internal class Exercise3
    {
        private static int num1,n2,res;
        public void addition()
        {
            
            Console.WriteLine("Enter a no");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second no");
            n2 = Convert.ToInt32(Console.ReadLine());
            res = num1 + n2;
            Console.WriteLine($"{num1}+{n2}={res}");
        }
        public int number1
        {

            get {
               
                return num1;
            }
            set
            {
             num1= value;
            }
        }
        
    public int number2
        {

            get
            {
                return n2;
            }
            set
            {
                n2 = value;
            }
        }

        static void Main(String[] a)
        {

            Exercise3 e = new Exercise3();
          
            e.addition();

            e.number1 = Convert.ToInt32(Console.ReadLine());
            e.number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a[0]);
           
            //Console.ReadLine();
            



        }
    }
}

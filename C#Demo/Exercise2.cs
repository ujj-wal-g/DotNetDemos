using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
    internal class Exercise2
    {
        static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter a no");
            n = Convert.ToInt32(Console.ReadLine());


            for(int i = 2; i <= n; i++)//4
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
         
        }
    }
}

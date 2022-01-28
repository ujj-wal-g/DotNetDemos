using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
     class Tupledemo
    {
        public (int, int) Math(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            return (c, d);
        }
        static void Main(string[] args)
        {
          Tupledemo td = new Tupledemo();
            
            Console.WriteLine(td.Math(5, 4));
        }
    }
}

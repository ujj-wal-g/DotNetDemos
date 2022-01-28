using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
    internal class LambdaFn
    {
        static void Main(string[] args)
        {
            Func<int, int> obj = (p => p * p);
            Console.WriteLine(obj(2));
        }
    }
}

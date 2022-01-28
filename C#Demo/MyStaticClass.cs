using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
    static  class MyStaticClass
    {
        public static void func3(this ExtensionMethod e)
        {
            Console.WriteLine("This is func3");
        }
    }
}

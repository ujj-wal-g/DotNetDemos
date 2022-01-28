using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
   class TestExtension
    {
        static void Main(string[] args)
        {
            ExtensionMethod et = new ExtensionMethod();
            et.func1();
            et.func2();

            et.func3();
        }
    }
}

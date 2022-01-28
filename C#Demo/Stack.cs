using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
    internal class Stack
    {

        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("21");
            foreach (string item in stack)
                Console.WriteLine(item);

        }
    }
}

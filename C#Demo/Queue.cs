using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
    internal class Queue
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("one");
            queue.Enqueue("two");
            queue.Enqueue("three");
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queue.Count());
            Console.WriteLine(queue.Contains("three"));

        }
    }
}

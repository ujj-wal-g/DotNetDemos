using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
   class ConsExercise
    {
        //int res;
        public ConsExercise()
        {
            Console.WriteLine( "Hello this is deafault constructor ");
        }
        public ConsExercise(String mes)
        {
            Console.WriteLine( mes);
        }
        //public ConsExercise(int a , int b)
        //{
        //    res = a + b;
        //    Console.WriteLine(res);
        //}
        static void Main(string[] args)
        {
            ConsExercise ce = new ConsExercise();
            ConsExercise ca = new ConsExercise("Hello this is parameterised constructor");
            //ConsExercise cb = new ConsExercise(4, 5);

        }
    }
}

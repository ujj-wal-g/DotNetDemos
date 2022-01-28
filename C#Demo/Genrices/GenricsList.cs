using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp.Genrics
{
   
     class GenricsList
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Ujjwal");
            list.Add("Tushar");
            list.Add("Mahaveer");
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            //list.Sort();
            //Console.WriteLine("After sorting list");
            //foreach (var item in list) 
            //{
            //    Console.WriteLine(item.ToString());
            //}

            var name = list.Find(item => item.ToString() == "Ujjwal");
            Console.WriteLine(name);

        }
    }
}

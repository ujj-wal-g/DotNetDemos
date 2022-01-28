using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{

    public class ArrayDemo
   {

        //Declaration of single diemension arrays 

        //int[] arr = new int[] { 1, 2, 3 };
        //int[] arr2 = { 1, 2, 2 };
        // static void Main(String[] args)
        // {
        // Array array = new Array();
        //int length = array.arr.Length;
        //for (int i = 0; i < length; i++)
        //{
        //    Console.WriteLine(array.arr[i]);
        //}
        //}
        //static void Main(string[] args)
        //{

        //    int[,] arr = new int[,]
        //            {
        //        { 1, 2 },
        //        { 3, 4 },
        //        { 5, 6 }
        //            };
        //    Console.WriteLine(arr.Rank);
        //    //    foreach(int i in arr)
        //    //    {
        //    //        foreach(int j in arr)
        //    //            Console.WriteLine("Elements in array{0}"arr[i][j] );
        //    //    }
        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < i; j++)
        //        {

        //            Console.WriteLine(arr[i, j]);

        //        }



        //    }
        // }

        //Printing the array in descending order using non static array class method
        //static void Main(string[] args)
        //{
        //    int[] arr = { 1, 2, 3, 4, 5 };
        //    Array ar= new Array();
        //    ar.ShortArray(arr);
        //}
        //public void ShortArray(int [] numarray)
        //{
        //    int swap = 0;
        //    for (int  i = 0; i <numarray.Length; i++)
        //    {
        //        for(int j =i+1;j<numarray.Length;j++)
        //        {
        //            if(numarray[i] < numarray[j])
        //            {
        //                swap = numarray[j];
        //                numarray[j] = numarray[i];
        //                numarray[i] = swap;
        //            }
        //        }
        //        Console.Write(numarray[i] + " ");
        //    }
        //}

        // Printing the array in descending order using array class method

        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 1, 2, 5, 7, 4 };
            Array.Sort(arr);
            //Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

        }

    }
}


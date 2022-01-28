using System;
using System.Collections;
namespace FirstDemoApp
{
    public class Collections

    {
        //public class Example<t>
        //{
        //    t box;
        //    public Example(t x)
        //    {
        //        this.box = x;
        //    }
        //    public t GetBox()
        //    {
        //        return this.box;
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Example<char> e = new Example<char>('U');
        //    Console.WriteLine(e.GetBox());
        //}

        // Get and set method in genrics

        //static void Main(string[] args)
        //{
        //    Example<int> e = new Example<int>();
        //    e.Box = 25;
        //    Console.WriteLine( e.Box);
        //}
        //public class Example<t>
        //{
        //    t box;

        //public t Box
        //   {
        //    set
        //     {
        //            this.box = value; 
        //     }
        //    get
        //    {
        //            return this.box;
        //    }
        //   }
        //}







        // ArrayList
        //In arraylist you can add data regardless of datatype.
        //  static void Main(string[] args)
        //{
        //    ArrayList al = new ArrayList();
        //    al.Add("Ujjwal");
        //    al.Add(1);
        //    al.Add('u');
        //    al.Add(0.5);
        //    al.Add(0.5f);
        //    foreach (var i in al)
        //    {
        //        Console.WriteLine(i);
        //    }

        //}

        // List
        //static void Main(string[] args)
        //{
        //    List<int> MyList = new List<int>();
        //    MyList.Add(1);
        //    MyList.Add(2);
        //    MyList.Add(3);
        //    MyList.Add(4);
        //    MyList.Add(5);
        //    MyList.Add(6);
        //    for (int i = 0; i < MyList.Count; i++)
        //    {
        //        Console.WriteLine(MyList[i]);
        //    }
        //}

        //Sorted List
        //static void Main(string[] args)
        //{

        //    SortedList<int, string> sl = new SortedList<int, string>();
        //    sl.Add(1, "Sam");
        //    sl.Add(2, "John");
        //    foreach (var i in sl)
        //    {
        //        //Console.WriteLine("Elements in sorted list is ",i.Key,i.Value);
        //        Console.WriteLine("key: {0}, value: {1}", i.Key, i.Value);
        //    }
        //}

        //Dictionary

        //static void Main(string[] args)
        //{
        //    IDictionary<int, string> dobj = new Dictionary<int, string>();
        //    dobj.Add(1, "Kim");
        //    dobj.Add(2, "jong");
        //    dobj.Add(3, "Un");
        //    foreach(KeyValuePair<int,string> kvp in dobj)
        //    {
        //        Console.WriteLine("key {0} ,Value {1}",kvp.Key,kvp.Value);
        //    }



        //}

        // Hashtable

        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(3, "three");
            ht.Add(4, "four");
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine("key {0} , value {1} ", de.Key, de.Value);
            }
            //Adding dictionary to hashtable
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            Hashtable ht3 = new Hashtable(dict);
            //Updating value to hashtable
            var cities = new Hashtable(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };
            string citiesOfUk = (string)cities["UK"];
            Console.WriteLine(cities);
            cities["UK"] = "Bristol";
            foreach (DictionaryEntry de in cities)
                Console.WriteLine("key: {0}, Value: {1}", de.Key, de.Value);

        }







    }
}
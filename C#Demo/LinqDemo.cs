using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
    public class ProductStore
    { 
        public int ProductPrice { get; set; }
        public string ProductName { get; set; }

    }

    class LinqDemo
    {
        static  void Main(string[] args)
        {

            //Using integer
            //  int [] arr = { 1, 2, 30 ,4,50,16,70,8,19,10};
            //var a =  from i in arr where i > 2 orderby i descending select i ;
            // foreach (var elements in a)
            //  {
            //      Console.Write(elements+" ");
            //  }

            //Using string 
            //string[] names = { "Ujjwal", "Tushar", "Mahaveer" };
            //var nameList = from name in names where name.Contains('j') select name;
            //foreach (var name in nameList)
            //{
            //    Console.WriteLine(" "+name);
            //}

            //Creating List
            //IList<string> Productlist = new List<string>()
            //{

            //     "Hard Disk",
            //    "Monitor",
            //    "SSD Disk",
            //    "RAM",
            //    "Processor",
            //    "Bluetooth",
            //    "Keyboard & Mouse"

            //};
            //// var listItem = from item in Productlist where item.Contains("RAM") select item;
            //var result = Productlist.Where(p => p.Contains("Disk"));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            IList<ProductStore> productlist = new List<ProductStore>();
            productlist.Add(new ProductStore() { ProductName = " ssd ", ProductPrice = 3200 });
            productlist.Add(new ProductStore() { ProductName = " RAM", ProductPrice = 2800 });
            productlist.Add(new ProductStore() { ProductName = " Monitor", ProductPrice = 11000 });
            productlist.Add(new ProductStore() { ProductName = " Keyboard", ProductPrice = 1000 });
            // var result = from p in productlist select p;
            //Lambda Method
            // var result = productlist.Select(p => p);
            //Filtering result based on price
            //var result = from p in productlist where p.ProductPrice>2000 && p.ProductPrice<5000 select p;
            //Using Linq method syntax filtering result


            // var result = productlist.Where(p => p.ProductPrice > 2000 && p.ProductPrice < 4000);
            //var result = productlist.Where(p => p.ProductName.Contains("RAM"));
            //var result = from p in productlist where p.ProductName.Contains("ssd") select p;
            var result = from p in productlist orderby p.ProductPrice ascending select p;
            foreach (var product in result)
            {
                Console.WriteLine(" ProductName{0}, ProductPrice {1} ", product.ProductName, product.ProductPrice);
            }
        }
    }
}

using System.Text;
namespace FirstDemoApp
{
    class FileHandling
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\PC\Documents\myFile.txt";
            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file, Encoding.UTF8))
                {

                    //writer.WriteLine("Hello world");
                    //Console.WriteLine( "Data written successfully");
                    //int[] arr = new int[5]
                    //{
                    //    1,2,3,4,5
                    //};
                    int[] arr = { 1, 2, 3, 4, 5 };
                    foreach (var elements in arr)
                    {
                        writer.Write(elements + " ");

                    }
                    Console.WriteLine("Data written sucessfully");
                }


            }



        }
    }
}


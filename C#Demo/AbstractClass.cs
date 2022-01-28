using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
    abstract class  Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public long PhoneNumber;

        public abstract void PrintDetails();

    }
     class Student: Person
    {
        public int RollNo;
        public int Fees;
        
        public override void PrintDetails()
        {
            string Name = this.FirstName + this.LastName;
            Console.WriteLine("Student Name is {0}:", Name);
            Console.WriteLine("Student Age is {0}:", this.Age);
            Console.WriteLine("Student Phone Number is {0}:", this.PhoneNumber);
            Console.WriteLine("Student RollNo is {0}:", this.RollNo);
            Console.WriteLine("Student Fees is {0}:", this.Fees);


        }


    }
    public class AbstractClass
    {
        static void Main(string[] args)
        {
            Student john = new Student();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Age = 20;
            john.PhoneNumber = 5455215555;
            john.RollNo = 111;
            john.Fees = 4000;
            john.PrintDetails();
        }
    
    }

}

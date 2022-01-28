using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoApp
{
    //Encapsulation
    class OOPSConcept
    {


        //public class Person
        //{
        //    private string Name;
        //    private int age;

        //    public void setName(string name)
        //    {
        //        if (string.IsNullOrEmpty(name))
        //        {
        //            Console.WriteLine("Please Enter a valid name");
        //        }
        //        else
        //        {
        //            this.Name = name;
        //        }
        //    }
        //    public void getName()
        //    {
        //        if (string.IsNullOrEmpty(Name))
        //        {
        //        }
        //        else
        //        {
        //            Console.WriteLine("Your name is {0}", this.Name);
        //        }
        //    }

        //    public void setAge(int age)
        //    {
        //        if (age > 0)
        //        {
        //            this.age = age;
        //        }
        //        else
        //        {
        //            Console.WriteLine("You are not old enough ");
        //        }
        //    }
        //    public void getAge()
        //    {
        //        if (this.age > 0)
        //        {
        //            Console.WriteLine("Your age is {0}", this.age);
        //        }
        //        else
        //        {
        //            return;
        //        }
        //    }
        //}


        //static void Main()
        //{
        //    Person p = new Person();
        //    int ag;
        //    string nm;
        //    Console.WriteLine("Please Enter your name");
        //    nm = Console.ReadLine();
        //    Console.WriteLine("Please enter your age");
        //    ag = Convert.ToInt32(Console.ReadLine());
        //    p.setName(nm);
        //    p.getName();
        //    p.setAge(ag);
        //    p.getAge();


        //}

        //abstraction 

        //   abstract class Animal
        //{
        //    // Abstract method (does not have a body)
        //    public abstract void animalSound();

        //    public void sleep()
        //    {
        //        Console.WriteLine("Zzz");
        //    }
        //}

        //// Derived class (inherit from Animal)
        //class Pig : Animal
        //{
        //    public override void animalSound()
        //    {

        //        Console.WriteLine("The pig says: wee wee");
        //    }
        //}

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        Pig myPig = new Pig(); 
        //        myPig.animalSound();  
        //        myPig.sleep();  
        //    }
        //}
        

        //Polymorphism and Inheritance
        class Animal  // Base class (parent) 
        {
            public void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal  // Derived class (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal  // Derived class (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }

        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
            
        }







    }
}

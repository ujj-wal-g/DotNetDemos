using System;
namespace EntityFrameworkCoreDemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(var context = new SchoolContext())
            {
                var std = new Student();
                std.StudentId = 2;
                std.StudentName = "Rahul";
                std.Height = 165.5f;
                std.Weight = 65.1f;
                std.Department = "CSE";

                //Creating new entity in table

                context.Students.Add(std);
                context.SaveChanges();

                //Updating an entity in table 

                context.Students.Update(std);
                context.SaveChanges();

                // Removing an entity from table

                //context.Students.Remove(std);
                //context.SaveChanges();


            }



        }
    }

}

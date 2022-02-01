using System;
 namespace FluentAPIDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                var EmpObj = new Employee();
                var Deptobj = new Department();
                var TeamObj = new Team();
               // EmpObj.EmployeeId = 121;
                EmpObj.EmpName = "Ujjwal Goyal";
                EmpObj.Email = "abcd@gmail.com";
                EmpObj.PrimaryContact = 1234567890;
               // Deptobj.DeptId = 121;
               // TeamObj.TeamId = 123;

                context.Employees.Add(EmpObj);
              //  context.Departments.Add(Deptobj);
              //  context.Teams.Add(TeamObj);
                context.SaveChanges();
            }

        }

    }
}

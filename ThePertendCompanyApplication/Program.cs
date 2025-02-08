using TCPData;
using TCPExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ThePertendCompanyApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = Data.GetEmployee();
            var filterd = employees.Where(emp => emp.FirstName == "Belal");
            foreach (var item in filterd)
            {
                Console.WriteLine($"Firstname :{item.FirstName}");
                Console.WriteLine($"Lastname :{item.LastName}");
                Console.WriteLine($"AnualSalary :{item.AnnualSalary}");
                Console.WriteLine($"DepartmentId :{item.DepartmentId}\n");
            }

            List<Department> departments = Data.GetDepartMent();
            var filteration = departments.Where(depart => depart.ShortName == "HR" || depart.ShortName == "TE");
            foreach (var depart in filteration)
            {
                Console.WriteLine($"ID :{depart.Id}");
                Console.WriteLine($"Shortname :{depart.ShortName}");
                Console.WriteLine($"LongName :{depart.LongName}\n");

            }


            Console.ReadLine();
        }
    }
}

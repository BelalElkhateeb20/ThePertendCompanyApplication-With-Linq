using TCPData;
using TCPExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
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
////First Case of Where >>>>>>>>Filterations
            var filteration = departments.Where(depart => depart.ShortName == "HR" || depart.ShortName == "TE");
            //second Case of Where >>>>>>>>

            filteration = departments.Where((p, i) => p.ShortName[0]=='H'&&i <5/*first Five Element only */);//You can't Do this With Query syntax

            foreach (var depart in filteration)
            {
                Console.WriteLine($"ID :{depart.Id}");
                Console.WriteLine($"Shortname :{depart.ShortName}");
                Console.WriteLine($"LongName :{depart.LongName}\n");
            }
            //Case one of Select
////Select:Transfotmaion operator If i Want to select All My Data(FirstName,LastName...... ) 
////Projrct /Transform every Element in Seq To A new Element in Seq of new DataType
            var NameVal = employees.Select(select=> new { ID=select.FirstName , select.LastName}); //Anonymous Type 
            foreach (var item in NameVal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
            //Case Two of Select >>Indexed Select Valid only in fluent syntax Query
            List<Products> products = Data.GetProducts();
            var Result =products.Select((sel,i) => new { index=i, Category = sel.Category, IsStocked = sel.IsStocked });
            foreach (var items in Result)
            {
                Console.WriteLine(items);
            }

            Console.ReadLine();
        }
    }
}

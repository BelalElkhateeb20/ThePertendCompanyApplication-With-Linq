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
            Console.WriteLine("\n ");

            //Case Two of Select >>Indexed Select Valid only in fluent syntax Query
            List<Products> products = Data.GetProducts();
            var Result =products.Select((sel,i) => new { index=i, Category = sel.Category, IsStocked = sel.IsStocked });
            foreach (var items in Result)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("\n ");

//OrderBy Elements (OrderBy,OrderByDescending,.ThenBy.ThenByDescending) Imidiate Execution
            var order = products.OrderBy(p => p.Id).Select(sel => new {id=sel.Id, Price = sel.Price});// From the small to large
            //var order = products.OrderByDescending(p => p.Id).Select(sel => new {id=sel.Id, Price = sel.Price}); // reverse to orderby
//Element Operator >>return singel element-Imidiate Execution 
            var last = products.Last(p => p.IsStocked == true);
            Console.WriteLine(last?.Name??"nA"); //single Element
            foreach (var i in order)
            {
                Console.WriteLine(i);
            }
            List<int> nums = new List<int>();
            var empty = nums.FirstOrDefault();// return First element or defult value if seq is empty
            var empty1 = nums.LastOrDefault();// return last element or defult value if seq is empty
            var empty2 = nums.LastOrDefault(p=>p/*.....*/==0);// return last element or defult value if seq is empty
            // NO Element Matching the predicate use FirstOrDefault



            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public static class Data
    {
        public static List<Employee> GetEmployee()

        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Belal", LastName = "Elkhateeb", AnnualSalary = 18000.0m, IsManager = true, DepartmentId = 1 },
                new Employee { Id = 2, FirstName = "Mohamed", LastName = "Elkhateeb", AnnualSalary = 15000.0m, IsManager = false, DepartmentId = 2 },
                new Employee { Id = 3, FirstName = "Ramy", LastName = "Elkhbat", AnnualSalary = 7000.0m, IsManager = false, DepartmentId = 3 },
                new Employee { Id = 4, FirstName = "Sarah", LastName = "Khaled", AnnualSalary = 12000.0m, IsManager = true, DepartmentId = 4 },
                new Employee { Id = 5, FirstName = "Omar", LastName = "Hassan", AnnualSalary = 9500.0m, IsManager = false, DepartmentId = 5 },
                new Employee { Id = 6, FirstName = "Laila", LastName = "Youssef", AnnualSalary = 11000.0m, IsManager = false, DepartmentId = 6 },
                new Employee { Id = 7, FirstName = "Hadi", LastName = "Samir", AnnualSalary = 13000.0m, IsManager = true, DepartmentId = 7 },
                new Employee { Id = 8, FirstName = "Nour", LastName = "Adel", AnnualSalary = 8000.0m, IsManager = false, DepartmentId = 8 },
                new Employee { Id = 9, FirstName = "Kareem", LastName = "Mahmoud", AnnualSalary = 14500.0m, IsManager = false, DepartmentId = 9 },
                new Employee { Id = 10, FirstName = "Dina", LastName = "Mostafa", AnnualSalary = 10000.0m, IsManager = true, DepartmentId = 10 }
            };
            return employees;
        }
        public static List<Department> GetDepartMent()
        {
            List<Department> departments = new List<Department>()
            {
               new Department { Id = 1, ShortName = "HR", LongName = "Human Resources" },
               new Department { Id = 2, ShortName = "IT", LongName = "Information Technology" },
               new Department { Id = 3, ShortName = "FIN", LongName = "Finance" },
               new Department { Id = 4, ShortName = "MKT", LongName = "Marketing" },
               new Department { Id = 5, ShortName = "SALES", LongName = "Sales" },
               new Department { Id = 6, ShortName = "OPS", LongName = "Operations" },
               new Department { Id = 7, ShortName = "ENG", LongName = "Engineering" },
               new Department { Id = 8, ShortName = "PR", LongName = "Public Relations" },
               new Department { Id = 9, ShortName = "QA", LongName = "Quality Assurance" },
               new Department { Id = 10,ShortName = "CS", LongName = "Customer Support" }
            };
            return departments;
        }
        public static List<Products> GetProducts()
        {
            List<Products> products = new List<Products>
        {
            new Products { Id = 1, Name = "Laptop", Price = 1200.50m, Category = "Electronics", IsStocked = true },
            new Products { Id = 8, Name = "Smartphone", Price = 800.99m, Category = "Electronics", IsStocked = true },
            new Products { Id = 3, Name = "Office Chair", Price = 150.75m, Category = "Furniture", IsStocked = false },
            new Products { Id = 4, Name = "Desk", Price = 300.00m, Category = "Furniture", IsStocked = true },
            new Products { Id = 5, Name = "Headphones", Price = 100.25m, Category = "Electronics", IsStocked = false },
            new Products { Id = 18, Name = "Monitor", Price = 250.99m, Category = "Electronics", IsStocked = true },
            new Products { Id = 7, Name = "Keyboard", Price = 50.49m, Category = "Electronics", IsStocked = true },
            new Products { Id = 8, Name = "Mouse", Price = 30.99m, Category = "Electronics", IsStocked = false },
            new Products { Id = 15, Name = "Printer", Price = 180.00m, Category = "Office Supplies", IsStocked = true },
            new Products { Id = 1, Name = "Notebook", Price = 5.99m, Category = "Office Supplies", IsStocked = true }
        };

            return products;
        }
    }
}

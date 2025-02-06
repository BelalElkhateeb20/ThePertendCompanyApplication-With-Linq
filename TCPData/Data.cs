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
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee()
            {
                Id =1,
                Firstname = "Belal",
                Lastname="Elkhateb",
                AnualSalary =4060.4m,
                IsManager =true,
                DepartmentId =1


            };
             employees.Add(employee);
             employee = new Employee()
            {
                Id =2,
                Firstname = "Mohamed",
                Lastname="Elkhateb",
                AnualSalary =15000.1m,
                IsManager =false,
                DepartmentId =2


            };
            employees.Add(employee);
            employee = new Employee()
            {
                Id =3,
                Firstname = "mansy",
                Lastname="Elkhateb",
                AnualSalary =7000.1m,
                IsManager =false,
                DepartmentId =2


            };
            employees.Add(employee);

            return employees;
        }
        public static List<Department> GetDepartMent()
        {
            List<Department> departments = new List<Department>();
            Department department = new Department()
            {
                Id = 1,
                Shortname ="HR",
                LongName="Human Resourcses",


            };
            departments.Add(department);
            department = new Department()
            {
                Id = 2,
                Shortname ="FN",
                LongName="Finance",


            };
            departments.Add(department);

            department = new Department()

            {
                Id = 3,
                Shortname ="TE",
                LongName="technology"
            };
            departments.Add(department);


            return departments;
        }
    }
}

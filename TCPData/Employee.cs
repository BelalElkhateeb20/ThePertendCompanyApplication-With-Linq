using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
     public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal AnualSalary { get; set; }
        public bool IsManager { get; set; }
        public int DepartmentId { get; set; }


    }
}

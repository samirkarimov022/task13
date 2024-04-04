using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public bool IsSuccessful { get; set; }
        public int Salary { get; set; }

        public Employee(string name, bool isSuccessful, int salary)
        {
            Name = name;
            IsSuccessful = isSuccessful;
            Salary = salary;
        }
    }
}

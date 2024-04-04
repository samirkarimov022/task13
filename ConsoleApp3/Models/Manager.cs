using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Manager:Assistant
    {
        public void GetPromotion(Employee employee)
        {

            Console.WriteLine($"{employee.Name} bonus qazandi");
            employee.Salary += 100;
            Console.WriteLine("sizin yekun maasiniz:" + employee.Salary);



        }
    }
}

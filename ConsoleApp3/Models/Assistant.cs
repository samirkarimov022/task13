using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Assistant
    {
        public void GetFeedback(Employee employee)
        {
            if (employee.IsSuccessful)
            {
                Manager manager = new Manager();
                manager.GetPromotion(employee);
            }
            else { Console.WriteLine("maas" + employee.Salary); }
        }
    }
}

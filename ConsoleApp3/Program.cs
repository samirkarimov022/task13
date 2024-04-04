using ConsoleApp3.Models;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("emil", true, 770);
            Employee employee1 = new Employee("garib", false, 530);

            Assistant Asisitant = new Assistant();
            Asisitant.GetFeedback(employee);
            Asisitant.GetFeedback(employee1);

        }
    }
}

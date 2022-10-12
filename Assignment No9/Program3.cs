using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No9
{
    public class Program3
    {
        static void Main(string[] args)
        {
            Employee2 e1 = new Employee2("emp1", 22000);
            Employee2 e2 = new Employee2("emp2", 23000);
            Employee2 e3 = new Employee2("emp3", 24000);
            e1.CalculateSalary();
            e2.CalculateSalary();
            e3.CalculateSalary();

            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(Employee2.TotalCount());

        }
    }
}

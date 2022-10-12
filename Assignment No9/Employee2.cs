using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No9
{
    public class Employee2
    {
            private int id;
            private string name;
            private int salary;
            private static int count;
            private int HRA, DA, PF, netpaid;
            public Employee2(string name, int salary)
            {
                count++;
                this.id = count;
                this.name = name;
                this.salary = salary;
            }
            public  void CalculateSalary()

            {
                HRA = (salary * 40) / 100;
                DA = (salary * 20) / 100;
                PF = (salary * 12) / 100;
                netpaid = (HRA + DA + salary) - PF;
            }
            public static string TotalCount()
            {
                return $"Total count is {count}";
            }
            public override string ToString()
            {
                return $"Id :{id} Name :{name} Salary :{salary}  NetPaid :{netpaid}";
            }
        
    }
}

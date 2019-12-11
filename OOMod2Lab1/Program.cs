using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod2Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            TechnicalEmployee techEmp1 = new TechnicalEmployee("Jackson");
            BusinessEmployee busEmp1 = new BusinessEmployee("Autumn");
            Employee emp1 = new Employee("Robert", 40000);


            Console.WriteLine(techEmp1.EmployeeStatus());
            Console.WriteLine(busEmp1.EmployeeStatus());
            Console.WriteLine(emp1.EmployeeStatus());
        }
    }
}

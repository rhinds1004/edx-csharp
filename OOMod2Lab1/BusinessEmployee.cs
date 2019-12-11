using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod2Lab1
{
    public class BusinessEmployee : Employee
    {

        public int BonusBudget { get; set; } = 1000;

        public BusinessEmployee(string name) : base(name, 50000)
        {
            
        }

        public override string EmployeeStatus()
        {
            return $"{GetEmployeeID()} {GetName()} Bonus budget: {BonusBudget}";
        }
    }
}

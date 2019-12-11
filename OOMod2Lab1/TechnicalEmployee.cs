using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod2Lab1
{
    public class TechnicalEmployee : Employee
    {
        private int _successfulCheckIns = 5;

        public TechnicalEmployee(string name) : base(name, 75000.00)
        {

        }

        public int SuccessfulCheckIns { get => _successfulCheckIns; set => _successfulCheckIns = value; }
        public override string EmployeeStatus()
        {
            return $"{GetEmployeeID()} {GetName()} Successful checkins: {SuccessfulCheckIns} ";
        }
    }
}

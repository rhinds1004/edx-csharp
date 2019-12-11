using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod2Lab1
{
    public class Employee
    {
        private string _name;
        private double _baseSalary;
        private int _employeeID = 0;
        private static int _employeeCount = 1;


    
        public int EmployeeID { get => _employeeID; set => _employeeID = value; }

        public Employee(string name, double baseSalary)
        {
            _name = name;
            _baseSalary = baseSalary;
            EmployeeID = _employeeCount++;
        }

        public double GetBaseSalary()
        {
            return _baseSalary;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetEmployeeID()
        {
            return _employeeID;
        }

        public new string ToString()
        {
            return $"{GetEmployeeID()} {GetName()}";
        }

        public virtual string EmployeeStatus()
        {
            return $"{ToString()} is in the comapany's system";
        }


    }
}

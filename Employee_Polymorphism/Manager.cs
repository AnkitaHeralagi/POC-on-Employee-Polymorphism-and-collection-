using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Polymorphism
{
    internal class Manager : Employee
    {
        public override decimal CalculateSalary()
        {
            decimal TA = 0.5m * BasicSalary;
            decimal DA = 0.4m * BasicSalary;
            return BasicSalary + TA + DA;
        }
    }
}

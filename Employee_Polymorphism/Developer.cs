using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Polymorphism
{
    internal class Developer : Employee
    {
        public override decimal CalculateSalary()
        {
            decimal PA = 0.4m * BasicSalary;
            return BasicSalary + PA;
        }
    }
}

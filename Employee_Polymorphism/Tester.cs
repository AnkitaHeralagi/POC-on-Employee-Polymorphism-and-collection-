using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Polymorphism 
{
    internal class Tester : Employee
    {
        public override decimal CalculateSalary()
        {
            decimal Perks = 0.3m * BasicSalary;
            return BasicSalary + Perks;
        }
    }
}

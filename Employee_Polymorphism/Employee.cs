using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Polymorphism
{
    abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BasicSalary { get; set; }

        public abstract decimal CalculateSalary();

        public void Display()
        {
            decimal monthly = CalculateSalary();
            decimal annual = monthly * 12;

            Console.WriteLine($"Type: {this.GetType().Name}");
            Console.WriteLine($"ID: {Id}, Name: {Name}");
            Console.WriteLine($"Monthly Salary: {monthly:F2}");
            Console.WriteLine($"Annual CTC: {annual:F2}");
            Console.WriteLine("-----------------------------------");
        }
    }
}

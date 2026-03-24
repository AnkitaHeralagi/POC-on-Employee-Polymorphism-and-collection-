using System;
using System.Collections.Generic;

namespace Employee_Polymorphism
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("\n******* Employee Management ******");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View Employees");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input! Enter a number.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        AddEmployee(employees);
                        break;
                    case 2:
                        DisplayEmployees(employees);
                        break;
                    case 3:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
        static void AddEmployee(List<Employee> employees)
        {
            int type;

            while (true)
            {
                Console.WriteLine("\nSelect Employee Type:");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. Developer");
                Console.WriteLine("3. Tester");
                Console.Write("Enter type: ");
                if (!int.TryParse(Console.ReadLine(), out type) || type < 1 || type > 3)
                {
                    Console.WriteLine("Invalid type! Please enter 1, 2 or 3.");
                    continue;
                }
                break;
            }
            Console.Write("Enter ID: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID!");
                return;
            }
            if (employees.Exists(e => e.Id == id))
            {
                Console.WriteLine("Employee with this ID already exists!");
                return;
            }
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty!");
                return;
            }
            Console.Write("Enter Basic Salary: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal salary) || salary <= 0)
            {
                Console.WriteLine("Invalid salary!");
                return;
            }
            Employee emp;
            switch (type)
            {
                case 1:
                    emp = new Manager { Id = id, Name = name, BasicSalary = salary };
                    break;

                case 2:
                    emp = new Developer { Id = id, Name = name, BasicSalary = salary };
                    break;

                default:
                    emp = new Tester { Id = id, Name = name, BasicSalary = salary };
                    break;
            }

            employees.Add(emp);
            Console.WriteLine("Employee added successfully!");
        }
        static void DisplayEmployees(List<Employee> employees)
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("\nNo employees available.");
                return;
            }
            Console.WriteLine("\n-----|Employee Details|-----");
            foreach (Employee emp in employees)
            {
                emp.Display();
            }
        }
    }
}
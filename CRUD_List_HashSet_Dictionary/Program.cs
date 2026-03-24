using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("----- LIST CRUD OPERATIONS -----");
        List<string> students = new List<string>();

        // Create (Add)
        students.Add("Ankita");
        students.Add("Rahul");
        students.Add("Kiran");

        // Read (Display)
        Console.WriteLine("\nInitial List:");
        foreach (var s in students)
        {
            Console.WriteLine(s);
        }

        // Update
        students[1] = "Sneha"; // Rahul to Sneha

        // Delete
        students.Remove("Kiran");

        Console.WriteLine("\nAfter Update & Delete:");
        foreach (var s in students)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("\n----- HASHSET CRUD OPERATIONS -----");
        HashSet<int> numbers = new HashSet<int>();

        // Create (Add)
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(20); // duplicate ignored

        // Read
        Console.WriteLine("\nInitial Set:");
        foreach (var n in numbers)
        {
            Console.WriteLine(n);
        }

        // Update (remove + add)
        numbers.Remove(10);
        numbers.Add(30);

        // Delete
        numbers.Remove(20);

        Console.WriteLine("\nAfter Update & Delete:");
        foreach (var n in numbers)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("\n----- DICTIONARY CRUD OPERATIONS -----");
        Dictionary<int, string> studentData = new Dictionary<int, string>();

        // Create (Add)
        studentData.Add(101, "Ankita");
        studentData.Add(102, "Rahul");
        studentData.Add(103, "Kiran");

        // Read
        Console.WriteLine("\nInitial Dictionary:");
        foreach (var item in studentData)
        {
            Console.WriteLine("Roll No: " + item.Key + " Name: " + item.Value);
        }

        // Update
        studentData[102] = "Sneha";

        // Delete
        studentData.Remove(103);

        Console.WriteLine("\nAfter Update & Delete:");
        foreach (var item in studentData)
        {
            Console.WriteLine("Roll No: " + item.Key + " Name: " + item.Value);
        }
    }
}
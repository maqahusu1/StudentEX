
using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentEX;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        while (true)
        {
            Console.WriteLine("\nStudent Management System");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Remove Student");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1": AddStudent(); break;
                case "2": DisplayStudents(); break;
                case "3": UpdateStudent(); break;
                case "4": RemoveStudent(); break;
                case "5": return;
                default: Console.WriteLine("Invalid option, try again."); break;
            }
        }
    }
}



   
public static class Extensions
{
   
    public static int CountVowels(this string str)
    {
        if (string.IsNullOrEmpty(str)) return 0;
        return str.Count(c => "aeiouAEIOU".Contains(c));
    }

    // Applies discount to a decimal value
    public static decimal ApplyDiscount (this decimal price, decimal discountPercentage)
    {
        if (discountPercentage < 0 || discountPercentage > 100)
            throw new ArgumentOutOfRangeException("Discount percentage must be between 0 and 100.");
        return price - (price * (discountPercentage / 100));
    }
}
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}


{
    static List<Student> students = new List<Student>();
    static int idCounter = 1;

   

    static void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Console.Write("Enter student age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            students.Add(new Student { Id = idCounter++, Name = name, Age = age });
            Console.WriteLine("Student added successfully.");
        }
        else Console.WriteLine("Invalid age.");
    }

    static void DisplayStudents()
    {
        if (students.Count == 0)
        Console.WriteLine("No students available.");


        else students.ForEach(s => Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}"));
    }

    static void UpdateStudent()
    {
        Console.Write("Enter student ID to update: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                Console.Write("Enter new name: ");
                student.Name = Console.ReadLine();
                Console.Write("Enter new age: ");
                if (int.TryParse(Console.ReadLine(), out int age)) student.Age = age;
                Console.WriteLine("Student updated successfully.");
            }
            else Console.WriteLine("Student not found.");
        }
    }

    static void RemoveStudent()
    {
        Console.Write("Enter student ID to remove: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student removed successfully.");
            }
            else Console.WriteLine("Student not found.");
        }
    }
}

}


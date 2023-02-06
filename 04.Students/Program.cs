using System;
using System.Collections.Generic;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] arr = command.Split();
                Student student = new Student(arr[0], arr[1], arr[2], arr[3]);
                listOfStudents.Add(student);
            }
            string town = Console.ReadLine();
            foreach (Student student in listOfStudents)
            {
                if (town == student.Hometown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
        class Student
        {
            public Student(string firstName, string lastName, string age, string homeTown)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Hometown = homeTown;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string Hometown { get; set; }
        }
    }
}

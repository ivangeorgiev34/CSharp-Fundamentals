using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split(" : ").ToArray();
                string courseName = tokens[0];
                string studentName = tokens[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);
                input = Console.ReadLine();
            }
            foreach (var course in courses)
            {
                string courseName = course.Key;
                var studentName = course.Value;
                Console.WriteLine($"{courseName}: {studentName.Count}");
                foreach (var student in studentName)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split(" -> ").ToArray();
                string companyName = tokens[0];
                string employeeID = tokens[1];
                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }
                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }
                command = Console.ReadLine();
            }
            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}

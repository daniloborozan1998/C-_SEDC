using System;
using System.Collections.Generic;
using Task04_Classes.Classes;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){FirstName = "Danilo", LastName = "Borozan", Age = 23},
                new Employee(){FirstName = "Steve", LastName = "Stevanoski", Age = 22},
                new Employee(){FirstName = "Elizabeth", LastName = "Johnston", Age = 22},
                new Employee(){FirstName = "Rose", LastName = "Redmington", Age = 21},
                new Employee(){FirstName = "Petar", LastName = "Peterson", Age = 20},
                new Employee(){FirstName = "Alexandro", LastName = "Alexandridis", Age = 28},
                new Employee(){FirstName = "Jessi", LastName = "Lingard", Age = 27},
                new Employee(){FirstName = "Anamarija", LastName = "Risteska", Age = 24},
                new Employee(){FirstName = "Krisitjan", LastName = "Sofronijoski", Age = 26},
                new Employee(){FirstName = "Ana", LastName = "Nakeska", Age = 24},
            };


            Dictionary<int, List<string>> dictionaryOfEmployees = new Dictionary<int, List<string>>();

            foreach (var employee in employees)
            {
                if (dictionaryOfEmployees.ContainsKey(employee.Age))
                {
                    List<string> newList = dictionaryOfEmployees[employee.Age];
                    newList.Add($"{employee.FirstName} {employee.LastName}");
                    dictionaryOfEmployees[employee.Age] = newList;
                }
                else
                {
                    dictionaryOfEmployees.Add(employee.Age, new List<string> { $"{ employee.FirstName} {employee.LastName}" });
                }
                
            }
            foreach (var keys in dictionaryOfEmployees)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine($"Employees with {keys.Key} years -");
                foreach (var name in keys.Value)
                {
                    Console.WriteLine(name);
                }
            }



            Console.ReadLine();
        }
    }
}

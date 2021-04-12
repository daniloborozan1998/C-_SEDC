using System;
using Domain.Classes;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager firstManager = new Manager("Lea", "Leova",1200);
            Manager secondManager = new Manager("John", "Johnsky",1100);
            SalesPerson salesPerson = new SalesPerson("Mona", "Monalisa");
            Contractor firstContractor = new Contractor("Bob ", "Bobert", 6.5,450,firstManager);
            Contractor secondContractor = new Contractor("Rick ", "Rickert", 5.5,400,secondManager);

            firstContractor.GetSalary();
            secondContractor.GetSalary();
            
            firstManager.AddBonus();
            firstManager.GetSalary();
            
            secondManager.AddBonus();
            secondManager.GetSalary();

            salesPerson.AddSuccessRevenue(30000);
            salesPerson.GetSalary();

            Employee[] company = new Employee[]
            {
                firstManager,
                secondManager,
                salesPerson,
                firstContractor,
                secondContractor
            };

            CEO empl = new CEO("Ron", "Ronsky", 1500, company);

            double ceoSalary = empl.GetSalary();
            string infoCEO = empl.PrintInfo();

            Console.WriteLine(infoCEO);
            Console.WriteLine($"Salary of CEO is: {empl.GetSalary()}");
            Console.WriteLine("Employees: ");
            empl.PrintEmployee();


            Console.ReadLine();
        }
    }
}

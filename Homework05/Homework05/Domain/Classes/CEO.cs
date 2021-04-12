using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Classes
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public void AddSharesPrice(double sharesPriceNew)
        {
            SharesPrice += sharesPriceNew;
        }

        public void PrintEmployee()
        {
            foreach (Employee perosn in Employees)
            {
                Console.WriteLine(perosn.PrintInfo());
            }
        }

        public override double GetSalary()
        {
            Salary = Salary + Shares * SharesPrice;
            return Salary;
        }

        public CEO(string firstName, string lastName,int shares,Employee[] employees) : base(firstName, lastName)
        {
            Salary = 500;
            Role = RoleEnum.CEO;
            FirstName = firstName;
            LastName = lastName;
            Shares = shares;
            Employees = employees;
            SharesPrice = 10000;
        }
    }
}

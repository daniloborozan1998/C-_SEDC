using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Classes
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }

        public void AddBonus()
        {
            _bonus = new Random().Next(2000, 5000);
        }
        public override double GetSalary()
        {
            Salary += _bonus;
            return Salary;
        }

        public Manager(string firstName,string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = RoleEnum.Manager;
            Salary = 1000;
        }
    }
}

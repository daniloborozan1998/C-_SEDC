using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }
        protected double Salary { get; set; }

        public string PrintInfo()
        {
            return $"First Name: {FirstName} Last Name: {LastName} Role: {Salary}";

        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

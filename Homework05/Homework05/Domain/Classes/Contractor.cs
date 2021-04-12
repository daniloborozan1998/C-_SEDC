using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Classes
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Employee Responsible { get; set; }

        public RoleEnum CurrentPosition()
        {
            return Role;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Employee responsible) :
            base(firstName, lastName)
        {
            Role = RoleEnum.Contractor;
            FirstName = firstName;
            LastName = lastName;
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }
    }
}

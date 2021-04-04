using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    public class Driver
    {
        public String Name { get; set; }
        public int Skill { get; set; }

        public Driver(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using  Task3_Classes.Enums;
using Enum = Task3_Classes.Enums.Enum;


namespace Task3_Classes.Classes
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public  Enum Gender { get; set; }

       
    }
}

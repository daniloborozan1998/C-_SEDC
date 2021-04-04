using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    public class Car
    {
        public String Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        public Car(string model, int speed,Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }

        public int CalculateSpeed(Driver driver)
        {
            
            int result = driver.Skill* Speed;
            return result;
        }

        


    }
}

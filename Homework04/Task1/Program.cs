using System;
using Task1.Models;

namespace Task1
{
    class Program
    {
        static void RaceCars(Car carNumber01, Car carNumber02)
        {
            int win = carNumber01.CalculateSpeed(carNumber01.Driver) - carNumber02.CalculateSpeed(carNumber02.Driver);
            if (win > 0)
            {
                Console.WriteLine($"Driver: {carNumber01.Driver.Name} Model: {carNumber01.Model} Speed: {carNumber01.Speed} vs Driver: {carNumber02.Driver.Name} Model: {carNumber02.Model} Speed: {carNumber02.Speed}  \n ==> The {carNumber01.Driver.Name} is winner!!! ");
            }
            else if (win < 0)
            {
                Console.WriteLine($"Driver: {carNumber01.Driver.Name} Model: {carNumber01.Model} Speed: {carNumber01.Speed} vs Driver: {carNumber02.Driver.Name} Model: {carNumber02.Model} Speed: {carNumber02.Speed}  \n ==> The {carNumber02.Driver.Name} is winner!!!");
            }
            else
            {
                Console.WriteLine($"Driver: {carNumber01.Driver.Name} Model: {carNumber01.Model} Speed: {carNumber01.Speed} vs Driver: {carNumber02.Driver.Name} Model: {carNumber02.Model} Speed: {carNumber02.Speed}  \n ==> {carNumber01.Driver.Name} and {carNumber02.Driver.Name} have the same speed");
            }
        }
        static void Main(string[] args)
        {
            Car[] myAutoCars = new Car[]
            {
                new Car("Golf", 120),
                new Car("BMW", 110),
                new Car("AUDI", 180),
                new Car("Mercedes", 160)
            };
            
            Driver[] drivers = new Driver[]
            {
                new Driver("Gilliland", 6),
                new Driver("Edwards", 2),
                new Driver("Busch", 9),
                new Driver("Gordon", 8)
            };
            bool success = false;
            do
            {

                Console.WriteLine("Please choose a car model for the first driver");
                foreach (Car cars in myAutoCars)
                {
                    Console.WriteLine(cars.Model);
                }

                Console.WriteLine("Enter model:");
                string firstCar = Console.ReadLine();
                string firstModel = "";
                int firstSpeed = 0;
                int counter = 0;

                Car[] newCar = new Car[] { };
                for (int i = 0; i < myAutoCars.Length; i++)
                {
                    if (firstCar.ToLower() == myAutoCars[i].Model.ToLower())
                    {
                        firstModel = myAutoCars[i].Model;
                        firstSpeed = myAutoCars[i].Speed;
                        continue;

                    }
                    else if (firstCar.ToLower() != myAutoCars[i].Model.ToLower())
                    {
                        Array.Resize(ref newCar, newCar.Length + 1);
                        newCar[counter++] = myAutoCars[i];
                    }
                }

                if (myAutoCars.Length == newCar.Length)
                {
                    Console.WriteLine("Please enter the model of car that is offered");
                    break;

                }

                Console.WriteLine("Please choose a driver for the first car");
                foreach (Driver driver in drivers)
                {
                    Console.WriteLine(driver.Name);
                }

                string name = "";
                int firstSkill = 0;
                Console.WriteLine("Enter driver name:");
                string firstDriverName = Console.ReadLine();
                int counterOfDrivers = 0;
                Driver[] newDrivers = new Driver[] { };
                for (int i = 0; i < myAutoCars.Length; i++)
                {
                    if (firstDriverName.ToLower() == drivers[i].Name.ToLower())
                    {
                        name = drivers[i].Name;
                        firstSkill = drivers[i].Skill;
                        continue;
                    }
                    else if (firstDriverName.ToLower() != drivers[i].Name.ToLower())
                    {
                        Array.Resize(ref newDrivers, newDrivers.Length + 1);
                        newDrivers[counterOfDrivers++] = drivers[i];

                    }
                }

                if (drivers.Length == newDrivers.Length)
                {
                    Console.WriteLine("Please enter the driver for car that is offered");
                    break;
                }

                Console.WriteLine("Please choose a car model for the second driver");
                foreach (Car cars in newCar)
                {
                    Console.WriteLine(cars.Model);
                }

                Console.WriteLine("Enter model:");
                string secondCarModel = Console.ReadLine();

                string secondModel = "";
                int secondSpeed = 0;
                for (int i = 0; i < newCar.Length; i++)
                {
                    if (secondCarModel.ToLower() == newCar[i].Model.ToLower())
                    {
                        secondModel = newCar[i].Model;
                        secondSpeed = newCar[i].Speed;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (secondModel == "" && secondSpeed == 0)
                {
                    Console.WriteLine("No car for race");
                    break;
                }

                Console.WriteLine("Please choose a driver for the second car");
                foreach (Driver driver in newDrivers)
                {
                    Console.WriteLine(driver.Name);

                }

                string secondName = "";
                int secondSkill = 0;
                Console.WriteLine("Enter driver name:");
                string secondDriver = Console.ReadLine();
                for (int i = 0; i < newDrivers.Length; i++)
                {
                    if (secondDriver.ToLower() == newDrivers[i].Name.ToLower())
                    {
                        secondName = newDrivers[i].Name;
                        secondSkill = newDrivers[i].Skill;
                        break;
                    }
                    else if (secondDriver.ToLower() != newDrivers[i].Name.ToLower())
                    {
                        continue;
                    }
                }

                if (secondName == "" && secondSkill == 0)
                {
                    Console.WriteLine("There is not such a driver for this car");
                    break;
                }

                Driver firDriver = new Driver(name, firstSkill);
                Driver secDriver = new Driver(secondName, secondSkill);
                Car firCar = new Car(firstModel, firstSpeed, firDriver);
                Car secCar = new Car(secondModel, secondSpeed, secDriver);

                RaceCars(firCar, secCar);

                Console.WriteLine("Do you want a new race (yes / no)");
                string newRace = Console.ReadLine();
                if (newRace.ToLower() == "yes")
                {
                    Console.Clear();
                    success = true;
                    Console.WriteLine("Start again");

                }
                else if (newRace.ToLower() == "no")
                {
                    Console.WriteLine("GoodBye");
                    break;
                }
                else
                {
                    Console.WriteLine("You entered incorrectly");

                }
            } while (success == true);
            

            Console.ReadLine();
        }
    }
}

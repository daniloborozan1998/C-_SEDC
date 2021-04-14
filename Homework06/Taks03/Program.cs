using System;
using System.Collections.Generic;
using System.Linq;
using Task3_Classes.Classes;
using Enum = Task3_Classes.Enums.Enum;


namespace Taks03
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal(){Name = "Sparky", Color = "brown", Age = 2, Gender = Enum.Male},
                new Animal(){Name = "Rose", Color = "white", Age = 3, Gender = Enum.Female},
                new Animal(){Name = "Kristophers", Color = "yellow", Age = 1, Gender = Enum.Male},
                new Animal(){Name = "Alexzanders", Color = "black", Age = 6, Gender = Enum.Male},
                new Animal(){Name = "Jacqueline", Color = "blackAndWhite", Age = 1, Gender = Enum.Female},
                new Animal(){Name = "Jennie", Color = "gray", Age = 3, Gender = Enum.Female},
                new Animal(){Name = "Alex", Color = "brown", Age = 7, Gender = Enum.Male},
                new Animal(){Name = "Maximiliano", Color = "white", Age = 2, Gender = Enum.Male},
                new Animal(){Name = "Elisabeth", Color = "brown", Age = 10, Gender = Enum.Female},
                new Animal(){Name = "Katherine", Color = "gray", Age = 5, Gender = Enum.Female}
            };
            Console.WriteLine("==================================================");
            Console.WriteLine("All animals:");
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name} Color: {animal.Color} Age: {animal.Age} Gender: {animal.Gender}");
            }


            List<string> agedFiveOrMore = animals.Where(x => x.Age >= 5)
                .Select(x => $"Name:{x.Name}  Color: {x.Color} Age:{x.Age} Gender: {x.Gender}").ToList();

            Console.WriteLine("==================================================");
            Console.WriteLine("Animal with 5 age or more:");
            foreach (string animal in agedFiveOrMore)
            {
                Console.WriteLine(animal);
            }

            List<Animal> nameStarWithA = animals.Where(x => x.Name.StartsWith("A")).ToList();

            Console.WriteLine("==================================================");
            Console.WriteLine("An animal whose name begins with A:");
            foreach (Animal animal in nameStarWithA)
            {
                Console.WriteLine($"Name: {animal.Name}");
            }

            
            Animal longerThanTen = animals.FirstOrDefault(d => d.Name.Length > 10);
            Console.WriteLine("==================================================");
            Console.WriteLine("First animal whose name is longer than 10 characters:");
            if (longerThanTen == null)
            {
                Console.WriteLine("Can not a animal whose name is longer than 10 characters ");
            }
            else
            {
                Console.WriteLine($"Name: {longerThanTen.Name}");
            }
            
            List<Animal> maleBrownAnimals = animals.Where(x => x.Color == "brown" && x.Gender == Enum.Male).ToList();
            Console.WriteLine("==================================================");
            Console.WriteLine("All male and brown animals:");
            foreach (Animal animal in maleBrownAnimals)
            {
                Console.WriteLine($"Name: {animal.Name} Color: {animal.Color} Gender: {animal.Gender}");
            }




            Console.ReadLine();
        }
    }
}

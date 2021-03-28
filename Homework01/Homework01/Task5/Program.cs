using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas enter a number from 1 to 3:");
            int action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    {
                        Console.WriteLine("You got a new car!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("You got a new plane!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("You got a new bike!");
                        break;
                    }
                default:
                    Console.WriteLine("Wrong number or character!! try again");
                    break;
            }

            Console.ReadLine();
        }
    }
}

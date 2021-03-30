using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            bool succ = double.TryParse(Console.ReadLine(), out double firstNumber);
            Console.WriteLine("Enter second number:");
            bool succ1 = double.TryParse(Console.ReadLine(), out double secondNumber);
            Console.WriteLine("Enter the third number:");
            bool succ2 = double.TryParse(Console.ReadLine(), out double thridNumber);
            Console.WriteLine("Enter the four number: ");
            bool succ3 = double.TryParse(Console.ReadLine(), out double fourNumber);
            if (succ && succ1 && succ2 && succ3)
            {
                double result = (firstNumber + secondNumber + thridNumber + fourNumber) / 4;
                Console.WriteLine($"The average is: {result}");
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            double thridNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the four number: ");
            double fourNumber = Convert.ToDouble(Console.ReadLine());

            double result;

            result = (firstNumber + secondNumber + thridNumber + fourNumber) / 4;

            Console.WriteLine($"The average is: {result}");

            Console.ReadLine();
        }
    }
}

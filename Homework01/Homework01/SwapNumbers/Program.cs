using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            double swap = firstNumber;
            firstNumber = secondNumber;
            secondNumber = swap;
            Console.WriteLine("After Swapping: ");
            Console.WriteLine($"First Number: {firstNumber}");
            Console.WriteLine($"Second Number: {secondNumber}");



            Console.ReadLine();
        }
    }
}

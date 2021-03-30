using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            bool succ = double.TryParse(Console.ReadLine(), out double firstNumber);
            Console.WriteLine("Enter second number");
            bool succ1 = double.TryParse(Console.ReadLine(), out double secondNumber);
            if (succ && succ1)
            {
                double swap = firstNumber;
                firstNumber = secondNumber;
                secondNumber = swap;
                Console.WriteLine("After Swapping: ");
                Console.WriteLine($"First Number: {firstNumber}");
                Console.WriteLine($"Second Number: {secondNumber}");
            }
            else
            {
                Console.WriteLine("Pleas enter number");
            }
            



            Console.ReadLine();
        }
    }
}

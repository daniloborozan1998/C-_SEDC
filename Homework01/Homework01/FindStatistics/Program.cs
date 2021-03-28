using System;

namespace FindStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result;
            if ((firstNumber % 2 == 0 || firstNumber == 0) && (secondNumber % 2 == 0 || secondNumber == 0))
            {
                result = firstNumber + secondNumber;
                Console.WriteLine($"Both numbers are even. The operation and result are {firstNumber} + {secondNumber} = {result}");
            }
            else if (firstNumber % 2 != 0 && secondNumber % 2 != 0)
            {
                result = firstNumber * secondNumber;
                Console.WriteLine($"Both numbers are odd. The operation and result are {firstNumber} * {secondNumber} = {result}");
            }
            else if ((firstNumber % 2 != 0 || firstNumber == 0) || (secondNumber % 2 != 0 || secondNumber == 0))
            {
                result = firstNumber - secondNumber;
                Console.WriteLine($"One of the numbers is odd. The operation and result are {firstNumber} - {secondNumber} = {result}");
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }


            Console.ReadLine();
        }
    }
}

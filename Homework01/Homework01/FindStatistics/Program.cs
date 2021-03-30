using System;

namespace FindStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            bool succ = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter second number");
            bool succ1 = int.TryParse(Console.ReadLine(), out int secondNumber);
            if(succ && succ1)
            {
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
            }
            else
            {
                Console.WriteLine("Enter number");
            }
            


            Console.ReadLine();
        }
    }
}

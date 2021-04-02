using System;

namespace SumOfDigits
{
    class Program
    {
        static int GetSum(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum = sum + number % 10;
                number = number / 10;
            }

            return sum;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            bool succ = int.TryParse(Console.ReadLine(), out int number);
            if (succ)
            {
                Console.WriteLine($"The sum of the digits in the number is: {GetSum(number)}");
            }

            Console.ReadLine();
        }
    }
}

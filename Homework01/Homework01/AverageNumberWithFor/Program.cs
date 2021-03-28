using System;

namespace AverageNumberWithFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int sum = 0;

            int[] numbers = new int[4];

            for (int i = 0; i < numbers.Length; i++)
            {


                Console.WriteLine($"Enter number{i + 1}:");
                if (Int32.TryParse(Console.ReadLine(), out input))
                {
                    numbers[i] = input;
                    sum += numbers[i];

                }

            }

            Console.WriteLine($"The average of your numbers: {(double)sum / (double)numbers.Length}");
            Console.ReadLine();
        }
    }
}

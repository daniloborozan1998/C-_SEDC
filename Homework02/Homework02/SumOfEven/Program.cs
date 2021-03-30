using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            int sum = 0;
            Console.WriteLine("Please enter number of element in array: ");
            bool success = int.TryParse(Console.ReadLine(), out int numOfElement);
            if (success)
            {
   
                Console.WriteLine($"Input {numOfElement} elements in the array :");
                for (int i = 0; i < numOfElement; i++)
                {
                    Console.WriteLine($"element - {i} : ");
                    bool succ = int.TryParse(Console.ReadLine(), out array[i]);
                    if (succ)
                    {
                        if (array[i] % 2 == 0)
                        {
                            sum += array[i];
                        }

                    }
                    else
                    {
                        Console.WriteLine("Enter a number");
                    }
                }
                Console.WriteLine($"Sum of all even elements stored in the array is : {sum}");


            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();
        }
    }
}

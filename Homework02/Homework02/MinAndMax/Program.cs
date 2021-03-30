using System;

namespace MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int min = 0;
            int max = 0;
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
                        max = array[0];
                        min = array[0];
                        if (array[i] > max)
                        {
                            max = array[i];
                        }
                        if (array[i] < min)
                        {
                            min = array[i];
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a number");
                    }
                }
                Console.WriteLine($"Minimum element is : {min}");
                Console.WriteLine($"Maximum element is : {max}");
                


            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();

        }
    }
}

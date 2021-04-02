using System;

namespace MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter number of element in array: ");
            bool success = int.TryParse(Console.ReadLine(), out int numOfElement);
            int[] array = new int[numOfElement];
            
            if (success)
            {
                int min = 0;
                int max = 0;
                Console.WriteLine($"Input {numOfElement} elements in the array :");
                for (int i = 0; i < numOfElement; i++)
                {
                    Console.WriteLine($"element - {i} : ");
                    bool succ = int.TryParse(Console.ReadLine(), out array[i]);
                    
                        max = array[0];
                        min = array[0];
                        for (int j = 0; j < numOfElement; j++)
                        {
                            if (array[j] > max)
                            {
                                max = array[j];
                            }

                            if (array[j] < min)
                            {
                                min = array[j];
                            }
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

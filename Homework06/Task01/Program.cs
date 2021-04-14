using System;
using System.Collections;
using System.Collections.Generic;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of items in the queue");
            bool succ = int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine($"Number of items {number}");
            Queue<int> queueList = new Queue<int>();
            if (succ)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine($"Enter the {i} element: ");
                    bool succ1 = int.TryParse(Console.ReadLine(), out int element);
                    if (succ1)
                    {
                        
                        queueList.Enqueue(element);
                    }
                    else
                    {
                        Console.WriteLine("Pls enter number");
                    }
                }
            }
            else
            {
                Console.WriteLine("Pls enter number");
            }

            Console.WriteLine("List of Queue:");
            foreach (int listQueue in queueList)
            {
                Console.WriteLine(listQueue);
            }

            

            Console.ReadLine();
        }
    }
}

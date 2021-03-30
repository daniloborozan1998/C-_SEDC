using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter the Maximum Number of Rows: ");
            bool success = int.TryParse(Console.ReadLine(), out int rows);
            int space = rows + 4 - 1;
            int number = 1;
            if (success)
            {
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = space; j >= 1; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int n = 1; n <= i; n++)
                        Console.Write($"{number++} ");
                    Console.Write("\n");
                    space--;
                }
            }
            
            
            Console.ReadLine();
        }
    }
}

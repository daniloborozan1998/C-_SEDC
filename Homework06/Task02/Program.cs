using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void SquaresOfAllNumbers(List<int> listNum)
        {
            List<int> squerListNum = listNum.Select(x => x * x).ToList();
            Console.WriteLine("Squares of all the numbers");
            foreach (int num in squerListNum)
            {
                Console.WriteLine(num);
            }
        }
        static void Main(string[] args)
        {
            List<int> listNumber = new List<int>()
            {
                2,
                3,
                5,
                6,
                12,
                7,
                8,
                20,
                24,
                15
            };
            Console.WriteLine("List of all  numbers");
            foreach (int nums in listNumber)
            {
                Console.WriteLine(nums);
            }
            SquaresOfAllNumbers(listNumber);

            Console.ReadLine();
        }
    }
}

using System;
using System.Threading;

namespace Reverseorder
{
    class Program
    {
        static String wordReverse(String str)
        {
            int i =  str.Length - 1;

            while (i>=0)
            {
                Console.Write(str[i]);
                i--;
            }

            return "";

        }

        
        public static void Main()
        {
            Console.WriteLine("Enter input string:");
            String word = Console.ReadLine();

            Console.Write(wordReverse(word));
            Console.ReadLine();
        }
    }
}

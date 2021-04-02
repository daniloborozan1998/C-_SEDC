using System;

namespace FindWord
{
    class Program
    {
        static bool WordPresent(String sentence, String word)
        {
            String[] s = sentence.Split(' ');
            foreach (String temp in s)
            {
                if (temp.CompareTo(word) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static void Main(String[] args)
        {
            // String sentence = "Danilo is studying at FINKI";
            Console.WriteLine("Enter sentence");
            string sentence = Console.ReadLine();
            // String word = "Danilo";
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();

            Console.WriteLine("Finding..");
            if (WordPresent(sentence.ToLower(), word.ToLower()))
                Console.WriteLine($"The word {word} has been found.");
            else
                Console.Write($"The word {word} was not found.");

            Console.ReadLine();
        }
    }
}

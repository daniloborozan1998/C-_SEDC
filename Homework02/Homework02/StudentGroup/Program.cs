using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] G1 = {"Bojan","Gjoce","Aleksandar","Rozeta","Sime"};
            string[] G2 = {"Danilo","Anamarija","Ana","Stevo","Kristijan"};

            Console.WriteLine("Enter student group: ( there are 1 and 2)");
            bool succ = int.TryParse(Console.ReadLine(),out int group);
            if (succ)
            {
                if(group == 1)
                {
                    Console.WriteLine("The Students in G1 are:");
                    foreach (string group1 in G1)
                    {
                        
                        Console.WriteLine(group1);
                    }
                }
                else if(group == 2)
                {
                    Console.WriteLine("The Students in G2 are:");
                    foreach (string group2 in G2)
                    {
                        
                        Console.WriteLine(group2);
                    }
                }
                else
                {
                    Console.WriteLine("Pleas enter 1 or 2");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();
        }
    }
}

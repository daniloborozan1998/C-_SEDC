using System;
using Microsoft.VisualBasic;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter your birthday(MM.DD.YYYY)");
           DateTime birth = DateTime.Parse(Console.ReadLine());
           Console.WriteLine($"Age: {GetAge(birth)}");
           Console.ReadLine();
        }

        public static int GetAge(DateTime birthDate)
        {
            DateTime date = DateTime.Now; 
            int age = date.Year - birthDate.Year;

            if (date.Month < birthDate.Month || (date.Month == birthDate.Month && date.Day < birthDate.Day))
            {
                age--;
            }
               

            return age;
        }
    }
}

using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter first number");
			double firstNumber = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter operators (*,/,+,-):");
			string result = Console.ReadLine();
			Console.WriteLine("Enter second number");
			double secondNumber = Convert.ToDouble(Console.ReadLine());
			if (result == "+")
			{
				Console.WriteLine("The result is: {0}", firstNumber + secondNumber);
			}
			if (result == "-")
			{
				Console.WriteLine("The result is: {0}", firstNumber - secondNumber);
			}
			if (result == "*")
			{
				Console.WriteLine("The result is: {0}", firstNumber * secondNumber);
			}
			if (result == "/")
			{
				Console.WriteLine("The result is: {0}", firstNumber / secondNumber);
			}
			Console.ReadLine();
		}
    }
}

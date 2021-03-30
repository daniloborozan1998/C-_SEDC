using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter first number");
			bool succ = double.TryParse(Console.ReadLine(), out double num1);
			Console.WriteLine("Enter operators (*,/,+,-):");
			string res = Console.ReadLine();
			Console.WriteLine("Enter second number");
			bool succ1 = double.TryParse(Console.ReadLine(), out double num2);
			
			if(succ && succ1)
			{
				switch (res)
				{
					case "+":
						{
							Console.WriteLine($"The result is: {num1 + num2}");
							break;
						}
					case "-":
						{
							Console.WriteLine($"The result is: {num1 - num2}");
							break;
						}
					case "/":
						{
							Console.WriteLine($"The result is: {num1 / num2}");
							break;
						}
					case "*":
						{
							Console.WriteLine($"The result is: {num1 * num2}");
							break;
						}
					default:
						Console.WriteLine("Wrong operator!! try again");
						break;
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

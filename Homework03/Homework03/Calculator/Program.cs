using System;

namespace Calculator
{
    class Program
    {
        static double GetCalculator(string operators,double num1, double num2)
        {
            double result = double.NaN;
            switch (operators)
            {
                case "+":
                    result = GetSum(num1, num2);
                    break;
                case "-":
                    result = GetSubstract(num1, num2);
                    break;
                case "*":
                    result = GetMultiplication(num1, num2);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = GetDivision(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("It is not divisible by zero");
                        
                    }
                    break;
               
                default:
                    break;
            }

            return result;
        }
        static double GetDivision(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }

        static double GetMultiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        static double GetSubstract(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        static double GetSum(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter operator");
            string operators = Console.ReadLine();
            Console.WriteLine("Enter first number");
            bool succ = double.TryParse(Console.ReadLine(), out double num1);
            Console.WriteLine("Enter second number");
            bool succ1 = double.TryParse(Console.ReadLine(), out double num2);

            if (succ && succ1 && operators != "")
            {
                Console.WriteLine($"The result of the calculation is: {GetCalculator(operators, num1, num2)}");
            }
            else
            {
                Console.WriteLine("Pleas enter valid number or enter operator");
            }

            Console.ReadLine();
        }
    }
}

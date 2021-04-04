using System;

namespace Task_4
{
    class Program
    {
        static double GetCalculator(string operators, double number1, double number2)
        {
            double result = double.NaN;
            switch (operators)
            {
                case "+":
                    result = GetSum(number1, number2);
                    break;
                case "-":
                    result = GetSubstract(number1, number2);
                    break;
                case "*":
                    result = GetMultiplication(number1, number2);
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        result = GetDivision(number1, number2);
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
        static double GetDivision(double number1, double number2)
        {
            double result = number1 / number2;
            return result;
        }

        static double GetMultiplication(double number1, double number2)
        {
            double result = number1 * number2;
            return result;
        }
        static double GetSubstract(double number1, double number2)
        {
            double result = number1 - number2;
            return result;
        }
        static double GetSum(double number1, double number2)
        {
            double result = number1 + number2;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter one of this operators  +   -   *   /");
            string operators = Console.ReadLine();
            Console.WriteLine("Please enter first number");
            bool success = double.TryParse(Console.ReadLine(), out double number1);
            Console.WriteLine("Please enter second number");
            bool success1 = double.TryParse(Console.ReadLine(), out double number2);

            if (success && success1 && operators != "")
            {
                Console.WriteLine("The result of the calculation is: ");
                Console.WriteLine(GetCalculator(operators, number1, number2));
            }
            else
            {
                Console.WriteLine("Pleas enter valid number or enter operator");
            }

            Console.ReadLine();
        }
    }
}

using System;

namespace Home_Work_Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Task 1...");
            int numb1 = int.Parse(Console.ReadLine());
            int numb2 = int.Parse(Console.ReadLine());
            int result = numb1 + numb2;
            Console.WriteLine(result);


            Console.WriteLine("...Task 2...");
            int numb3 = int.Parse(Console.ReadLine());
            int numb4 = int.Parse(Console.ReadLine());
            int numb5 = int.Parse(Console.ReadLine());
            int numb6 = int.Parse(Console.ReadLine());
            int averageNumber = (numb3 + numb4 + numb5 + numb6) / 4;
            Console.WriteLine(averageNumber);


            Console.WriteLine("...Task 3...");
            int swapNumber1 = int.Parse(Console.ReadLine());
            int swapNumber2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Values before swap...");
            Console.WriteLine("Number 1 value is " + swapNumber1);
            Console.WriteLine("Number 2 value is " + swapNumber2);

            swapNumber1 = swapNumber1 + swapNumber2;
            swapNumber2 = swapNumber1 - swapNumber2;
            swapNumber1 = swapNumber1 - swapNumber2;

            Console.WriteLine("Values after swap...");
            Console.WriteLine("Number 1 value is " + swapNumber1);
            Console.WriteLine("Number 2 value is " + swapNumber2);


            Console.WriteLine("...Task 4...");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int findStatNum1, findStatNum2;
            bool n1 = int.TryParse(input1, out findStatNum1);
            bool n2 = int.TryParse(input2, out findStatNum2);
            Console.WriteLine("Input number 1: " + n1);
            Console.WriteLine("Input number 2: " + n2);
            if (findStatNum1 % 2 == 0 && findStatNum2 % 2 == 0)
            {
                int sumOfn1n2 = findStatNum1 + findStatNum2;
                Console.WriteLine($"The numbers are even and the sum of them is {findStatNum1} + {findStatNum2} = {sumOfn1n2}");
            }
            else if (findStatNum1 % 2 == 0 || findStatNum2 % 2 == 0)
            {
                int diffOfn1n2 = findStatNum1 - findStatNum2;
                Console.WriteLine($"The numbers are even and the difference of them is {findStatNum1} - {findStatNum2} = {diffOfn1n2}");
            }
            else
            {
                int multiOfn1n2 = findStatNum1 * findStatNum2;
                Console.WriteLine($"The numbers are even and the difference of them is {findStatNum1} * {findStatNum2} = {multiOfn1n2}");
            }


            Console.WriteLine("...Task 5...");
            Console.WriteLine("Please enter 1, 2 or 3");
            string inputNumber = Console.ReadLine();
            int choosenNumber;
            bool numberInput = int.TryParse(inputNumber, out choosenNumber);
            switch (choosenNumber)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Please enter some of this number(1, 2, 3");
                    break;
            }



            Console.ReadLine();
        }
    }
}

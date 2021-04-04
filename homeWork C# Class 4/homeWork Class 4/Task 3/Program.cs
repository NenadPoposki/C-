using System;

namespace Task_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, sum = 0, m;
            Console.Write("Please enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("The sum of digits is: " + sum);

            Console.ReadLine();
        }
    }
}

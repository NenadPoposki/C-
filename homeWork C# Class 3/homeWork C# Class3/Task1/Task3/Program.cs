using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 55, 4, 22, 68, -12, 6, -31, 82, 555, 434 };
            int i, max, min, n;
            n = 10; // size of the array
            max = arr[0];
            min = arr[0];
            for( i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Maximum number = {max}");
            Console.WriteLine($"Minimum number = {min}");

            Console.ReadLine();
        }
    }
}

using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            int sum = 0;
            Console.WriteLine("Please enter number of elements in this array: ");
            bool successNum = int.TryParse(Console.ReadLine(), out int numberOfElement);
            if (successNum)
            {

                Console.WriteLine($"Input {numberOfElement} elements in the array :");
                for (int i = 0; i < numberOfElement; i++)
                {
                    Console.WriteLine($"element index {i} : ");
                    bool success = int.TryParse(Console.ReadLine(), out array[i]);
                    if (success)
                    {
                        if (array[i] % 2 == 0)
                        {
                            sum += array[i];
                        }

                    }
                    else
                    {
                        Console.WriteLine("Enter a number");
                    }
                }
                Console.WriteLine($"Sum of all even elements in the array is : {sum}");


            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}

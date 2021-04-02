using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of elements in array");
            bool success = int.TryParse(Console.ReadLine(), out int number);
            int[] array = new int[number];
            int counter = 0;

            if(success)
            {
                for(int i = 0; i < number; i++)
                {
                    Console.WriteLine($"element index {i} :");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] == 3 && array[j + 1] == 3)
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"{counter} times there are two 3 next to each other");

            }
            else
            {
                Console.WriteLine("You have some EROR");
            }
            Console.ReadKey();
        }
    }
}

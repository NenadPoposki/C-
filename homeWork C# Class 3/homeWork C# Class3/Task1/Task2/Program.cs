using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Group of students");
            string[] G1 = { "Zddravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] G2 = { "Nenad", "Angela", "Mihail", "Petar", "Jana" };
            Console.WriteLine("Please enter number of Group: 1 or 2");
            string input1 = Console.ReadLine();
            bool successNum = int.TryParse(input1, out int num);
            if (successNum)
            {
                if (num == 1)
                {
                    Console.WriteLine("The students od G1 are: ");
                    foreach (string studentsName in G1)
                    {
                        Console.WriteLine(studentsName);
                    }
                }
                else if (num == 2)
                {
                    Console.WriteLine("The students od G2 are: ");
                    foreach (string studentsName2 in G2)
                    {
                        Console.WriteLine(studentsName2);
                    }
                }
                else
                {
                    Console.WriteLine("You must pick 1 or 2");
                }
            }




                Console.ReadLine();
        }
    }
}

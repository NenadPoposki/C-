using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday date (DD.MM.YYYY");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"You are: {GetAge(birth)} years old");

            Console.ReadLine();
        }

        public static int GetAge(DateTime birthDate)
        {
            DateTime date = DateTime.Now;
            int age = date.Year - birthDate.Year;

            if(date.Month <birthDate.Month || (date.Month == birthDate.Month && date.Day < birthDate.Day))
            {
                age--;
            }
            return age;
        }
    }
}

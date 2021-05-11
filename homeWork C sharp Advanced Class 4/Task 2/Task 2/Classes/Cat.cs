using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Classes
{
    public class Cat : Pet
    {
        public string Lazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat (string name, string type, int age, string lazy, int livesLeft)
            : base(name, type, age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
           if (Age < 0 || LivesLeft < 0)
            {
                Console.WriteLine("Cat Age and LivesLeft must be positive number!");
            }

            Console.WriteLine($"Cat {Name} is {Age} years old and {Name} has {LivesLeft}");
        }
    }
}

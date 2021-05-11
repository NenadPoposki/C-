using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Classes
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }
        public Fish (string name, string type, int age, string color, int size)
            : base (name, type, age)
        {
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            if (Size < 0)
            {
                Console.WriteLine("Fish size must be positive number");
            }
            if (string.IsNullOrEmpty(Color))
            {
                Console.WriteLine("Fish color can not be a empty");
            }

            Console.WriteLine($"Fish {Name} is {Color}");
        }
    }
}

using homeWork_C_sharp_Advanced_Class_2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork_C_sharp_Advanced_Class_2.classes
{
    public class Dog : Animal, IDog
    {
        public bool Play { get; set; }
        public Dog(string name, int age, bool play)
            : base(name, age)
        {
            Play = play;
        }

        public void Bark()
        {
            Console.WriteLine("Best Dog for Playing");
        }
    }
}

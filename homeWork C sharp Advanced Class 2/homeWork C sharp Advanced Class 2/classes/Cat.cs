using homeWork_C_sharp_Advanced_Class_2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork_C_sharp_Advanced_Class_2.classes
{
    public class Cat : Animal, ICat
    {
        public string Color { get; set; }
        public Cat(string name, int age, string food)
            : base(name, age)
        {
            Color = Color;
        }

        public string Eat(string food)
        {
            return $"Cat {Name} eating {food}";
        }
    }
}

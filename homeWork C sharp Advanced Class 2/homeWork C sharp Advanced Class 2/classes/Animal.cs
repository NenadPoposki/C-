using homeWork_C_sharp_Advanced_Class_2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork_C_sharp_Advanced_Class_2.classes
{
    public class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintAnimal()
        {
            Console.WriteLine($"Name: {Name} has {Age} years");

        }
    }
}

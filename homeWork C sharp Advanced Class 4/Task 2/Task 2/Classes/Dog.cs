using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Classes
{
    public class Dog : Pet
    {
       public string FavoriteFood { get; set; }
        public Dog (string name, string type, int age, string favoriteFood)
            : base (name, type, age)
        {
            FavoriteFood = favoriteFood;
        }
public override void PrintInfo()
        {
            if (Age < 0)
            {
                Console.WriteLine("Dog Age must be positive number!");
            }

            Console.WriteLine($"Cat {Name} is {Age} years old");
        }
    }
    
}

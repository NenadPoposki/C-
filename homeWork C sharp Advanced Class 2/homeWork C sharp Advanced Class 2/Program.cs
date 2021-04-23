using homeWork_C_sharp_Advanced_Class_2.classes;
using System;

namespace homeWork_C_sharp_Advanced_Class_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Tosho", 3, "Best food");
            Cat cat1 = new Cat("Tom", 5, "Homemade food");
            Cat cat2 = new Cat("Mia", 1, "Healty food");

            Dog dog = new Dog("Bark", 4, true);
            Dog dog1 = new Dog("Molly", 2, false);
            Dog dog2 = new Dog("Jack", 6, true);


            Console.WriteLine("---Cat---");
            cat.PrintAnimal();

            Console.WriteLine("");
            Console.WriteLine("---Cat1---");
            cat1.PrintAnimal();

            Console.WriteLine("");
            Console.WriteLine("---Cat2---");
            cat2.PrintAnimal();

            Console.WriteLine("");
            Console.WriteLine("---Dog---");
            dog.PrintAnimal();
            dog.Bark();

            Console.WriteLine("");
            Console.WriteLine("---Dog1---");
            dog1.PrintAnimal();
            dog1.Bark();


            Console.WriteLine("");
            Console.WriteLine("---Dog2---");
            dog2.PrintAnimal();
            
            dog2.Bark();




            Console.ReadLine();
        }
    }
}

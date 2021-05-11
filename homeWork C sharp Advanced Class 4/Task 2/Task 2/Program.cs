using System;
using Task_2.Classes;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            PetStore<Pet>.Pet.Add(new Cat("Tosho", "Cat ? Type", 5, "Lazy", 6));

            PetStore<Pet>.Pet.Add(new Cat("Tom", "Cat ? Type", 2, "Lazy", 3));


            PetStore<Pet>.Pet.Add(new Dog("Bart", "Bulldog", 4, "DogFood"));

            PetStore<Pet>.Pet.Add(new Dog("Molly", "Bulldog", 1, "DogFood"));


            PetStore<Pet>.Pet.Add(new Fish("Nemo", "Goldfish", 9, "Orande-gold", 10));

            PetStore<Pet>.Pet.Add(new Fish("Marche", "Goldfish", 3, "Orande-gold", 12));


            Console.WriteLine("Pets Store");
            foreach(Pet pets in PetStore<Pet>.Pet)
            {
                pets.PrintInfo();
            }


            PetStore<Pet>.BuyPet(PetStore<Pet>.Pet[2]);
            PetStore<Pet>.BuyPet(PetStore<Pet>.Pet[0]);
            PetStore<Pet>.BuyPet(PetStore<Pet>.Pet[1]);

            Console.ReadLine();
        }
    }
}

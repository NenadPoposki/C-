using homeWork_C_sharp_Claas_4.Classes;
using System;

namespace homeWork_C_sharp_Claas_4
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericDb<Shape>.Shape.Add(new Circle(1, 4));
            GenericDb<Shape>.Shape.Add(new Circle(2, 3));
            GenericDb<Shape>.Shape.Add(new Rectangle(2, 3, 5));
            GenericDb<Shape>.Shape.Add(new Rectangle(3, 5, 7));

            Console.WriteLine("Type is:");
            foreach (Shape shape in GenericDb<Shape>.Shape)
            {
                shape.PrintType();
            }

            Console.WriteLine("Area is:");
            GenericDb<Shape>.PrintArea();
            
            Console.WriteLine("Perimeter is:");
            GenericDb<Shape>.PrintPerimeter();


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork_C_sharp_Claas_4.Classes
{
    public static class GenericDb<T> where T : Shape 
    {
        public static List<T> Shape { get; set; }

        static GenericDb()
        {
            Shape = new List<T>();
        }

        public static void PrintArea()
        {
            foreach (T areaShape in Shape)
            {
                Console.WriteLine($"The Area is: {areaShape.GetArea()}");
            }
        }

        public static void PrintPerimeter()
        {
            foreach (T perimeterShape in Shape)
            {
                Console.WriteLine($"The Perimeter is: {perimeterShape.GetPerimeter()}");
            }
        }
    }
}

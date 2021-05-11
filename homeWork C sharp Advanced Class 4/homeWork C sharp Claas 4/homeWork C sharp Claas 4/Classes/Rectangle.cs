using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork_C_sharp_Claas_4.Classes
{
    public class Rectangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public Rectangle (int Id, double a, double b)
            : base(Id)
        {
            A = a;
            B = b;
        }
        public override double GetArea()
        {
            if (A <= 0 || B <= 0)
            {
                Console.WriteLine("Radius must be positive number");
            }
            return A * B;
        }

        public override double GetPerimeter()
        {
            if (A <= 0 || B <= 0)
            {
                Console.WriteLine("Perimeter must be positive number");
            }
            return 2 *(A * B);
        }
    }
}

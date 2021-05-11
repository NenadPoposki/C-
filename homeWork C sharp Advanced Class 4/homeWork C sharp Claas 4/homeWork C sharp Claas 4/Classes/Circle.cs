using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork_C_sharp_Claas_4.Classes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle (int Id, double radius) 
            : base(Id)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
           if (Radius <= 0)
            {
                Console.WriteLine("Radius must be positive number");
            }
            return Math.PI * (Radius * Radius);
        }

        public override double GetPerimeter()
        {
           if (Radius <= 0)
            {
                Console.WriteLine("Perimeter mus be a positive number");
            }
            return Math.PI * Radius * 2;
        }
    }
}

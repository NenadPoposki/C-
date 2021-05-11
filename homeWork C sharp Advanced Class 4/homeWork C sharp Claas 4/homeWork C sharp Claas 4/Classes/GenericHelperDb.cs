using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork_C_sharp_Claas_4.Classes
{
    public static class GenericHelperDb
    {
        public static void PrintType(this Shape shapes)
        {
            Console.WriteLine($" Id = {shapes.Id} Type = {shapes.GetType()}");
        }
    }
}

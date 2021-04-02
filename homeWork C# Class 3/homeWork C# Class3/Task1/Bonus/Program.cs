using System;

namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, spc, rows, k, t = 1;
            rows = 4;
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", t++);
                Console.Write("\n");
                spc--;

            }
        }
    }
}

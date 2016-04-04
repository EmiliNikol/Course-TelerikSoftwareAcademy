using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ConvertBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int p = int.Parse(Console.ReadLine());
            int p1 = (~p);
            int p2 = 0;
            int pShifted = p;

            while (pShifted > 0)
            {
                p2 <<= 1;
                p2 |= (pShifted & 1);
                pShifted >>= 1;
            }
            p = (p ^ p1) & p2;
            Console.WriteLine(p);
        }
    }
}

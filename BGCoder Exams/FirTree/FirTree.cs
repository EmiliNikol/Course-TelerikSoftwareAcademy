using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string dots, asterisk;

        for (int row = 1; row <= n; row++)
        {
            if (row < n)
            {
                dots = new string('.', n - row - 1);
                asterisk = new string('*', row * 2 - 1);

                Console.Write(dots);
                Console.Write(asterisk);
                Console.WriteLine(dots);
            }
            if (row == n)
            {
                dots = new string('.', n - 2);
                Console.Write(dots);
                Console.Write("*");
                Console.WriteLine(dots);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string asterisk, dots;

        for (int row = 1; row <= n + 1; row++)
        {
            if (row == 1)
            {
                dots = new string('.', n);
                asterisk = new string('*', n);
                Console.Write(dots);
                Console.WriteLine(asterisk);
            }
            else if (row == n + 1)
            {
                asterisk = new string('*', 2 * n);
                Console.WriteLine(asterisk); ;
            }
            else
            {
                dots = new string('.', n - row + 1);
                Console.Write(dots);
                Console.Write("*");
                dots = new string('.', n + row - 3);
                Console.Write(dots);
                Console.WriteLine("*");
            }
        }
    }
}

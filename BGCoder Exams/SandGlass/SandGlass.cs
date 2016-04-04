using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string asterisk, dots;

        for (int row = 1; row <= n; row++)
        {
            if (row < (n / 2) + 1)
            {
                asterisk = new string('*', n - 2 * (row - 1));
                dots = new string('.', row - 1);
                Console.Write(dots);
                Console.Write(asterisk);
                Console.WriteLine(dots);
            }
            else
            {
                asterisk = new string('*', 2 * row - n);
                dots = new string('.', n - row);
                Console.Write(dots);
                Console.Write(asterisk);
                Console.WriteLine(dots);
            }
        }
    }
}

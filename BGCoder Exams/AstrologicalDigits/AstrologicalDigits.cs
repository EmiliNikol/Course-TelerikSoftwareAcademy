using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class AstrologicalDigits
{
    static void Main()
    {
        string n = Console.ReadLine();

        int sumDigits = 0;
        int currentDigit = 0;
        
        for (int i = 0; i < n.Length; i++)
        {
            if (!Char.IsDigit(n[i]))
            {
                continue;
            }

            currentDigit = n[i] - '0';
            sumDigits += currentDigit;
        }

        if (sumDigits > 9)
        {
            do
            {
                n = Convert.ToString(sumDigits);
                sumDigits = 0;
                currentDigit = 0;

                for (int i = 0; i < n.Length; i++)
                {
                    currentDigit = n[i] - '0';
                    sumDigits += currentDigit;
                }
            }
            while (sumDigits > 9);
        }

        Console.WriteLine(sumDigits);
    }
}

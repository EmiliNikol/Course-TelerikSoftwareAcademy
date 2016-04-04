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
        n = n.TrimStart('-');

        SolutionWithString(n);
        return;

        string[] number = n.Split('.');
        int sumDigits = 0;
        BigInteger digits = 0;

        for (int i = 0; i < number.Length; i++)
        {
            digits = BigInteger.Parse(number[i]);

            while (digits > 0)
            {
                sumDigits += (int)(digits % 10);
                digits /= 10;
            }
        }
        do 
        {
            digits = sumDigits;
            sumDigits = 0;

            while (digits > 0)
            {
                sumDigits += (int)digits % 10;
                digits /= 10;
            }
        }
        while (sumDigits > 9);
        Console.WriteLine(sumDigits);
    }

    private static void SolutionWithString(string n)
    {
        int result = 0;

        for (int letterIndex = 0; letterIndex < n.Length; letterIndex++)
        {
            if (!Char.IsDigit(n[letterIndex]))
            {
                continue;
            }

            int currentDigit = n[letterIndex] - '0';
            result += currentDigit;
        }

        if (result > 9)
        {
            SolutionWithString(result.ToString());
            return;
        }

        Console.WriteLine(result);
    }

}

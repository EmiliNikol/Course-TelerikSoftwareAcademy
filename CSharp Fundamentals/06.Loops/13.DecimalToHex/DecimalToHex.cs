using System;
using System.Collections.Generic;

// Using loops write a program that converts an integer number to its hexadecimal representation.
//  - The input is entered as long. The output should be a variable of type string.
//  - Do not use the built-in .NET functionality.

class DecimalToHex
{
    static void Main()
    {
        long decimalNum = long.Parse(Console.ReadLine());
        List<string> hexNum = new List<string>();

        while (decimalNum > 0)
        {
            long residue = (long)decimalNum % 16;

            if (residue <= 9)
            {
                hexNum.Add(Convert.ToString(residue));
            }
            else
            {
                switch (residue)
                {
                    case 10:
                        hexNum.Add("A");
                        break;
                    case 11:
                        hexNum.Add("B");
                        break;
                    case 12:
                        hexNum.Add("C");
                        break;
                    case 13:
                        hexNum.Add("D");
                        break;
                    case 14:
                        hexNum.Add("E");
                        break;
                    case 15:
                        hexNum.Add("F");
                        break;
                }
            }

            decimalNum /= 16;
        }

        for (int i = hexNum.Count - 1; i >= 0; i--)
        {
            Console.Write(hexNum[i]);
        }
    }
}

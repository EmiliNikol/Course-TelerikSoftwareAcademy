using System;
using System.Collections.Generic;

// Using loops write a program that converts an integer number to its binary representation.
//  - The input is entered as long. The output should be a variable of type string.
//  - Do not use the built-in .NET functionality.

class DecimalToBinary
{
    static void Main()
    {
        long decimalNum = long.Parse(Console.ReadLine());
        List<string> binaryNum = new List<string>();

        while (decimalNum > 0)
        {
            if (decimalNum % 2 == 0)
            {
                binaryNum.Add("0");
            }
            else
            {
                binaryNum.Add("1");
            }

            decimalNum /= 2;
        }

        for (int i = binaryNum.Count - 1; i >= 0; i--)
        {
            Console.Write(binaryNum[i]);
        }
    }
}

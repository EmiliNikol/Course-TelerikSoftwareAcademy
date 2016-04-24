using System;

// Using loops write a program that converts a binary integer number to its decimal form.
//  - The input is entered as string. The output should be a variable of type long.
//  - Do not use the built-in .NET functionality.

class BinaryToDecimal
{
    static void Main()
    {
        string binaryNum = Console.ReadLine();
        long decimalNum = 0;
        int step = 0;

        for (int i = binaryNum.Length - 1; i >= 0; i--)
        {
            if (binaryNum[i] == '1')
            {
                decimalNum += (long)Math.Pow(2, step);
            }
            step++;
        }

        Console.WriteLine(decimalNum);
    }
}

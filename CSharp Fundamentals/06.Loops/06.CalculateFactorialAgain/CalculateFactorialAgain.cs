using System;
using System.Numerics;

// Write a program that calculates N! / K! for given N and K.
//  - Use only one loop.

class CalculateFactorialAgain
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int numK = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        for (int i = 1; i <= numN; i++)
        {
            factorialN *= i;

            if (numK >= i)
            {
                factorialK *= i;
            }
        }

        Console.WriteLine(factorialN / factorialK);
    }
}

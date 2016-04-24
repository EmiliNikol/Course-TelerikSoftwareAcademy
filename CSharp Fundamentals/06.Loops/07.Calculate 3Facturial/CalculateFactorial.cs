using System;
using System.Numerics;

// Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.
//  - Try to use only two loops.

class CalculateFactorial
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int numK = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;


        for (int i = 1; i <= numN; i++)
        {
            factorialN *= i;

            if (numK >= i)
            {
                factorialK *= i;
            }
        }

        for (int j = 1; j <= (numN - numK); j++)
        {
            factorialNK *= j;
        }

        Console.WriteLine(factorialN / (factorialK * factorialNK));
    }
}

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());

        BigInteger factorial2N = 1;
        BigInteger factorialNPlus1 = 1;
        BigInteger factorialN = 1;

        for (int i = 1; i <= 2 * numN; i++)
        {
            factorial2N *= i;

            if (i <= numN + 1)
            {
                factorialNPlus1 *= i;
            }

            if (i <= numN)
            {
                factorialN *= i;
            }
        }
        Console.WriteLine(factorial2N / (factorialNPlus1 * factorialN));
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


class Tribonacci
{
    static void Main()
    {
        BigInteger firstElem = BigInteger.Parse(Console.ReadLine());
        BigInteger secondElem = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdElem = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        for (int i = 3; i < n; i++)
        {
            BigInteger nElem = firstElem + secondElem + thirdElem;
            firstElem = secondElem;
            secondElem = thirdElem;
            thirdElem = nElem;
        }
        Console.WriteLine(thirdElem);
    }
}

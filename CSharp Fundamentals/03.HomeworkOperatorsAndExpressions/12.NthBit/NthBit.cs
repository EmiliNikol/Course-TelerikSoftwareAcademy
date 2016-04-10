using System;

// Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.

class NthBit
{
    static void Main()
    {
        long p = long.Parse(Console.ReadLine());
        sbyte n = sbyte.Parse(Console.ReadLine());

        // string pInBinaryRep = Convert.ToString(p, 2).PadLeft(24, '0');

        int mask = 1 << n;
        long nthBit = (p & mask) >> n;

        Console.WriteLine(nthBit);
    }
}

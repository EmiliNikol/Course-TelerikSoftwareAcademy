using System;

// Write a program first reads 3 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1} 
// with bits {q, q+1, …, q+k-1} of n. Print the resulting integer on the console.

class BitSwap
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        uint numInBinaryOnly1 = 0;

        for (int i = 0; i < k; i++)
        {
            numInBinaryOnly1 += (uint)Math.Pow(2, i);
        }
        
        uint maskP = numInBinaryOnly1 << p;
        uint bitsP = (number & maskP) >> p;
        uint maskQ = numInBinaryOnly1 << q;
        uint bitsQ = (number & maskQ) >> q;

        uint modifiedNum = (number & ~maskP) | (bitsQ << p);
        modifiedNum = (modifiedNum & ~maskQ) | (bitsP << q);

        Console.WriteLine(modifiedNum);
    }
}

using System;

class Sheets
{
    static void Main()
    {
        int sheets = int.Parse(Console.ReadLine());

        // A10 = 2^0; A9 = 2^1; A8 = 2^2 ... A1 = 2^9; A0 = 2^10

        int[] sizeA = new int[11];

        for (int i = 0; i < sizeA.Length; i++)
        {
            sizeA[i] = (int)Math.Pow(2, i);
        }

        for (int i = sizeA.Length - 1; i >= 0; i--)
        {
            if (sheets >= sizeA[i])
            {
                sheets -= sizeA[i];
                sizeA[i] = 0;
            }
        }
        Array.Reverse(sizeA);

        for (int i = 0; i < sizeA.Length; i++)
        {
            if (sizeA[i] != 0)
            {
                Console.WriteLine("A{0}", i);
            }
        }
    }
}

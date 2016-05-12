using System;

class DancingBits
{
    static void Main()
    {
        int numK = int.Parse(Console.ReadLine());
        int numN = int.Parse(Console.ReadLine());
        string bitSeq = string.Empty;

        for (int i = 0; i < numN; i++)
        {
            bitSeq += Convert.ToString(int.Parse(Console.ReadLine()), 2);
        }

        int currentBit = bitSeq[0];
        int currentCount = 1;
        int count = 0;

        for (int i = 1; i < bitSeq.Length; i++)
        {
            if (currentBit == bitSeq[i])
            {
                currentCount++;
            }
            else
            {
                if (currentCount == numK)
                {
                    count++;
                }
                currentBit = bitSeq[i];
                currentCount = 1;
            }
        }

        if (currentCount == numK)
        {
            count++;
        }
        Console.WriteLine(count);
    }
}

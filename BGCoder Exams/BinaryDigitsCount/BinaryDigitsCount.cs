using System;

class BinaryDigitsCount
{
    static void Main()
    {
        char B = char.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        int count = 0;
        int[] countB = new int[N];

        for (int i = 0; i < N; i++)
        {
            long number = long.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);

            for (int j = 0; j < binary.Length; j++)
            {
                char currentBit = binary[j];
                
                if (currentBit == B)
                {
                    count++;
                }
            }
            countB[i] = count;
            count = 0;
        }

        for (int e = 0; e < countB.Length; e++)
        {
            Console.WriteLine(countB[e]);
        }
    }
}


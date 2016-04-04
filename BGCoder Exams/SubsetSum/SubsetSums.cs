using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SubsetSums
{
    static void Main()
    {
        long sum = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        long[] numbers = new long[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        long counter = 0;

        for (int i = 1; i < Math.Pow(2, n); i++)
        {
            long temp = 0;

            for (int j = 0; j < n; j++)
            {
                long mask = (long)(1 << j);
                mask = (i & mask) >> j;

                if (mask == 1)
                {
                    temp += numbers[j];
                }
            }

            if (temp == sum)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}


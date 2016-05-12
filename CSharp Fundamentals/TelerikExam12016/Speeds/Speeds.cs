using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Speeds
{
    static void Main()
    {
        int c = int.Parse(Console.ReadLine());

        List<ulong> street = new List<ulong>();

        for (int i = 0; i < c; i++)
        {
            street.Add(ulong.Parse(Console.ReadLine()));
        }

        street.Reverse();
        ulong currentSum = street[0];
        int currentCount = 0;
        ulong sum = 0;
        int count = 0;

        for (int i = 1; i < street.Count; i++)
        {
            if (street[i] < street[i - 1])
            {
                currentSum += street[i];
                currentCount++;

            }
            else
            {
                if (currentCount >= count)
                {
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                    }
                    count = currentCount;
                }
                currentCount = 0;
                currentSum = street[i];
            }
        }
        if (currentCount >= count)
        {
            if (currentSum > sum)
            {
                sum = currentSum;
            }
            count = currentCount;
        }
        Console.WriteLine(sum);
    }
}

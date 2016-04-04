using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LeastMajorityMultiple
{
    static void Main()
    {
        int[] array = new int[5];

        for (int i = 0; i < 5; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i > 0; i++)
        {
            int count = 0;

            for (int j = 0; j < 5; j++)
            {
                if (i % array[j] == 0)
                {
                    count++;
                }
                if (count >= 3)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}

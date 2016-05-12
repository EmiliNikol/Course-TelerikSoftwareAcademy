using System;

// Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//  - Find in the array a subset of K elements that have sum S or indicate about its absence.

class SubsetKWithSumS
{
    static void Main()
    {
        int lenArray = int.Parse(Console.ReadLine());
        int[] array = new int[lenArray];

        for (int i = 0; i < lenArray; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        bool check = false;

        for (int i = 1; i < (1 << lenArray); i++)
        {
            int subsetSum = 0;
            int counter = 0;

            for (int j = 0; j < lenArray; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    subsetSum += array[j];
                    counter++;
                }
            }

            if (subsetSum == sum && counter == k)
            {
                check = true;
                Console.WriteLine("yes");
                break;
            }
        }

        if (!check)
        {
            Console.WriteLine("no");
        }
    }
}


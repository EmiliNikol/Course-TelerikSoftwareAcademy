using System;

// We are given an array of integers and a number S. Write a program to find if there exists 
// a subset of the elements of the array that has a sum S.

class SubsetWithSumS
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
        bool check = false;

        for (int i = 1; i < (1 << lenArray); i++)
        {
            int subsetSum = 0;

            for (int j = 0; j < lenArray; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    subsetSum += array[j];
                }
            }

            if (subsetSum == sum)
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

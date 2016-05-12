using System;

// Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
//  - Can you do it with only one loop (with single scan through the elements of the array)?

class MaximalSumOfConsecutiveElements
{
    static void Main()
    {
        int lenArray = int.Parse(Console.ReadLine());
        int[] array = new int[lenArray];

        for (int i = 0; i < lenArray; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int maxSum = 0;

        for (int i = 0; i < lenArray; i++)
        {
            sum += array[i];

            if (sum > maxSum)
            {
                maxSum = sum;
            }

            if (sum < 0)
            {
                sum = 0;
            }
        }

        Console.WriteLine(maxSum);
    }
}

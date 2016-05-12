﻿using System;

// Write a program that finds the length of the maximal increasing sequence in an array of N integers.

class MaximalIncreasingSequence
{
    static void Main()
    {
        int lenArray = int.Parse(Console.ReadLine());
        int[] array = new int[lenArray];

        for (int i = 0; i < lenArray; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int currentElem = array[0];
        int currentCount = 1;
        int count = 1;

        for (int i = 1; i < lenArray; i++)
        {
            if (currentElem < array[i])
            {
                currentCount++;
                currentElem = array[i];
            }
            else
            {
                if (count < currentCount)
                {
                    count = currentCount;
                }

                currentElem = array[i];
                currentCount = 1;
            }
        }

        if (count < currentCount)
        {
            count = currentCount;
        }

        Console.WriteLine(count);
    }
}

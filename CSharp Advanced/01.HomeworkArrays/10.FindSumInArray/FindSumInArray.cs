using System;
using System.Collections.Generic;

// Write a program that finds in given array of integers a sequence of given sum S (if present).

class FindSumInArray
{
    static void Main()
    {
        int lenArray = int.Parse(Console.ReadLine());
        int sum = int.Parse(Console.ReadLine());
        int[] array = new int[lenArray];

        for (int i = 0; i < lenArray; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int currentSum = 0;
        int index = 1;
        int currentIndex = 0;

        while (currentSum != sum)
        {
            if (currentIndex < lenArray)
            {
                currentSum += array[currentIndex];
                currentIndex++;

                if (currentSum > sum)
                {
                    currentSum = 0;
                    currentIndex = index;
                    index++;
                }
            }
            else
            {
                break;
            }
        }

        List<int> sequence = new List<int>();

        for (int i = currentIndex - 1; i >= 0; i--)
        {
            if (currentSum > 0)
            {
                currentSum -= array[i];
                sequence.Add(array[i]);
            }
            else
            {
                break;
            }
        }

        for (int i = sequence.Count - 1; i >= 0; i--)
        {
            Console.Write(i > 0 ? sequence[i] + ", " : sequence[i] + "");
        }
    }
}

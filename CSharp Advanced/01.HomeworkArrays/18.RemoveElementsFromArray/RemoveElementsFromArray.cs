using System;
using System.Collections.Generic;

// Write a program that reads an array of integers and removes from it a minimal number 
// of elements in such a way that the remaining array is sorted in increasing order. 
// Print the minimal number of elements that need to be removed in order for the array to become sorted.

class RemoveElementsFromArray
{
    static void Main()
    {
        int lenArray = int.Parse(Console.ReadLine());
        List<int> array = new List<int>();
        List<int> newArray = new List<int>();
        int maxLen = 0;

        for (int i = 0; i < lenArray; i++)
        {
            array.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < lenArray; i++)
        {
            newArray.Add(1);
        }

        for (int i = 1; i < lenArray; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if ((array[j] <= array[i]) && (newArray[i] < (newArray[j] + 1)))
                {
                    newArray[i] = newArray[j] + 1;

                    if (maxLen < newArray[i])
                    {
                        maxLen = newArray[i];
                    }
                }
            }
        }

        Console.WriteLine(lenArray - maxLen);
    }
}


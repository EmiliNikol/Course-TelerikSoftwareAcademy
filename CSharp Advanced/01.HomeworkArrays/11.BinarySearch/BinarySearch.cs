using System;

// Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.

class BinarySearch
{
    static void Main()
    {
        int lenArray = int.Parse(Console.ReadLine());
        int[] array = new int[lenArray];

        for (int i = 0; i < lenArray; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int xElem = int.Parse(Console.ReadLine());
        Array.Sort(array);

        int firstIndex = 0;
        int lastIndex = lenArray - 1;
        int middleIndex = 0;
        bool found = false;

        while (firstIndex <= lastIndex)
        {
            middleIndex = (firstIndex + lastIndex) / 2;

            if (xElem > array[middleIndex])
            {
                firstIndex = middleIndex + 1;
            }
            else if (xElem < array[middleIndex])
            {
                lastIndex = middleIndex - 1;
            }
            else
            {
                found = true;
                Console.WriteLine(middleIndex);
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("-1");
        }

    }
}

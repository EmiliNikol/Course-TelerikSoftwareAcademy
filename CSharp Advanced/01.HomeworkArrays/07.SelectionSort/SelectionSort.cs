using System;

// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
// Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
// find the smallest from the rest, move it at the second position, etc.

class SelectionSort
{
    static void Main()
    {
        int lenArray = int.Parse(Console.ReadLine());
        int[] array = new int[lenArray];

        for (int i = 0; i < lenArray; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int minElem = 0;

        for (int i = 0; i < lenArray; i++)
        {
            minElem = i;

            for (int j = i + 1; j < lenArray; j++)
            {
                if (array[j] < array[minElem])
                {
                    minElem = j;
                }
            }

            if (array[i] > array[minElem])
            {
                array[i] = array[i] + array[minElem];
                array[minElem] = array[i] - array[minElem];
                array[i] = array[i] - array[minElem];
            }
        }

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}


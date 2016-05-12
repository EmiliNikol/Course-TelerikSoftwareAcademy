using System;

// Write a program that sorts an array of integers using the Quick sort algorithm.

class SortArrayWhitQuickSort
{
    static void Main()
    {
        int lenArray = int.Parse(Console.ReadLine());
        int[] array = new int[lenArray];

        for (int i = 0; i < lenArray; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        QuickSort(array, 0, lenArray - 1);

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

    static void QuickSort(int[] array, int left, int right)
    {
        if (left > right)
        {
            return;
        }

        int pivot = Partition(array, left, right);

        QuickSort(array, left, pivot - 1);
        QuickSort(array, pivot + 1, right);
    }

    static void Swap(int[] array, int from, int to)
    {
        if (from == to)
        {
            return;
        }

        array[from] ^= array[to];
        array[to] = array[from] ^ array[to];
        array[from] ^= array[to];
    }

    static int Partition(int[] array, int left, int right)
    {
        int k = left - 1;

        for (int i = left; i <= right; i++)
        {
            if (array[i] <= array[right])
            {
                k++;
                Swap(array, i, k);
            }
        }

        return k;
    }

}

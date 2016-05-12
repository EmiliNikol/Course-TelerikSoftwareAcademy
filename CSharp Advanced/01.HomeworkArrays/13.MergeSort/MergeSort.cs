using System;

// Write a program that sorts an array of integers using the Merge sort algorithm.

class MergeSort
{
    static void Main()
    {
        int lenArray = int.Parse(Console.ReadLine());
        int[] array = new int[lenArray];

        for (int i = 0; i < lenArray; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Split(array);

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

    static void Merge(int[] mainArray, int[] leftArray, int[] rightArray)
    {
        int lLen = leftArray.Length;
        int rLen = rightArray.Length;
        int i = 0;
        int j = 0;
        int k = 0;

        while (i < lLen && j < rLen)
        {
            if (leftArray[i] <= rightArray[j])
            {
                mainArray[k] = leftArray[i];
                i++;
            }
            else
            {
                mainArray[k] = rightArray[j];
                j++;
            }
            k++;
        }
        while (i < lLen)
        {
            mainArray[k] = leftArray[i];
            i++;
            k++;
        }
        while (j < rLen)
        {
            mainArray[k] = rightArray[j];
            j++;
            k++;
        }
    }

    static void Split(int[] mainArray)
    {
        if (mainArray.Length < 2)
        {
            return;
        }
        int middle = mainArray.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[mainArray.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            left[i] = mainArray[i];
        }

        for (int i = middle; i < mainArray.Length; i++)
        {
            right[i - middle] = mainArray[i];
        }
        Split(left);
        Split(right);
        Merge(mainArray, left, right);
    }
}

using System;

// Write a program that finds the most frequent number in an array of N elements.

class FrequentNumber
{
    static void Main()
    {
        int lenArray = int.Parse(Console.ReadLine());
        int[] array = new int[lenArray];

        for (int i = 0; i < lenArray; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        int currentElem = array[0];
        int currentCount = 1;
        int count = 1;
        int elem = 0;

        for (int i = 1; i < lenArray; i++)
        {
            if (currentElem == array[i])
            {
                currentCount++;
            }
            else
            {
                if (count < currentCount)
                {
                    count = currentCount;
                    elem = currentElem;
                }

                currentElem = array[i];
                currentCount = 1;
            }
        }

        if (count < currentCount)
        {
            count = currentCount;
            elem = currentElem;
        }

        Console.WriteLine("{0} ({1} times)", elem, count);
    }
}

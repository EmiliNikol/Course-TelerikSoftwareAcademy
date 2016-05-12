using System;

// Write a program that reads two integer numbers N and K and an array of N elements from the console. 
// Find the maximal sum of K elements in the array.

class MaximalKSum
{
    static void Main()
    {
        int lenArray = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[lenArray];

        for (int i = 0; i < lenArray; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Array.Reverse(array);

        int sum = 0;

        for (int i = 0; i < k; i++)
        {
            sum += array[i];
        }

        Console.WriteLine(sum);
    }
}

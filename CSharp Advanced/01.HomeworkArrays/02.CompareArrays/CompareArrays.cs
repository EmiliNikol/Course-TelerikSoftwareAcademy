using System;

// Write a program that reads two integer arrays of size N from the console and compares them element by element.

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                counter++;
            }
        }

        Console.WriteLine(counter == n ? "Equal" : "Not equal");
    }
}

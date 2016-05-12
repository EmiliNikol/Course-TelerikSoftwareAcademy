using System;

// Write a program that allocates array of N integers, 
// initializes each element by its index multiplied by 5 and the prints the obtained array on the console.

class AllocateArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = i * 5;
           
            Console.WriteLine(array[i]);
        }
    }
}

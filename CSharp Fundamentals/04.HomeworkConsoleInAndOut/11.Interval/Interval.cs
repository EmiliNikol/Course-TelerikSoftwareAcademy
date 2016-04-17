using System;

// Write a program that reads two positive integer numbers N and M and prints
// how many numbers exist between them such that the reminder of the division by 5 is 0.

class Interval
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int numM = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int i = numN + 1; i < numM; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}

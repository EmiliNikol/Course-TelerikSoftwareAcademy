using System;

// Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.
//  -Note: You may need to use a for-loop.

class SumOfNNumbers
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        double sumNnum = 0;

        for (int i = 0; i < numN; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sumNnum += number;
        }

        Console.WriteLine(sumNnum);
    }
}


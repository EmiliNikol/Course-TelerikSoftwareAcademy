using System;

// Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
//  - Use the Euclidean algorithm (find it in Internet).

class GreatestCommonDivisor
{
    static void Main()
    {
        string[] userInput = Console.ReadLine().Split(' ');

        int numA = int.Parse(userInput[0]);
        int numB = int.Parse(userInput[1]);

        int result = 1;

        while (numB > 0)
        {
            result = numA % numB;
            numA = numB;
            numB = result;
        }

        Console.WriteLine(numA);
    }
}


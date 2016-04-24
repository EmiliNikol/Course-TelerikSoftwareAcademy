using System;

// Write a program that, for a given two integer numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x^2 + … + N!/x^N.
//   - Use only one loop. Print the result with 5 digits after the decimal point.

class CalculateFaktorial
{
    static void Main()
    {
        double numN = double.Parse(Console.ReadLine());
        double numX = double.Parse(Console.ReadLine());

        double faktorial = 1;
        double sum = 1;

        for (int i = 1; i <= numN; i++)
        {
            faktorial *= i;
            sum += faktorial / (Math.Pow(numX, i));
        }

        Console.WriteLine("{0:F5}", sum);
    }
}

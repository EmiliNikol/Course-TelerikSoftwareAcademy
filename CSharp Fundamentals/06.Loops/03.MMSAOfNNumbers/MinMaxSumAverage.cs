using System;

// Write a program that reads from the console a sequence of N integer numbers and returns the minimal, 
// the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//  - The input starts by the number N (alone in a line) followed by N lines, each holding an integer number.
//  - The output is like in the examples below.

class MinMaxSumAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double minNum = 10000;
        double maxNum = -10000;
        double sum = 0;
        double average = 0;

        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());

            if (maxNum < number)
            {
                maxNum = number;
            }
            
            if (minNum > number)
            {
                minNum = number;
            }

            sum += number;
        }

        average = sum / n;

        Console.WriteLine("min={0:F2}", minNum);
        Console.WriteLine("max={0:F2}", maxNum);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", average);
    }
}

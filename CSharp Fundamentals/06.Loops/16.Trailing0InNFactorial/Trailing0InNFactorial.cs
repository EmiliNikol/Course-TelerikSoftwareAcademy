using System;
using System.Numerics;

// Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
//  - Your program should work well for very big numbers, e.g. N = 100000.

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int zeroCounter = 0;
        int devider = 5;
       
        while (number / devider >= 1)
        {
            zeroCounter += number / devider;
            devider *= 5;
        }

        Console.WriteLine(zeroCounter);
    }
}

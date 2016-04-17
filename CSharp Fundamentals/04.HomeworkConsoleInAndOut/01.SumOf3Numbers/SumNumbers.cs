using System;

// Write a program that reads 3 real numbers from the console and prints their sum.

class SumNumbers
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());

        Console.WriteLine(firstNum + secondNum + thirdNum);
    }
}

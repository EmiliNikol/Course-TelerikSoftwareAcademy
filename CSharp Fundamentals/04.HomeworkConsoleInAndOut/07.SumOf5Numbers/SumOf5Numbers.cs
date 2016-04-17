using System;

// Write a program that reads 5 integer numbers from the console and prints their sum.

class SumOf5Numbers
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());
        int fourthNum = int.Parse(Console.ReadLine());
        int fifthNum = int.Parse(Console.ReadLine());

        Console.WriteLine(firstNum + secondNum + thirdNum + fourthNum + fifthNum);
    }
}

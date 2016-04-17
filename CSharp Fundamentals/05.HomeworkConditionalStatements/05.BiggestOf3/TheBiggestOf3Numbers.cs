using System;

// Write a program that finds the biggest of three numbers that are read from the console.

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());

        double biggestNum = firstNum;

        if (secondNum >= firstNum && secondNum >= thirdNum)
        {
            biggestNum = secondNum;
        }
        else if (thirdNum > firstNum && thirdNum > secondNum)
        {
            biggestNum = thirdNum;
        }

        Console.WriteLine(biggestNum);
    }
}

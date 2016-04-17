using System;

// Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.

class TheBiggestOf5Numbers
{
    static void Main(string[] args)
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());
        double fourthNum = double.Parse(Console.ReadLine());
        double fifthNum = double.Parse(Console.ReadLine());

        if (firstNum >= secondNum && firstNum >= thirdNum && firstNum >= fourthNum && firstNum >= fifthNum)
        {
            Console.WriteLine(firstNum);
        }
        else if (secondNum > firstNum && secondNum > thirdNum && secondNum > fourthNum && secondNum > fifthNum)
        {
            Console.WriteLine(secondNum);
        }
        else if (thirdNum > firstNum && thirdNum > secondNum && thirdNum > fourthNum && thirdNum > fifthNum)
        {
            Console.WriteLine(thirdNum);
        }
        else if (fourthNum > fifthNum && fourthNum > secondNum && fourthNum > thirdNum && fourthNum > fifthNum)
        {
            Console.WriteLine(fourthNum);
        }
        else if (fifthNum > firstNum && fifthNum > secondNum && fifthNum > thirdNum && fifthNum > fourthNum)
        {
            Console.WriteLine(fifthNum);
        }
    }
}

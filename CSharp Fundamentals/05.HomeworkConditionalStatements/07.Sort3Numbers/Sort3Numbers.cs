using System;

// Write a program that enters 3 real numbers and prints them sorted in descending order.
//  -Use nested if statements.
//  -Don’t use arrays and the built-in sorting functionality.

class Sort3Numbers
{
    static void Main(string[] args)
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());

        double isFirst = 0;
        double isSecond = 0;
        double isThird = 0;

        if (firstNum >= secondNum && firstNum >= thirdNum)
        {
            isFirst = firstNum;
            if (secondNum >= thirdNum)
            {
                isSecond = secondNum;
                isThird = thirdNum;
            }
            else
            {
                isSecond = thirdNum;
                isThird = secondNum;
            }
        }
        else if (secondNum >= firstNum && secondNum >= thirdNum)
        {
            isFirst = secondNum;
            if (firstNum >= thirdNum)
            {
                isSecond = firstNum;
                isThird = thirdNum;
            }
            else
            {
                isSecond = thirdNum;
                isThird = firstNum;
            }
        }
        else if (thirdNum >= firstNum && thirdNum >= secondNum)
        {
            isFirst = thirdNum;
            if (firstNum >= secondNum)
            {
                isSecond = firstNum;
                isThird = secondNum;
            }
            else
            {
                isSecond = secondNum;
                isThird = firstNum;
            }
        }

        Console.WriteLine("{0} {1} {2}", isFirst, isSecond, isThird);
    }
}

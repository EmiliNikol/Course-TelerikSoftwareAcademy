using System;

// Write a program that gets two numbers from the console and prints the greater of them.

class NumberComparer
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());

        Console.WriteLine(firstNum >= secondNum ? firstNum : secondNum);
    }
}

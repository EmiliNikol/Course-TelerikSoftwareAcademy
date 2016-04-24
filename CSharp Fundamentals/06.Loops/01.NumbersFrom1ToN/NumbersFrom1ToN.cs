using System;

// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to N inclusive, 
// on a single line, separated by a whitespace.

class NumbersFrom1ToN
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}

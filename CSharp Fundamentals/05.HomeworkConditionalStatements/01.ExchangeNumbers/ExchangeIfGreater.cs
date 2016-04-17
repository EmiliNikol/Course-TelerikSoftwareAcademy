using System;

// Write a program that reads two double values from the console A and B, 
// stores them in variables and exchanges their values if the first one is greater than the second one.
// Use an if-statement. As a result print the values of the variables A and B, separated by a space.

class ExchangeIfGreater
{
    static void Main()
    {
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());

        if (numA > numB)
        {
            Console.WriteLine("{0} {1}", numB, numA);
        }
        else
        {
            Console.WriteLine("{0} {1}", numA, numB);
        }
    }
}

using System;

// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.

class NullValuesArithmetic
{
    static void Main()
    {
        int? firstVar = null;
        double? secondVar = null;

        Console.WriteLine("Prints{0}{1}Nothing.", firstVar, secondVar); 
        firstVar = firstVar + null;
        secondVar = secondVar + 1000;
        Console.WriteLine("Prints{0}{1}Nothing.", firstVar, secondVar);
    }
}

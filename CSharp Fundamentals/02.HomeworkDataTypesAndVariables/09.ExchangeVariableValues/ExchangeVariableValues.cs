using System;

// Declare two integer variables a and b and assign them with 5 and 10 
// and after that exchange their values by using some programming logic. 
// Print the variable values before and after the exchange.

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before exchange:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        // First option.
        a = a + b;
        b = a - b;
        a = a - b;

        // Second option.
        // a = a * b;
        // b = a / b;
        // a = a / b;

        // Third option.
        // int c = 0;
        // c = a;
        // a = b;
        // b = c;

        // Fourth option.
        // a = a ^ b;
        // b = a ^ b;
        // a = a ^ b;
        Console.WriteLine("After exchange:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

    }
}

using System;

// Write a program that outputs: The "use" of quotations causes difficulties.

class QuotesInStrings
{
    static void Main()
    {
        // First option.
        string str1 = "The \"use\" of quotations causes difficulties.";

        // Second option.
        // string str1 = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(str1);
    }
}

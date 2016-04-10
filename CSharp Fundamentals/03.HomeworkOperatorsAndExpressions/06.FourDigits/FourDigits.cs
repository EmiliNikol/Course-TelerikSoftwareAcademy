using System;

// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// 1.Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
// 2.Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
// 3.Puts the last digit in the first position: dabc (in our example 1201) and prints the result.
// 4.Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.

class FourDigits
{
    static void Main()
    {
        int abcd = int.Parse(Console.ReadLine());

        int d = abcd % 10;
        int c = (abcd / 10) % 10;
        int b = (abcd / 100) % 10;
        int a = (abcd / 1000) % 10;

        Console.WriteLine(a + b + c + d);
        Console.WriteLine("{3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("{3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("{0}{2}{1}{3}", a, b, c, d);
    }
}

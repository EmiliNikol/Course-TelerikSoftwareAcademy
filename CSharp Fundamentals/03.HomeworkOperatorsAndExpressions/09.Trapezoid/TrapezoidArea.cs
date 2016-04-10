using System;

// Write an expression that calculates trapezoid's area by given sides a and b and height h. 
// The three values should be read from the console in the order shown below. All three value will be floating-point numbers.

class TrapezoidArea
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = ((sideA + sideB) / 2) * height;

        Console.WriteLine("{0:F7}", area);
    }
}

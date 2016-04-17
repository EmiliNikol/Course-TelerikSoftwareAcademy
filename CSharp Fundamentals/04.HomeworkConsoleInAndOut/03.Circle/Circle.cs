using System;

// Write a program that reads from the console the radius r of a circle and prints its perimeter 
// and area, rounded and formatted with 2 digits after the decimal point.

class Circle
{
    static void Main()
    {
        double radiusCircle = double.Parse(Console.ReadLine());

        double perimeter = Math.PI * 2 * radiusCircle;
        double area = Math.PI * Math.Pow(radiusCircle, 2);

        Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
    }
}

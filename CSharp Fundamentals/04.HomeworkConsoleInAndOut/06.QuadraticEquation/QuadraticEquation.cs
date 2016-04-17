using System;

// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

class QuadraticEquation
{
    static void Main()
    {
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());

        double discriminant = Math.Pow(numB, 2) - (4 * numA * numC);

        double firstRoot = (-numB + Math.Sqrt(discriminant)) / (2 * numA);
        double secondRoot = (-numB - Math.Sqrt(discriminant)) / (2 * numA);

        if (discriminant < 0 || numA == 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("{0:F2}", firstRoot);
        }
        else
        {
            Console.WriteLine((firstRoot < secondRoot ? "{0:F2}\n{1:F2}" : "{1:F2}\n{0:F2}"), firstRoot, secondRoot);
        }

    }
}

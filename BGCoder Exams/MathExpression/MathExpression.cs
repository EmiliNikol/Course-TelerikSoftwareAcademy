using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MathExpression
{
    static void Main()
    {
        double N = double.Parse(Console.ReadLine());
        double M = double.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());

        double expr1 = 1 / (M * P);
        double expr2 = N - (128.523123123 * P);
        double expr3 = Math.Sin((int)M % 180);

        double result = (N * N + expr1 + 1337) / expr2 + expr3;

        Console.WriteLine("{0:F6}", result);
    }
}

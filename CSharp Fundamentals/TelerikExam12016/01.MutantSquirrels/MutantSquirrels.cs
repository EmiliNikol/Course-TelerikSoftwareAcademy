using System;

class MutantSquirrels
{
    static void Main()
    {
        double t = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double s = double.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());

        double result = t * b * s * n;

        if (result % 2 == 0)
        {
            result *= 376439;
        }
        else
        {
            result /= 7;
        }
        Console.WriteLine("{0:F3}", result);
    }
}

using System;

// Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.
// Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature 
// of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely 
// to each other than a fixed constant eps.

class ComparingFloats
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double eps = 0.000001;

        double difference = Math.Abs(a - b);

        Console.WriteLine(difference < eps ? "true" : "false");
        
    }
}

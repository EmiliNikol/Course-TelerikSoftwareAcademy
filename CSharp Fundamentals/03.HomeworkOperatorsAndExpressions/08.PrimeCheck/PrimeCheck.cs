using System;

// Write a program that reads an integer N (which will always be less than 100 or equal) 
// and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).
// Note: You should check if the number is positive

class PrimeCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine("false");
            return;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine("false");
                return;
            }
        }
        Console.WriteLine("true");
    }
}

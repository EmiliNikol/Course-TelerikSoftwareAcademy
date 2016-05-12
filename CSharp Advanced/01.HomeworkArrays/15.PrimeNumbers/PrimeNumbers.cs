using System;

// Write a program that finds all prime numbers in the range [1 ... N]. 
// Use the Sieve of Eratosthenes algorithm. The program should print the biggest prime number which is <= N.

class PrimeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] isPrime = new bool[n + 1];

        for (int i = 2; i <= n; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            if (!isPrime[i])
            {
                continue;
            }

            for (int j = i * i; j <= n; j += i)
            {
                isPrime[j] = false;
            }
        }

        for (int i = n; i >= 0; i--)
        {
            if (isPrime[i])
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}

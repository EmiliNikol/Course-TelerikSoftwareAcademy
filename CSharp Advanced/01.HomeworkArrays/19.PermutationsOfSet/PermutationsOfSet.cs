using System;

// Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

class PermutationsOfSet
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        PrintPermutations(n, n, array);
    }
    static void PrintPermutations(int N, int K, int[] arr)
    {
        if (K == 0)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("({0}, ", arr[i]);
                }
                else if (i == arr.Length - 1)
                {
                    Console.WriteLine("{0})", arr[i]);
                }
                else
                {
                    Console.Write("{0}, ", arr[i]);
                }
            }

            return;
        }

        for (int i = 0; i < N; i++)
        {
            arr[arr.Length - K] = i + 1;
            bool areEqual = false;

            for (int j = 0; j < arr.Length - K; j++)
            {
                if (arr[arr.Length - K] == arr[j])
                {
                    areEqual = true;
                }
            }
            if (areEqual)
            {
                continue;
            }
            PrintPermutations(N, K - 1, arr);
        }
    }
}

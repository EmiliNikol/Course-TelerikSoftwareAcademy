using System;

// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].

class VariationsOfSet
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[k];

        PrintVariations(n, k, array);
    }

    static void PrintVariations(int N, int K, int[] arr)
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
            PrintVariations(N, K - 1, arr);
        }
    }
}

using System;

// You are given N integers (given in a single line, separated by a space).
//  - Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//  - Elements are counted from 1 to N, so the first element is odd, the second is even, etc.

class OddAndEvenProduct
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());

        string[] userInput = Console.ReadLine().Split(' ');

        ulong oddProduct = 1;
        ulong evenProduct = 1;

        for (int i = 0; i < numN; i++)
        {
            ulong element = ulong.Parse(userInput[i]);

            if (i % 2 == 0)
            {
                oddProduct *= element;
            }
            else
            {
                evenProduct *= element;
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }
    }
}

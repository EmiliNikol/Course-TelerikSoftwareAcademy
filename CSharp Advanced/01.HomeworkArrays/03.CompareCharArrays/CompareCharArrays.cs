using System;

// Write a program that compares two char arrays lexicographically (letter by letter).

class CompareCharArrays
{
    static void Main()
    {
        string firstStr = Console.ReadLine();
        char[] firstArray = firstStr.ToCharArray();

        string secondStr = Console.ReadLine();
        char[] secondArray = secondStr.ToCharArray();

        int length = firstArray.Length;

        if (length > secondArray.Length)
        {
            length = secondArray.Length;
        }

        for (int i = 0; i < length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                Console.WriteLine(firstArray[i] > secondArray[i] ? ">" : "<");
                return;
            }
        }

        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine(firstArray.Length > secondArray.Length ? ">" : "<");
        }
        else
        {
            Console.WriteLine("=");
        }
    }
}

using System;

// Write a program that reads a number N and prints on the console the first N members
// of the Fibonacci sequence (at a single line, separated by comma and space - ", ") : 
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

class FibonacciNumbers
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());

        ulong firstMember = 0;
        ulong secondMember = 1;

        if (numN == 1)
        {
            Console.WriteLine(firstMember);
        }
        else if (numN == 2)
        {
            Console.WriteLine("{0}, {1}", firstMember, secondMember);
        }
        else
        {
            Console.Write("{0}, {1}, ", firstMember, secondMember);

            for (int i = 3; i <= numN; i++)
            {
                ulong currentMember = firstMember + secondMember;

                Console.Write((i < numN ? "{0}, " : "{0}"), currentMember);

                firstMember = secondMember;
                secondMember = currentMember;
                currentMember = 0;
            }
        }
    }
}

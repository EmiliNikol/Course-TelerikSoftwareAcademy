using System;

// Write a program that reads from the console a positive integer number N and prints a matrix 
// like in the examples below. Use two nested loops.
//  - Challenge: achieve the same effect without nested loops

class MatrixOfNumbers
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());

        // With nested loops. 

        for (int i = 1; i <= numN; i++)
        {
            for (int j = 0; j < numN; j++)
            {
                Console.Write(i + j + " ");
            }

            Console.WriteLine();
        }

        // Without nested loops.

        //  int currentCount = 1;
        //  int count = 1;
        //  int rowIndex = 0;

        //  for (int i = 0; i < (numN * numN); i++)
        //  {
        //      if (currentCount <= numN)
        //      {
        //          Console.Write(count + " ");

        //          if (currentCount == numN)
        //          {
        //              rowIndex++;
        //              count = rowIndex;
        //              currentCount = 0;

        //              Console.WriteLine();
        //          }
        //      }
        //      count++;
        //      currentCount++;
        //  }
    }
}

using System;

// Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) 
// and prints a matrix holding the numbers from 1 to N*N in the form of square spiral like in the examples below.

class SpiralMatrix
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());

        int counter = 1;
        int maxValue = numN * numN;
        int minRow = 0;
        int maxRow = numN - 1;
        int minCol = 0;
        int maxCol = numN - 1;
        int[,] matrix = new int[numN, numN];

        do
        {
            for (int i = minCol; i <= maxCol; i++)
            {
                matrix[minRow, i] = counter;
                counter++;
            }
            minRow++;
            for (int i = minRow; i <= maxRow; i++)
            {
                matrix[i, maxCol] = counter;
                counter++;
            }
            maxCol--;
            for (int i = maxCol; i >= minCol; i--)
            {
                matrix[maxRow, i] = counter;
                counter++;
            }
            maxRow--;
            for (int i = maxRow; i >= minRow; i--)
            {
                matrix[i, minCol] = counter;
                counter++;
            }
            minCol++;
        } while (counter <= maxValue);

        for (int i = 0; i < numN; i++)
        {
            for (int j = 0; j < numN; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

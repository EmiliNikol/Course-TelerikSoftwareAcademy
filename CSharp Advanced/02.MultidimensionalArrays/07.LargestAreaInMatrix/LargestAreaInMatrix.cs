using System;

// Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

class LargestAreaInMatrix
{
    static void Main()
    {
        string[] sizes = Console.ReadLine().Split(' ');
        int rows = int.Parse(sizes[0]);
        int cols = int.Parse(sizes[1]);

        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            string[] inputRows = Console.ReadLine().Split(' ');

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = int.Parse(inputRows[col]);
            }
        }

        bool[,] isCounted = new bool[rows, cols];
        int counter = 0;
        int element = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentCounter = 0;

                if (!isCounted[row, col])
                {
                    currentCounter = CounterOfEqualNeighborElements(matrix, isCounted, row, col, currentCounter);
                }

                if (currentCounter > counter)
                {
                    counter = currentCounter;
                    element = matrix[row, col];
                }
            }
        }

        Console.WriteLine(counter);
    }

    static int CounterOfEqualNeighborElements(int[,] matrix, bool[,] isCounted, int startRow, int startCol, int counter)
    {
        isCounted[startRow, startCol] = true;
        counter++;

        if (startRow - 1 >= 0) 
        {
            if (matrix[startRow - 1, startCol] == matrix[startRow, startCol] && isCounted[startRow - 1, startCol] == false)
            {
                counter = CounterOfEqualNeighborElements(matrix, isCounted, startRow - 1, startCol, counter);
            }
        }

        if (startCol - 1 >= 0)
        {
            if (matrix[startRow, startCol - 1] == matrix[startRow, startCol] && isCounted[startRow, startCol - 1] == false)
            {
                counter = CounterOfEqualNeighborElements(matrix, isCounted, startRow, startCol - 1, counter);
            }
        }

        if (startRow + 1 < matrix.GetLength(0))
        {
            if (matrix[startRow + 1, startCol] == matrix[startRow, startCol] && isCounted[startRow + 1, startCol] == false)
            {
                counter = CounterOfEqualNeighborElements(matrix, isCounted, startRow + 1, startCol, counter);
            }
        }

        if (startCol + 1 < matrix.GetLength(1))
        {
            if (matrix[startRow, startCol + 1] == matrix[startRow, startCol] && isCounted[startRow, startCol + 1] == false)
            {
                counter = CounterOfEqualNeighborElements(matrix, isCounted, startRow, startCol + 1, counter);
            }
        }

        return counter;
    }
}

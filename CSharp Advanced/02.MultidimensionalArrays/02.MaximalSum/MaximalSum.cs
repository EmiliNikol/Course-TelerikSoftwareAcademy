using System;

class MaximalSum
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

        int maxSum = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = 0;

                for (int currentRow = row; currentRow < row + 3; currentRow++)
                {
                    for (int currentCol = col; currentCol < col + 3; currentCol++)
                    {
                        sum += matrix[currentRow, currentCol];
                    }
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }

        Console.WriteLine(maxSum);
    }
}

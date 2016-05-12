using System;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char character = char.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        switch (character)
        {
            case 'a':
                FirstCase(matrix);
                break;
            case 'b':
                SecondCase(matrix);
                break;
            case 'c':
                ThirdCase(matrix);
                break;
            case 'd':
                FourthCase(matrix);
                break;
        }

        PrintMatrix(matrix);
    }

    static void FirstCase(int[,] matrix)
    {
        int elem = 1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[col, row] = elem++;
            }
        }
    }

    static void SecondCase(int[,] matrix)
    {
        int elem = 1;

        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            if (col % 2 == 1)
            {
                for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
                {
                    matrix[row, col] = elem++;
                }
            }
            else
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[row, col] = elem++;
                }
            }
        }
    }

    static void ThirdCase(int[,] matrix)
    {
        int maxNumber = matrix.GetLength(0) * matrix.GetLength(1);
        int startRow = matrix.GetLength(0) - 1;
        int startCol = 0;
        int elem = 1;

        while (elem <= maxNumber)
        {
            int currentRow = startRow;
            int currentCol = startCol;

            while (currentRow < matrix.GetLength(0) && currentRow >= 0 && currentCol < matrix.GetLength(1) && currentCol >= 0)
            {
                matrix[currentRow, currentCol] = elem++;
                currentRow++;
                currentCol++;
            }

            if (currentCol >= matrix.GetLength(1))
            {
                startCol++;
            }
            else if (currentRow >= matrix.GetLength(0))
            {
                startRow--;
            }
        }
    }

    static void FourthCase(int[,] matrix)
    {
        int maxNumber = matrix.GetLength(0) * matrix.GetLength(1);
        int elem = 1;
        int currentRow = -1;
        int currentCol = 0;
        string direction = "down";
        int upperBorder = 0;
        int bottomBorder = matrix.GetLength(0) - 1;
        int rightBorder = matrix.GetLength(1) - 1;
        int leftborder = 0;

        while (elem <= maxNumber)
        {
            switch (direction)
            {
                case "down":
                    currentRow++;
                    break;
                case "right":
                    currentCol++;
                    break;
                case "up":
                    currentRow--;
                    break;
                case "left":
                    currentCol--;
                    break;
            }

            matrix[currentRow, currentCol] = elem++;

            if (currentRow == bottomBorder && direction == "down")
            {
                direction = "right";
                leftborder++;
            }
            else if (currentCol == rightBorder && direction == "right")
            {
                direction = "up";
                bottomBorder--;
            }
            else if (currentRow == upperBorder && direction == "up")
            {
                direction = "left";
                rightBorder--;
            }
            else if (currentCol == leftborder && direction == "left")
            {
                direction = "down";
                upperBorder++;
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col == matrix.GetLength(1) - 1)
                {
                    Console.WriteLine(matrix[row, col]);
                }
                else
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
            }
        }
    }

}

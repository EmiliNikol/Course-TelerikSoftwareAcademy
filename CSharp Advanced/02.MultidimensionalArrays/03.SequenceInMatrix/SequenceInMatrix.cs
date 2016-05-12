using System;

class SequenceInMatrix
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

        int counterOfEqualElements = 1;
        string elementOfSequence = string.Empty;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                int currentCounter = 1;
                string currentElement = string.Empty;
                string direction = "right";
                int currentRow = row;
                int currentCol = col;

                while (true)
                {
                    switch (direction)
                    {
                        case "right":
                            currentCol++;
                            break;
                        case "right-down":
                            currentRow++;
                            currentCol++;
                            break;
                        case "down":
                            currentRow++;
                            break;
                        case "left-down":
                            currentRow++;
                            currentCol--;
                            break;
                    }

                    if (direction == "right" && currentCol == cols)
                    {
                        currentCol = col;
                        direction = "right-down";
                        currentCounter = 1;
                        continue;
                    }
                    else if (direction == "right-down" && (currentRow == rows || currentCol == cols))
                    {
                        currentRow = row;
                        currentCol = col;
                        direction = "down";
                        currentCounter = 1;
                        continue;
                    }
                    else if (direction == "down" && currentRow == rows)
                    {
                        currentRow = row;
                        direction = "left-down";
                        currentCounter = 1;
                        continue;
                    }
                    else if (direction == "left-down" && (currentRow == rows || currentCol < 0))
                    {
                        break;
                    }

                    if (matrix[row, col] == matrix[currentRow, currentCol])
                    {
                        currentCounter++;
                        currentElement = Convert.ToString(matrix[row, col]);
                    }
                    else
                    {
                        currentCounter = int.MinValue;
                    }

                    if (currentCounter > counterOfEqualElements)
                    {
                        counterOfEqualElements = currentCounter;
                        elementOfSequence = currentElement;
                    }
                }
            }
        }
        Console.WriteLine(counterOfEqualElements);
    }
}

using System;
using System.Collections.Generic;

class Lines
{
    static void Main()
    {
        byte[] numbers = new byte[8];

        for (int i = 0; i <= 7; i++)
        {
            numbers[i] = byte.Parse(Console.ReadLine());
        }

        string[] bitLines = new string[8];

        for (int i = 0; i <= 7; i++)
        {
            bitLines[i] = Convert.ToString(numbers[i], 2).PadLeft(8, '0');
        }

        int currentLine = 0;
        List<int> longestLine = new List<int>();

        for (int rowIndex = 0; rowIndex < 8; rowIndex++)
        {
            for (int colIndex = 0; colIndex < 8; colIndex++)
            {
                if (bitLines[rowIndex][colIndex] == '1')
                {
                    currentLine++;
                }

                if (bitLines[rowIndex][colIndex] == '0' || (bitLines[rowIndex][colIndex] == '1' && colIndex == 7))
                {
                    if (currentLine > 0)
                    {
                        longestLine.Add(currentLine);
                        currentLine = 0;
                    }
                }
            }
        }
        currentLine = 0;

        for (int colIndex = 0; colIndex < 8; colIndex++)
        {
            for (int rowIndex = 0; rowIndex < 8; rowIndex++)
            {
                 if (bitLines[rowIndex][colIndex] == '1')
                {
                    currentLine++;
                }

                if (bitLines[rowIndex][colIndex] == '0' || (bitLines[rowIndex][colIndex] == '1' && rowIndex == 7))
                {
                    if (currentLine > 0)
                    {
                        longestLine.Add(currentLine);
                        currentLine = 0;
                    }
                }
            }
        }
        longestLine.Sort();
        longestLine.Reverse();

        int bigLine = longestLine[0];
        int bigLineCount = 1;

        for (int i = 1; i < longestLine.Count; i++)
        {
            if (bigLine == longestLine[i])
            {
                bigLineCount++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(bigLine);
        Console.WriteLine(bigLine > 1 ? bigLineCount : bigLineCount / 2);
    }
}

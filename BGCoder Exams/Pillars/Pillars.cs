using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pillars
{
    static void Main()
    {
        byte[] numbers = new byte[8];

        for (int i = 0; i <= 7; i++)
        {
            numbers[i] = byte.Parse(Console.ReadLine());
        }

        // First decision
        string[] bitLines = new string[8];

        for (int i = 0; i <= 7; i++)
        {
            bitLines[i] = Convert.ToString(numbers[i], 2).PadLeft(8, '0');
        }

        for (int pillarIndex = 1; pillarIndex < 7; pillarIndex++)
        {
            int leftBits = 0;
            int rightBits = 0;

            for (int rowIndex = 0; rowIndex < 8; rowIndex++)
            {
                for (int colIndex = 0; colIndex < 8; colIndex++)
                {
                    if (colIndex < pillarIndex && bitLines[rowIndex][colIndex] == '1')
                    {
                        leftBits++;
                    }
                    if (colIndex > pillarIndex && bitLines[rowIndex][colIndex] == '1')
                    {
                        rightBits++;
                    }
                }
            }

            if (leftBits == rightBits && leftBits != 0)
            {
                Console.WriteLine(7 - pillarIndex);
                Console.WriteLine(leftBits);
                return;
            }
        }

        Console.WriteLine("No");
    }
}

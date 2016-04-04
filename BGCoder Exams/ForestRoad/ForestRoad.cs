using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ForestRoad
{
    static void PrintResult(string param1, string param2)
    {
        Console.Write(param1);
        Console.Write('*');
        Console.WriteLine(param2);
    }
    
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string leftDots, rightDots;

        for (int row = 1; row < 2 * n; row++)
        {
            if (row < n)
            {
                leftDots = new string('.', row - 1);
                rightDots = new string('.', n - row);
                
                PrintResult(leftDots, rightDots);
            }
            else
            {
                leftDots = new string('.', 2 * n - row - 1);
                rightDots = new string('.', row - n);

                PrintResult(leftDots, rightDots);
            }   
        }
    }
}


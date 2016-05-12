using System;
using System.Numerics;

class TribonacciTriangle
{
    static void Main()
    {
        long firstElem = long.Parse(Console.ReadLine());
        long secondElem = long.Parse(Console.ReadLine());
        long thirdElem = long.Parse(Console.ReadLine());
        int numL = int.Parse(Console.ReadLine());

        int lastTribIndex = 0;

        for (int i = 1; i <= numL; i++)
        {
            lastTribIndex += i;
        }
        
        long[] tribSequence = new long[lastTribIndex];
        tribSequence[0] = firstElem;
        tribSequence[1] = secondElem;
        tribSequence[2] = thirdElem;


        for (int j = 3; j < lastTribIndex; j++)
        {
            tribSequence[j] = tribSequence[j - 1] + tribSequence[j - 2] + tribSequence[j - 3];
        }
        
        int index = 0;

        for (int row = 1; row <= numL; row++)
        {
            for (int col = 0; col < row - 1; col++)
            {
                Console.Write(tribSequence[index] + " ");
                index++;
            }
            Console.WriteLine(tribSequence[index]);
            index++;
        }
    }
}

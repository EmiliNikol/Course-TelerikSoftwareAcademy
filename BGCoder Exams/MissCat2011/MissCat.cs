using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MissCat
{
    static void Main(string[] args)
    {
        int jury = int.Parse(Console.ReadLine());
        int[] array = new int[jury];

        for (int i = 0; i < jury; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);

        int currentVote = array[0];
        int currentCount = 1;
        int bestVote = 0;
        int count = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (currentVote == array[i])
            {
                currentCount++;
            }
            else
            {
                if (currentCount > count)
                {
                    count = currentCount;
                    bestVote = currentVote;
                }
                currentVote = array[i];
                currentCount = 1;
            }
        }

        if (currentCount > count)
        {
            count = currentCount;
            bestVote = currentVote;
        }
        Console.WriteLine(bestVote);
    }
}

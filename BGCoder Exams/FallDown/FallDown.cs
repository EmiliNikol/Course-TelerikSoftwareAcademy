using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FallDown
{
    static void Main()
    {
        byte[] array = new byte[8];

        for (int i = 0; i < 8; i++)
        {
            array[i] = byte.Parse(Console.ReadLine());
        }

        for (int j = 1; j < 8; j++)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                byte mask = array[i];
                array[i] |= array[i - 1];
                array[i - 1] &= mask;
            }
        }

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

﻿using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i < 1002; i++)
        {
            if (i % 2 == 0)             // Print even numbers.
            {
                Console.WriteLine(i);
            }
            else                        // Print odd numbers.
            {
                Console.WriteLine("-" + i);
            }
        }
    }
}

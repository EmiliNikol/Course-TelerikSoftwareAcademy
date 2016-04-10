using System;

// We are given an integer number N (read from the console), 
// a bit value v (read from the console as well) (v = 0 or 1) and a position P (read from the console).
// Write a sequence of operators (a few lines of C# code) that modifies N to hold the value v at the position P 
// from the binary representation of N while preserving all other bits in N. Print the resulting number on the console.

class ModifyBit
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());
        
        ulong mask = (ulong)1 << position;

        ulong modifiedNum = (number & ~mask) | ((ulong)value << position);

        Console.WriteLine(modifiedNum);
    }
}

using System;

// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).

class BitExchange
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        // 7 in binary is 0000 0111

        uint maskBits345 = 7 << 3;
        uint bits345 = (number & maskBits345) >> 3;
        uint maskBits242526 = 7 << 24;
        uint bits242526 = (number & maskBits242526) >> 24;

        uint modifiedNum = (number & ~maskBits345) | (bits242526 << 3);
        modifiedNum = (modifiedNum & ~maskBits242526) | (bits345 << 24);

        Console.WriteLine(modifiedNum);
    }
}

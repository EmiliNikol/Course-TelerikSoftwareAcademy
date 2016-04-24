using System;

// Using loops write a program that converts a hexadecimal integer number to its decimal form.
//  - The input is entered as string. The output should be a variable of type long.
//  - Do not use the built-in .NET functionality.

class Program
{
    static void Main()
    {
        string hexNum = Console.ReadLine();
        long decimalNum = 0;
        int step = 0;
        int elem = 0;

        for (int i = hexNum.Length - 1; i >= 0; i--)
        {
            switch (hexNum[i])
            {
                case '0':
                    elem = 0;
                    break;
                case '1':
                    elem = 1;
                    break;
                case '2':
                    elem = 2;
                    break;
                case '3':
                    elem = 3;
                    break;
                case '4':
                    elem = 4;
                    break;
                case '5':
                    elem = 5;
                    break;
                case '6':
                    elem = 6;
                    break;
                case '7':
                    elem = 7;
                    break;
                case '8':
                    elem = 8;
                    break;
                case '9':
                    elem = 9;
                    break;
                case 'A':
                    elem = 10;
                    break;
                case 'B':
                    elem = 11;
                    break;
                case 'C':
                    elem = 12;
                    break;
                case 'D':
                    elem = 13;
                    break;
                case 'E':
                    elem = 14;
                    break;
                case 'F':
                    elem = 15;
                    break;
            }
            decimalNum += elem * ((long)Math.Pow(16, step));
            step++;
        }

        Console.WriteLine(decimalNum);
    }
}


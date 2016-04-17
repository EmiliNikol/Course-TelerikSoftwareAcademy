using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Upr
{
    static void Main(string[] args)
    {
        ulong n = ulong.Parse(Console.ReadLine());

        ulong firstNum = 0;
        ulong secondNum = 1;

        Console.Write("{0} {1} ", firstNum, secondNum);

        for (ulong i = 3; i <= n; i++)
        {
            ulong curentNum = firstNum + secondNum;
            Console.Write(curentNum + " ");
            firstNum = secondNum;
            secondNum = curentNum;
            curentNum = 0;
        }
    }
}


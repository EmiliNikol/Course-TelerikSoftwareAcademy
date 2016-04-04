using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ShipDamage
{
    static void Main()
    {
        int sX1 = int.Parse(Console.ReadLine());
        int sY1 = int.Parse(Console.ReadLine());
        int sX2 = int.Parse(Console.ReadLine());
        int sY2 = int.Parse(Console.ReadLine());

        if (sX1 > sX2)
        {
            sX1 ^= sX2;
            sX2 ^= sX1;
            sX1 ^= sX2;
        }
        if (sY1 > sY2)
        {
            sY1 ^= sY2;
            sY2 ^= sY1;
            sY1 ^= sY2;
        }
        int h = int.Parse(Console.ReadLine());
        int damage = 0;

        for (int i = 0; i < 3; i++)
        {
            int cX = int.Parse(Console.ReadLine());
            int cY = int.Parse(Console.ReadLine());
            
            cY = h * 2 - cY;

            if ((cX == sX1 || cX == sX2) && (cY == sY1 || cY == sY2))
            {
                damage += 25;
            }
            else if (((cX == sX1 || cX == sX2) && (cY > sY1 && cY < sY2)) || ((cY == sY1 || cY == sY2) && (cX > sX1 && cX < sX2)))
            {
                damage += 50;
            }
            else if (cX > sX1 && cX < sX2 && cY < sY2 && cY > sY1)
            {
                damage += 100;
            }
        }
        Console.WriteLine(damage + "%");
    }
}


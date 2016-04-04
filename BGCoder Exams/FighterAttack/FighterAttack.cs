using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FighterAttack
{
    static void Main()
    {
        int pX1 = int.Parse(Console.ReadLine());
        int pY1 = int.Parse(Console.ReadLine());
        int pX2 = int.Parse(Console.ReadLine());
        int pY2 = int.Parse(Console.ReadLine());

        if (pX1 > pX2)
        {
            pX1 ^= pX2;
            pX2 ^= pX1;
            pX1 ^= pX2;
        }
        if (pY1 > pY2)
        {
            pY1 ^= pY2;
            pY2 ^= pY1;
            pY1 ^= pY2;
        }
        int fX = int.Parse(Console.ReadLine());
        int fY = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int fX1 = fX + d;
        int damage = 0;

        if (fX1 >= pX1 && fX1 <= pX2 && fY >= pY1 && fY <= pY2)
        {
            damage += 100;
        }
        if ((fX1 + 1) >= pX1 && (fX1 + 1) <= pX2 && fY >= pY1 && fY <= pY2)
        {
            damage += 75;
        }
        if (fX1 >= pX1 && fX1 <= pX2 && ((fY + 1) >= pY1) && ((fY + 1) <= pY2))
        {
            damage += 50;
        }
        if (fX1 >= pX1 && fX1 <= pX2 && ((fY - 1) >= pY1) && ((fY - 1) <= pY2))
        {
            damage += 50;
        }

        Console.WriteLine(damage + "%");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Conductors
{
    static void Main()
    {
        int p = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            int ticket = int.Parse(Console.ReadLine());

            //Console.WriteLine(ticket ^ p);
            string bitsP = Convert.ToString(p, 2);
            string bitsT = Convert.ToString(ticket, 2);
            string mask = string.Empty;
            
            for (int j = 0; j < bitsP.Length; j++)
            {
                mask += "1";
            }
            int mask1 = 0;
            int count = 0;
            for (int j = mask.Length - 1; j >= 0; j--)
            {
                mask1 += (int)Math.Pow(2, count);
                count++;
            }
            //Console.WriteLine(mask1);
            count = bitsP.Length;
            int step = p;
            while (count <= bitsT.Length)
            {

                int currentBits = ticket & mask1;

                if (currentBits == step)
                {
                    ticket = (ticket & p) ^ ticket;
                }
                mask1 <<= 1;
                step <<= 1;
                count++;
            }
            Console.WriteLine(ticket);

            //int count = 0;
            //int mask = p;
            //int counter = 0;
            //bitsT.Reverse();
            //Console.WriteLine(bitsT);
            //while (counter < bitsT.Length)
            //{
            //    for (int j = 0; j < bitsP.Length; j++)
            //    {
            //        if (bitsP[j] == bitsT[j])
            //        {
            //            count++;
            //        }
            //        if (count == bitsP.Length)
            //        {
            //            bitsT.Reverse();
            //            ticket = (ticket & mask) ^ ticket;
            //        }
            //    }
            //    counter++;
            //    mask <<= 1;
            //}


            //Console.WriteLine(ticket);


            ////Console.WriteLine("{0} {1}", bitsP.Length, bitsT.Length);
            //int step = bitsP.Length;
            //int mask = p;

            //ticket = (ticket & mask) ^ ticket;
            //mask <<= 1;
            ////Console.WriteLine(mask);

            //if (bitsT.Length >= step)
            //{
            //    for (int j = 1; j < bitsT.Length; j++)
            //    {
            //        ticket = (ticket & mask) ^ ticket;
            //        mask <<= 1;
            //    }
            //}

            //Console.WriteLine(ticket);

        }

    }
}

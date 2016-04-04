using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CoordinateSystem
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());

        double y = double.Parse(Console.ReadLine());

        if (x > 0)
        {
            if (y > 0)
            {
                Console.Write("1");
            }
            else if (y < 0)
            {
                Console.Write("4");
            }
            else
	        {
                Console.Write("6");
	        }
        }
        else if (x < 0)
        {
            if (y > 0)
            {
                Console.Write("2");
            }
            else if (y < 0)
            {
                Console.Write("3");
            }
            else
            {
                Console.Write("6");
            }
        }
        else
        {
            if (y == 0)
            {
                Console.Write("0");
            }
            else
            {
                Console.Write("5");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//class OddNumber
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        long[] array = new long[n];

//        for (int i = 0; i < n; i++)
//        {
//            array[i] = long.Parse(Console.ReadLine());
//        }
//        Array.Sort(array);

//        long currentDigit = array[0];
//        int counter = 1;
//        long digit = 0;

//        if (n == 1)
//        {
//            Console.WriteLine(currentDigit);
//        }
//        else
//        {
//            for (int i = 1; i < array.Length; i++)
//            {
//                if (currentDigit == array[i])
//                {
//                    counter++;

//                    if (i == array.Length - 1 && counter % 2 != 0)
//                    {
//                        digit = array[i];
//                    }
//                }
//                else if (i == array.Length - 1)
//                {
//                    digit = array[i];
//                }
//                else
//                {
//                    if (counter % 2 != 0)
//                    {
//                        digit = array[i - 1];
//                        break;
//                    }
//                    currentDigit = array[i];
//                    counter = 1;
//                }
//            }
//            Console.WriteLine(digit);
//        }
//    }
//}

class OddNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] inputs = new long[n];
        for (int i = 0; i < n; i++)
        {
            inputs[i] = long.Parse(Console.ReadLine());
        }
        Array.Sort(inputs);
        for (int i = 0; i < n - 1; i += 2)
        {
            if (inputs[i] != inputs[i + 1])
            {
                Console.WriteLine(inputs[i]);
                return;
            }
        }
        Console.WriteLine(inputs[n - 1]);
    }
}

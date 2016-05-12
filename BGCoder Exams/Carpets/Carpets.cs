using System;

class Carpets
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        string dots;

        for (int row = 1; row <= numN; row++)
        {
            int count = row;

            if (row <= numN / 2)
            {
                dots = new string('.', numN / 2 - row);
                Console.Write(dots);

                while (row > 0)
                {
                    Console.Write('/');
                    count--;

                    if (count == 0)
                    {
                        break;
                    }
                    Console.Write(' ');
                    count--;

                    if (count == 0)
                    {
                        break;
                    }
                }
                count = row;

                while (row > 0)
                {
                    if (row % 2 != 0)
                    {
                        Console.Write('\\');
                        count--;

                        if (count == 0)
                        {
                            break;
                        }
                        Console.Write(' ');
                        count--;

                        if (count == 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.Write(' ');
                        count--;

                        if (count == 0)
                        {
                            break;
                        }
                        Console.Write('\\');
                        count--;

                        if (count == 0)
                        {
                            break;
                        }
                    }
                }
                dots = new string('.', numN / 2 - row);
                Console.WriteLine(dots);
            }
            else
            {
                count = numN - row + 1;
                dots = new string('.', row - numN / 2 - 1);
                Console.Write(dots);

                while (row > 0)
                {
                    Console.Write('\\');
                    count--;

                    if (count == 0)
                    {
                        break;
                    }
                    Console.Write(' ');
                    count--;

                    if (count == 0)
                    {
                        break;
                    }
                }
                count = numN - row + 1;

                while (row > 0)
                {
                    if (row % 2 == 0)
                    {
                        Console.Write('/');
                        count--;

                        if (count == 0)
                        {
                            break;
                        }
                        Console.Write(' ');
                        count--;

                        if (count == 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.Write(' ');
                        count--;

                        if (count == 0)
                        {
                            break;
                        }
                        Console.Write('/');
                        count--;

                        if (count == 0)
                        {
                            break;
                        }
                    }
                }
                dots = new string('.', row - numN / 2 - 1);
                Console.WriteLine(dots);
            }
        }
    }
}

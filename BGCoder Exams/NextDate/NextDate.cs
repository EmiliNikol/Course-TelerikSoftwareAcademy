using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        if (month == 2 && (((year % 4 == 0) && day == 29) || ((year % 4 != 0) && day == 28)))
        {
            day = 1;
            month++;
        }
        else if ((month == 12 && day == 31))
        {
            day = 1;
            month = 1;
            year++;
        }
        else if (day == 30)
        {
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    day = 1;
                    month++;
                    break;
            }
        }
        else if (day == 31)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    day = 1;
                    month++;
                    break;
            }
        }
        else
        {
            day++;
        }

        Console.WriteLine("{0}.{1}.{2}", day, month, year);
    }
}

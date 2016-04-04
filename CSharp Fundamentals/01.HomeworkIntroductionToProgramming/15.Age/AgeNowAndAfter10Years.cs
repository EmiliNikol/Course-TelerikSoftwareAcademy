using System;
using System.Globalization;

// Write a program that reads your birthday(in the format MM.DD.YYYY) from the console 
// and prints on the console how old you are you now and how old will you be after 10 years.

class AgeNowAndAfter10Years
{
    static void Main()
    {
        DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", CultureInfo.InvariantCulture);

        int age = DateTime.Now.Year - birthDate.Year;
        int month = DateTime.Now.Month - birthDate.Month;
        int day = DateTime.Now.Day - birthDate.Day;
        
        if ((month < 0 || (month == 0 && day < 0)) && age > 0)
        {
            age--;
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
        else
        {
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}

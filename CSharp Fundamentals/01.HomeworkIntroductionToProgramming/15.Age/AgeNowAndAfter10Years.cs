using System;
using System.Globalization;

// Write a program that reads your birthday(in the format MM.DD.YYYY) from the console 
// and prints on the console how old you are you now and how old will you be after 10 years.

class AgeNowAndAfter10Years
{
    static void Main()
    {
        string dateBirth = Console.ReadLine();

        DateTime birthDate = DateTime.ParseExact(dateBirth, "MM.dd.yyyy", CultureInfo.InvariantCulture);

        int age = DateTime.Now.Year - birthDate.Year;
        int month = DateTime.Now.Month - birthDate.Month;
        
        if (month < 0)
        {
            Console.WriteLine(age - 1);
            Console.WriteLine((age + 10) - 1);
        }
        else
        {
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}

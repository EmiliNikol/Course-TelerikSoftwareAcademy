using System;

// Write a program that, depending on the first line of the input, reads an int, double or string variable.
//  -If the variable is int or double, the program increases it by one.
//  -If the variable is a string, the program appends * at the end.
//  -Print the result at the console. Use switch statement.

class IntDoubleString
{
    static void Main()
    {
        string selectDigit = Console.ReadLine();

        switch (selectDigit)
        {
            case "integer":
                int firstChoise = int.Parse(Console.ReadLine());
                Console.WriteLine(firstChoise + 1);
                break;
            case "real":
                double secondChoise = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", secondChoise + 1);
                break;
            case "text":
                string thirdChoise = Console.ReadLine();
                Console.WriteLine(thirdChoise + "*");
                break;
        }
    }
}

using System;

// Write a program that reads a card sign(as a char) from the console and generates and prints
// all possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers). 
// The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//  - The card faces should start from 2 to A.
//  - Print each card face in its four possible suits: clubs, diamonds, hearts and spades.

class PrintADeck
{
    static void Main()
    {
        string cardSign = Console.ReadLine();
        int num = 0;

        switch (cardSign)
        {
            case "2":
                num = 2;
                break;
            case "3":
                num = 3;
                break;
            case "4":
                num = 4;
                break;
            case "5":
                num = 5;
                break;
            case "6":
                num = 6;
                break;
            case "7":
                num = 7;
                break;
            case "8":
                num = 8;
                break;
            case "9":
                num = 9;
                break;
            case "10":
                num = 10;
                break;
            case "J":
                num = 11;
                break;
            case "Q":
                num = 12;
                break;
            case "K":
                num = 13;
                break;
            case "A":
                num = 14;
                break;
        }

        for (int i = 2; i <= num; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                if (i <= 10)
                {
                    Console.Write("{0}", i);
                }

                switch (i)
                {
                    case 11:
                        Console.Write("J");
                        break;
                    case 12:
                        Console.Write("Q");
                        break;
                    case 13:
                        Console.Write("K");
                        break;
                    case 14:
                        Console.Write("A");
                        break;
                }
                switch (j)
                {
                    case 1:
                        Console.Write(" of spades, ");
                        break;
                    case 2:
                        Console.Write(" of clubs, ");
                        break;
                    case 3:
                        Console.Write(" of hearts, ");
                        break;
                    case 4:
                        Console.Write(" of diamonds");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}

using System;

// Write a program that creates an array containing all letters from the alphabet (a-z). 
// Read a word from the console and print the index of each of its letters in the array.

class IndexOfLetters
{
    static void Main()
    {
        string word = Console.ReadLine();

        char[] alphabet = new char[26];
        alphabet[0] = 'a';

        for (int i = 1; i < 26; i++)
        {
            alphabet[i] = (char)(alphabet[0] + i);
        }

        for (int i = 0; i < word.Length; i++)
        {
            int firstIndex = 0;
            int lastIndex = alphabet.Length - 1;
            int middleIndex = 0;
            int xElem = word[i];

            while (firstIndex <= lastIndex)
            {
                middleIndex = (firstIndex + lastIndex) / 2;

                if (xElem > alphabet[middleIndex])
                {
                    firstIndex = middleIndex + 1;
                }
                else if (xElem < alphabet[middleIndex])
                {
                    lastIndex = middleIndex - 1;
                }
                else
                {
                    Console.WriteLine(middleIndex);
                    break;
                }
            }
        }
    }
}


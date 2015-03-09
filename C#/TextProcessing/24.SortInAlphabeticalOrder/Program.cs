using System;
using System.Collections.Generic;

class SortInAlphabeticalOrder
{
    static void Main()
    {
        string words = Console.ReadLine();

        string[] separatedWords = words.Split(' ');

        for (int i = 0; i < separatedWords.Length; i++)
        {
            for (int j = i + 1; j < separatedWords.Length; j++)
            {
                string currentWord = separatedWords[i];
                int firstLetterOfCurrentWord = Char.ToLower(currentWord[0]) - '0';
                string nextWord = separatedWords[j];
                int firstLetterOfNextWord = Char.ToLower(nextWord[0]) - '0';

                if (firstLetterOfCurrentWord > firstLetterOfNextWord)
                {
                    string temp = separatedWords[i];
                    separatedWords[i] = separatedWords[j];
                    separatedWords[j] = temp;
                }
            }
        }

        foreach (var item in separatedWords)
        {
            Console.WriteLine(item);
        }
    }
}
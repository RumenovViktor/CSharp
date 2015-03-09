using System;
using System.Collections.Generic;
using System.Text;

class MovingLetters
{
    static void Main()
    {
        string expression = Console.ReadLine();

        string[] words = expression.Split(' ');
        StringBuilder mixedLetters = new StringBuilder();
        int length = 0;

        foreach (var item in words)
        {
            length = Math.Max(length, item.Length);
        }

        for (int i = 0; i < length; i++)
        {
            foreach (var word in words)
            {
                if (word.Length > i)
                {
                    int lastLettersIndex = word.Length - 1 - i;
                    mixedLetters.Append(word[lastLettersIndex]);
                }
            }
        }

        for (int i = 0; i < mixedLetters.Length; i++)
        {
            char currentLetter = mixedLetters[i];
            int wantedPosition = Char.ToLower(mixedLetters[i]) - 'a' + 1;
            int currentLetterNewIndex = (i + wantedPosition) % mixedLetters.Length;
            mixedLetters.Remove(i, 1);
            mixedLetters.Insert(currentLetterNewIndex, currentLetter);
        }

        Console.WriteLine(mixedLetters.ToString());
    }
}
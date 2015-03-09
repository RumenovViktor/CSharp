using System;
using System.Collections.Generic;

//Write a program that extracts from a given text all sentences containing given word.
//		Example: The word is "in". The text is:


class FindSentenceWithGivenWord
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        string[] splitText = text.Split('.');

        for (int i = 0; i < splitText.Length; i++)
        {
            string currentSentance = splitText[i];

            string[] wordsInCurrentSentance = currentSentance.Split();

            for (int j = 0; j < wordsInCurrentSentance.Length; j++)
            {
                if (wordsInCurrentSentance[j] == "in")
                {
                    Console.WriteLine(currentSentance + '.');
                    break;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();
        int length = 0;

        for (int i = 0; i < n; i++)
        {
            string word = Console.ReadLine();
            length = Math.Max(length, word.Length);
            words.Add(word);
        }

        // Order the words
        for (int i = 0; i < words.Count; i++)
        {
            int newPosition = words[i].Length % (n + 1);
            words.Insert(newPosition, words[i]);

            if (newPosition < i)
            {
                words.RemoveAt(i + 1);
            }
            else
            {
                words.RemoveAt(i);
            }
        }

        var letters = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            foreach (var word in words)
            {                
                if (word.Length > i)
                {
                    letters.Append(word[i]);
                }
            }
        }

        Console.WriteLine(letters.ToString());
    }
}
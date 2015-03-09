using System;
using System.Collections.Generic;
using System.Text;

class ReverseWordsInText
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        string[] wordsInText = text.Split(new char[] {',', ' ', '!'});

        Array.Reverse(wordsInText);

        StringBuilder formatedText = new StringBuilder();
        foreach (var item in wordsInText)
        {
            Console.Write(item);
        }

        Console.WriteLine();
    }
}
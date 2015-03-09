using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";

        StringBuilder formatedText = new StringBuilder();

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i] != text[i + 1] || i + 1 >= text.Length - 1)
            {
                formatedText.Append(text[i]);
            }
        }

        Console.WriteLine(formatedText);
    }
}
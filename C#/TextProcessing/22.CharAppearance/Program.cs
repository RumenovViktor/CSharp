//22.Write a program that reads a string from the 
//console and lists all different words in the string
//along with information how many times each word is found.

namespace _22.CharAppearence
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class WordAppearence
    {
        static void Main()
        {
            Dictionary<string, int> appearence = new Dictionary<string, int>();

            Console.WriteLine("Enter your text: ");
            string[] text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '/', '\\', '!', '?', ')', '(', '-'
                                                                , ';', ':', '\'', '\"', '[', '{', '}', ']', '<', '>', '|'
                                                                , '+', '-', '_', '=', '*', '&' , '%', '^', '$', '#', '@', '~', '`'},
                                                                  StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < text.Length; i++)
            {
                if (appearence.ContainsKey(text[i]))
                {
                    appearence[text[i]]++;
                }
                else
                {
                    appearence.Add(text[i], 1);
                }
            }

            Console.WriteLine("The list: ");
            foreach (var item in appearence)
            {
                Console.WriteLine(item);
            }
        }
    }
}

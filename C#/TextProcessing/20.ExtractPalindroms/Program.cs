//20.Write a program that extracts from a given 
//text all palindromes, e.g. "ABBA", "lamal", "exe".

namespace _20.ExtractPalindroms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ExtractPalindroms
    {
        private static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Text: ");
            string[] text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '/', '\\', '!', '?', ')', '(', '-', ';', ':', '\'', '\"' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < text.Length; i++)
            {
                if (IsPalindrome(text[i]))
                {
                    Console.WriteLine(text[i]);
                }
            }
        }
    }
}

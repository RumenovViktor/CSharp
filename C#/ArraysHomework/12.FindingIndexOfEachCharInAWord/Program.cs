using System;
using System.Collections.Generic;

class FindingIndexOfEachCharInAWord
{
    static void Main()
    {
        char[] alphabet = new char [52];
        byte letter = 64;
        Console.Write("Write a word: ");
        string word = Console.ReadLine();
        List<int> indexes = new List<int>();

        // Initialize the array with the upper case letters
        for (int i = 0; i < alphabet.Length / 2; i++)
        {
            letter++;
            alphabet[i] = (char)letter;
        }
        
        letter = 96;

        // Initialize the array with the lower case letters
        for (int i = (alphabet.Length / 2); i < alphabet.Length; i++)
        {
            letter++;
            alphabet[i] = (char)letter;
        }

        //foreach (var item in alphabet)
        //{
        //    Console.Write(item + " ");
        //}
        //Console.WriteLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    indexes.Add(j);
                }
            }
        }

        foreach (var index in indexes)
        {
            Console.Write(index + " ");
        }
    }
}

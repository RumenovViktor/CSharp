using System;
/*
 * Write a program that compares two char arrays lexicographically (letter by letter). 
 */

class CompareCharacters
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        bool areEqual = false;

        if (first.Length != second.Length) // If the length isn't equal, the arrays are not equal
        {
            Console.WriteLine("Are equal ? {0}", areEqual);
            return;
        }

        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] != second[i])
            {
                Console.WriteLine("Are equal ? {0}", areEqual);
                return;
            }
        }

        areEqual = true;
        Console.WriteLine("Are equal ? {0}", areEqual);
    }
}
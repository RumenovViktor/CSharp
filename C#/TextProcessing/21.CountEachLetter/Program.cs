//21.Write a program that reads a string from the console
//and prints all different letters in the string along 
//with information how many times each letter is found. 

namespace _21.CharAppearence
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class WordAppearence
    {
        static void Main()
        {
            Dictionary<char, int> appearence = new Dictionary<char, int>();

            Console.Write("Enter your string: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (!(input[i] < 'A' || (input[i] > 'Z' && input[i] < 'a') || input[i] > 'z'))
                {
                    if (appearence.ContainsKey(input[i]))
                    {
                        appearence[input[i]]++;
                    }
                    else
                    {
                        appearence.Add(input[i], 1);
                    }
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

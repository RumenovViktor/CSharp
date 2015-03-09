//14.A dictionary is stored as a sequence of text lines
//containing words and their explanations. Write a program 
//that enters a word and translates it by using the dictionary. 

namespace _14.Dictionary
{
    using System.Text;
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Dictionary
    {
        static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            StreamReader stream = new StreamReader(@"..\..\Dictionary.txt");
            using (stream)
            {
                string line = stream.ReadLine();
                while (line != null)
                {
                    dict.Add(line.Substring(0, line.IndexOf(' ')), line.Substring(line.IndexOf(' ') + 3, line.Length - line.IndexOf(' ') - 3));
                    line = stream.ReadLine();
                }
            }

            Console.Write("Enter Word: ");
            string word = Console.ReadLine().Trim();

            if (dict.ContainsKey(word))
            {
                Console.Write("Explenation: ");
                Console.WriteLine(dict[word]);
            }
        }
    }
}

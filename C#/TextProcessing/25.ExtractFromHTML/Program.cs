//25.Write a program that extracts from 
//given HTML file its title (if available), 
//and its body text without the HTML tags. 

namespace _25.ExtractFromHtml
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

    class ExtractFromHtml
    {
        static void Main()
        {
            StreamReader file = new StreamReader(@"..\..\File.html");
            StringBuilder text = new StringBuilder();

            using (file)
            {
                string line = file.ReadLine();
                while (line != null)
                {
                    text.Append(line);
                    line = file.ReadLine();
                }
            }

            StringBuilder nonGibirish = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    i++;
                    while (i < text.Length && text[i] != '<')
                    {
                        nonGibirish.Append(text[i]);
                        i++;
                    }
                    nonGibirish.Append(' ');
                }
            }

            Console.WriteLine(nonGibirish);
        }
    }
}

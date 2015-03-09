using System;
using System.Collections.Generic;
using System.Text;

//You are given a text. Write a program that changes the text 
//in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 

class Program
{
    static void Main()
    {
        const char upperOpen = '<';
        const char upperClose = '/';
        const string upCaseOpenTag = "<upcase>";
        const string upCaseCloseTag = "</upcase>";
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        StringBuilder convertedText = new StringBuilder(text);

        // Set all the words inside the tags to upper case
        for (int i = 0; i < convertedText.Length; i++)
        {
            if (convertedText[i] == upperOpen)
            {
                while (convertedText[i] != upperClose)
                {
                    convertedText[i] = Char.ToUpper(convertedText[i]);
                    i++;
                }
            }
        }

        // Remove all tags 
        convertedText.Replace(upCaseOpenTag.ToUpper(), upCaseOpenTag.ToLower());
        convertedText.Replace(upCaseCloseTag.ToUpper(), upCaseCloseTag.ToLower());
        convertedText.Replace(upCaseOpenTag, "");
        convertedText.Replace(upCaseCloseTag, "");

        Console.WriteLine(convertedText);
    }
}

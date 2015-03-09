using System;
using System.Collections.Generic;
using System.Text;

class ReplaceTags
{
    static void Main()
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        StringBuilder formatedText = new StringBuilder(text);

        formatedText.Replace("<a href", "[URL");
        formatedText.Replace(@""">", @"""]");
        formatedText.Replace("</a>", "[/URL]");

        Console.WriteLine(formatedText);
    }
}
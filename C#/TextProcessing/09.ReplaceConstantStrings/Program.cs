using System;
using System.Collections.Generic;
using System.Text;

class ReplaceConstantStrings
{
    static void Main()
    {
        const string php = "PHP";
        const string microsoft = "Microsoft";
        const string clr = "CLR";

        string text = "Microsoft announced it's next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        StringBuilder formatedText = new StringBuilder(text);

        formatedText.Replace(microsoft, new string('*', microsoft.Length));
        formatedText.Replace(php, new string('*', php.Length));
        formatedText.Replace(clr, new string('*', clr.Length));

        Console.WriteLine(formatedText);
    }
}
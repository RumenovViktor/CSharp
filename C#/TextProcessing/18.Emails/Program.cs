//18.Write a program for extracting all email addresses 
//from given text. All substrings that match the format
//<identifier>@<host>…<domain> should be recognized as emails.

namespace _18.Emails
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Emails
    {
        static void Main(string[] args)
        {
            //it is sort of a hack but all emails will begin with a space and end with one
            //the also wont contain any spaces
            Console.WriteLine("Enter text: ");
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains("@"))
                {
                    //if there is any punctioation
                    if (input[i][input[i].Length - 1] < 'A' || (input[i][input[i].Length - 1] > 'Z'
                        && input[i][input[i].Length - 1] < 'a') || input[i][input[i].Length - 1] > 'z')
                    {
                        input[i] = input[i].Remove(input[i].Length - 1, 1);
                    }
                    Console.WriteLine(input[i]);
                }
            }
        }
    }
}

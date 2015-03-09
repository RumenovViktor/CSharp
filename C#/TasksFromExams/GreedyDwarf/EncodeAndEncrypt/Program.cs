using System;
using System.Collections.Generic;
using System.Text;

class EncodeAndEncrypt
{
    static void Main()
    {
        string message = Console.ReadLine();
        string cypher = Console.ReadLine();
        StringBuilder encrypted = new StringBuilder();

        string finalResult = Encode(Encrypt(message, cypher) + cypher) + cypher.Length;

        Console.WriteLine(finalResult);
    }

    static string Encode(string encrypted)
    {
        StringBuilder result = new StringBuilder();
        int counter = 1;
        char previous = encrypted[0];

        for (int i = 1; i < encrypted.Length; i++)
        {
            if (previous == encrypted[i])
            {
                counter++;
            }
            else
            {
                if (counter == 1)
                {
                    result.Append(previous);
                }
                else if (counter == 2)
                {
                    result.Append(new string(previous, 2));
                }
                else
                {
                    result.Append(counter + previous.ToString());
                }

                counter = 1;
            }

            previous = encrypted[i];
        }

        if (counter == 1)
        {
            result.Append(previous);
        }
        else if (counter == 2)
        {
            result.Append(new string(previous, 2));
        }
        else
        {
            result.Append(counter + previous.ToString());
        }

        counter = 1;

        return result.ToString();
    }

    static string Encrypt(string message, string cypher)
    {
        string result = String.Empty;

        if (message.Length >= cypher.Length)
        {
            result = EncryptWhenMessageIsLonger(message, cypher);
        }
        else
        {
            result = EncryptWhenCypherIsLonger(message, cypher);
        }

        return result;
    }

    static string EncryptWhenMessageIsLonger(string message, string cypher)
    {
        int cypherIndex = 0;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < message.Length; i++)
        {
            if (cypherIndex == cypher.Length)
            {
                cypherIndex = 0;
            }

            int xorResult = (message[i] - 'A') ^ (cypher[cypherIndex] - 'A');
            char letter = (char)(xorResult + 'A');
            result.Append(letter);

            cypherIndex++;
        }

        return result.ToString();
    }

    static string EncryptWhenCypherIsLonger(string message, string cypher)
    {
        int cypherIndex = message.Length;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < message.Length; i++)
        {
            int xorResult = (message[i] - 'A') ^ (cypher[i] - 'A');

            if (i < message.Length - 1)
            {
                xorResult = xorResult ^ (cypher[cypherIndex] - 'A');   
            }

            char letter = (char)(xorResult + 'A');
            result.Append(letter);

            if (cypherIndex < cypher.Length - 1)
            {
                cypherIndex++;
            }
        }

        return result.ToString();
    }
}
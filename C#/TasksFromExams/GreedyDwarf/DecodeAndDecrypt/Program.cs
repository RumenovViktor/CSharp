using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DecodeAndDecrypt
{
    static void Main()
    {
        string encoded =Console.ReadLine();

        StringBuilder encodedSecond = new StringBuilder(encoded);
        int cypherLength = int.Parse(encoded[encoded.Length - 1].ToString());
        encodedSecond.Remove(encoded.Length - 1, 1);

        string decoded = Decode(encodedSecond.ToString());

        StringBuilder encrypted = new StringBuilder(decoded);
        StringBuilder cypher = new StringBuilder();

        int startingIndex = decoded.Length - cypherLength;
        string sypher = decoded.Substring(startingIndex, cypherLength);
        encrypted.Remove(startingIndex, cypherLength);
        cypher.Append(sypher);

        string result = Encrypt(encrypted.ToString(), cypher.ToString());

        Console.WriteLine(result);
    }

    static string Encrypt(string message, string cypher)
    {
        string result = "";

        if (message.Length > cypher.Length)
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
        StringBuilder result = new StringBuilder();
        int indexForCypher = 0;

        for (int i = 0; i < message.Length; i++)
        {
            if (indexForCypher == cypher.Length)
            {
                indexForCypher = 0;
            }

            int xor = (message[i] - 'A') ^ (cypher[indexForCypher] - 'A');
            result.Append((char)(xor + 'A'));
            indexForCypher++;
        }

        return result.ToString();
    }

    static string EncryptWhenCypherIsLonger(string message, string cypher)
    {
        StringBuilder result = new StringBuilder();
        int startingIndex = message.Length - 1;

        for (int i = 0; i < message.Length; i++)
        {
            int xor = (message[i] - 'A') ^ (cypher[i] - 'A');

            if (i < message.Length - 1)
            {
                int cyph = cypher[startingIndex] - 'A';
                xor ^= cyph;
            }

            if (startingIndex < cypher.Length - 1)
            {
                startingIndex++;
            }

            result.Append((char)(xor + 'A'));
        }

        return result.ToString();
    }

    static string Decode(string expression)
    {
        StringBuilder result = new StringBuilder();
        StringBuilder numbers = new StringBuilder();
        int n = 0;
        char lastChar = expression[expression.Length - 1];

        for (int i = 0; i < expression.Length - 1; i++)
        {
            numbers.Append(expression[i]);
            bool canParse = int.TryParse(numbers.ToString(), out n);
            if (!canParse)
            {
                numbers.Clear();
                result.Append(expression[i]);
            }
            else if (!Char.IsDigit(expression[i + 1]))
            {
                int num = int.Parse(numbers.ToString());

                result.Append(new string(expression[i + 1], num - 1));
            }
            else
            {
                result.Append(expression[i]);
            }
        }

        result.Append(lastChar);

        return result.ToString();
    }
}
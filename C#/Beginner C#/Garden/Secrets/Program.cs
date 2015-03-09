using System;
using System.Numerics;

class Secrets
{
    static void Main()
    {

        string number = Console.ReadLine();

        BigInteger count = 0;
        BigInteger position = 0;
        BigInteger result = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            int digit = number[i] - '0';
                       
            position++;
            count++;

            if (position % 2 != 0)
            {
                result += digit * (count * count);
                continue;
            }
            else if (position % 2 == 0)
            {
                result += (digit * digit) * count;
                continue;
            }
        }

        Console.WriteLine(result);

        BigInteger length = result % 10;
        int fakeLength = (int)length;

        if (length == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", number);
            return;
        }
        
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int startLetter = (int)result % 26;

        for (int i = startLetter; i < alphabet.Length; i++)
        {
            length--;
            Console.Write(alphabet[i]);

            if (i == alphabet.Length - 1)
            {
                for (int j = 0; j < (startLetter + fakeLength) - 26; j++)
                {
                    Console.Write(alphabet[j]);
                }
                
            }
            
            if (length == 0)
            {
                break;
            }
        }
    }
}

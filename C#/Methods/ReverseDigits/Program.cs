using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseDigits
{
    static void Main()
    {
        string number = Console.ReadLine();

        ReverseNumber(number);
    }

    static void ReverseNumber(string number)
    {
        int length = number.Length - 1;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            Console.Write(number[i]);
        }

        Console.WriteLine();
    }
}

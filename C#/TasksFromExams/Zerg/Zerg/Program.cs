using System;
using System.Collections.Generic;

class Zerg
{
    static void Main()
    {
        string[] zergNumbers = 
        { 
          "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", 
          "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", 
          "Zzzz", "Bauu", "Djav", "Myau", "Gruh" 
        };

        string zergNum = Console.ReadLine();

        byte counter = 0;
        string element = "";
        List<long> numbers = new List<long>();
        long decimalNumber = 0;

        for (int i = 0; i < zergNum.Length; i++)
        {
            element += zergNum[i];
            counter++;

            if (counter == 4)
            {
               long num = Array.IndexOf(zergNumbers, element);
               counter = 0;
               element = "";
               numbers.Add(num);
            }
        }

        long pow = numbers.Count - 1;

        for (int i = 0; i < numbers.Count; i++)
        {
            decimalNumber += (numbers[i] * (long)Math.Pow(15, pow));
            pow--;
        }

        Console.WriteLine(decimalNumber);
    }
}
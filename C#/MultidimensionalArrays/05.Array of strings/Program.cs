using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayOfStrings
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        string[] sequenseOfStrings = new string [length];

        for (int i = 0; i < length; i++)
        {
            sequenseOfStrings[i] = Console.ReadLine();
        }

        for (int i = 0; i < length; i++)
        {
            int currentElement = sequenseOfStrings[i].Length;

            for (int j = i + 1; j < length; j++)
            {
                int nextElement = sequenseOfStrings[j].Length;
               
                if (currentElement > nextElement)
                {
                    // Swap values
                    string tempValue = sequenseOfStrings[i];
                    sequenseOfStrings[i] = sequenseOfStrings[j];
                    sequenseOfStrings[j] = tempValue;
                }
            }
        }

        Console.WriteLine(new string('=', 12));

        // Print the array
        for (int i = 0; i < length; i++)
        {
            Console.Write(sequenseOfStrings[i]);
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

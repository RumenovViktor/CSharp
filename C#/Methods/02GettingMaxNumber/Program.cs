using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxNumber
{
    static void Main()
    {
        int x1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());

        int bigger = Math.Max(x1, x2);

        Console.WriteLine(GetMax(bigger, x3));
    }

    static int GetMax(int first, int second)
    {
        int biggest = Math.Max(first, second);

        return biggest;
    }
}

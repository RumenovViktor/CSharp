using System;

class CoffeMchine
{
    static void Main()
    {
        ushort n1 = ushort.Parse(Console.ReadLine());
        ushort n2 = ushort.Parse(Console.ReadLine());
        ushort n3 = ushort.Parse(Console.ReadLine());
        ushort n4 = ushort.Parse(Console.ReadLine());
        ushort n5 = ushort.Parse(Console.ReadLine()); 

        decimal n1Money =  n1 * 0.05m;
        decimal n2Money = n2 * 0.10m;
        decimal n3Money = n3 * 0.2m;
        decimal n4Money = n4 * 0.5m;
        decimal n5Money = n5 * 1.00m;

        decimal moneyMachineHas = n1Money + n2Money + n3Money + n4Money + n5Money;

        decimal amount = decimal.Parse(Console.ReadLine());
        decimal price = decimal.Parse(Console.ReadLine());

        decimal result = amount - price;

        if (result < 0)
        {
            result *= -1;
            Console.WriteLine("More {0:0.00}", result);
            return;
        }

        result = result - moneyMachineHas;

        if (result > moneyMachineHas)
        {
            
            Console.WriteLine("No {0:0.00}", result);
        }
        else
        {
            result *= -1;
            Console.WriteLine("Yes {0:0.00}", result);
        }
    }
}


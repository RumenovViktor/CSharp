using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        ulong a = ulong.Parse(Console.ReadLine());
        ulong b = ulong.Parse(Console.ReadLine());
        ulong c = ulong.Parse(Console.ReadLine());
        ulong d = ulong.Parse(Console.ReadLine());
        ulong e = ulong.Parse(Console.ReadLine());

        ulong divider = 0;

        while (true)
        {
            divider++;
            int count = 0;

            if (divider % a == 0)
            {
                count++;
            }
            if (divider % b == 0)
            {
                count++;
            }
            if (divider % c == 0)
            {
                count++;
            }
            if (divider % d == 0)
            {
                count++;
            }
            if (divider % e == 0)
            {
                count++;
            }

            if (count >= 3)
            {
                Console.WriteLine(divider);
                return;
            }
        //    if ((counter % a == 0) && (counter % b == 0) && (counter % c == 0))
        //    {
        //        Console.WriteLine(counter);
        //        break;
        //    }
        //    if ((counter % a == 0) && (counter % c == 0) && (counter % d == 0))
        //    {
        //        Console.WriteLine(counter);
        //        break;
        //    }
        //    if ((counter % a == 0) && (counter % c == 0) && (counter % e == 0))
        //    {
        //        Console.WriteLine(counter);
        //        break;
        //    }
        //    if ((counter % a == 0) && (counter % d == 0) && (counter % e == 0))
        //    {
        //        Console.WriteLine(counter);
        //        break;
        //    }
        //    if ((counter % a == 0) && (counter % b == 0) && (counter % d == 0))
        //    {
        //        Console.WriteLine(counter);
        //        break;
        //    }
        //    if ((counter % a == 0) && (counter % b == 0) && (counter % e == 0))
        //    {
        //        Console.WriteLine(counter);
        //        break;
        //    }

        //    if ((counter % a == 0) && (counter % b == 0) && (counter % c == 0) && (counter % d == 0))
        //    {
        //        Console.WriteLine(counter);
        //        break;
        //    }

        //    if ((counter % a == 0) && (counter % c == 0) && (counter % d == 0) && (counter % e == 0))
        //    {
        //        Console.WriteLine(counter);
        //        break;
        //    }

        //    if ((counter % b == 0) && (counter % c == 0) && (counter % d == 0) && (counter % e == 0))
        //    {
        //        Console.WriteLine(counter);
        //        break;
        //    }

        //    if ((counter % a == 0) && (counter % b == 0) && (counter % c == 0) && (counter % d == 0) && (counter % e == 0))
        //    {
        //        Console.WriteLine(counter);
        //        break;
        //    }
        }
    }
}

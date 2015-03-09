using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        string xCoord = Console.ReadLine();
        double x;
        bool xCoordinate = double.TryParse(xCoord, out x);

        if (!xCoordinate)
        {
            return;
        }

        string yCoord = Console.ReadLine();
        double y;
        bool yCoordinate = double.TryParse(yCoord, out y);

        if ((x == 0) && (y == 0))
        {
            Console.WriteLine(0);
        }
        else if ((x > 0) && (y > 0))
        {
            Console.WriteLine(1);
        }
        else if ((x < 0) && (y > 0))
        {
            Console.WriteLine(2);
        }
        else if ((x < 0) && (y < 0))
        {
            Console.WriteLine(3);
        }
        else if ((x > 0) && (y < 0))
        {
            Console.WriteLine(4);
        }
        else if (((x == 0) && (y != 0)))
        {
            Console.WriteLine(5);
        }
        else if (((y == 0) && (x != 0)))
        {
            Console.WriteLine(6);
        }
    }
}


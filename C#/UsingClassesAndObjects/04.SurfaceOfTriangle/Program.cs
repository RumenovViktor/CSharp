using System;
using System.Collections.Generic;

// 4. Write methods that calculate the surface of a triangle by given:
// -  Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

class SurfaceOfTriangle
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose how to calculate triangle's surface: ");
            Console.WriteLine("Give side and atitude press 1 ");
            Console.WriteLine("Give three sides press 2 ");
            Console.WriteLine("Give two sides and angle between them press 3 ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CalculateBySideAndAtitude(); break;
                case 2: CalculateWithThreeSides(); break;
                case 3: CalculateWithTwoSidesAndAnAngle(); break;
                default: 
                    Console.WriteLine("Wrong input !");
                    Console.WriteLine();
                    break;
            }
        }
    }

    static double CalculateBySideAndAtitude()
    {
        double surface = 0;

        double side = double.Parse(Console.ReadLine());
        double atitude = double.Parse(Console.ReadLine());

        surface = (side * atitude) / 2;
        
        return surface;
    }

    static double CalculateWithThreeSides()
    {
        double surface = 0;
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double sideC = double.Parse(Console.ReadLine());

        surface = (sideA + sideB + sideC) / 2;
        surface = Math.Sqrt(surface * (surface - sideA) * (surface - sideB) * (surface - sideC));

        return surface;
    }

    static double CalculateWithTwoSidesAndAnAngle()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());

        double surface = 0;
        surface = (sideA * sideB * Math.Sin(Math.PI * angle / 180)) / 2;

        return surface;
    }
}
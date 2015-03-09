using System;
using System.Linq;

class MultriFunctionWithArrays
{
    //Adds polinomials
    static double[] Addition(double[] first, double[] second)
    {
        double[] added = new double[Math.Max(first.Length,second.Length)];
       
        for (int i = 0; i < Math.Min(first.Length,second.Length); i++)
        {
            added[i] = first[i] + second[i];
        }

        return added;
    }

    //Gets input
    static double Input(string message)
    {
        double number;

        Console.Write(message);
        string str = Console.ReadLine();

        if (double.TryParse(str, out number))
        {
            number = double.Parse(str);
            return number;
        }
        else
        {
            throw new System.ArgumentException("Bad Input.");
        }
    }

    //prints the polinom
    static void Print(double[] polinomial)
    {
        string polinom = "";

        for (int i = polinomial.Length - 1; i >= 0; i--)
        {
            polinom += "(" + polinomial[i] + ") * x^" + i + " + ";
        }
        polinom += "\b\b  "; 
        Console.WriteLine(polinom);
        Console.WriteLine();
    }

    static void Main()
    {
        //Getting input
        int n = (int)Input("First Polinomial Lenght: ");
        double[] firstPolinomial = new double[n];

        for (int i = 0; i < n; i++)
        {
            string text = "First polinomial coefficients X^" + i + " = ";
            firstPolinomial[i] = Input(text);
        }

        Print(firstPolinomial);

        n = (int)Input("Second Polinomial Lenght: ");
        double[] secondPolinomial = new double[n];

        for (int i = 0; i < n; i++)
        {
            string text = "Second polinomial coefficients X^" + i + " = ";
            secondPolinomial[i] = Input(text);
        }

        Print(secondPolinomial);

        double[] afterAdding = Addition(firstPolinomial,secondPolinomial);
        Print(afterAdding);
    }
}
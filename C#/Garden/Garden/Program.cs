using System;

class Garden
{
    static void Main()
    {
        float tomatoCost = 0.5f;
        float cucumberCost = 0.4f;
        float potatoCost = 0.25f;
        float carrotCost = 0.6f;
        float cabbageCost = 0.3f;
        float beansCost = 0.4f;

        const int totalArea = 250;

        int tomatoSeeds = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberSeeds = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potatoSeeds = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotSeeds = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageSeeds = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beansSeeds = int.Parse(Console.ReadLine());

        tomatoCost *= tomatoSeeds;
        cucumberCost *= cucumberSeeds;
        potatoCost *= potatoSeeds;
        carrotCost *= carrotSeeds;
        cabbageCost *= cabbageSeeds;
        beansCost *= beansSeeds;

        // Calculates the used area
        int areaUsed = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
        int beansArea = totalArea - areaUsed;

        float totalCost = tomatoCost + cucumberCost + potatoCost + carrotCost + cabbageCost + beansCost;
        
        Console.WriteLine("Total costs: {0:0.00}", totalCost);

        if (areaUsed > totalArea)
        {
            Console.WriteLine("Insufficient area");
            return;
        }

        if (beansArea <= 0)
        {
            Console.WriteLine("No area for beans");
        }
        else if (beansArea > 0)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
            return;
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        RetetaTort tort = new RetetaTort();
        var reteta = tort.PreparaTort(RetetaTort.ingrediente, RetetaTort.arome);
        // Afișați rezultatul
        foreach (var strat in reteta)
        {
            Console.WriteLine($"\nStratul de {strat.Key}:");
            foreach (var ingredient in strat.Value)
            {
                string unitate = ingredient.Key == "ouă" || ingredient.Key == "esenta de vanilie" || ingredient.Key == "aromă" ? "" : (ingredient.Key == "lapte" || ingredient.Key == "smântână pentru frișcă" ? "ml" : "g");
                Console.WriteLine($"  {ingredient.Key}: {ingredient.Value}{unitate}");
            }
        }
        Console.ReadLine();
    }
}

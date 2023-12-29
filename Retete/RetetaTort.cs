using System;
using System.Collections.Generic;

class RetetaTort
{
    public static Dictionary<string, Dictionary<string, (int, int)>> ingrediente = new Dictionary<string, Dictionary<string, (int, int)>>()
    {
        ["blat"] = new Dictionary<string, (int, int)>()
        {
            ["făină"] = (250, 350),
            ["zahăr"] = (150, 250),
            ["unt"] = (100, 150),
            ["ouă"] = (3, 5),
            ["lapte"] = (100, 200),
            ["praf de copt"] = (5, 10),
            ["esenta de vanilie"] = (1, 5)
        },
        ["cremă"] = new Dictionary<string, (int, int)>()
        {
            ["unt"] = (100, 200),
            ["zahăr pudră"] = (100, 200),
            ["ciocolată"] = (50, 150),
            ["smântână pentru frișcă"] = (100, 200)
        },
        ["glazură"] = new Dictionary<string, (int, int)>()
        {
            ["ciocolată neagră"] = (100, 200),
            ["unt"] = (50, 100),
            ["lapte"] = (50, 100)
        }
    };

    public static List<string> arome = new List<string> { "vanilie", "rom", "lamaie", "portocală", "cafea" };

    public Dictionary<string, Dictionary<string, object>> PreparaTort(Dictionary<string, Dictionary<string, (int, int)>> ingrediente, List<string> arome)
    {
        var reteta = new Dictionary<string, Dictionary<string, object>>();
        var random = new Random();

        foreach (var strat in ingrediente)
        {
            var ingredienteStrat = new Dictionary<string, object>();
            foreach (var ingredient in strat.Value)
            {
                int cantitate = random.Next(ingredient.Value.Item1, ingredient.Value.Item2 + 1);
                ingredienteStrat.Add(ingredient.Key, cantitate);
            }
            reteta.Add(strat.Key, ingredienteStrat);
        }

        string aromaAleasa = arome[random.Next(arome.Count)];
        reteta["cremă"].Add("aromă", aromaAleasa);

        return reteta;
    }
}

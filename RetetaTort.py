import random

ingrediente = {
    "blat": {
        "făină": (250, 350),
        "zahăr": (150, 250),
        "unt": (100, 150),
        "ouă": (3, 5),
        "lapte": (100, 200),
        "praf de copt": (5, 10),
        "esenta de vanilie": (1, 5)
    },
    "cremă": {
        "unt": (100, 200),
        "zahăr pudră": (100, 200),
        "ciocolată": (50, 150),
        "smântână pentru frișcă": (100, 200)
    },
    "glazură": {
        "ciocolată neagră": (100, 200),
        "unt": (50, 100),
        "lapte": (50, 100)
    }
}

arome = ["vanilie", "rom", "lamaie", "portocală", "cafea"]

def prepara_tort(ingrediente, arome):
    reteta = {"blat": {}, "cremă": {}, "glazură": {}}
    for strat, ingrediente_strat in ingrediente.items():
        for ingredient, (minim, maxim) in ingrediente_strat.items():
            cantitate = random.randint(minim, maxim)
            reteta[strat][ingredient] = cantitate
    aroma_aleasa = random.choice(arome)
    reteta["cremă"]["aromă"] = aroma_aleasa
    return reteta

reteta_tort = prepara_tort(ingrediente, arome)
print("Rețetă pentru tort:")
for strat, ingrediente_strat in reteta_tort.items():
    print(f"\nStratul de {strat}:")
    for ingredient, cantitate in ingrediente_strat.items():
        unitate = "" if ingredient in ["ouă", "esenta de vanilie", "aromă"] else (
            "ml" if ingredient in ["lapte", "smântână pentru frișcă"] else "g")
        print(f"  {ingredient}: {cantitate}{unitate}")

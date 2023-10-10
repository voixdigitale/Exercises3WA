using System.Xml.Linq;

Cake cakeChoco = new Cake("Cake au Chocolat", 60, 100, 3, "Chocolat", 200, 45);
Cake cakeOlives = new Cake("Cake aux olives", 250, 10, 4, "Olives", 200, 60);
Cake cakeAmandes = new Cake("Cake aux amandes", 150, 120, 2, "Amandes", 100, 50);

cakeChoco.Recipe();
Console.WriteLine("----------------------\n\n");
cakeOlives.Recipe();
Console.WriteLine("----------------------\n\n");
cakeAmandes.Recipe();

class Cake {
    int flour,
        egg,
        sugar,
        cookingTime,
        specialIngredientQuantity;
    string name,
           specialIngredientName;


    public Cake(string _name, int _flour, int _egg, int _sugar, string _specialIngredientName, int _specialIngredientQuantity, int _cookingTime) {
       name = _name;
       flour = _flour;
       egg = _egg;
       sugar = _sugar;
       specialIngredientName = _specialIngredientName;
       specialIngredientQuantity = _specialIngredientQuantity;
       cookingTime = _cookingTime;
    }

    public void Recipe() {
        Console.WriteLine($"{name}\n\n" +
            $"{flour}g de farine\n" +
            $"{sugar}g de sucre\n" +
            $"{egg}oeuf{(egg>1 ? "s" : "")}\n" +
            $"{specialIngredientQuantity}g de { specialIngredientName}\n\n" +
            $"Temps de cuisson: {cookingTime} min"
        );
    }
}
Console.WriteLine("Donne-moi deux mots et je te dirais quel est le plus grand :");
Console.WriteLine("C'est quoi ton premier mot ?");
string mot = Console.ReadLine();
Console.WriteLine("Et le deuxième ?");
string mot2 = Console.ReadLine();
Console.WriteLine($"\nLe mot plus grand est {TheBigOne(mot, mot2)}");

string TheBigOne( string mot1, string mot2) => mot1.Length > mot2.Length ? mot1 : mot2;
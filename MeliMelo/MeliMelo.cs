Console.WriteLine("Donne-moi deux mots pour les entremêler :");
Console.WriteLine("C'est quoi ton premier mot ?");
string mot = Console.ReadLine();
Console.WriteLine("Et le deuxième ?");
string mot2 = Console.ReadLine();
Console.WriteLine($"\nLe mot entremêlé est {MeliMelo(mot, mot2)}");

string MeliMelo(string mot1, string mot2) {
    int longueur = Math.Min(mot1.Length, mot2.Length);
    string meliMelo = "";
    int i;
    for (i = 0; i < longueur; i++) {
        meliMelo += mot1[i];
        meliMelo += mot2[i];
    }

    string grandMot = TheBigOne(mot1, mot2);

    for ( ; i < grandMot.Length; i++) {
        meliMelo += grandMot[i];
    }
    return meliMelo;
}

string TheBigOne(string mot1, string mot2) => mot1.Length > mot2.Length ? mot1 : mot2;
int[] loto = new int[6];
for ( int i = 0; i < loto.Length; i++ ) {
    int tirage = tirageEntre1Et50();
    bool tirageUnique = !Array.Exists(loto, nombre => nombre == tirage);
    while (!tirageUnique) {
        tirage = tirageEntre1Et50();
        tirageUnique = !Array.Exists(loto, nombre => nombre == tirage);
    }
    loto[i] = tirage;
}

Console.WriteLine("Voici les 6 nombres uniques entre 1 et 50 :");

for (int i = 0; i < loto.Length; i++) {
    Console.WriteLine(loto[i]);
}

int tirageEntre1Et50() {
    Random rand = new Random();
    return rand.Next(0, 51);
}
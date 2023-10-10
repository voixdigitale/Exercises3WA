Console.WriteLine("Donne-moi un string pour l'écrire lettre par lettre :");
string mot = Console.ReadLine();

Console.WriteLine("Avec une boucle for :");

for (int i = 0; i < mot.Length; i++) {
    Console.WriteLine(mot[i]);
}

Console.WriteLine("\nAvec une boucle foreach :");
foreach(char lettre in mot) {
    Console.WriteLine(lettre);
}

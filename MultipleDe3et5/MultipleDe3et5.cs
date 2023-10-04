Console.WriteLine("Veuillez Entrer un chiffre et appuyez sur ENTRER :");
int variable = Int32.Parse(Console.ReadLine());
if (variable % 3 == 0 && variable % 5 == 0) {
    Console.WriteLine($"{variable} est multiple de 3 et 5");
} else {
    Console.WriteLine($"{variable} n'est pas multiple de 3 et 5");
}
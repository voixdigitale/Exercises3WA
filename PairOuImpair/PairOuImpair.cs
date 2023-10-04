Console.WriteLine("Veuillez Entrer un chiffre et appuyez sur ENTRER :");
int variable = Int32.Parse(Console.ReadLine());
if (variable % 2 == 0) {
    Console.WriteLine($"{variable} est pair");
} else {
    Console.WriteLine($"{variable} est impair");
}
Console.WriteLine("Veuillez Entrer un chiffre et appuyez sur ENTRER :");
int variable = Int32.Parse(Console.ReadLine());
if (variable % 2 == 0) {
    Console.WriteLine($"{variable} est pair et " + ((variable > 10) ? "plus grand que 10" : (variable < 10) ? "plus petit que 10" : "égal à 10"));
} else {
    Console.WriteLine($"{variable} est impair et " + ((variable > 10) ? "plus grand que 10" : (variable < 10) ? "plus petit que 10" : "égal à 10"));
}
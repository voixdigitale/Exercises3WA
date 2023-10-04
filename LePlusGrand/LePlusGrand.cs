Console.WriteLine("Veuillez entrer un chiffre et appuyez sur ENTRER :");
int variable = Int32.Parse(Console.ReadLine());
Console.WriteLine("Veuillez entrer un autre chiffre et appuyez sur ENTRER :");
int variable2 = Int32.Parse(Console.ReadLine());
if (variable > variable2) {
    Console.WriteLine($"{variable} est plus grand que {variable2}");
} else if (variable < variable2) {
    Console.WriteLine($"{variable} est plus petit que {variable2}");
} else {
    Console.WriteLine($"{variable} et {variable2} sont égaux");
}

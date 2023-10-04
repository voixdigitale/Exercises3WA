Console.WriteLine("Veuillez Entrer un chiffre pair ou plus grand que 10 et appuyez sur ENTRER :");
int variable = Int32.Parse(Console.ReadLine());
Console.WriteLine($"Le chiffre {variable} est " + (variable % 2 == 0 || variable > 10 ? "valide" : "invalide"));
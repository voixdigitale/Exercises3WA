Console.WriteLine("Veuillez entrer un chiffre et appuyez sur ENTRER :");
int variable = Int32.Parse(Console.ReadLine());
Console.WriteLine("Veuillez entrer un autre chiffre et appuyez sur ENTRER :");
int variable2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Choisissez une opération : +, -, / ou * et appuyez sur ENTRER :");
string operation = Console.ReadLine();

int? resultat = operation switch {
    "+" => variable + variable2,
    "-" => variable - variable2,
    "/" => variable / variable2,
    "*" => variable * variable2,
    _ => null,
};

if (resultat != null) {
    Console.WriteLine($"{variable} {operation} {variable2} = {resultat}");
} else {
    Console.WriteLine($"Je ne connais pas cette opération");
}
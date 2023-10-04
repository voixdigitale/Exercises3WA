Console.WriteLine("Veuillez entrer un chiffre et appuyez sur ENTRER :");
int variable = Int32.Parse(Console.ReadLine());
int i = 1;
do {
    Console.WriteLine($"Tour {i} / {variable}");
    i++;
} while (i <= variable);

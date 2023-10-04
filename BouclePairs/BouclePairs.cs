Console.WriteLine("Veuillez entrer un chiffre et appuyez sur ENTRER :");
int variable = Int32.Parse(Console.ReadLine());
string pairs = "0";
int i = 2;
while (i <= variable) {
    if(i % 2 == 0) {
        pairs += ", " + i;
    }
    i++;
}
Console.WriteLine($"Nombres pairs jusqu'à {variable} : " + pairs);

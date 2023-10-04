string[] classement = new string[8] {
    "Ryu",
    "Sagat",
    "Chun-Li",
    "Ken",
    "Guile",
    "E. Honda",
    "Blanka",
    "Zangief"
};

Console.WriteLine("Veuillez entrer une place entre 1 et 8 et appuyez sur ENTRER pour consulter le classement :");
int place = Int32.Parse(Console.ReadLine());

string position = place switch {
    1 => "ère",
    2 => "nde",
    _ => "ème"
};

Console.WriteLine($"{classement[place-1]} est arrivé à la {place}{position} place.");
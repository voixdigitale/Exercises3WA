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

Console.WriteLine("Voici le classement :\n");


for (int i = 0; i < classement.Length; i++) {
    string position = (i + 1) switch {
        1 => "er",
        2 => "nd",
        _ => "ème"
    };

    Console.WriteLine($"{i + 1}{position} : {classement[i]}");
}

Random rand = new Random();
int num = rand.Next(1, 100);
int playerNum = 0;

do {
    Console.WriteLine("Veuillez entrer un chiffre entre 1 et 100 et appuyez sur ENTRER :");
    try {
        playerNum = Int32.Parse(Console.ReadLine());

        if (playerNum > num) {
            Console.WriteLine("Le nombre est plus petit");
        } else if (playerNum < num) {
            Console.WriteLine("Le nombre est plus grand");
        }
    } catch (Exception e) {
        Console.WriteLine("Réessayez !");
    }
} while (num != playerNum);

Console.WriteLine("Bravo ! Vous avez deviné !");
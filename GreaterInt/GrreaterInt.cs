//Algorithme pour trouver le plus grand nombre d'une liste
//Nom : GreaterNumber(LISTE)
//Paramètre :
//LISTE: La liste contenant les chiffres à tester
//Retour
//    Le plus grand nombre trouvé

//GreaterNumber(LISTE)
//	plusgrand < -LISTE[1]
//    i < -2
//    Répéter jusqu'à ce que i > Taille de LISTE
//		Si LISTE [i] > plusgrand
//            plusgrand < LISTE[i]
//        i < -i + 1
//    ->plusgrand

List<int> LISTE = new List<int>() {
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};

GreaterNumber(LISTE);

void GreaterNumber(List<int> list)
{
    int plusgrand = list[0];
    for (int i = 1; i < list.Count; i++)
    {
        if (plusgrand < list[i]) plusgrand = list[i];
    }
    Console.WriteLine(plusgrand);
}
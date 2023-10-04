//Algorithme pour compter la somme des éléments d'un tableau
//Nom : CalculateSum(LISTE)
//Paramètre :
//LISTE: La liste contenant les nombres qu on veut additionner
//Retour
//    La somme calculée
//
//CalculateSum(LISTE)
//	i < -1
//    somme < -0
//    Répéter jusqu'à ce que i > Taille de LISTE
//		somme <- somme + LISTE [i]
//        i < -i + 1
//    ->somme

using System.Media;

List<int> LISTE = new List<int>() {
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};

CalculateSum(LISTE);

void CalculateSum(List<int> list)
{
    int somme = 0;
    for (int i = 0; i < list.Count; i++)
    {
        somme += list[i];
    }
    Console.WriteLine(somme);
}
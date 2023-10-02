//Algorithme pour dire les éléments d'une liste, un par un
//Nom : Dire(LISTE)
//Dire(LISTE)
//    i < -1
//   Répéter jusqu'à ce que i > Taille de LISTE
//		Dire(LISTE [i])
//		i < -i + 1

List<int> LISTE = new List<int>() {
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};

PrintList(LISTE);

void PrintList(List<int> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(list[i]);
        i++;
    }
}
//Algorithme pour remplacer tous les éléments d'une liste par 1
//Nom : RemplacerPar1(LISTE,LONGUEUR)
//Paramètres :
//LISTE: La liste dont on va remplacer les éléments 
//    LONGUEUR : Le nombre d'éléments de la liste
//Retour
//    Pas de retours, on modifie directement la liste passée en paramètre

//PSEUDO-CODE:
//RemplacerPar1(LISTE, LONGUEUR)
//    Répéter:
//        i <- 1
//        LISTE[i] <- 1
//        Si i <= LONGUEUR
//            i <- i + 1
//        Sinon
//            Stop

// Liste Test
List<int> LISTE = new List<int>() {
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};

//Longueur Test
int LONGUEUR = 10;


ReplaceByOne(LISTE, LONGUEUR);
//TEST
//Console.WriteLine(string.Join(", ", LISTE));

void ReplaceByOne(List<int> list, int length)
{
    for (int i = 0; i < length; i++)
    {
        LISTE[i] = 1;
    }
}
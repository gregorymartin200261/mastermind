using System;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] combi;
            ChoixCombi(out combi); //out car sortie
            Afficher(combi);       //pas de out car affichage
        }
        //cette fonction permet a l'ordinateur de choissir une combinaison de 4 chiffres
        static void ChoixCombi(out int[] combi) {
            combi = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                Random rnd = new Random();
                int valeur = rnd.Next(1, 7);
                combi[i] = valeur;
            }
        }

        //Calule  du nombre de pions rouge  s
        static void PionRouge(int[] propositionTableau,int [] ChoixCombi ,out int nbrPionRouge)
        {
            nbrPionRouge = 0;
            for (int i = 0; i < 3; i++)
            {
                if (propositionTableau[i] == ChoixCombi[i])
                {
                    nbrPionRouge++;
                }
            }
        }
        //Calule  du nombre de pions blancs
         static void PionBlanc(int[] propositionTableau,int [] ChoixCombi ,out int nbrPionBlanc)
        {
            nbrPionBlanc = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (propositionTableau[i] == ChoixCombi[j])
	                {
                        nbrPionBlanc++;
                        propositionTableau[i] = -1;
                        ChoixCombi[j] = -2;
	                }  
                    
                }
            }
         }

        static void Afficher(int[] combi)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Entrez une combinaison de 4 chiffres")
                Console.Write(combi[i]);
                Console.WriteLine()
            }
        }
    }
}

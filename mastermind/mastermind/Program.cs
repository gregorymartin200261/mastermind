using System;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] combi;
            int[] propositionTableau;
            int nbrPionRouge;
            int nbrPionBlanc;
            int nbrChance = 12;
            string proposition;
            ChoixCombiF(out combi); //out car sortie
            Afficher(combi);       //pas de out car affichage
            while (nbrPionRouge !=4 && nbrChance > 0)
            { 
                Console.WriteLine("Entrez une combinaison de 4 chiffres");
                proposition = Console.ReadLine();
                StringToArray(proposition, out int [] propositionTableau);
                Afficher(propositionTableau);
                PionRouge(propositionTableau , combi, out nbrPionRouge);
                Console.WriteLine(nbrPionRouge);
                PionBlanc(propositionTableau , combi, out nbrPionBlanc);
                Console.WriteLine(nbrPionBlanc);
            }
        }
        //cette fonction permet a l'ordinateur de choissir une combinaison de 4 chiffres
        static void ChoixCombiF(out int[] combi) {
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
                Console.Write(combi[i]);
                Console.WriteLine()
            }
        }

        static void StringToArray(string proposition, out int[] propositionTableau)
        { 
            propositionTableau = new int[4];
            for(int i = 0; i <= 3; i++)
			{
                propositionTableau[i] = proposition[i];
			}
        }
    }
}

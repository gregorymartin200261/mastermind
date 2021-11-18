﻿using System;

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
        static void Afficher(int[] combi)
        {
            for (int i = 0; i <= 3; i++)
            Console.Write(combi[i]);
        }
    }
}

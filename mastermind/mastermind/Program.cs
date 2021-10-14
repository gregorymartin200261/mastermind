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

        static void ChoixCombi(out int [] combi){
            combi = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                Random rnd = new Random();
                int valeur = rnd.Next(1, 7);
                combi[i] = valeur;
            }
        }

        static void Afficher(int[] combi)
        {
            for (int i = 0; i <= 3; i++)
            Console.Write(combi[i]);
        }
    }
}

using System;

namespace DemoYams
{
    internal class Noah
    {
        public int[] compteur = new int[7];
        public int[] valeurs = new int[5];
        Random rand = new Random();

        public int Lancer()
        {
            return rand.Next(1, 7);
        }

        public int LancerTous()
        {
            int s = 0;
            for (int i = 0; i < 5; i++)
            {
                valeurs[i] = Lancer();
                s += valeurs[i];
            }
            return s;
        }

        public int RelancerChoisis(int[] relance)
        {
            int s = 0;
            for (int i = 0; i < 5; i++)
            {
                if (relance[i] == 1) valeurs[i] = Lancer();
                s += valeurs[i];
            }
            return s;
        }

        public void Afficher()
        {
            Console.Write("Dés : ");
            for (int i = 0; i < 5; i++)
                Console.Write(valeurs[i] + " ");
            Console.WriteLine();
        }

        public void CompterFaces()
        {
            for (int i = 1; i <= 6; i++) compteur[i] = 0;
            for (int i = 0; i < 5; i++) compteur[valeurs[i]]++;
        }

        public int Yams()
        {
            for (int i = 1; i <= 6; i++)
                if (compteur[i] == 5) return 1;
            return 0;
        }

        public int Full()
        {
            int trois = 0, deux = 0;

            for (int i = 1; i <= 6; i++)
            {
                if (compteur[i] == 3) trois = 1;
                if (compteur[i] == 2) deux = 1;
            }
            return (trois == 1 && deux == 1) ? 1 : 0;
        }

        public int PetiteSuite()
        {
            int[] p = new int[7];
            for (int i = 0; i < 5; i++) p[valeurs[i]] = 1;

            if (p[1] == 1 && p[2] == 1 && p[3] == 1 && p[4] == 1) return 1;
            if (p[2] == 1 && p[3] == 1 && p[4] == 1 && p[5] == 1) return 1;
            if (p[3] == 1 && p[4] == 1 && p[5] == 1 && p[6] == 1) return 1;

            return 0;
        }

        public int GrandeSuite()
        {
            int[] p = new int[7];
            for (int i = 0; i < 5; i++) p[valeurs[i]] = 1;

            if (p[1] == 1 && p[2] == 1 && p[3] == 1 && p[4] == 1 && p[5] == 1) return 1;
            if (p[2] == 1 && p[3] == 1 && p[4] == 1 && p[5] == 1 && p[6] == 1) return 1;

            return 0;
        }

        public int Somme()
        {
            int total = 0;
            for (int i = 0; i < 5; i++) total += valeurs[i];
            return total;
        }
    }
}
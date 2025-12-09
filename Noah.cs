using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DemoYams
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== TOUR DE YAMS ===");

            Noah yams = new Noah();

            yams.LancerTous();
            yams.Afficher();

            // 2 relances possibles
            for (int lancer = 1; lancer <= 2; lancer++)
            {
                Console.WriteLine("Entrer les index à relancer (0 1 2 3 4) ou ENTER pour arrêter :");
                string saisie = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(saisie)) ;

                string[] morceaux = saisie.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int[] relance = new int[5];

                foreach (var m in morceaux)
                {
                    if (int.TryParse(m, out int idx))
                        if (idx >= 0 && idx < 5) relance[idx] = 1;
                }

                yams.RelancerChoisis(relance);
                yams.Afficher();
            }

            // analyse
            yams.CompterFaces();
            int score = 0;

            if (yams.Yams() == 1) score = 50;
            else if (yams.Full() == 1) score = 25;
            else if (yams.GrandeSuite() == 1) score = 40;
            else if (yams.PetiteSuite() == 1) score = 30;
            else score = yams.Somme();

            Console.WriteLine("Score obtenu : " + score);
            Console.WriteLine("Fin du tour !");
        }
    }
}
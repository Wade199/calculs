using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice26
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration
            int secondes;

            // saisie des nombre 
            do
            {
                Console.WriteLine("Entrez le nombre de seconde (entre 0 et 86400) =  ");
                secondes = int.Parse(Console.ReadLine());
            } while (secondes < 0 || secondes > 86400);

            // cacul des heures , minutes er secondes
            int h = secondes / 3600;
            int m = secondes - (h * 3600) / 60;
            int s = secondes - (h * 3600) - (m * 60);

            // formatage de l'affichage
            string affichage = "";
            if(h < 10)
            {
                affichage += "0";
            }
            affichage += h + ":";
            if (m < 10)
            {
                affichage += "0";
            }
            affichage += m + ":";
            if (s < 10)
            {
                affichage += "0";
            }
            affichage += s;

            // affichage finale sous forme HH:MM:SS
            Console.WriteLine(affichage);

            Console.ReadLine();
        }
    }
}

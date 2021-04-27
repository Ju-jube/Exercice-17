using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string choix;
            do
            {

                


                // saisir un nombre
                Console.Write("Saisir un nombre = ");
                int nombre = int.Parse(Console.ReadLine());

                //saisir la racine carrée du nombre
                Console.Write("Saisir la racine carrée de " + nombre + " = ");
                double racine = double.Parse(Console.ReadLine());

                //bonne réponse : message bravo
                double reponse = Math.Sqrt(nombre);
                if (racine == reponse)
                {
                    Console.WriteLine("Bravo ! ");
                }
                //mauvaise réponse : message erreur + bonne réponse
                else
                {
                    Console.Write("Erreur, la racine carrée de " + nombre + " est = " + reponse);
                }

                Console.WriteLine("Entrer une autre nombre ? (O/N)");
                choix = Console.ReadLine();
                Console.Clear();
                

            } while (choix == "O");
        }
    }
}

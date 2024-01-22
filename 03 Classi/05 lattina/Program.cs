using _05_lattina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_lattina
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lattina[] lattine = new Lattina[2];
            double raggio;
            double altezza;
            for (int i = 0; i < lattine.Length; i++)
            {

                Console.Write("Inserisci il raggio: ");
                raggio = Convert.ToDouble(Console.ReadLine());

                Console.Write("Inserisci l'altezza: ");
                altezza = Convert.ToDouble(Console.ReadLine());

                lattine[i] = new Lattina(raggio, altezza);

            }

            foreach (Lattina c in lattine)
            {
                Console.WriteLine(c);
                Console.WriteLine("Superfice TOT: "+c.Superficetotale() + " SuperficeLaterale: " + c.SuperficeLaterale() + " Volume: " + c.Volume());
            }
            Console.ReadLine();

        }
    }
}

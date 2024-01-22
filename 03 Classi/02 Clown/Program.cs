using _02_Clown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clowns[] clown = new Clowns[2];
            string nome;
            double peso;
            double altezza; 
            for(int i = 0; i < clown.Length; i++)
            {
                Console.Write("Inserisci il nome del clown: "); 
                nome = Console.ReadLine();

                Console.Write("Inserisci il peso del clown: ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Inserisci l'altezza del clown: ");
                altezza = Convert.ToDouble(Console.ReadLine());

                clown[i] = new Clowns(nome, peso, altezza);

            }

            foreach(Clowns c in clown)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}

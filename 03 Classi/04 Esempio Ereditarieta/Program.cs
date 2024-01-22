using _04_Esempio_Ereditarieta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _04_Esempio_Ereditarieta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cane C = new Cane(true, "Pluto");
            Console.WriteLine(C.abbaia()); 
            C.Dormire();
            C.Nome = "Cane Pluto"; 
            Console.WriteLine(C.Nome);
            Console.ReadLine();

        }
    }
}

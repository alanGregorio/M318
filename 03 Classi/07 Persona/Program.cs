using _07_Persona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Studente s = new Studente("San Gallo",23123,"alan","gregorio",232323);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _07_Persona.Models
{
    internal class Studente : Persona
    {
        private string _universita;
        private int _matricola;
        
        

        public string Universita { get { return _universita; } set { _universita = value; } }
        public int Matricola { get { return _matricola; } set { _matricola = value; } }

        public Studente(string universita, int matricola, string nome, string cognome, int codicefiscale) : base(nome, cognome, codicefiscale)
        {
            Universita = universita;
            Matricola = matricola;

        }

        public override string ToString() 
        {
            return String.Format("{0,-20} {1,-20} {2,-20} {3, -20} {4, -20}", Universita, Matricola, CodiceFiscale, Nome, Cognome);
        }

    }
}

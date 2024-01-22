using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Persona.Models
{
    internal class Persona
    {

        private string _nome;
        private string _cognome;
        private int _CodiceFiscale; 

        public string Nome { get {return _nome; }
            
            set {_nome = value; } }
        public string Cognome { get {return _cognome; } set {_cognome = value; } }

        public int CodiceFiscale { get {  return _CodiceFiscale; } set { _CodiceFiscale = value; } }

        public Persona(string nome, string cognome, int codiceFiscale)
        {
            Nome = nome;
            Cognome = cognome;
            CodiceFiscale = codiceFiscale;
        }

        public override string ToString()
        {
            return String.Format("{0,-20} {1,-20} {2,-20}",CodiceFiscale, Nome, Cognome); 
        }

        //
    }
}

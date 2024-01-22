using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Persona.Models
{
    internal class Docente : Persona
    {

        private string _materia;
        private int _salario;

        public string Materia { get { return _materia; } 
            set { 
                if (String.IsNullOrEmpty(_materia))
                {
                    value = "Sconosciuto";

                }

                _materia = value; 
            
            } 
        }
        public int Salario { get { return _salario; } 
            set { 
                if( value <= 0)
                {
                    value = 100; 

                }

                _salario = value; 
            
            } }

        public Docente(string materia, int salario, string nome, string cognome, int codicefiscale) : base(nome, cognome, codicefiscale)
        {
            Materia = materia;
            Salario = salario;
        }

        public override string ToString()
        {
            return String.Format("{0,-20} {1,-20} {2,-20} {3, -20} {4, -20}", Materia, Salario, CodiceFiscale, Nome, Cognome);  
        }
    }
}

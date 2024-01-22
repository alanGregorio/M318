using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clown.Models
{
    internal class Clowns
    {
        #region =02=== membri & proprietà ============propfull==
        private string _nome; 
        public string Nome {
            get => _nome; 
            set { 
                if( string.IsNullOrWhiteSpace(value))
                {
                    _nome = "Sconsociuto";
                }else
                {
                    _nome = value;
                }
            
            }
        }
        private double _altezza; 
        public double Altezza
        {
            get { return _altezza; }
            set { 
                if( value < 100 || string.IsNullOrWhiteSpace(value.ToString()))
                {
                    _altezza = 100; 
                }else
                {
                    _altezza = value;
                }
            
            }
        }
        private double _peso;
        public double Peso
        {
            get { return _peso; }
            set {
                if (value < 30 || string.IsNullOrWhiteSpace(value.ToString()))
                {
                    _peso = 60.0;
                }
                else
                {
                    _peso = value;
                }
            }
        }
        #endregion

        #region =03=== costruttori =======================ctor==
        public Clowns() {
            _nome = "Sconosciuto";
            _altezza = 0.0;
            _peso = 0.0;
        
        }

        public Clowns(string nome, double altezza, double peso)
        {
            _nome = nome;
            _altezza = altezza;
            _peso = peso;
        }
        #endregion

        private string RaccontaColmo()
        {
            return "Quale è il colmo per un gatto? ... Fare una vita da cani";
        }


        #region =05=== metodi public ===========================
        public string Saluta()
        {
            return "Ciao Sono" + _nome + "\n" + RaccontaColmo();
        }

        public override string ToString()
        {
            return Nome + " ; " + Altezza + " ; " + Peso;
        }


        #endregion
    }
}

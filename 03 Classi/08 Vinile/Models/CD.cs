using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Vinile.Models
{
    internal class CD : Supporto
    {
        private double _dimensione;

        public double Dimensione
        {
            get { return _dimensione; }
            set { _dimensione = value; }
        }

        public CD(string marca, string modello, brano[] traccie, double dimensione) : base(marca, modello, traccie) 
        {
            Dimensione = dimensione;
        }
    }
}

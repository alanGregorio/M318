using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Vinile.Models
{
    internal class AudioCassetta : Supporto
    {

        private double _lunghezzaNastro;

        public double LunghezzaNastro
        {
            get { return _lunghezzaNastro; }
            set { _lunghezzaNastro = value; }
        }

        public AudioCassetta(string marca, string modello, brano[] traccie, double lunghezzaNastro) : base(marca, modello, traccie)
        {
            LunghezzaNastro = lunghezzaNastro;
        }
    }
}

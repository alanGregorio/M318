using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Vinile.Models
{
    internal class Vinile : Supporto
    {
        private int _giriMinuti;

        public int GiriMinuti
        {
            get { return _giriMinuti; }
            set { _giriMinuti = value; }
        }

        public Vinile(string marca, string modello, brano[] traccie, int giriMinuti) : base(marca, modello,traccie)
        {
            GiriMinuti = giriMinuti;
        }
    }
}

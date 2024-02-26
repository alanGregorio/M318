using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Vinile.Models
{
    internal class Supporto
    {

        private string _marca;
        private string _modello;
        private brano[] _traccie;

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modello
        {
            get { return _modello; }
            set { _modello = value; }
        }

        public brano[] Traccie
        {
            get { return _traccie; }
            set { _traccie = value; }
        }

        public Supporto(string marca, string modello, brano[] traccie)
        {
            Marca = marca;
            Modello = modello;
            Traccie = traccie;
        }
    }
}

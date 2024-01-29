using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Vinile.Models
{
    internal class stereo
    {
        private string _modello;

        public string Modello
        {
            get { return _modello; }
            set { _modello = value; }
        }

        public stereo(string modello)
        {
            _modello = modello;
        }
    }
}

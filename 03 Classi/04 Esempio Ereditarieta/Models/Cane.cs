using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Esempio_Ereditarieta.Models
{
    internal class Cane : Mammifero 
    {
        private bool _isSegugio;

        public bool IsSegugio {
            get { return _isSegugio; }
            set { _isSegugio = value; } 
        }

        public Cane(bool IsSegugio, string nome) : base(nome) 
        {
            _isSegugio = IsSegugio;
        }

        public string abbaia()
        {
            return "BAU BAU"; 
        }

        
        public override string EmettiVerso()
        {
            return "BAU BAU";
        }

    }
}

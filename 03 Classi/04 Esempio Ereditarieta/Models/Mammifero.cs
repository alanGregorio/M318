using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _04_Esempio_Ereditarieta.Models
{
    internal class Mammifero
    {

        private string _nome; 
        public string Nome {
            get { return _nome;  }
            set { _nome = value; } 
        }

        public Mammifero(string nome)
        {
            _nome = nome;
        }

        public void Dormire()
        {
            Console.WriteLine("Ronf Ronf Dormo");
            
        }

        // virtual = indica che quel metodo della classe base puo essere sovvrascritto da una calsse ereditaria
        public virtual string EmettiVerso()
        {
            return "Emetto un verso"; 
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Ereditarietà_Prodotti.Models
{
    internal class NonAlimentari : Prodotto
    {

		private string _materiale;

		public string Materiale
		{
			get { return _materiale; }
			set { _materiale = value; }
		}

        public NonAlimentari(string materiale, int codiceBarre, string descrizione, int prezzo) : base(codiceBarre, descrizione, prezzo)
        {

            Materiale = materiale;

        }


        public override void applicaSconto()
        {
            if(Materiale == "carta" || Materiale = "vetro" | Materiale = "plastica")
            {
                Prezzo = Prezzo * 0.9;
            }
            else
            {
                Prezzo = Prezzo * 0.95;
            }
        }

    }
}

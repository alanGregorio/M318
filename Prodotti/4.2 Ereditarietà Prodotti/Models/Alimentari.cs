using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Ereditarietà_Prodotti.Models
{
    internal class Alimentari : Prodotto
    {

		private int _dataScadenza;

		public int DataScadenza
        {
			get { return _dataScadenza; }
			set { _dataScadenza = value; }
		}

		public Alimentari(int dataScadenza, int codiceBarre, string descrizione, int prezzo):base(codiceBarre, descrizione, prezzo)
		{

			DataScadenza = dataScadenza;

		}


        public override void applicaSconto()
        {
            if (DataScadenza + 10 >= )
            {
                Prezzo = Prezzo * 0.8;
            }
            else
            {
                Prezzo = Prezzo * 0.95;
            }
        }
    }
}

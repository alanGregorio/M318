using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Ereditarietà_Prodotti.Models
{
    internal class Alimentari : Prodotto
    {

        private DateTime _dataScadenza;

        public DateTime DataScadenza
        {
            get { return _dataScadenza; }
            set { _dataScadenza = value; }
        }

        public Alimentari(DateTime dataScadenza, int codiceBarre, string descrizione, int prezzo) : base(codiceBarre, descrizione, prezzo)
        {

            DataScadenza = dataScadenza;

        }

    }
}

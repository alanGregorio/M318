using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Ereditarietà_Prodotti.Models
{
    internal class Prodotto
    {

        private int _codiceBarre;
        private string _descrizione;
        private int _prezzo;

        public int CodiceBarre
        {
            get { return _codiceBarre; }
            set { _codiceBarre = value; }
        }

        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        public int Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        public Prodotto(int codiceBarre, string descrizione, int prezzo)
        {
            CodiceBarre = codiceBarre;
            Descrizione = descrizione;
            Prezzo = prezzo;
        }

        public float applicaSconto()
        {
            return Prezzo * 0.95f;
        }

        public override string ToString()
        {
            return CodiceBarre + "; " +  Descrizione + "; " + Prezzo + "; " ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Fumetto.Models
{
    internal class Fumetto
    {

        #region =02=== membri & proprietà ============propfull==


        private string _titolo;
        public string Titolo
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    value = "Sconosciuto";
                }
                _titolo = value;
            }
            get { return _titolo; }
        }

        private string _autore;
        public string Autore
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    value = "Sconosciuto";
                }
                _autore = value;
            }
            get { return _autore; }
        }

        private int _annoPubblicazione;
        public int AnnoPubblicazione
        {
            set
            {
                if (value <= 0)
                {
                    value = 0;
                }
                _annoPubblicazione = value;
            }
            get { return _annoPubblicazione; }
        }

        private int _prezzo;
        public int Prezzo
        {
            set
            {
                if (value <= 0)
                {
                    value = 0;
                }
                _prezzo = value;
            }
            get { return _prezzo; }
        }

        private string _breveDescrizione;

        public string BreveDescrizione
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    value = "Sconosciuta";
                }
                _breveDescrizione = value;
            }
            get { return _breveDescrizione; }
        }

        private int _isbn;
        public int Isbn
        {
            set
            {
                if (value <= 0)
                {
                    value = 0;
                }
                _isbn = value;
            }
            get { return _isbn; }
        }

        private bool _stato; 


        public bool Stato
        {
            set { 
                _stato = value;
            }
            get { return _stato; }
        }


        #endregion

        #region =03=== costruttori =======================ctor==
        public Fumetto()
        {
            _titolo = "Sconosciuto";
            _autore = "Sconosciuto";
            _annoPubblicazione = 2000 - 01 - 01;
            _prezzo = 0;
            _isbn = 0;
            _breveDescrizione = "Sconosciuta";
            _stato = false;
        }
        public Fumetto(string titolo, string autore, int annoPubblicazione, int prezzo, string breveDescrizione, int isbn, bool stato)
        {
            Titolo = titolo;
            Autore = autore;
            AnnoPubblicazione = annoPubblicazione;
            Prezzo = prezzo;
            BreveDescrizione = breveDescrizione;
            Isbn = isbn;
            Stato = stato;
        }


        #endregion

        #region =04=== metodi private e aiuto ==================


        #endregion

        #region =05=== metodi public ===========================

        public string checkString(string stringa)
        {
            if(stringa.Length > 20)
            {
                return stringa.Substring(0, 18) + ".."; 
            }
            return stringa; 
        }
        public override string ToString()
        {
            string desc = String.Format("{0,-20}|{1,-20}|{2,-10}|{3,-10}|{4,-10}|", checkString(Titolo), checkString(Autore), AnnoPubblicazione, Prezzo, Stato);
            return desc; 
        }

        #endregion

    }
}

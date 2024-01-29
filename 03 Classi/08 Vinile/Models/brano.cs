using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Vinile.Models
{
    internal class brano
    {
        private string _artista;
        private float _durata;
        private string _titolo;

        public string Artista
        {
            get { return _artista; }
            set { _artista = value; }
        }

        public float Durata
        {
            get { return _durata; }
            set { _durata = value; }
        }

        public string Titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }

        public brano(string artista, float durata, string titolo)
        {
            Artista = artista;
            Durata = durata;
            Titolo = titolo;
        }
    }
}

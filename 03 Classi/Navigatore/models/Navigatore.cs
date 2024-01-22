using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Consoleapp2.models
{
    public class Prova
    {
        #region =02=== membri & proprietà ============propfull==

        public string Marca; //public permtette alle altre classi di accedere all'attributo
        public int Dimensioni;
        public string Modello;

        #endregion


        #region =03=== costruttori =======================ctor==

        public Prova() {
            Marca = "Sconosciuta";
            Dimensioni = 0;
            Modello = "Sconosciuta";
        
        }

        public Prova(string marca, int dimensioni, string modello)
        {
            Marca = marca;
            Dimensioni = dimensioni;
            Modello = modello;

            

        }

        #endregion


        #region =05=== metodi public ===========================


        /// <summary>
        /// Ottenere il tragitto
        /// </summary>
        /// <param name="Destinazione">destinazione da raggiungere</param>
        /// <returns>>Percorso da effettuare</returns>
        public String TrovaPercorso(String Destinazione)
        {
            if (Destinazione.Equals("lugano"))
            {
                return "bellinzona --> giubiasco --> lugano";
            }
            else if (Destinazione.Equals("mendrisio"))
            {
                return "bellinzona --> giubiasco --> lugano --> mendrisio";
            }
            else
            {
                return "destinazione non valida";
            }
        }

        /// <summary>
        /// Metodo che trova un altro percorso da una deviazione
        /// </summary>
        /// <param name="Deviazione">Deviazione di percorso</param>
        /// <returns>percorso</returns>
        public void InserireDeviazione(string Deviazione)
        {
            //Implementare codice metodo 
        }

        
        public void InserireDestinazione()
        {
            //Implementare codice metodo 
        }

        /// <summary>
        /// Metodo che calcola la distanza del percorso
        /// </summary>
        /// <returns>Distanza</returns>
        public void DistanzaTotale()
        {
            //Implementare codice metodo 
        }


        /// <summary>
        /// Metodo che calcola il tempo totale di percorrenza 
        /// </summary>
        /// <param name="Destinazione">destinazione da raggiungere</param>
        /// <returns>Tempo di percorrenza</returns>
        public double TempoTotale(String Destinazione)
        {
            if (Destinazione.Equals("lugano"))
            {
                return 30;
            }
            else if (Destinazione.Equals("mendrisio"))
            {
                return 60;
            }
            return -1;
        }

        /// <summary>
        /// metodo che stampa le informazioni sul navigatore 
        /// </summary>
        /// <returns>informazioni</returns>
        public String Informazioni()
        {
            return "Marca: " + Marca + "  " + "dimensioni: " + Dimensioni + "  " + "Modello: " + Modello;
        }

        #endregion

    }
}


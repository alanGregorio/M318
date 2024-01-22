using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _05_lattina.Models
{
    internal class Lattina
    {
        #region =01=== costanti & statici ======================
        #endregion
        #region =02=== membri & proprietà ============propfull==
        private double _altezza;

        public double Altezza
        {
            get => _altezza;
            private set 
            {
                if (value < 0)
                {
                    _altezza = 0;
                }
                else
                {
                    _altezza = value;
                }

            }
        }

        private double _raggio;

        public double Raggio
        {
            get => _raggio;
            private set
            {
                if (value < 0)
                {
                    _raggio = 0;
                }
                else
                {
                    _raggio = value;
                }

            }
        }
        #endregion
        #region =03=== costruttori =======================ctor==
        public Lattina()
        {
            _altezza = 0.0;
            _raggio = 0.0;

        }
        public Lattina(double altezza, double raggio)
        {
            _altezza = altezza;
            _raggio = raggio;
        }
        #endregion
        #region =04=== metodi private e aiuto ==================

        private double AreaBase()
        {
            return Math.Pow(_raggio, 2) * Math.PI;
        }

        private double circonferenza()
        {
            return _raggio * 2 * Math.PI;
        }

        #endregion
        #region =05=== metodi public ===========================

        public double SuperficeLaterale()
        {
            return circonferenza() * _altezza;
        }

        public double Superficetotale() 
        {
            return SuperficeLaterale() + AreaBase()*2;
        }

        public double Volume()
        {
            return AreaBase() * _altezza; 
        }

        public override string ToString()
        {
            return "Altezza: " + _altezza + "  Raggio: " + _raggio;
        }


        #endregion

    }
}

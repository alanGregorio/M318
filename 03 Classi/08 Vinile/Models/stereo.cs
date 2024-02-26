using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Vinile.Models
{
    internal class stereo
    {
        private string _modello;

        public string Modello
        {
            get { return _modello; }
            set { _modello = value; }
        }

        public stereo(string modello)
        {
            _modello = modello;
        }

        public void InserisciSupportoCassetta()
        {

        }

        public void InserisciSupportoVinile()
        {

        }

        public void InserisciSupportoCD()
        {

        }

        public void RimuoviSupportoCD()
        {

        }

        public void RimuoviSupportoVinile()
        {

        }

        public void RimuoviSupportoCassetta()
        {

        }

        public void PlayCD()
        {

        }

        public void PlayVinile()
        {

        }

        public void PlayCassetta()
        {

        }

        public void Stop()
        {

        }
    }
}

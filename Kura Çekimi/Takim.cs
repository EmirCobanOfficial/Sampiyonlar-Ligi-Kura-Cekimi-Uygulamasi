using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kura_Çekimi
{
     class Takim
    {
        private string TakimIsmi;
        private string TakımUke;

        public Takim(string isim, string ulke)
        {
            TakimIsmi = isim;
            TakımUke = ulke;
        }

        public string TeamName
        {
            get
            {
                return TakimIsmi;
            }

            set
            {
                TakimIsmi = value;
            }
        }

        public string TeamCountry
        {
            get
            {
                return TakımUke;
            }
            set
            {
                TakımUke= value;
            }
        }

        public override string ToString()
        {
            return TakimIsmi + "-" + TakımUke;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolosG
{
    public class Dom : Mieszkanie
    {
       
        public int pietra { get; set; }
        public static int nrDomu { get; set; }

        //domyslny
        public Dom()
        {
            nrDomu++;
            wolny = true;
            adres = null;
        }

        public Dom(string adres, EnumRodzaj rodzaj, int liczbaPokoi, bool wolny, int pietra) 
            : base(adres, rodzaj, liczbaPokoi, wolny)
        {
            this.pietra = pietra;
        }

    }
}

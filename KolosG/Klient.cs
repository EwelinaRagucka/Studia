using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolosG
{
    public class Klient : Osoba
    {
        static int IDKlienta = 0;

        public Klient()
        {
        }

        public Klient(string imieNazwisko, string numerTelefonu, string pesel, string dataUrodzenia) 
            : base(imieNazwisko, numerTelefonu, pesel, dataUrodzenia)
        {
            IDKlienta++;
        }

        public override string ToString()
        {
            return $"IdKlienta: {IDKlienta}, {base.ToString()}";
        }
    }
}

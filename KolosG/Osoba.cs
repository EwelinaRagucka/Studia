using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KolosG
{
    public  class Osoba
    {
        public string imieNazwisko { get; set; }
        public string numerTelefonu { get; set; }
        public string pesel;
        public string dataUrodzenia { get;  set; }

        public string Pesel
        {
            get => pesel;
            set
            {
                if (!Regex.IsMatch(value, @"^\d{11}$"))
                    throw new FormatException("Pesel musi skladac sie z 11 cyfr");
                else pesel = value;
            }
        }
        public string NumerTelefonu
        {
            get => numerTelefonu;
            set
            {
                if (!Regex.IsMatch(value, @"^\d{9}$"))
                    throw new FormatException("Numer telefonu musi skladac sie z 9 cyfr");
                else numerTelefonu = value;
            }
        }

        public Osoba(string imieNazwisko, string numerTelefonu, string pesel, string dataUrodzenia)
        {
            this.imieNazwisko = imieNazwisko;
            this.NumerTelefonu = numerTelefonu;
            this.Pesel = pesel;

            //Sprawdzenie formatu danych
            if (DateTime.TryParseExact(dataUrodzenia,
                new[] { "dd-MM-yyyy", "yyyy-MM-dd" },
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                this.dataUrodzenia = parsedDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture); // Konwersja na string
            }
            else
            {
                throw new ArgumentException("Niepoprawny format daty urodzenia. Użyj formatu dd-MM-yyyy lub yyyy-MM-dd.");
            }
        }


        public Osoba()
        {
        }

        public override string ToString()
        {
            return $"Imie i nazwisko: {imieNazwisko} PESEL: {Pesel}, Numer telefonu: {numerTelefonu}";
        }

        //metoda, gdzie osoba staje sie klientem
        public Klient ToKlient() => new Klient(imieNazwisko, numerTelefonu, Pesel, dataUrodzenia);
    }
}

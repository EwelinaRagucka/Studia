namespace KolosG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
namespace KolosG
{
    class Program
    {
        static void  Main()
        {
            //Oferta mieszkan i domow
            Mieszkanie m1 = new Mieszkanie("Krowodrza 44", EnumRodzaj.Standart, 2, true);
            Mieszkanie m2 = new("Wiolda Budryka 5", EnumRodzaj.Standart, 2, true);
            Mieszkanie m3 = new("Stolarska 77", EnumRodzaj.Luksus, 4, true);
            Mieszkanie m4 = new("Swietokrzyska 10", EnumRodzaj.Podstawa, 3, true);
            Dom d1 = new("Starowislanska 2", EnumRodzaj.Standart, 6, true, 1);
            Dom d2 = new("Konna 22", EnumRodzaj.Luksus, 12, true, 3);

            //Console.WriteLine(m1.ToString());
            //Console.WriteLine(m2.ToString());
            //Console.WriteLine(m3.ToString());
            //Console.WriteLine("\n");


            //Wynajecie dwoch mieszkan
            Osoba os1 = new("Kornelia Kozlowska", "123124312", "10101010101", "26-05-2005");
            Osoba os2 = new("Pawel Jonski", "123456876", "20020220982", "25-06-1990");
            Osoba os3 = new("Adam Malysz", "570987634", "09876245378", "01-01-2001");

            //skoro osoba wynajmie mieszkanie to staje sie klientem
            Klient k1 = os1.ToKlient();
            Wynajecie w1 = new(k1.imieNazwisko, m2,  new System.DateTime(2020,11,24), new System.DateTime(2020, 11,26));
            Console.WriteLine(w1.ToString());
            Console.WriteLine($"Cena wynajmu: {w1.ObliczCene():c}");

            Klient k2 = os2.ToKlient();
            Wynajecie w2 = new(k2.imieNazwisko, m3, new System.DateTime(2020, 10, 20), new System.DateTime(2020, 12, 20));
            Console.WriteLine(w2.ToString());
            Console.WriteLine($"Cena wynajmu: {w2.ObliczCene():c}");

            //oddzialy oferujace wynajem mieszkan i domow
            Oddzial o1 = new("Agencja Mieszkan","Krakow");
            o1.DodajMieszkanie(m1);
            o1.DodajMieszkanie(m2);
            o1.DodajMieszkanie(m3);
            Console.WriteLine(o1.ToString());
            Console.WriteLine("\n");

            //wynajecie miszkan przez ten oddzial
            o1.DodajWynajecie(w1);
            o1.DodajWynajecie(w2);
            Console.WriteLine(o1.ToString());
            Console.WriteLine("\n");

            //gdy chcemy zobaczyc jakie wolne mieezkania zostaly
            Console.WriteLine($"wolne mieszkania i domy");
            o1.PodajWolneMieszkania();
            Console.WriteLine("\n");

            Oddzial o2 = new("Domy i Mieszkania", "Krakow");
            o2.DodajMieszkanie(m4);
            o2.DodajDom(d1);
            o2.DodajDom(d2);
            Console.WriteLine(o2.ToString());
            Console.WriteLine("\n");

          

            ////zad4
            //o1.Zwolnij(m2);
            //Console.WriteLine("Po zwolnieniu:\n");
            //Console.WriteLine(o1.ToString());
            //Console.WriteLine("\n");
            //Console.WriteLine("Po wynajeciu:\n");
            //o1.Wynajmij(w1);
            //Console.WriteLine(o1.ToString());

            ////zad5
            //Console.WriteLine("Po sortowaniu:\n");
            //o1.Sortuj();
            //Console.WriteLine(o1.ToString());

            //Console.WriteLine("Po sortowaniu nazwy:\n");
            //o1.SortujNazwa();
            //Console.WriteLine(o1.ToString());

            ////zapis do DataContract
            //o1.ZapisDCXml("Zadanie.xml");

            ////do nowego oddzialu pustego to wsadzam
            //Oddzial? o2 = Oddzial.OdczytDCXml("Zadanie.xml");
            //Console.WriteLine($"Po odczycie {o2.ToString()}");

        }

       
    }
}

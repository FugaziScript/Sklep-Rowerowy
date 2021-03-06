using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO{
    public class Kierownica : Czesci {
        public Kolory Kolor { get; set; }
        public Typy Typ { get; set; }
        public Materialy Material { get; set; }
        public double Szerokosc { get; set; } //Szerokość w cm
        public override List<string> Wypisz()
        {
            List<string> opis = new List<string>(0);
            opis.Add(ID.ToString());
            opis.Add(Nazwa);
            opis.Add(Producent.ToString());
            opis.Add(Cena.ToString());
            opis.Add(Ilosc.ToString());
            opis.Add(Kolor.ToString());
            opis.Add(Typ.ToString());
            opis.Add(Material.ToString());
            opis.Add(Szerokosc.ToString());
            separator.endl(opis);
            return opis;
        }
    }
}

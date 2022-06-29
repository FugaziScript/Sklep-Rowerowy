using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Rama : Czesci {
        public Kolory Kolor { get; set; }
        public Typy Typ { get; set; }
        public Materialy Material { get; set; }
        public Rozmiary Rozmiar { get; set; }
        public double Waga { get; set; } //Waga ramy w kg
        public double SrednicaSztycy { get; set; } 
        public double RozmiarKola { get; set; }
        

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
            opis.Add(Rozmiar.ToString());
            opis.Add(Waga.ToString());
            opis.Add(SrednicaSztycy.ToString());
            opis.Add(RozmiarKola.ToString());
            separator.endl(opis);
            return opis;
        }
    }
}

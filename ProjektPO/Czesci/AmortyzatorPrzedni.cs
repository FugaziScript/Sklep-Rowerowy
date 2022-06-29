using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class AmortyzatorPrzedni : Czesci {
        public Kolory Kolor { get; set; }
        public Materialy Material { get; set; }
        public RodzajeAmortyzacji RodzajAmortyzacji { get; set; }
        public double Skok { get; set; } //W mm
        public double RozmiarKola { get; set; }
        public double SrednicaSztycy { get; set; } //W mm
        public override List<string> Wypisz() 
        {
            List<string> opis = new List<string>(0);
            opis.Add(ID.ToString());
            opis.Add(Nazwa);
            opis.Add(Producent.ToString());
            opis.Add(Cena.ToString());
            opis.Add(Ilosc.ToString());
            opis.Add(Kolor.ToString());
            opis.Add(RodzajAmortyzacji.ToString());
            opis.Add(Skok.ToString());
            opis.Add(RozmiarKola.ToString());
            opis.Add(Material.ToString());
            opis.Add(SrednicaSztycy.ToString());
            separator.endl(opis);
            return opis;
        }
    }
}

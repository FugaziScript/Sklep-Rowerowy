using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Stopka : Akcesoria {
        public Kolor kolor { get; set; }
        public Material material { get; set; }
        public RodzajStopki rodzaj_stopki { get; set; }
        //Funkcja pozwalająca wypisać dane przedmiotu
        /// <summary>
        /// Metoda zwracająca sformatowane parametry jako listę string.
        /// </summary>
        /// <returns></returns>
        public override List<string> Wypisz() {
            List<string> opis = new List<string>(0);
            opis.Add(Nazwa + ":");
            opis.Add("Cena: " + Cena + "zł");
            opis.Add("Producent: " + producent.ToString());
            opis.Add("Kolor: " + kolor.ToString());
            opis.Add("Materiał: " + material.ToString());
            opis.Add("Rodzaj: " + rodzaj_stopki.ToString());
            separator.endl(opis);
            return opis;
        }
    }
}

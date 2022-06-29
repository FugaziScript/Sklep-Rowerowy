using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Rękawiczki : Akcesoria {
        public Kolor kolor { get; set; }
        public Material materiał { get; set; }
        public Plec plec { get; set; }
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
            opis.Add("Płeć: " + plec.ToString());
            opis.Add("Kolor: " + kolor.ToString());
            opis.Add("Materiał: " + materiał.ToString());
            separator.endl(opis);
            return opis;
        }
    }
}

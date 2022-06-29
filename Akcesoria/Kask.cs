using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Kask : Akcesoria {
        public int rozmiar { get; set; } //Rozmiar, trzeba jakoś walidować dane.
        public Plec plec { get; set; } //Płeć
        public Material material { get; set; } //Materiał
        public double masa { get; set; } //Masa (w kg)
        public Kolor kolor { get; set; }
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
            opis.Add("Płeć: " + plec.ToString());
            opis.Add("Materiał: " + material.ToString());
            opis.Add("Rozmiar: " + rozmiar.ToString());
            opis.Add("Masa: " + masa.ToString());
            separator.endl(opis);
            return opis;
        }
    }
}

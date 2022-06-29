using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Bidon : Akcesoria {
        public double pojemnosc { get; set; } //Pokemność (w litrach)
        public Material material { get; set; } //Materiał wykonania
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
            opis.Add("Materiał: " + material.ToString());
            opis.Add("Pojemność: " + pojemnosc.ToString());
            opis.Add("Masa: " + masa.ToString());
            separator.endl(opis);
            return opis;
        }
    }
}

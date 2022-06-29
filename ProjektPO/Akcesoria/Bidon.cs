using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Bidon : Akcesoria {
        public double Pojemnosc { get; set; } //Pokemność (w litrach)
        public Materialy Material { get; set; } //Materiał wykonania
        public double Masa { get; set; } //Masa (w kg)
        public Kolory Kolor { get; set; }
        //Funkcja pozwalająca wypisać dane przedmiotu
        /// <summary>
        /// Metoda zwracająca sformatowane parametry jako listę string.
        /// </summary>
        /// <returns></returns>
        public override List<string> Wypisz() {
            List<string> opis = new List<string>(0);
            opis.Add(ID.ToString());
            opis.Add(Nazwa);
            opis.Add(Producent.ToString());
            opis.Add(Cena.ToString());
            opis.Add(Ilosc.ToString());
            opis.Add(Kolor.ToString());
            opis.Add(Material.ToString());
            opis.Add(Pojemnosc.ToString());
            opis.Add(Masa.ToString());
            separator.endl(opis);
            return opis;
        }
    }
}

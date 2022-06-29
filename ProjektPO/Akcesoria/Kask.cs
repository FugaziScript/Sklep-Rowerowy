using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Kask : Akcesoria {
        public Rozmiary Rozmiar { get; set; } //Rozmiar, trzeba jakoś walidować dane.
        public Plcie Plec { get; set; } //Płeć
        public Materialy Material { get; set; } //Materiał
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
            opis.Add(Rozmiar.ToString());
            opis.Add(Masa.ToString());
            separator.endl(opis);
            return opis;
        }
    }
}

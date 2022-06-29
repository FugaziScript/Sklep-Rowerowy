using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Lusterko : Akcesoria {
        public Polozenia Rodzaj_lusterka { get; set; } //Prawe/Lewe/Uniwersalne
        public Kolory Kolor { get; set; }
        public Materialy Material { get; set; }
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
            opis.Add(Rodzaj_lusterka.ToString());
            separator.endl(opis);
            return opis;
        }
    }
}

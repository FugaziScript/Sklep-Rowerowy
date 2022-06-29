using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Pokrowiec : Akcesoria {
        public TypPokrowca typ { get; set; }
        public Kolor kolor { get; set; }
        public Material material { get; set; }
        /// <summary>
        /// Metoda zwracająca sformatowane parametry jako listę string.
        /// </summary>
        /// <returns></returns>
        public override List<string> Wypisz() {
            List<string> opis = new List<string>(0);
            opis.Add(Nazwa + ":");
            opis.Add("Typ: " + tostr.TypPokrowca2str(typ));
            opis.Add("Cena: " + Cena + "zł");
            opis.Add("Producent: " + producent.ToString());
            opis.Add("Kolor: " + kolor.ToString());
            opis.Add("Materiał: " + material.ToString());
            separator.endl(opis);
            return opis;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Pokrowiec : Akcesoria {
        public TypPokrowca Typ { get; set; }
        public Kolory Kolor { get; set; }
        public Materialy Material { get; set; }
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
            opis.Add(Typ.ToString().Replace('_', ' '));
            separator.endl(opis);
            return opis;
        }
    }
}

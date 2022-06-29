using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Narzedzia : Akcesoria {
        public Narzedzia() {
            this.narzedzia = null;
        }
        public Narzedzia(List<RodzajNarzedzi> narzedzia) {
            this.DodajNarzedzia(narzedzia);
        }
        public void DodajNarzedzia(List<RodzajNarzedzi> narzedzia) {
            if (this.narzedzia == null) { //Nie utworzono
                this.narzedzia = new List<RodzajNarzedzi>(0);
            }
            foreach (RodzajNarzedzi narzedzie in narzedzia) {
                this.narzedzia.Add(narzedzie);
            }
        }
        public void DodajNarzedzia(RodzajNarzedzi narzedzie) {
            if (this.narzedzia == null) { //Nie utworzono
                this.narzedzia = new List<RodzajNarzedzi>(0);
            }
            narzedzia.Add(narzedzie);
        }
        private List<RodzajNarzedzi> narzedzia;
        public Material material { get; set; }
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
            opis.Add("Materiał: " + material.ToString());
            if (this.narzedzia != null) {
                opis.Add("Narzędzia w zestawie:\n" + tostr.List2str(narzedzia));
            }
            separator.endl(opis);
            return opis;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Narzedzia : Akcesoria {
        
        public Narzedzia() {
            //this.narzedzia = null;
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
        
        public List<RodzajNarzedzi> narzedzia = new List<RodzajNarzedzi>();
        public Materialy Material { get; set; }
        //Funkcja pozwalająca wypisać dane przedmiotu
        /// <summary>
        /// Metoda zwracająca sformatowane parametry jako listę string.
        /// </summary>
        /// <returns></returns>
        public override List<string> Wypisz() {
            List<string> opis = new List<string>(0);
            StringBuilder str = new StringBuilder();
            foreach (var xd in narzedzia)
            {
                str.Append(xd);
                str.Append(", ");
            }
            opis.Add(ID.ToString());
            opis.Add(Nazwa);
            opis.Add(Producent.ToString());
            opis.Add(Cena.ToString());
            opis.Add(Ilosc.ToString());
            opis.Add(Material.ToString());
            opis.Add(str.ToString().Replace('_', ' '));
            separator.endl(opis);
            return opis;
        }
    }
}

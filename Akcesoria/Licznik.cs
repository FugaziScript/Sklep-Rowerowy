using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Licznik : Akcesoria {
        public Licznik() {
            this.funkcje = null;
        }
        public Licznik(List<FunkcjeLicznika> funkcje) {
            this.DodajFunkcje(funkcje);
        }
        public void DodajFunkcje(List<FunkcjeLicznika> funkcje) {
            if (this.funkcje == null) { //Nie utworzono
                this.funkcje = new List<FunkcjeLicznika>(0);
            }
            foreach(FunkcjeLicznika funkcja in funkcje) {
                this.funkcje.Add(funkcja);
            }
        }
        public void DodajFunkcje(FunkcjeLicznika funkcja) {
            if (this.funkcje == null) { //Nie utworzono
                this.funkcje = new List<FunkcjeLicznika>(0);
            }
            funkcje.Add(funkcja);
        }
        public IP ip { get; set; } //Stopień ochrony IP
        public double czas_pracy { get; set; } //Czas pracy na baterii (w h)
        public Kolor kolor { get; set; }
        private List<FunkcjeLicznika> funkcje;
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
            opis.Add("Stopień ochrony IP: " + tostr.IP2str(ip));
            opis.Add("Czas pracy na baterii: " + czas_pracy.ToString());
            if (this.funkcje != null) {
                opis.Add("Funkcje:\n" + tostr.List2str(funkcje));
            }
            separator.endl(opis);
            return opis;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Licznik : Akcesoria {
        public Licznik() {
            //this.funkcje = null;
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
        public IPs IP { get; set; } //Stopień ochrony IP
        public double Czas_pracy { get; set; } //Czas pracy na baterii (w h)
        public Kolory Kolor { get; set; }
        public List<FunkcjeLicznika> funkcje = new List<FunkcjeLicznika>();
        //Funkcja pozwalająca wypisać dane przedmiotu
        /// <summary>
        /// Metoda zwracająca sformatowane parametry jako listę string.
        /// </summary>
        /// <returns></returns>
        public override List<string> Wypisz() {
            List<string> opis = new List<string>(0);

            StringBuilder str = new StringBuilder();
            foreach (var xd in funkcje)
            {
                str.Append(xd);
                str.Append(", ");
            }
            opis.Add(ID.ToString());
            opis.Add(Nazwa);
            opis.Add(Producent.ToString());
            opis.Add(Cena.ToString());
            opis.Add(Ilosc.ToString());
            opis.Add(Kolor.ToString());
            opis.Add(tostr.IP2str(IP));
            opis.Add(Czas_pracy.ToString());
            opis.Add(str.ToString());
            separator.endl(opis);
            return opis;
        }
    }
}

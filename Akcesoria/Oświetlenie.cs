using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Oswietlenie : Akcesoria {
        /// <summary>
        /// Konstruktor bez parametrów.
        /// </summary>
        public Oswietlenie() {
            this.kolor_swiecenia = null;
            this.tryb_swiecenia = null;
        }
        /// <summary>
        /// Konstruktor przyjmyjący listę trybów świecenia.
        /// </summary>
        /// <param name="tryby"></param>
        public Oswietlenie(List<TrybSwiecenia> tryby) {
            this.kolor_swiecenia = null;
            this.UstawTrybSwiecenia(tryby);
        }
        /// <summary>
        /// Konstruktor przyjmujący pojedynczy tryb świecenia.
        /// </summary>
        /// <param name="tryb"></param>
        public Oswietlenie(TrybSwiecenia tryb) {
            this.kolor_swiecenia = null;
            this.UstawTrybSwiecenia(tryb);
        }
        /// <summary>
        /// Konstruktor przyjmujący listę kolorów świecenia.
        /// </summary>
        /// <param name="kolory"></param>
        public Oswietlenie(List<Kolor> kolory) {
            this.tryb_swiecenia = null;
            this.UstawKolorSwiecenia(kolory);
        }
        /// <summary>
        /// Konstruktor przyjmujący kolor świecenia.
        /// </summary>
        /// <param name="kolor"></param>
        public Oswietlenie(Kolor kolor) {
            this.tryb_swiecenia = null;
            this.UstawKolorSwiecenia(kolor);
        }
        /// <summary>
        /// Konstruktor przyjmujące kolor świecenia i tryb świecenia.
        /// </summary>
        /// <param name="kolor"></param>
        /// <param name="tryb"></param>
        public Oswietlenie(Kolor kolor, TrybSwiecenia tryb) {
            this.UstawKolorSwiecenia(kolor);
            this.UstawTrybSwiecenia(tryb);
        }
        /// <summary>
        /// Konstruktor przyjmujące kolor świecenia i listę trybów świecenia.
        /// </summary>
        /// <param name="kolor"></param>
        /// <param name="tryby"></param>
        public Oswietlenie(Kolor kolor, List<TrybSwiecenia> tryby) {
            this.UstawKolorSwiecenia(kolor);
            this.UstawTrybSwiecenia(tryby);
        }
        /// <summary>
        /// Konstruktor przyjmujące listę kolorów świecenia i tryb świecenia.
        /// </summary>
        /// <param name="kolory"></param>
        /// <param name="tryb"></param>
        public Oswietlenie(List<Kolor> kolory, TrybSwiecenia tryb) {
            this.UstawKolorSwiecenia(kolory);
            this.UstawTrybSwiecenia(tryb);
        }
        /// <summary>
        /// Konstruktor przyjmujące listę kolorów świecenia i listę trybów świecenia.
        /// </summary>
        /// <param name="kolory"></param>
        /// <param name="tryby"></param>
        public Oswietlenie(List<Kolor> kolory, List<TrybSwiecenia> tryby) {
            this.UstawKolorSwiecenia(kolory);
            this.UstawTrybSwiecenia(tryby);
        }
        /// <summary>
        /// Konstruktor przyjmujący tryb świecenia i kolor świecenia.
        /// </summary>
        /// <param name="tryb"></param>
        /// <param name="kolor"></param>
        public Oswietlenie(TrybSwiecenia tryb, Kolor kolor) {
            this.UstawKolorSwiecenia(kolor);
            this.UstawTrybSwiecenia(tryb);
        }
        /// <summary>
        /// Konstruktor przyjmujący listę trybów świecenia i kolor świecenia.
        /// </summary>
        /// <param name="tryby"></param>
        /// <param name="kolor"></param>
        public Oswietlenie(List<TrybSwiecenia> tryby, Kolor kolor) {
            this.UstawKolorSwiecenia(kolor);
            this.UstawTrybSwiecenia(tryby);
        }
        /// <summary>
        /// Konstruktor przyjmujący tryb świecenia i listę kolorów świecenia.
        /// </summary>
        /// <param name="tryb"></param>
        /// <param name="kolory"></param>
        public Oswietlenie(TrybSwiecenia tryb, List<Kolor> kolory) {
            this.UstawKolorSwiecenia(kolory);
            this.UstawTrybSwiecenia(tryb);
        }
        /// <summary>
        /// Konstruktor przyjmujące listę trybów świecenia i listę kolorów świecenia.
        /// </summary>
        /// <param name="tryby"></param>
        /// <param name="kolory"></param>
        public Oswietlenie(List<TrybSwiecenia> tryby, List<Kolor> kolory) {
            this.UstawKolorSwiecenia(kolory);
            this.UstawTrybSwiecenia(tryby);
        }
        /// <summary>
        /// Metoda ustawiająca tryby świecenia na przyjęte w liście trybów świecenia.
        /// </summary>
        /// <param name="tryby"></param>
        public void UstawTrybSwiecenia(List<TrybSwiecenia> tryby) {
            if (this.tryb_swiecenia == null) {
                this.tryb_swiecenia = new List<TrybSwiecenia>(0);
            }
            foreach (TrybSwiecenia tryb in tryby) {
                this.tryb_swiecenia.Add(tryb);
            }
        }
        //Metoda ustawiająca tryb świecenia na przyjęty tryb świecenia.
        public void UstawTrybSwiecenia(TrybSwiecenia tryb) {
            if (this.tryb_swiecenia == null) {
                this.tryb_swiecenia = new List<TrybSwiecenia>(0);
            }
            this.tryb_swiecenia.Add(tryb);
        }
        /// <summary>
        /// Metoda ustawiająca kolory świecenia na przyjęte w liście kolorów świecenia.
        /// </summary>
        /// <param name="kolory"></param>
        public void UstawKolorSwiecenia(List<Kolor> kolory) {
            if (this.kolor_swiecenia == null) {
                this.kolor_swiecenia = new List<Kolor>(0);
            }
            foreach(Kolor kolor in kolory) {
                this.kolor_swiecenia.Add(kolor);
            }
        }
        /// <summary>
        /// Metoda ustawiająca kolor świecenia na przyjęty kolor świecenia.
        /// </summary>
        /// <param name="kolor"></param>
        public void UstawKolorSwiecenia(Kolor kolor) {
            if (this.kolor_swiecenia == null) {
                this.kolor_swiecenia = new List<Kolor>(0);
            }
            this.kolor_swiecenia.Add(kolor);
        }
        public Material material { get; set; }
        private List<Kolor> kolor_swiecenia;
        private List<TrybSwiecenia> tryb_swiecenia;
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
            if (this.tryb_swiecenia != null) {
                opis.Add("Tryby świecenia:\n" + tostr.List2str(tryb_swiecenia));
            }
            if (this.kolor_swiecenia != null) {
                opis.Add("Kolory świecenia:\n" + tostr.List2str(kolor_swiecenia));
            }
            separator.endl(opis);
            return opis;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    class koszyk {
        public koszyk() {
            this.zawartosc = new List<IItem>(0);
            //Singleton
            this.blokada = Singleton.Zablokuj();
        }
        public void Dodaj(IItem element) {
            this.zawartosc.Add(element);
            this.Aktualizuj();
        }
        public void Usun(IItem element) {
            this.zawartosc.Remove(element);
            this.Aktualizuj();
        }
        public void Wyczysc() {
            this.zawartosc.Clear();
            this.Aktualizuj();
        }
        private void Aktualizuj() {
            foreach(IItem element in zawartosc) {
                //Napiszę puźniej, gdy zostanie utworzony interfejs item, 
                //tak aby nie pomylić się z nazwami właściwości.
            }
            //Wywołanie funkcji GUI do zmiany wyświetlanej zawartości koszyka.
        }
        //Zakup listy produktów niedodanych do koszyka.
        public static void Kup(List<IItem> przedmioty) {
            //Tworzymy wewnętrzny tymczasowy koszyk
            koszyk Temp = new koszyk();
            //Dodajemy przekazane elementy do tymczasowego koszyka.
            foreach(IItem element in przedmioty) {
                Temp.Dodaj(element);
            }
            //Wywołujemy metodę do kupowania przedniotów z koszyka.
            Temp.Kup();
            //Czyścimy tymczasowy koszyk.
            Temp.Wyczysc();
        }
        //Zakup produktu niedodanego do koszyka.
        public static void Kup(IItem przedmiot) {
            //Tworzymy wewnętrzny tymczasowy koszyk
            koszyk Temp = new koszyk();
            //Dodajemy przekazany element do tymczasowego koszyka.
            Temp.Dodaj(przedmiot);
            //Wywołujemy metodę do kupowania przedniotów z koszyka.
            Temp.Kup();
            //Czyścimy tymczasowy koszyk.
            Temp.Wyczysc();
        }
        //Zakup produktów w koszyku
        public void Kup() {
            //Komunikacja z interfejsem obsługi bazy zostanie dodana później.
            foreach(IItem element in zawartosc) {
                //Wywołanie metody uzuwającej element z bazy dla każdego elementu.
            }
            //Funkcja GUI wyświetlająca komunikat o dokonaniu zakupu.
            this.Wyczysc();
        }
        private List<IItem> zawartosc;
        private Singleton blokada;
    }
}

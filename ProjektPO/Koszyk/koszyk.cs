using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_PO {
    public class Koszyk {
        //Konstruktor publiczny
        public Koszyk(GUI AppGUI, bool display = false) {
            if (AppGUI == null) {
                throw new Exception("AppGUI nie może być null!");
            }
            this.zawartosc = new List<ZawartoscLst>(0);
            this.KoszykGUI = new koszyk_GUI(AppGUI, this, display);
            this.cena = 0;
        }
        //Konstruktor prywatny
        private Koszyk() {
            this.zawartosc = new List<ZawartoscLst>(0);
            this.cena = 0;
        }
        private IItem GetIItem(int ID) {
            foreach(ZawartoscLst element in zawartosc) {
                if (element.element.ID == ID) {
                    return element.element;
                }
            }
            return null;
        }
        public void value_update_GUI(object sender, int ID, int zmiana) {
            if (sender != KoszykGUI) {
                throw new Exception("Tylko GUI może używać tej funkcji zmiany!");
            }
            IItem element = GetIItem(ID);
            if (element == null) {
                throw new Exception("Nie ma w koszyku elementu o podanym ID!");
            }
            if (zmiana < 0) {
                while (zmiana < 0) {
                    this.Usun(element);
                    zmiana++;
                }
            }
            if (zmiana > 0) {
                for (int i = 0; i < zmiana; i++) {
                    this.Dodaj(element);
                }
            }
        }
        public void Usun(IItem element) {
            for(int i=0; i<zawartosc.Count; i++) {
                if (zawartosc[i].element.ID == element.ID) {
                    if (zawartosc[i].ilosc > 0) {
                        zawartosc[i].ilosc--;
                    } else {
                        throw new Exception("Nie można usunąć żądanego przedmiotu, ponieważ jego ilość jest zbyt mała!");
                    }
                } else {
                    throw new Exception("Nie znaleziono żądanego przedmiotu!");
                }
            }
            this.Aktualizuj();
        }
        public void Dodaj(IItem element) {
            bool znaleziono = false;
            for (int i = 0; i < zawartosc.Count; i++) {
                if (zawartosc[i].element.ID == element.ID) {
                    zawartosc[i].ilosc++;
                    znaleziono = true;
                }
            }
            if (znaleziono == false) {
                ZawartoscLst temp = new ZawartoscLst();
                temp.element = element;
                temp.ilosc = 1;
                this.zawartosc.Add(temp);
            }
            this.Aktualizuj();
        }
        public void Wyczysc() {
            this.zawartosc.Clear();
            this.Aktualizuj();
        }
        private void Aktualizuj() {
            cena = 0; //Zerujemy cenę przed ponownym ustaleniem
            foreach(ZawartoscLst element in zawartosc) {
                cena += (element.element.Cena*element.ilosc);
            }
            if (KoszykGUI != null) {
                KoszykGUI.Wyswietl();
            }
        }
        //Zakup produktów w koszyku
        public void Kup() {
            Zamowienie z1 = new Zamowienie
            {
                Data = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
            };

            foreach (ZawartoscLst element in zawartosc) {
                //Wywołanie metody usuwającej element z bazy dla każdego elementu (zmiana jego ilości).
                DataSourceSQL.Instance.UstawIlosc(element.element, element.element.Ilosc-element.ilosc);   //??
                z1.towary.Add(element.element);
                z1.ilosc.Add(element.ilosc);    //??
            }

            if (KoszykGUI != null) {
                KoszykGUI.DokonanoZakupu(cena);
                DataSourceSQL.Instance.DodajZamowienie(z1); //Dodanie zamówienia do bazy.
            }
            this.Wyczysc();
        }
        public void Widocznosc(bool widocznosc) { //Włączamy widoczność koszyka
            if (widocznosc == true) {
                this.KoszykGUI.Visible = true;
            } else {
                this.KoszykGUI.Visible = false;
            }
        }
        public List<ZawartoscLst> PobierzZawartoscLst() {
            List<ZawartoscLst> kopia = new List<ZawartoscLst>(zawartosc);
            return kopia;
        }
        public List<IItem> PobierzZawartoscIItem() {
            List<IItem> kopia = new List<IItem>(0);
            foreach(ZawartoscLst element in zawartosc) {
                kopia.AddRange(element.ToIItem());
            }
            return kopia;
        }
        private List<ZawartoscLst> zawartosc;
        //GUI
        private koszyk_GUI KoszykGUI;
        public double cena {
            get;
            private set;
        }
    }
}

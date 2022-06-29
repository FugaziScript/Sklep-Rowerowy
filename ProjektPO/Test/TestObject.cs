using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO.Test {
    public abstract partial class Object {
        public static void TestujObiekt(Tryb tryb, bool blad=false) {
            IItem tmp_item = null;
            switch (tryb) {
                case Tryb.licznik:
                    tmp_item = CreateLicznik();
                    break;
                case Tryb.oswietlenie:
                    tmp_item = CreateOświetlenie();
                    break;
                case Tryb.koszyk:
                    TestKoszyk();
                    break;
            }
            List<string> outpoot=null;
            if (tmp_item != null) {
                outpoot = tmp_item.Wypisz();
                wypisz_liste(outpoot);
            }
        }
        private static Licznik CreateLicznik() {
            List<FunkcjeLicznika> funkcje = new List<FunkcjeLicznika>(0);
            funkcje.Add(FunkcjeLicznika.dystans);
            funkcje.Add(FunkcjeLicznika.predkosc);
            funkcje.Add(FunkcjeLicznika.zegar);
            Licznik liczydlo = new Licznik();
            liczydlo.Cena = 200;
            liczydlo.Czas_pracy = 10000;
            liczydlo.IP = IPs.IP44;
            liczydlo.Nazwa = "Licznik";
            liczydlo.Producent = Producents.Cossack;
            liczydlo.DodajFunkcje(funkcje);
            return liczydlo;
        }
        private static Oswietlenie CreateOświetlenie() {
            List<Kolory> kolory = new List<Kolory>(0);
            List<TrybSwiecenia> tryb = new List<TrybSwiecenia>(0);
            kolory.Add(Kolory.Czerwony);
            kolory.Add(Kolory.Niebieski);
            kolory.Add(Kolory.Zielony);
            tryb.Add(TrybSwiecenia.ciagly);
            tryb.Add(TrybSwiecenia.migajacy);
            tryb.Add(TrybSwiecenia.migajacy_dwukolorowy);
            Oswietlenie lampa = new Oswietlenie(kolory);
            lampa.UstawTrybSwiecenia(tryb);
            lampa.Cena = 50;
            lampa.Material = Materialy.Plastik;
            lampa.Nazwa = "Światła";
            lampa.Producent = Producents.Andar_Bike;
            return lampa;
        }
        private static void wypisz_liste(List<string> lista) {
            foreach (string element in lista) {
                Console.Write(element);
            }
        }
    }
}

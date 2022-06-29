using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    class Rower {
        public Rower() { }
        public Rower(List<IItem> czesci) {
            if (walidacja(czesci) == false) {
                throw new Exception("Brakuje jednego z niezbędnych elementów.");
            }
            foreach (IItem czesc in czesci) {
                if (czesc is Rama) {
                    this.rama = (Rama)czesc;
                    continue;
                }
                if (czesc is Kola) {
                    this.kola = (Kola)czesc;
                    continue;
                }
                if (czesc is Siodełko) {
                    this.siodelko = (Siodełko)czesc;
                    continue;
                }
                if (czesc is Oswietlenie) {
                    this.swiatla = (Oswietlenie)czesc;
                    continue;
                }
                if (czesc is HamulecPrzedni) {
                    this.hamulec_przedni = (HamulecPrzedni)czesc;
                    continue;
                }
                if (czesc is HamulecTylny) {
                    this.hamulec_tylny = (HamulecTylny)czesc;
                    continue;
                }
                if (czesc is PrzerzutkiPrzednie) {
                    this.przerzutki_przednie = (PrzerzutkiPrzednie)czesc;
                    continue;
                }
                if (czesc is PrzerzutkiTylne) {
                    this.przerzutki_tylne = (PrzerzutkiTylne)czesc;
                    continue;
                }
                if (czesc is AmortyzatorPrzedni) {
                    this.amortyzator_przedni = (AmortyzatorPrzedni)czesc;
                    continue;
                }
                if (czesc is AmortyzatorTylny) {
                    this.amortyzator_tylny = (AmortyzatorTylny)czesc;
                    continue;
                }
            }
        }
        private static bool walidacja(List<IItem> czesci) {
            List<IItem> wzor = GenerujWzor();
            bool stan;
            foreach (IItem element in wzor) {
                stan = false;
                foreach (IItem czesc in czesci) {
                    if (element.GetType() == czesc.GetType()) {
                        stan = true;
                        continue;
                    }
                    if (stan != true) {
                        return false;
                    }
                }
            }
            return true;
        }
        private static List<IItem> GenerujWzor() {
            List<IItem> wzor = new List<IItem>(0);
            //Lista zawiera typ każego z niezbędnych elementów
            wzor.Add(new Rama());
            wzor.Add(new Kola());
            wzor.Add(new Siodełko());
            wzor.Add(new HamulecPrzedni());
            wzor.Add(new HamulecTylny());
            return wzor;
        }

        Rama rama { get; }
        Kola kola { get; }
        Siodełko siodelko { get; }
        Oswietlenie swiatla { get; }
        HamulecPrzedni hamulec_przedni { get; }
        HamulecTylny hamulec_tylny { get; }
        PrzerzutkiPrzednie przerzutki_przednie { get; }
        PrzerzutkiTylne przerzutki_tylne { get; }
        AmortyzatorPrzedni amortyzator_przedni { get; }
        AmortyzatorTylny amortyzator_tylny { get; }

        /*
         * Klasy potomne:
         *  - BMX
         *  - Cross
         *  - Szosowe
         *  - Dziecięce
         *  
         *  Później zostanie dodane więcej.
         */
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public class Hamulec : Czesci {
        public TypyHamulca TypHamulca { get; set; }
        public Polozenia Polozenie { get; set; }
        public Typy Typ { get; set; }
        public Kolory Kolor { get; set; }
        public override List<string> Wypisz()
        {
            List<string> opis = new List<string>(0);
            opis.Add(ID.ToString());
            opis.Add(Nazwa);
            opis.Add(Producent.ToString());
            opis.Add(Cena.ToString());
            opis.Add(Ilosc.ToString());
            opis.Add(TypHamulca.ToString().Replace('_', ' '));
            opis.Add(Polozenie.ToString());
            opis.Add(Kolor.ToString());
            opis.Add(Typ.ToString());
            separator.endl(opis);
            return opis;
        }
    }
}

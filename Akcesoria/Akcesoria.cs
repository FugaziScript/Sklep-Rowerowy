using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    //Klasa abstrakcyjna dla akcesoriów
    public abstract class Akcesoria : IItem {
        public int ID { get; set; }  // Unikalny numer ID każdego przedmiotu  
        public string Nazwa { get; set; }  //Nazwa przedmiotu
        public double Cena { get; set; }   //Cena Przedmiotu
        public Producent producent { get; set; } //Producent przedmiotu
        public int Ilosc { get; set; } // Ilość przedmiotu
        //Funkcja pozwalająca wypisać dane przedmiotu
        /// <summary>
        /// Metoda zwracająca sformatowane parametry jako listę string.
        /// </summary>
        /// <returns></returns>
        public virtual List<string> Wypisz() {
            List<string> opis = new List<string>(0);
            opis.Add(Nazwa + ":");
            opis.Add("Cena: " + Cena + "zł");
            opis.Add("Producent: " + producent);
            separator.endl(opis);
            return opis;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PO {
    public abstract class Czesci : IItem {
        public int Ilosc { get; set; } // Ilość przedmiotu
        public int ID { get; set; }  // Unikalny numer ID każdego przedmiotu  
        public string Nazwa { get; set; }  //Nazwa przedmiotu
        public double Cena { get; set; }   //Cena Przedmiotu
        public Producents Producent { get; set; }  //Producent Przedmiotu
        public virtual List<string> Wypisz() { return null; }   //funkcja pozwalająca wypisać dane przedmiotu
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_PO{
    public interface IItem {
        int Ilosc { get; set; } //Ilość przedmiotu
        int ID { get; set; }  //Unikalny numer ID każdego przedmiotu  
        string Nazwa { get; set; }  //Nazwa przedmiotu
        double Cena { get; set; }   //Cena Przedmiotu
        public Producent producent { get; set; }  //Producent Przedmiotu
        public List<string> Wypisz() { return null; }   //Funkcja pozwalająca wypisać dane przedmiotu
    }
}
